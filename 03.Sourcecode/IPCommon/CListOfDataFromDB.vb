Option Strict On
Option Explicit On 

Public Class CListOfDataFromDB
    Private m_hashtable As Hashtable
    Public Sub New(ByVal ip_ds As DataSet, _
                     Optional ByVal ip_key_name As String = "ID", _
                     Optional ByVal ip_value_name As String = "TEN" _
                    )
        Debug.Assert(Not (ip_ds Is Nothing), "CSUNG: DS NOT FILLED")
        Debug.Assert(Not (ip_ds.Tables.Count = 0), "CSUNG: DS NOT FILLED")

        Try
            m_hashtable = New Hashtable()
            Dim v_i As Integer = 0

            For v_i = 0 To ip_ds.Tables(0).Rows.Count - 1

                Debug.Assert(Not ip_ds.Tables(0).Rows(v_i).IsNull(ip_key_name), "Csung: Key khong nulll duoc")
                If ip_ds.Tables(0).Rows(v_i).IsNull(ip_value_name) Then
                    m_hashtable.Add(ip_ds.Tables(0).Rows(v_i)(ip_key_name), Nothing)
                else
                    m_hashtable.Add(ip_ds.Tables(0).Rows(v_i)(ip_key_name), _
                                    ip_ds.Tables(0).Rows(v_i)(ip_value_name))
                End If

            Next
        Catch v_e As Exception
            Debug.Assert(False, "csung khong biet: " & v_e.Message)
        End Try

    End Sub

    Default Public ReadOnly Property Item(ByVal ip_key As Object) As Object
        Get
            Return m_hashtable(ip_key)
        End Get
    End Property


End Class
