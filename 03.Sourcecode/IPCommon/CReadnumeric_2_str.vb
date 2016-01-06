Option Strict Off
Option Explicit On
Public Class CRead
   

    Public Shared Function ChuyenSo(ByVal i_str_gia_tri_so As String) As String
        Dim so As String() = {"không", "một", "hai", "ba", "bốn", "lăm", "sáu", "bảy", "tám", "chín", "mười"}
        Dim hang As String() = {"trăm", "nghìn", "triệu", "tỷ"}
        Dim void As ArrayList = New ArrayList
        Dim i As Byte
        Dim du, thuong As Long
        Dim kt1 As Boolean = False
        Dim ch As String
        Dim v_l_value_of_string As Long
        Dim s As String
        i = 0
        If Not IsNumeric(i_str_gia_tri_so) Then
            Return ""
        End If
        void.Clear()
        v_l_value_of_string = Val(i_str_gia_tri_so)
        ch = CStr(v_l_value_of_string)
        i_str_gia_tri_so = chuan_hoa_chuoi_so(ch)

        s = ""
        If v_l_value_of_string >= 0 AndAlso v_l_value_of_string <= 10 Then
            If v_l_value_of_string = 5 Then
                s = "năm"
            Else
                s = so(v_l_value_of_string)
            End If

            void.Add(v_l_value_of_string)
        Else
            While (v_l_value_of_string <> 0)
                i += 1
                du = v_l_value_of_string Mod 10
                thuong = v_l_value_of_string \ 10
                If i Mod 3 = 1 AndAlso du = 0 AndAlso thuong Mod 10 > 1 Then
                    s = "Mươi" + " " + s
                    void.Add(21)
                ElseIf i Mod 3 = 1 AndAlso du = 0 AndAlso thuong Mod 10 = 0 Then
                    kt1 = False
                ElseIf i Mod 3 = 1 AndAlso du <> 0 AndAlso thuong <> 0 AndAlso thuong Mod 10 = 0 Then
                    s = "linh" + " " + so(du) + " " + s
                    void.Add(du)
                    void.Add(26)
                    kt1 = True
                ElseIf i Mod 3 = 1 AndAlso du <> 0 Then
                    If thuong Mod 10 > 1 Then
                        If du = 1 Then
                            s = "mươi" + " " + "mốt" + " " + s
                            void.Add(20)
                            void.Add(21)
                        Else
                            s = "mươi" + " " + so(du) + " " + s
                            void.Add(du)
                            void.Add(21)
                        End If
                    Else
                        If du = 5 AndAlso thuong = 0 Then
                            s = "năm" + " " + s
                            void.Add(5)
                        Else
                            s = so(du) + " " + s
                            void.Add(du)
                        End If
                    End If
                    kt1 = True
                ElseIf i Mod 3 = 2 AndAlso du <> 0 AndAlso thuong <> 0 AndAlso thuong Mod 10 = 0 Then
                    If du > 1 AndAlso du <> 5 Then
                        s = so(0) + " " + hang(0) + " " + so(du) + " " + s
                        void.Add(du)
                        void.Add(22)
                        void.Add(0)
                    ElseIf du = 5 Then
                        s = so(0) + " " + hang(0) + " " + "năm" + " " + s
                        void.Add(5)
                        void.Add(22)
                        void.Add(0)
                    Else
                        s = so(0) + " " + hang(0) + " " + so(10) + " " + s
                        void.Add(10)
                        void.Add(22)
                        void.Add(0)
                    End If
                    kt1 = False
                ElseIf i Mod 3 = 2 AndAlso du <> 0 AndAlso thuong <> 0 Then
                    If du > 1 AndAlso du <> 5 Then
                        s = hang(0) + " " + so(du) + " " + s
                        void.Add(du)
                        void.Add(22)
                    ElseIf du = 5 Then
                        s = hang(0) + " " + "năm" + " " + s
                        void.Add(5)
                        void.Add(22)
                    Else
                        s = hang(0) + " " + so(10) + " " + s
                        void.Add(10)
                        void.Add(22)
                    End If
                ElseIf i Mod 3 = 2 AndAlso du = 0 AndAlso thuong Mod 10 <> 0 Then
                    s = hang(0) + " " + s
                    void.Add(22)
                ElseIf i Mod 3 = 2 AndAlso du = 0 AndAlso thuong <> 0 AndAlso thuong Mod 10 = 0 And kt1 = True Then
                    s = so(0) + " " + hang(0) + " " + s
                    void.Add(22)
                    void.Add(0)
                    kt1 = False
                ElseIf i Mod 3 = 2 AndAlso du <> 0 AndAlso thuong = 0 Then
                    If du > 1 AndAlso du <> 5 Then
                        s = so(du) + " " + s
                        void.Add(du)
                    ElseIf du = 5 Then
                        s = "năm" + " " + s
                        void.Add(5)
                    Else
                        s = so(10) + " " + s
                        void.Add(10)
                    End If
                ElseIf i Mod 3 = 0 AndAlso du <> 0 AndAlso thuong <> 0 AndAlso thuong Mod 1000 <> 0 Then
                    If du = 5 Then
                        s = hang(i \ 3) + " " + "năm" + " " + s
                        void.Add(5)
                    Else
                        s = hang(i \ 3) + " " + so(du) + " " + s
                        void.Add(du)
                    End If
                    void.Add((22 + i \ 3))
                ElseIf i Mod 3 = 0 AndAlso du = 0 AndAlso thuong Mod 1000 <> 0 Then
                    s = hang(i \ 3) + " " + s
                    void.Add((22 + i \ 3))
                ElseIf i Mod 3 = 0 AndAlso du <> 0 Then
                    If du = 5 Then
                        s = "năm" + " " + s
                        void.Add(5)
                    Else
                        s = so(du) + " " + s
                        void.Add(du)
                    End If
                End If
                v_l_value_of_string = thuong
            End While
        End If
        If s.Length > 0 Then
            s = s.Substring(0, 1).ToUpper() + s.Substring(1)
        End If
        Return s + " đồng"


        
    End Function
    Private Shared Function chuan_hoa_chuoi_so(ByVal i_str_chuoi_so As String) As String
        'example : 1234->1.234
        Dim v_i_count As Integer = 0
        Dim v_str_result As String = i_str_chuoi_so
        v_i_count = Len(v_str_result)
        v_i_count = v_i_count - 3
        While (v_i_count > 0)
            v_str_result = v_str_result.Insert(v_i_count, ".")
            v_i_count = v_i_count - 3
        End While
        Return v_str_result
    End Function
End Class