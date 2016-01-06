Public Class CNullOfRow
    Private m_dr As DataRow

    Public Sub ReferenceToRow(ByVal i_dr As DataRow)
        m_dr = i_dr
    End Sub

    Public Function IsNull(ByVal i_FieldName As String) As Boolean
        Return m_dr.IsNull(i_FieldName)
    End Function

    Public Function NVLDecimal(ByVal i_FieldName As String, _
         Optional ByVal i_DefaultValue As Decimal = IPConstants.c_DefaultDecimal) As Decimal
        If m_dr.IsNull(i_FieldName) Then
            Return i_DefaultValue
        Else
            Return CType(m_dr.Item(i_FieldName), Decimal)
        End If
    End Function

    Public Function NVLDate(ByVal i_FieldName As String, _
            Optional ByVal i_DefaultValue As Date = IPConstants.c_DefaultDate) As Date
        If m_dr.IsNull(i_FieldName) Then
            Return i_DefaultValue
        Else
            Return CType(m_dr.Item(i_FieldName), Date)
        End If
    End Function

    Public Function NVLString(ByVal i_FieldName As String, _
            Optional ByVal i_DefaultValue As String = IPConstants.c_DefaultString) As String
        If m_dr.IsNull(i_FieldName) Then
            Return i_DefaultValue
        Else
            Return CType(m_dr.Item(i_FieldName), String)
        End If
    End Function
End Class