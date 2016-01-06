
Option Strict On
Option Explicit On 
Imports System.Xml
Imports System.Windows.Forms
Imports ip.Core.IPCommon.MessageForms

Public Class BaseMessages

#Region "Nhiệm vụ của class"
    '*************************************************************
    ' Dùng để hiện thị các thông báo của hệ thống
    '
    '*************************************************************
#End Region

#Region "Vùng khai báo biến"
    Public Enum IsDataCouldBeDeleted
        CouldBeDeleted = 232
        ShouldNotBeDeleted = 1111
    End Enum

    Private Shared m_DataSet As New DatasetMsg
    Private Shared m_dsUser As New Users_DataSet
    Private Const c_strUserFileName As String = "NumOfMessage.XML"
    Private Const c_InfoMsgString As String = "Thông báo"
    Private Const c_ErrorMsgString As String = "Thông báo lỗi"
    Private Const c_ConfirmMsgString As String = "Xác nhận lại"
    Private Const c_WarningMsgString As String = "Cảnh báo"
    Private Shared m_IntialedClass As Boolean
    'Các thông số liên quan đến chế độ chạy
    Private Const c_RunApp As String = "RUN"
    Private Const c_DeburgMode As String = "DEBURG"

    Public Enum MsgBtnType As Integer
        MsgBtnOK = 0
        MsgBtnYes_No = 1
        MsgBtnYes_No_Cancel = 2
    End Enum

    Public Enum MsgIconType As Integer
        InfomationIcon = 0
        ErrorIcon = 1
        QuestionIcon = 2
        WarningIcon = 3
    End Enum

#End Region

#Region "Các hàm khởi tạo huỷ dữ liệu"

    Private Shared Sub InitClass(ByVal i_UserFileName As String)
        Try
            Dim v_UserFileName As String = AppDomain.CurrentDomain.SetupInformation.ApplicationBase & i_UserFileName
            m_dsUser.ReadXml(v_UserFileName)
            m_IntialedClass = True

        Catch v_Ex As Exception
            Exit Sub
        Finally
        End Try
    End Sub

    Public Shared Sub Close()
        m_DataSet = Nothing
    End Sub
    Private Shared Sub LoadMessagesData(ByVal i_NumOFMsg As Decimal)
        Dim v_strWhere As String
        Dim v_FileName As String = AppDomain.CurrentDomain.SetupInformation.ApplicationBase
        v_strWhere = "(FromNum <= " & i_NumOFMsg & ") and (" & i_NumOFMsg & " < ToNum)"
        Dim v_dvUserData As New DataView(m_dsUser.Users_DataSet, v_strWhere, "", DataViewRowState.CurrentRows)
        If v_dvUserData.Count > 0 Then
            v_FileName &= CType(v_dvUserData.Item(0).Item("FileName"), String)
            m_DataSet.ReadXml(v_FileName)
        End If
    End Sub
#End Region

#Region "Lấy dữ liệu thông báo"
    'Lay lai cac thong bao trong database theo cac chi so cua thong bao
    Public Shared Function GetMsg(ByVal i_MsgNumber As Decimal) As String
        Dim v_strValue As String
        Dim v_strWhere As String = "ID=" & i_MsgNumber
        If Not m_IntialedClass Then
            InitClass(c_strUserFileName)
        End If
        LoadMessagesData(i_MsgNumber)
        Dim v_dvMessage As New DataView(m_DataSet.Message, v_strWhere, "", DataViewRowState.CurrentRows)
        If v_dvMessage.Count > 0 Then
            v_strValue = CType(v_dvMessage.Item(0).Item("Message"), String)
        Else
            v_strValue = "Thông báo này chưa đựơc định nghĩa"
        End If
        Return v_strValue
    End Function
#End Region

