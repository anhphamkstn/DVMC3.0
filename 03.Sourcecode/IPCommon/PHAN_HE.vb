Option Explicit On 
Option Strict On


    Public Enum SubSystemKey
    QUAN_TRI_HE_THONG = 0
    CO_SO_DAO_TAO = 1
    TAI_CHINH = 2
    HANH_CHINH = 3
    KE_TOAN = 4
    End Enum

Public Class PHAN_HE
    
   public class TEN_PHAN_HE
        public const CO_SO_DAO_TAO as String = "Cơ sở đào tạo"
        public  const QUAN_TRI_HE_THONG as String = "Quản trị hệ thống"
        public  const TAI_CHINH as String = "Tài chính"
        Public Const HANH_CHINH As String = "Hành chính"
        Public Const KE_TOAN As String = "Kế toán"
    End Class

    public class MA_PHAN_HE
        public const CO_SO_DAO_TAO as String = "CSDT"
        public  const QUAN_TRI_HE_THONG as String = "QH"
        public  const TAI_CHINH as String = "TC"
        public  const HANH_CHINH AS String = "HC"
        Public Const KE_TOAN As String = "KT"
    End Class

    Public shared function getTen(byval i_subsystem as SubSystemKey) as String
        select case i_subsystem
            case  SubSystemKey.CO_SO_DAO_TAO
                return ten_phan_he.CO_SO_DAO_TAO
            case SubSystemKey.HANH_CHINH
                return ten_phan_he.HANH_CHINH
            case SubSystemKey.QUAN_TRI_HE_THONG
                return ten_phan_he.QUAN_TRI_HE_THONG
            case SubSystemKey.TAI_CHINH
                Return TEN_PHAN_HE.TAI_CHINH
            Case SubSystemKey.KE_TOAN
                Return TEN_PHAN_HE.KE_TOAN
        End Select
    End Function

    public shared function getTen(byval i_strMaPhanHe as string) as string
        if i_strMaPhanHe = ma_phan_he.CO_SO_DAO_TAO then
            return getten(SubSystemKey.CO_SO_DAO_TAO)
        elseif i_strmaphanhe = ma_phan_he.QUAN_TRI_HE_THONG then
            return getten(SubSystemKey.QUAN_TRI_HE_THONG)
        elseif i_strmaphanhe = ma_phan_he.HANH_CHINH then
            return getten(SubSystemKey.HANH_CHINH)
        elseif i_strmaphanhe = ma_phan_he.TAI_CHINH then
            Return getTen(SubSystemKey.TAI_CHINH)
        ElseIf i_strMaPhanHe = MA_PHAN_HE.KE_TOAN Then
            Return getTen(SubSystemKey.KE_TOAN)
        Else
            Debug.Assert(False, "")
        End If
    End Function    

    public shared function getMa(byval i_subsystem as SubSystemKey) as String
        select case i_subsystem
            case  SubSystemKey.CO_SO_DAO_TAO
                return ma_phan_he.CO_SO_DAO_TAO
            case SubSystemKey.HANH_CHINH
                return ma_phan_he.HANH_CHINH
            case SubSystemKey.QUAN_TRI_HE_THONG
                return ma_phan_he.QUAN_TRI_HE_THONG
            case SubSystemKey.TAI_CHINH
                return ma_phan_he.TAI_CHINH
        End Select
    End Function
End Class
