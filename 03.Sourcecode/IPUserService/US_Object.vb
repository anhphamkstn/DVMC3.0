option Explicit On
Option Strict On

Imports IP.Core.IPCommon
Imports IP.Core.IPData
Imports IP.Core.IPBusinessService

Public Class US_Object
    Protected pm_objDS As DataSet
    Protected pm_objDR As DataRow
    Protected pm_strTableName As String
    Protected pm_objBS As New BS_Object()

    'Điền dữ liệu vào DataSet theo chuỗi điều kiện tương ứng
    'Chú ý: chuỗi điều kiện i_strDieuKien phải bắt đầu bằng từ WHERE
    Public Overridable Sub FillDataset(ByVal i_objDS As DataSet, _
                ByVal i_strDieuKien As String)
        pm_objBS.FillDataset(i_objDS, pm_strTableName, i_strDieuKien)
    End Sub

    'Điền dữ liệu vào DataSet không có điều kiện
    Public Overridable Sub FillDataset(ByVal i_objDS As DataSet)
        pm_objBS.FillDataset(i_objDS, pm_strTableName, "")
    End Sub

    'Điền dữ liệu vào DataSet theo một sqlcommand tương ứng
    Public Overridable Sub FillDatasetByCommand(ByVal i_objDS As DataSet, _
                                    ByVal i_selectCmd As SqlClient.SqlCommand)
        pm_objBS.FillDatasetByCommand(i_objDS, i_selectCmd)
    End Sub
    Public Overridable Sub FillData_2_Dataset(ByVal i_objDS As DataSet, _
                                    ByVal i_selectCmd As SqlClient.SqlCommand)
        pm_objBS.FillData2Dataset(i_objDS, i_selectCmd)
    End Sub

    Public Overridable Sub Update()
        'Tên bảng phải khác rỗng nếu không thì chết luôn
        If pm_strTableName Is Nothing Or pm_strTableName.Length = 0 Then Debug.Assert(False)
        Dim v_DRTemp As DataRow
        pm_objDS.EnforceConstraints = False
        v_DRTemp = getRowClone(pm_objDR)
        If pm_objDS.Tables(pm_strTableName).Rows.Count >= 1 Then
            pm_objDS.Tables(pm_strTableName).Rows.RemoveAt(0)
        End If
        pm_objDS.Tables(pm_strTableName).Rows.Add(v_DRTemp)
        pm_objBS.Update(pm_objDS, pm_strTableName)
    End Sub
    Public Overridable Sub Update_CoGhiLog(ByVal i_dc_nguoi_dung_id As Decimal, _
                                           ByVal i_str_ten_tham_so As String)
        'Tên bảng phải khác rỗng nếu không thì chết luôn
        If pm_strTableName Is Nothing Or pm_strTableName.Length = 0 Then Debug.Assert(False)
        Dim v_DRTemp As DataRow
        pm_objDS.EnforceConstraints = False
        v_DRTemp = getRowClone(pm_objDR)
        If pm_objDS.Tables(pm_strTableName).Rows.Count >= 1 Then
            pm_objDS.Tables(pm_strTableName).Rows.RemoveAt(0)
        End If
        pm_objDS.Tables(pm_strTableName).Rows.Add(v_DRTemp)
        pm_objBS.Update_GhiLog(pm_objDS, pm_strTableName, i_dc_nguoi_dung_id, i_str_ten_tham_so)
    End Sub

    Public Overridable Sub Insert()
        'Tên bảng phải khác rỗng nếu không thì chết luôn
        If pm_strTableName Is Nothing Or pm_strTableName.Length = 0 Then Debug.Assert(False)
        'Them vao dataset
        'Dim v_ipcommonObj As New BS_Object
        Dim v_DRTemp As DataRow
        'Me.pm_objDR.Item("ID") = v_ipcommonObj.getObjectID()
        v_DRTemp = getRowClone(pm_objDR)
        pm_objDS.EnforceConstraints = False
        If pm_objDS.Tables(pm_strTableName).Rows.Count >= 1 Then
            pm_objDS.Tables(pm_strTableName).Rows.RemoveAt(0)
            'pm_objDS.Tables(pm_strTableName).Rows.Clear()
        End If
        pm_objDS.Tables(pm_strTableName).Rows.Add(v_DRTemp)
        Me.pm_objDR.Item("ID") = pm_objBS.Insert(pm_objDS, pm_strTableName)
    End Sub
    Public Overridable Sub Insert_CoGhiLog(ByVal i_dc_nguoi_dung_id As Decimal, _
                                           ByVal i_str_ten_tham_so As String)
        'Tên bảng phải khác rỗng nếu không thì chết luôn
        If pm_strTableName Is Nothing Or pm_strTableName.Length = 0 Then Debug.Assert(False)
        'Them vao dataset
        'Dim v_ipcommonObj As New BS_Object
        Dim v_DRTemp As DataRow
        'Me.pm_objDR.Item("ID") = v_ipcommonObj.getObjectID()
        v_DRTemp = getRowClone(pm_objDR)
        pm_objDS.EnforceConstraints = False
        If pm_objDS.Tables(pm_strTableName).Rows.Count >= 1 Then
            pm_objDS.Tables(pm_strTableName).Rows.RemoveAt(0)
            'pm_objDS.Tables(pm_strTableName).Rows.Clear()
        End If
        pm_objDS.Tables(pm_strTableName).Rows.Add(v_DRTemp)
        Me.pm_objDR.Item("ID") = pm_objBS.Insert_GhiLog(pm_objDS, pm_strTableName, i_dc_nguoi_dung_id, i_str_ten_tham_so)
    End Sub
    Public Overridable Sub Insert(ByRef op_dc_id As Decimal, ByVal i_dc_nguoi_dung As Decimal, ByVal i_str_ten_tham_so As String)
        'Tên bảng phải khác rỗng nếu không thì chết luôn
        If pm_strTableName Is Nothing Or pm_strTableName.Length = 0 Then Debug.Assert(False)
        'Them vao dataset
        'Dim v_ipcommonObj As New BS_Object
        Dim v_DRTemp As DataRow
        'Me.pm_objDR.Item("ID") = v_ipcommonObj.getObjectID()
        v_DRTemp = getRowClone(pm_objDR)
        pm_objDS.EnforceConstraints = False
        If pm_objDS.Tables(pm_strTableName).Rows.Count >= 1 Then
            pm_objDS.Tables(pm_strTableName).Rows.RemoveAt(0)
            'pm_objDS.Tables(pm_strTableName).Rows.Clear()
        End If
        pm_objDS.Tables(pm_strTableName).Rows.Add(v_DRTemp)
        Me.pm_objDR.Item("ID") = pm_objBS.Insert_GhiLog(pm_objDS, pm_strTableName, i_dc_nguoi_dung, i_str_ten_tham_so)
        op_dc_id = CIPConvert.ToDecimal(Me.pm_objDR.Item("ID"))
    End Sub

    Public Overridable Sub Delete()
        'Tên bảng phải khác rỗng nếu không thì chết luôn
        If pm_strTableName Is Nothing Or pm_strTableName.Length = 0 Then Debug.Assert(False)
        Dim v_DRTemp As DataRow
        pm_objDS.EnforceConstraints = False
        v_DRTemp = getRowClone(pm_objDR)
        If pm_objDS.Tables(pm_strTableName).Rows.Count >= 1 Then
            pm_objDS.Tables(pm_strTableName).Rows.RemoveAt(0)
        End If

        pm_objDS.Tables(pm_strTableName).Rows.InsertAt(v_DRTemp, 0)
        pm_objBS.Delete(pm_objDS, pm_strTableName)
    End Sub

    Public Overridable Sub DeleteByID(ByVal i_dcID As Decimal)
        'Tên bảng phải khác rỗng nếu không thì chết luôn
        If pm_strTableName Is Nothing Or pm_strTableName.Length = 0 Then Debug.Assert(False)
        pm_objBS.DeleteByID(pm_objDS, pm_strTableName, i_dcID)
    End Sub
    Public Overridable Sub DeleteByID_CoGhiLog(ByVal i_dcID As Decimal, _
                                               ByVal i_dc_nguoi_dung_id As Decimal, _
                                               ByVal i_str_ten_tham_so As String)
        'Tên bảng phải khác rỗng nếu không thì chết luôn
        If pm_strTableName Is Nothing Or pm_strTableName.Length = 0 Then Debug.Assert(False)
        pm_objBS.DeleteByID_GhiLog(pm_objDS, pm_strTableName, i_dcID, i_dc_nguoi_dung_id, i_str_ten_tham_so)
    End Sub

    Public Overridable Sub Me2DataRow(ByVal i_objDR As DataRow)
        Dim v_i As Integer
        For v_i = 0 To pm_objDR.Table.Columns.Count - 1
            i_objDR.Item(getColName(v_i)) = pm_objDR.Item(getColName(v_i))
        Next
    End Sub

    Public Overridable Sub DataRow2Me(ByVal i_objDR As DataRow)
        Dim v_i As Integer
        For v_i = 0 To pm_objDR.Table.Columns.Count - 1
            pm_objDR.Item(getColName(v_i)) = i_objDR.Item(getColName(v_i))
        Next
    End Sub

    Public Overridable Function isUpdatable() As Boolean
        'Tên bảng phải khác rỗng nếu không thì chết luôn
        If pm_strTableName Is Nothing Or pm_strTableName.Length = 0 Then Debug.Assert(False)
        Dim v_DRTemp As DataRow

        v_DRTemp = getRowClone(pm_objDR)
        If pm_objDS.Tables(pm_strTableName).Rows.Count >= 1 Then
            pm_objDS.Tables(pm_strTableName).Rows.RemoveAt(0)
        End If
        pm_objDS.Tables(pm_strTableName).Rows.Add(v_DRTemp)
        Return pm_objBS.isUpdatable(pm_objDS, pm_strTableName)
    End Function

    Public Overridable Sub PrepareUpdate()
        Dim v_b_is_updatable As Boolean = isUpdatable()
    End Sub

    Public Overridable Function BeginTransaction() As SqlClient.SqlTransaction
        Return pm_objBS.BeginTransaction()
    End Function

    Public Overridable Sub CommitTransaction()
        pm_objBS.CommitTransaction()
    End Sub

    Public Overridable Sub Rollback()
        pm_objBS.Rollback()
    End Sub

    Protected Friend Overridable Sub ExecCommand(ByVal i_cmd As SqlClient.SqlCommand)
        pm_objBS.ExecCommand(i_cmd)
    End Sub

    Public Overridable Function GetTransaction() As SqlClient.SqlTransaction
        Return pm_objBS.getTransaction()
    End Function

    Public Overridable Sub SetTransaction(ByVal i_Trans As SqlClient.SqlTransaction)
        pm_objBS.setTransaction(i_Trans)
    End Sub

    Public Overridable Sub UseTransOfUSObject(ByVal i_usObject As US_Object)
        pm_objBS.setTransaction(i_usObject.GetTransaction())
    End Sub

    Public Sub setSavePoint(ByVal i_str_save_point_name As String)
        Debug.Assert(pm_objBS.HaveTransaction, "Chi duoc dat SavePoint khi US_Object co transaction - tuanqt")
        pm_objBS.setSavePoint(i_str_save_point_name)
    End Sub

    Public Sub rollbackToSavePoint(ByVal i_str_save_point_name As String)
        Debug.Assert(pm_objBS.HaveTransaction, "Chi duoc dat SavePoint khi US_Object co transaction - tuanqt")
        pm_objBS.rollbackToSavePoint(i_str_save_point_name)
    End Sub

    Public Overridable Function is_having_transaction() As Boolean
        Return pm_objBS.HaveTransaction()
    End Function

    Public Overridable Sub CopyData2USObject(ByVal i_usObject As US_Object)
        Debug.Assert(Not i_usObject Is Nothing, "phai khoi tao doi tuong truoc khi copy data vao no - tuanqt")
        Try
            i_usObject.DataRow2Me(pm_objDR)
        Catch
            Debug.Assert(False, "Copy vao doi tuong us khac kieu roi - tuanqt")
        End Try
    End Sub

    Public Overridable Sub ClearAllFields()
        Dim v_i As Integer
        For v_i = 0 To pm_objDS.Tables(pm_strTableName).Columns.Count - 1
            pm_objDR.Item(getColName(v_i)) = Convert.DBNull
        Next
    End Sub

    Protected Function getRowClone(ByVal i_objDR As DataRow) As DataRow
        Dim v_Row As DataRow = pm_objDS.Tables(pm_strTableName).NewRow()
        Dim v_i As Integer
        For v_i = 0 To pm_objDS.Tables(pm_strTableName).Columns.Count - 1
            v_Row.Item(getColName(v_i)) = i_objDR.Item(getColName(v_i))
        Next
        Return v_Row
    End Function

    Protected Function getColName(ByVal i_Index As Integer) As String
        Return pm_objDS.Tables(pm_strTableName).Columns(i_Index).ColumnName
    End Function
End Class
