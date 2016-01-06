Imports System.Data.SqlClient
Public Class CMakeAndSelectCmd
    Implements IMakeSelectCmd
    Protected m_ds As DataSet
    Protected m_TableName
    Protected m_Conditions() As ICondition

    Public Sub New(ByVal i_ds As DataSet, ByVal i_strTableName As String)
        m_ds = i_ds
        m_TableName = i_strTableName
    End Sub

    Private Function getSelectCommand(Optional ByVal i_sDieuKien As String = "") As SqlClient.SqlCommand
        
    End Function

    Private Function getSelectString(ByVal i_cmd As SqlCommand) As String
        Dim v_strSelect As String = " Select "
        Dim v_DataColumn As System.Data.DataColumn
        For Each v_DataColumn In m_ds.Tables(m_TableName).Columns
            v_strSelect &= v_DataColumn.ColumnName & ", "
        Next
        v_strSelect = v_strSelect.Substring(0, v_strSelect.Length - 2)
        v_strSelect &= " from " & m_TableName & " "
        If Not m_Conditions Is Nothing Then
            v_strSelect &= " Where " & m_Conditions(0).GetConditionStr()
            i_cmd.Parameters.Add(m_Conditions(0).GetParameter())
            Dim v_iIndex As Integer
            For v_iIndex = 1 To UBound(m_Conditions)
                v_strSelect &= " AND " & m_Conditions(v_iIndex).GetConditionStr()
                If (Not i_cmd.Parameters.Contains(m_Conditions(v_iIndex).GetParameter().ParameterName)) Then
                    i_cmd.Parameters.Add(m_Conditions(v_iIndex).GetParameter())
                End If

            Next
        End If
        Return v_strSelect
    End Function

    Sub AddCondition(ByVal i_strTenTruong As String, _
            ByVal i_Value As Object, ByVal i_KieuDuLieu As eKieuDuLieu, ByVal i_KieuSoSanh As eKieuSoSanh) Implements IMakeSelectCmd.AddCondition
        If Not m_Conditions Is Nothing Then
            ReDim Preserve m_Conditions(UBound(m_Conditions) + 1)
        Else
            ReDim m_Conditions(0)
        End If
        Dim v_iNewItem As Integer
        v_iNewItem = UBound(m_Conditions)
        Select Case i_KieuDuLieu
            Case eKieuDuLieu.KieuNumber
                Dim v_iDouble As Double
                Try
                    v_iDouble = CType(i_Value, Double)
                Catch
                    Debug.Assert(False, "Sai kieu roi, phai la so - tuanqt trong CMakeAndSelectCmd")
                End Try
                m_Conditions(v_iNewItem) = New CNumberCondition(i_strTenTruong, v_iDouble, i_KieuSoSanh)

            Case eKieuDuLieu.KieuString
                Dim v_iStr As String
                Try
                    v_iStr = CType(i_Value, String)
                Catch
                    Debug.Assert(False, "Sai kieu roi, phai la xau - tuanqt trong CMakeAndSelectCmd")
                End Try
                m_Conditions(v_iNewItem) = New CStringCondition(i_strTenTruong, v_iStr, i_KieuSoSanh)
            Case eKieuDuLieu.KieuDate
                Dim v_iDate As Date
                Try
                    v_iDate = CType(i_Value, DateTime)
                Catch
                    Debug.Assert(False, "Sai kieu roi, phai la so - tuanqt trong CMakeAndSelectCmd")
                End Try
                m_Conditions(v_iNewItem) = New CDateCondition(i_strTenTruong, v_iDate, i_KieuSoSanh)

            Case Else
                Debug.Assert(False, "Chua code kieu nay")
        End Select
    End Sub

    Function getConditionString() As String Implements IMakeSelectCmd.getConditionString
        Debug.Assert(False, "Chua co code tuanqt")
    End Function

    Function getParameters() As Collection Implements IMakeSelectCmd.getParameters
        Debug.Assert(False, "Chua co code tuanqt")
    End Function

    Function getSelectCmd() As SqlCommand Implements IMakeSelectCmd.getSelectCmd
        Dim v_Cmd As SqlClient.SqlCommand
        v_Cmd = New SqlClient.SqlCommand()
        v_Cmd.CommandText = getSelectString(v_Cmd)
        v_Cmd.CommandType = CommandType.Text
        Return v_Cmd
    End Function
End Class
