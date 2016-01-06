Option Strict On
Option Explicit On 
'Imports environment
Public Class CSystemLog_301

#Region "Nhiệm vụ của Class"
    '************************************************************************
    '* Created by: Csung, 2003-11
    '* Xử lý các exception của hệ thống 
    '* - Chú ý: Class này thuộc lớp cuối cùng, sẽ không reference đến một lớp nào khác
    '*
    '************************************************************************
#End Region

#Region "Variables "
    Private Shared m_strRunMode As String = IPConstants.C_RUNMODE_NOT_LOADED
    Shared m_stream_writer As System.IO.StreamWriter
#End Region

#Region "class public interface"
    Public Shared Sub Initialize()
        If m_strRunMode = IPConstants.C_RUNMODE_NOT_LOADED Then
            Dim v_configReader As New System.Configuration.AppSettingsReader
            m_strRunMode = v_configReader.GetValue("RUN_MODE", IPConstants.C_StringType).ToString()
        End If
    End Sub

    Public Shared Sub ExceptionHandle(ByVal i_exp As System.Exception)
        Try
            Initialize()
            WriteToLog(i_exp)
            ' xử lý lỗi theo các trường hợp khác nhau
            ' tạm thời dùng theo kiểu select-case,
            ' nếu có nhu cầu cụ thể sẽ chuyển sang dạng strategy
            Select Case m_strRunMode
                Case IPConstants.C_RUNMODE_TEST
                    System.Windows.Forms.MessageBox.Show("environment-TEST: " & i_exp.Message, "IP-LOGGING ")
                Case IPConstants.C_RUNMODE_DEVELOP
                    System.Windows.Forms.MessageBox.Show("environment-DEVELOPE: " & i_exp.Message, "IP-LOGGING ")
                Case IPConstants.C_RUNMODE_RUNTIME
                    System.Windows.Forms.MessageBox.Show("environment-RUNTIME: " & i_exp.Message, "IP-LOGGING ")
            End Select
        Catch
            System.Windows.Forms.MessageBox.Show("environment- Không có file Ini")
        End Try
    End Sub
    Public Shared Sub ExceptionHandle(ByVal i_page As System.Web.UI.Page, ByVal i_exp As System.Exception)

        Try
            Initialize()
            ' xử lý lỗi theo các trường hợp khác nhau
            ' tạm thời dùng theo kiểu select-case,
            ' nếu có nhu cầu cụ thể sẽ chuyển sang dạng strategy
            WriteToLog(i_exp)
            Dim v_str_msg As String = i_exp.Message
            v_str_msg = v_str_msg.Replace(Chr(10), "")

            Select Case m_strRunMode
                Case IPConstants.C_RUNMODE_TEST
                    i_page.Response.Redirect("MessageError.aspx?Message= Error:" + v_str_msg)
                Case IPConstants.C_RUNMODE_DEVELOP
                    i_page.Response.Redirect("MessageError.aspx?Message= Error:" + v_str_msg)
                Case IPConstants.C_RUNMODE_RUNTIME
                    i_page.Response.Redirect("MessageError.aspx?Message= Đã xảy ra lỗi trong quá trình cập nhật dữ liệu!")
            End Select
        Catch ex As Exception
            'i_page.Response.Redirect("../MessageError.aspx?mess=Title Website: " + i_page.Title + ". Message: " + i_exp.Message + " Source: " + i_exp.Source)
        End Try
    End Sub
    Private Shared Sub WriteToLog(ByVal i_exeption As Exception)
        Dim v_str_path As String
        v_str_path = AppDomain.CurrentDomain.BaseDirectory + "Logs\"
        write_string_2_log_file(i_exeption.Message + Environment.NewLine + i_exeption.Source, v_str_path)
    End Sub
    Private Shared Sub write_string_2_log_file(ByVal i_str_error As String, ByVal i_str_path As String)
        Try
            Dim v_str_filename As String
            v_str_filename = i_str_path + DateTime.Now.ToString("yyyyMMddHHmm") + ".log"
            If (System.IO.File.Exists(v_str_filename)) Then
                m_stream_writer = System.IO.File.AppendText(v_str_filename)
            Else : m_stream_writer = System.IO.File.CreateText(v_str_filename)
            End If
            m_stream_writer.WriteLine(DateTime.Now.ToString("yyyyMMdd HH:mm:ss ") + i_str_error)
        Finally
            If (Not IsNothing(m_stream_writer)) Then
                m_stream_writer.Close()
            End If
        End Try
    End Sub
#End Region
End Class
