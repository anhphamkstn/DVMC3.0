'NHIỆM VỤ CỦA CLASS
'   
'
' đọc các tham số hệ thống
'
'
'
' Intend: lam 4 class de dinh nghia ma tham so moi de dang hon
' Nhung no lai khong strong type khi goi -> doi de sua sau


Option Explicit On 
Option Strict On

Imports IP.Core.IPCommon
Imports IP.Core.IPException
Imports IP.Core.IPData
Imports IP.Core.IPUserService
Public Class CSystemParameter
#Region "PUBLIC INTERFACE"
    'Public Shared Function getParamValue(ByVal i_tham_so As SystemParamKey, _
    '                                      ByVal i_phan_he As SubSystemKey) As String
    '    ' ININITALIZATION
    '    If Not m_initialized Then
    '        Initialize()
    '        m_initialized = True
    '    End If
    '    'SEARCH DATA
    '    Try
    '        Dim v_ma_tham_so As String = get_ma_tham_so(i_tham_so)
    '        Dim v_ma_phan_he As String = phan_he.getMa(i_phan_he)
    '        Return get_gia_tri_tham_so(v_ma_phan_he, v_ma_tham_so)
    '    Catch v_e As Exception
    '        Debug.Assert(False, "Không đúng tên dữ liệu, kiểm tra lại xem - csung")
    '    End Try
    'End Function

   

   
    Public Shared Function get_quan_tri_ht_para_value(ByVal i_eMa_tham_so As eSystemAdminSysParaEnum) As String
        ' ININITALIZATION
        If Not m_initialized Then
            Initialize()
            m_initialized = True
        End If
        'SEARCH DATA
        Try
            Dim v_ma_tham_so As String = CSystemAdminSystemParameter.get_ma_tham_so(i_eMa_tham_so)
            Dim v_ma_phan_he As String = PHAN_HE.getMa(SubSystemKey.QUAN_TRI_HE_THONG)
            Return get_gia_tri_tham_so(v_ma_phan_he, v_ma_tham_so)
        Catch v_e As Exception
            Debug.Assert(False, "Không đúng tên dữ liệu, kiểm tra lại xem - csung")
        End Try
    End Function

    
#End Region

#Region "CONSTANTS"

#End Region

#Region "DATA STRUCTURES"

    Public Enum SystemParamKey
        SO_GIO_SANG = 0
        SO_GIO_CHIEU = 1
        SO_GIO_TOI = 2
        DIEM_TRUNG_BINH = 3
        THI_LAI_MAX = 4
        NAM_KE_TOAN = 5
    End Enum

#End Region

#Region "MEMBERS"
    Private Shared m_ds_tham_so As DS_HT_THAM_SO_HE_THONG
    Private Shared m_ma_tham_so_list As Hashtable
    Private Shared m_initialized As Boolean = False
#End Region

#Region "EVENT HANDLERS"

#End Region

#Region "PRIVATES"
    Private Shared Sub InitializeMaThamSo()
        m_ma_tham_so_list = New Hashtable
        m_ma_tham_so_list.Add(SystemParamKey.SO_GIO_CHIEU, "SO_GIO_CHIEU")
        m_ma_tham_so_list.Add(SystemParamKey.SO_GIO_SANG, "SO_GIO_SANG")
        m_ma_tham_so_list.Add(SystemParamKey.SO_GIO_TOI, "SO_GIO_TOI")
        m_ma_tham_so_list.Add(SystemParamKey.DIEM_TRUNG_BINH, "DIEM_TRUNG_BINH")
        m_ma_tham_so_list.Add(SystemParamKey.THI_LAI_MAX, "THI_LAI_MAX")
        m_ma_tham_so_list.Add(SystemParamKey.NAM_KE_TOAN, "NAM_KE_TOAN")
    End Sub

    Private Shared Sub Initialize()
        Try
            InitializeMaThamSo()
            m_ds_tham_so = New DS_HT_THAM_SO_HE_THONG
            Dim v_us As New US_HT_THAM_SO_HE_THONG
            v_us.FillDataset(m_ds_tham_so)
        Catch v_e As Exception
            Dim v_handler As New CDBExceptionHandler(v_e, New CDBClientDBExceptionInterpret)
            v_handler.showErrorMessage()
            Debug.Assert(True, "Không khởi tạo được tham số HT - csung")
        End Try
    End Sub

    Private Shared Function get_ma_tham_so(ByVal i_tham_so As SystemParamKey) As String
        Dim v_result As String
        Try
            v_result = Convert.ToString(m_ma_tham_so_list(i_tham_so))
        Catch
            Debug.Assert(True, "Không có tham số như vậy")
        End Try
        Return v_result
    End Function

    Private Shared Function get_gia_tri_tham_so(ByVal i_ma_phan_he As String, ByVal i_ma_tham_so As String) As String
        Try
            Dim v_sqlFilter As String
            v_sqlFilter = "PHAN_HE = " & "'" & i_ma_phan_he & "'"
            v_sqlFilter &= " and MA_THAM_SO = " & "'" & i_ma_tham_so & "'"
            Dim v_dv As DataView = m_ds_tham_so.HT_THAM_SO_HE_THONG.DefaultView
            v_dv.RowFilter = v_sqlFilter
            Dim v_drv As DataRowView
            Dim v_result As String
            For Each v_drv In v_dv
                v_result = CNull.RowNVLString(v_drv.Row, "GIA_TRI")
            Next
            Return v_result
        Catch v_e As Exception
            CSystemLog_301.ExceptionHandle(v_e)
            Debug.Assert(True, "Không tìm thấy tham số, kiểm tra lại")
        End Try
    End Function
#End Region

#Region "INNER CLASSES"

#End Region

End Class


