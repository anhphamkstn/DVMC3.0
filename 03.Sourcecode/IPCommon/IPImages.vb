Option Explicit On 
Option Strict On

Public Class IPImages
    Private m_frmForm As frmIcons
    Private Sub New()
        m_frmForm = New frmIcons()
    End Sub

    Private Function getImage(ByVal i_imgIndex As Integer) As System.Drawing.Image
        Debug.Assert(i_imgIndex >= 0 And i_imgIndex <= m_frmForm.m_imgListOfIcons.Images.Count - 1, _
                    " ta: khoong co image voi index =  " & i_imgIndex.ToString)
        Return m_frmForm.m_imgListOfIcons.Images(i_imgIndex)
    End Function

    Private Shared m_IPImages As IPImages

    Public Shared Function getImageResource(ByVal i_imgIndex As Integer) As System.Drawing.Image
        If m_IPImages Is Nothing Then m_IPImages = New IPImages()
        Return m_IPImages.getImage(i_imgIndex)
    End Function
End Class
