'NHIỆM VỤ:
' 
'   Thực hiện BOOL Algebra trên giá trị Y/N   
'
Option Explicit On 
Option Strict On


Public Class YNBool
    Private Const C_YES As String = "Y"
    Private Const C_NO As String = "N"

    'Chuyển từ Boolean sang Y_N
    Public Shared Function Boolean2YN(ByVal i_bBoolean As Boolean) As String
        If i_bBoolean Then
            Return C_YES
        Else
            Return C_NO
        End If
    End Function
    'Chuyển từ Y_N sang Boolean
    Public Shared Function YN2Boolean(ByVal i_strYN As String) As Boolean
        If i_strYN = C_YES Then
            Return True
        Else
            If i_strYN = C_NO Then
                Return False
            Else
                Debug.Assert(False)
                'Nếu chương trình bị dừng ở đây 
                'thì chuỗi truyền vào là không hợp lệ
            End If
        End If
    End Function
    '
    Public Shared Function Negalt(ByVal i_strYN As String) As String
        If i_strYN = C_YES Then
            Return C_NO
        ElseIf i_strYN = C_NO Then
            Return C_YES
        Else
            Debug.Assert(False, "Khong phai la YN string")
        End If
    End Function
End Class
