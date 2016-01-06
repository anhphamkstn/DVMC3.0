'NHIỆM VỤ CỦA CLASS
'   đọc và viết file config
'
'
Option Strict On
Option Explicit On 

Imports System
Imports System.Xml
Imports System.Reflection.Assembly



Public Class AppSettingsWriter
#Region "MEMBERS"
    Private m_configFileName As String
    Private m_document As XmlDocument
#End Region

#Region "CONSTANTS"
    Private Const C_DOUBLE_QUOTE As String = Chr(34)
#End Region

#Region "public interface"
    Public Sub New()
        Dim v_asmy As System.Reflection.Assembly
        Dim v_tempName As String
        v_asmy = GetEntryAssembly()
        v_tempName = v_asmy.Location

        m_configFileName = v_tempName & ".config"
        m_document = New XmlDocument
        m_document.Load(m_configFileName)
    End Sub

    Public Sub writeValue(ByVal i_Key As String, ByVal i_Value As String)

        Dim v_Query As String
        Dim v_Node As XmlNode
        Dim v_Root As XmlNode
        Dim v_Key_Attribute As XmlNode
        Dim v_Value_Attribute As XmlNode

        v_Query = "/configuration/appSettings/add[@key=" & C_DOUBLE_QUOTE & i_Key & C_DOUBLE_QUOTE & "]"
        v_Node = m_document.DocumentElement.SelectSingleNode(v_Query)
        If Not v_Node Is Nothing Then  ' neu co not nay roi thi doc no ra va set gia tri
            v_Node.Attributes.GetNamedItem("value").Value = i_Value
        Else  ' neu chua co thi tao ra
            v_Node = m_document.CreateNode(XmlNodeType.Element, "add", "")

            v_Key_Attribute = m_document.CreateNode(XmlNodeType.Attribute, "key", "")
            v_Key_Attribute.Value = i_Key
            v_Node.Attributes.SetNamedItem(v_Key_Attribute)

            v_Value_Attribute = m_document.CreateNode(XmlNodeType.Attribute, "value", "")
            v_Value_Attribute.Value = i_Value
            v_Node.Attributes.SetNamedItem(v_Value_Attribute)

            v_Query = "/configuration/appSettings"
            v_Root = m_document.DocumentElement.SelectSingleNode(v_Query)
            If Not v_Root Is Nothing Then
                v_Root.AppendChild(v_Node)
            Else
                Throw New InvalidOperationException("Khong doc duoc file config")
            End If
        End If

    End Sub

    Public Sub SaveFile()
        m_document.Save(m_configFileName)
    End Sub
#End Region
End Class