#Region "Public Interface"

    'Hàm thông báo lỗi dùng chỉ số lỗi
    Public Shared Sub MsgBox_Error(ByVal MsgNumber As Integer)
        Dim v_StrMsg As String = MsgNumber & " - " & GetMsg(MsgNumber)
        MsgBox_Error(v_StrMsg)
    End Sub
    'Hàm thông báo lỗi với một chuỗi
    Public Shared Sub MsgBox_Error(ByVal i_strMsg As String)
        Dim v_FormMsg As New MsgBoxForm_OK
        v_FormMsg.Display(i_strMsg, c_ErrorMsgString, Msgs.MsgIconType.ErrorIcon)
    End Sub
    'Hàm thông báo Thông tin thông thường bằng chỉ số lỗi
    Public Shared Sub MsgBox_Infor(ByVal MsgNumber As Integer)
        Dim v_StrMsg As String = MsgNumber & " - " & GetMsg(MsgNumber)
        MsgBox_Infor(v_StrMsg)
    End Sub
    'Hàm thông báo Thông tin thông thường bằng chuỗi
    Public Shared Sub MsgBox_Infor(ByVal i_strMsg As String)
        Dim v_FormMsg As New MsgBoxForm_OK
        v_FormMsg.Display(i_strMsg, c_InfoMsgString, Msgs.MsgIconType.InfomationIcon)
    End Sub
    'Hàm xác nhận lại yêu cầu  dùng chuỗi
    '
    Public Shared Function MsgBox_Confirm(ByVal i_strMsg As String) As Boolean
        Dim v_Result As Boolean
        Dim v_confirm As DialogResult
        Dim v_FormMsg As New IPCommon.MessageForms.MsgBoxForm_Yes_No
        v_confirm = v_FormMsg.Display(i_strMsg, c_ConfirmMsgString, Msgs.MsgIconType.QuestionIcon)
        Select Case v_confirm
            Case DialogResult.Yes
                v_Result = True
            Case DialogResult.No
                v_Result = False
        End Select
        Return v_Result
    End Function
    'Hàm xác nhận lại yêu cầu  dùng chỉ sỗ chuỗi thông báo
    Public Shared Function MsgBox_Confirm(ByVal MsgNumber As Integer) As Boolean
        Dim v_StrMsg As String = MsgNumber & " - " & GetMsg(MsgNumber)
        v_StrMsg = MsgNumber & " - " & GetMsg(MsgNumber)
        Return MsgBox_Confirm(v_StrMsg)
    End Function

    'Hàm cảnh báo

    Public Shared Function MsgBox_Warning(ByVal MsgNumber As Integer) As Boolean
        Dim v_StrMsg As String = MsgNumber & " - " & GetMsg(MsgNumber)
        Dim v_FormMsg As New MessageForms.MsgBoxForm_OK
        v_FormMsg.Display(v_StrMsg, c_WarningMsgString, Msgs.MsgIconType.WarningIcon)
    End Function

    'Hàm confirm "Yes","No","Cancel"
    Public Shared Function MsgBox_YES_NO_CANCEL(ByVal MsgNumber As Integer) As DialogResult
        Dim v_StrMsg As String = MsgNumber & " - " & GetMsg(MsgNumber)
        Dim v_confirm As DialogResult = MsgBox_YES_NO_CANCEL(v_StrMsg)
        Return v_confirm
    End Function
    'Hàm confirm "Yes","No","Cancel"
    Public Shared Function MsgBox_YES_NO_CANCEL(ByVal i_strMsg As String) As DialogResult
        Dim v_FormMsg As New MsgBoxFormYes_No_Cancel
        Dim v_confirm As DialogResult = v_FormMsg.Display(i_strMsg, c_ConfirmMsgString, Msgs.MsgIconType.QuestionIcon)
        Return v_confirm
    End Function
    ' Hàm hỏi có xoá dữ liệu không
    Public Shared Function askUser_DataCouldBeDeleted(Optional ByVal i_MsgNumber As Integer = 8) As IsDataCouldBeDeleted
        If MsgBox_Confirm(i_MsgNumber) Then
            Return IsDataCouldBeDeleted.CouldBeDeleted
        Else
            Return IsDataCouldBeDeleted.ShouldNotBeDeleted
        End If
    End Function

#End Region

End Class
