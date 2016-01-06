Public Enum eSystemAdminSysParaEnum
    CHUA_DINH_NGHIA = 0
End Enum

Friend Class CSystemAdminSystemParameter
    Public Shared Function get_ma_tham_so(ByVal i_eMa As eSystemAdminSysParaEnum) As String
        Select Case i_eMa
            Case Else
                Debug.Assert(False, "Khong ma tham so nay trong enum eSchoolSysParaEnum")
        End Select
    End Function
End Class
