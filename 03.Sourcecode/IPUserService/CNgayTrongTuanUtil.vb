
Option Explicit On 
Option Strict On

Imports IP.Core.IPCommon
Imports IP.Core.IPData
Imports IP.Core.IPException

Public Class CNgayTrongTuanUtil

#Region "DataStructures"

    Public Enum Enum_NgayTrongTuan
        THU_HAI = 0
        THU_BA = 1
        THU_TU = 2
        THU_NAM = 3
        THU_SAU = 4
        THU_BAY = 5
        CHU_NHAT = 6
    End Enum


#End Region

#Region "Private"
    Private Shared Sub Initialize_NgayTrongTuan()
        Try
            Dim v_us_ht_ngay_trong_tuan As New US_HT_NGAY_TRONG_TUAN()
            Dim v_ds_ngaytrongtuan As New DS_HT_NGAY_TRONG_TUAN()
            v_us_ht_ngay_trong_tuan.FillDataset(v_ds_ngaytrongtuan)
            m_View_NgayTrongTuan = New DataView(v_ds_ngaytrongtuan.HT_NGAY_TRONG_TUAN)
        Catch v_e As Exception
            Dim v_handler As New CDBExceptionHandler(v_e, New CDBClientDBExceptionInterpret())
            v_handler.showErrorMessage()
        End Try

    End Sub

    Private Shared Function getMaNgay(ByVal i_ngay As Enum_NgayTrongTuan) As String
        Dim v_result As String
        Select Case i_ngay
            Case Enum_NgayTrongTuan.CHU_NHAT
                v_result = MA_NGAY_TRONG_TUAN.CHU_NHAT
            Case Enum_NgayTrongTuan.THU_HAI
                v_result = MA_NGAY_TRONG_TUAN.THU_HAI
            Case Enum_NgayTrongTuan.THU_BA
                v_result = MA_NGAY_TRONG_TUAN.THU_BA
            Case Enum_NgayTrongTuan.THU_TU
                v_result = MA_NGAY_TRONG_TUAN.THU_TU
            Case Enum_NgayTrongTuan.THU_NAM
                v_result = MA_NGAY_TRONG_TUAN.THU_NAM
            Case Enum_NgayTrongTuan.THU_SAU
                v_result = MA_NGAY_TRONG_TUAN.THU_SAU
            Case Enum_NgayTrongTuan.THU_BAY
                v_result = MA_NGAY_TRONG_TUAN.THU_BAY
        End Select
        Return v_result
    End Function
#End Region

#Region "Members"
    Private Shared m_View_NgayTrongTuan As DataView
    Private Shared m_Initialized As Boolean = False
#End Region

#Region "PUBLIC INTERFACE"
   
    Public Shared Function getNgayTrongTuan(ByVal i_ngay As Enum_NgayTrongTuan) As US_HT_NGAY_TRONG_TUAN
        Try
            If Not m_Initialized Then
                Initialize_NgayTrongTuan()
                m_Initialized = True
            End If
            m_View_NgayTrongTuan.RowFilter = "Ma =" & "'" & getMaNgay(i_ngay) & "'"
            Dim v_drv As DataRowView
            Dim v_us_result As New US_HT_NGAY_TRONG_TUAN()
            For Each v_drv In m_View_NgayTrongTuan
                v_us_result.DataRow2Me(v_drv.Row)
            Next
            Return v_us_result
        Catch
            Debug.Assert(False, "Không lấy được ngày - csung ")
        End Try
    End Function


#End Region

#Region "Inner Classes"
    Private Class MA_NGAY_TRONG_TUAN

        Public Const CHU_NHAT As String = "CHU_NHAT"
        Public Const THU_BA As String = "THU_BA"
        Public Const THU_BAY As String = "THU_BAY"
        Public Const THU_HAI As String = "THU_HAI"
        Public Const THU_NAM As String = "THU_NAM"
        Public Const THU_SAU As String = "THU_SAU"
        Public Const THU_TU As String = "THU_TU"
    End Class


   
#End Region
End Class

