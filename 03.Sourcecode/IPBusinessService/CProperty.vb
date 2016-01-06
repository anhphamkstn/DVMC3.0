
Public Class CProperty
    Protected p_DataType As System.Type
    Protected p_PropertyName As String

    Public Sub New()

    End Sub

    Public Sub SetValues(ByVal i_DataType As System.Type, ByVal i_PropertyName As String)
        p_DataType = i_DataType
        p_PropertyName = i_PropertyName
    End Sub

    Public Function getName() As String
        Return p_PropertyName
    End Function

    Public Overridable Function getValueParaName() As String
        Return "@" & p_PropertyName
    End Function

    Public Overridable Function CreateSQLValuePara() As SqlClient.SqlParameter
        Return DataType2Parameter(p_DataType, getValueParaName())
    End Function

    Private Function DataType2Parameter(ByVal i_DataType As System.Type, _
                    ByVal i_ParaName As String) As SqlClient.SqlParameter
        'Chuyen tu datatype voi ten tuong ung thanh sqlparameter
        Dim v_SqlPara As SqlClient.SqlParameter
        Select Case p_DataType.ToString
            Case "System.String"
                v_SqlPara = New SqlClient.SqlParameter(i_ParaName, System.Data.SqlDbType.NVarChar)
            Case "System.DateTime"
                v_SqlPara = New SqlClient.SqlParameter(i_ParaName, System.Data.SqlDbType.DateTime)
            Case "System.Decimal", "System.Int32"
                v_SqlPara = New SqlClient.SqlParameter(i_ParaName, System.Data.SqlDbType.Decimal)
            Case Else
                'Cac truong hop la so
                'Raise Error o day
        End Select
        Return v_SqlPara
    End Function

End Class
