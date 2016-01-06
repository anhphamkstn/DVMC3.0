
'''''import crystal
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine

Public Class CReportParameterFields
#Region "PUBLIC INTERFACE"

    Public Sub AddParameter(ByVal i_paramName As String, _
                                          ByVal i_paramValue As String, _
                                          ByVal o_paramFields As ParameterFields)

        Dim paramField As New ParameterField
        Dim paramDiscreteValue As New ParameterDiscreteValue
        Dim paramValues As New ParameterValues

        ' Set the name of the parameter to modify.
        paramField.ParameterFieldName = i_paramName

        ' Set a value to the parameter.
        paramDiscreteValue.Value = i_paramValue
        paramValues.Add(paramDiscreteValue)
        paramField.CurrentValues = paramValues

        ' Add the parameter to the ParameterFields collection.
        o_paramFields.Add(paramField)
        '      Return paramFields
    End Sub

    Public Sub AddParameter(ByVal i_paramName As String, _
                                      ByVal i_paramValue As Decimal, _
                                      ByVal o_paramFields As ParameterFields)

        Dim paramField As New ParameterField
        Dim paramDiscreteValue As New ParameterDiscreteValue
        Dim paramValues As New ParameterValues

        ' Set the name of the parameter to modify.
        paramField.ParameterFieldName = i_paramName

        ' Set a value to the parameter.
        paramDiscreteValue.Value = i_paramValue
        paramValues.Add(paramDiscreteValue)
        paramField.CurrentValues = paramValues

        ' Add the parameter to the ParameterFields collection.
        o_paramFields.Add(paramField)
        '      Return paramFields
    End Sub

    Public Sub AddParameter(ByVal i_paramName As String, _
                                      ByVal i_paramValue As Integer, _
                                      ByVal o_paramFields As ParameterFields)

        Dim paramField As New ParameterField
        Dim paramDiscreteValue As New ParameterDiscreteValue
        Dim paramValues As New ParameterValues

        ' Set the name of the parameter to modify.
        paramField.ParameterFieldName = i_paramName

        ' Set a value to the parameter.
        paramDiscreteValue.Value = i_paramValue
        paramValues.Add(paramDiscreteValue)
        paramField.CurrentValues = paramValues

        ' Add the parameter to the ParameterFields collection.
        o_paramFields.Add(paramField)
        '      Return paramFields
    End Sub

    Public Sub AddParameter(ByVal i_paramName As String, _
                                          ByVal i_paramValue As DateTime, _
                                          ByVal o_paramFields As ParameterFields)

        Dim paramField As New ParameterField
        Dim paramDiscreteValue As New ParameterDiscreteValue
        Dim paramValues As New ParameterValues

        ' Set the name of the parameter to modify.
        paramField.ParameterFieldName = i_paramName

        ' Set a value to the parameter.
        paramDiscreteValue.Value = i_paramValue
        paramValues.Add(paramDiscreteValue)
        paramField.CurrentValues = paramValues

        ' Add the parameter to the ParameterFields collection.
        o_paramFields.Add(paramField)
        '      Return paramFields
    End Sub

#End Region

#Region "PRIVATE METHODS"

#End Region
End Class
