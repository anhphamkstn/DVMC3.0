'NHIỆM VỤ CỦA CLASS:
'  
'  - là class chứa template method cho in-place editing 
'  
'
'
Option Explicit On 
Option Strict On

Imports C1.Win.C1FlexGrid
Imports IP.Core.IPCommon

Public Class CGridRowUpdate2DB

#Region "MEMBERS"
    Private m_isRowEditing As Boolean = False
    Private m_oCSaveTrangThai1DongCuaGrid As CSaveTrangThai1DongCuaGrid
    Private m_trans As SqlClient.SqlTransaction
    Private m_usObject As Object
    Private m_fg As C1FlexGrid
    Private m_current_row As Integer

#End Region


#Region "Public interface"

    Public Sub New(ByVal i_usObject As Object)
        Debug.Assert(Not (i_usObject Is Nothing), "e, sao khong khoi tao -csung")
        m_usObject = i_usObject
    End Sub

    Public Sub handle_StartEdit(ByVal i_c1fg As C1FlexGrid, _
                                ByVal e As RowColEventArgs)
        If m_isRowEditing Then Exit Sub
        RaiseEvent GridRow2Me_4_IsUpdatable(i_c1fg, e.Row, m_usObject)
        m_fg = i_c1fg
        m_current_row = e.Row
        BeginTran()
        Dim v_isUpdatable As Boolean
        RaiseEvent CheckIsUpdatable(m_trans, m_usObject, v_isUpdatable)
        If v_isUpdatable Then
            m_isRowEditing = True
            m_oCSaveTrangThai1DongCuaGrid = New CSaveTrangThai1DongCuaGrid(i_c1fg, e.Row)
        Else
            BaseMessages.MsgBox_Warning(15)
            Rollback()
            e.Cancel = True
        End If
    End Sub

    Public Sub handle_CancelRowEditing()
        If Not m_isRowEditing Then Exit Sub
        m_isRowEditing = False
        m_oCSaveTrangThai1DongCuaGrid.UndoTrangThai1Dong()
        Me.Rollback()
    End Sub


    Public Sub handle_BeforeRowColChange(ByVal i_c1fg As C1FlexGrid, _
                                         ByVal e As RangeEventArgs)
        If e.OldRange.r1 = e.NewRange.r1 And _
           e.OldRange.r2 = e.NewRange.r2 Then Exit Sub
        If Not m_isRowEditing Then Exit Sub

        Update2DB(i_c1fg, e.Cancel)
    End Sub


    Public Sub handle_FormClosing(ByVal i_c1fg As C1FlexGrid, _
                                   ByVal e As System.ComponentModel.CancelEventArgs, _
                                 ByRef o_formShouldStayOpened As Boolean)
        o_formShouldStayOpened = False
        If Not m_isRowEditing Then Exit Sub
        Dim v_UserAction As DialogResult = BaseMessages.MsgBox_YES_NO_CANCEL(17)
        Select Case v_UserAction
            Case DialogResult.No
                Rollback()
                m_oCSaveTrangThai1DongCuaGrid.UndoTrangThai1Dong()
                m_isRowEditing = False
                Exit Sub
            Case DialogResult.Cancel
                e.Cancel = True
                o_formShouldStayOpened = True
            Case DialogResult.OK

                Update2DB(i_c1fg, e.Cancel)
                o_formShouldStayOpened = e.Cancel
        End Select
    End Sub

    Public Delegate Sub Update_withoutCommitHandler(ByVal i_trans As SqlClient.SqlTransaction, _
                                                    ByVal i_usObject As Object, _
                                                    ByRef o_isSucceeded As Boolean, _
                                                    ByRef o_errorMessage2Display As String)
    Public Event Update_withoutCommit As Update_withoutCommitHandler
    Public Delegate Sub CheckIsUpdatable_handler(ByVal i_trans As SqlClient.SqlTransaction, _
                                                 ByVal i_usObject As Object, _
                                                 ByRef o_IsUpdatable As Boolean)
    Public Event CheckIsUpdatable As CheckIsUpdatable_handler
    Public Delegate Sub GridRow2Me_4_IsUpdatable_Handler(ByVal i_c1fg As C1FlexGrid, _
                                                         ByVal i_row As Integer, _
                                                         ByVal i_UsObject As Object)
    Public Event GridRow2Me_4_IsUpdatable As GridRow2Me_4_IsUpdatable_Handler
    Public Delegate Sub GridRow2Me_4_Update_Handler(ByVal i_c1fg As C1FlexGrid, _
                                                    ByVal i_row As Integer, _
                                                    ByVal i_UsObject As Object)
    Public Event GridRow2Me_4_Update As GridRow2Me_4_Update_Handler
    Public Delegate Sub Data2GridRow_AfterCommit_Handler(ByVal i_c1fg As C1FlexGrid, _
                                                         ByVal i_row As Integer, _
                                                         ByVal i_UsObject As Object)
    Public Event Data2GridRow_AfterEdit As Data2GridRow_AfterCommit_Handler

#End Region

#Region "Privates"
    Public Sub Update2DB(ByVal i_c1fg As C1FlexGrid, _
                         ByRef eCancel As Boolean)

        RaiseEvent GridRow2Me_4_Update(i_c1fg, i_c1fg.Row, m_usObject)
        Dim v_IsSucceeded As Boolean = False
        Dim v_errMsg As String
        RaiseEvent Update_withoutCommit(m_trans, m_usObject, v_IsSucceeded, v_errMsg)
        If v_IsSucceeded Then
            m_isRowEditing = False
            Me.Commit()
            RaiseEvent Data2GridRow_AfterEdit(m_fg, m_current_row, m_usObject)
            Exit Sub
        End If

        'if failed to update to db
        Dim v_msg_ask As String = v_errMsg & Microsoft.VisualBasic.vbCrLf & BaseMessages.GetMsg(16)
        If BaseMessages.MsgBox_Confirm(v_msg_ask) Then
            eCancel = True
        Else
            m_isRowEditing = False
            m_oCSaveTrangThai1DongCuaGrid.UndoTrangThai1Dong()
            Rollback()
        End If
    End Sub

#End Region

#Region "Must Override"
    'Protected MustOverride Sub GridRow2Me_4_IsUpdatable(ByVal i_c1fg As C1FlexGrid, ByVal i_row As Integer)
    'Protected MustOverride Sub GridRow2Me_4_Update(ByVal i_c1fg As C1FlexGrid, ByVal i_row As Integer)
    'Protected MustOverride Sub Update_withoutCommit(ByVal i_trans As SqlClient.SqlTransaction, _
    '                                                ByRef o_isSucceeded As Boolean)
    'Protected MustOverride Function IsUpdatable(ByVal i_trans As SqlClient.SqlTransaction) As Boolean


#End Region

#Region "Overridable"
    Protected Sub Rollback()
        m_trans.Rollback()
    End Sub
    Protected Sub Commit()
        m_trans.Commit()

    End Sub

    Protected Sub BeginTran()
        Dim v_us As New US_Object()
        m_trans = v_us.BeginTransaction
    End Sub

#End Region

 
End Class

