' NHI?M V? C?A CLASS
'
'
'
'
'
'
Option Explicit On 
Option Strict On

Imports C1.Win.C1FlexGrid
Imports IP.Core.IPCommon
Imports IP.Core.IPData
Imports IP.Core.IPSystemAdmin
Imports IP.Core.IPException
Imports IP.Core.IPBusinessService

Public Class CUser_LogDiary_tabHandler4F200

#Region "PUBLIC INTERFACE"
    Public Sub New(ByVal i_fg As C1FlexGrid)
        m_fg = i_fg
        CControlFormat.setC1FlexFormat(m_fg)
        CGridUtils.AddSearch_Handlers(m_fg)
    End Sub

    Public Sub displayData(ByVal i_dcID_NSD As Decimal)


    End Sub

#End Region

#Region "CONSTANTS"

#End Region

#Region "STRUCTURES"

#End Region

#Region "MEMBERS"
    Private WithEvents m_fg As C1FlexGrid
#End Region

#Region "PRIVATES"

#End Region

    ' **********************************************
    '*
    '*  EVENT HANDLERS
    '*
    ' **********************************************


End Class
