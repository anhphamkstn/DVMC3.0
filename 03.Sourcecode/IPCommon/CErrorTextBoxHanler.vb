option Strict On
option explicit On 

imports System.Windows.Forms
imports system.drawing 

public  class CErrorTextBoxHandler

        PRIVATE CONST C_ERROR_CONTROL_IMAGE_INDEX AS INTEGER = 14
        PRIVATE C_BACKCOLOR_ERROR AS system.Drawing.Color = system.DRAWING.Color.pink
        private withevents m_txtBox as textbox            
        private withevents m_form as form
        private m_old_backcolor_of_txtBox as Drawing.color
        
        private sub new (byval i_txtBox as textbox)
            m_txtBox = i_txtBox
            m_txtbox.Tag = me
            m_form = i_txtBox.FindForm
            addErrorMark()            
            try 
                m_txtbox.focus
                addhandler m_txtBox.TextChanged , addressof handle_changed
                addhandler m_txtBox.leave , addressof handle_leave
            catch v_e as exception
                addhandler m_form.KeyDown, addressof keydown_in_form    
            End Try
        End Sub

        private sub removeErrorMarkandHandlers()
            removeErrorMark()
            removehandler m_txtBox.TextChanged , addressof handle_changed    
            removehandler m_txtBox.leave , addressof handle_leave
            removehandler m_form.KeyDown, addressof  keydown_in_form
            m_txtbox.Tag = nothing
        End Sub

        private sub handle_changed( ByVal sender As Object, ByVal e As System.EventArgs)  
            removeErrorMarkandHandlers()
        End Sub
        
        private sub handle_leave( ByVal sender As Object, ByVal e As System.EventArgs)  
            removeErrorMarkandHandlers()
        End Sub

        private sub keydown_in_form(ByVal sender As Object, ByVal e As KeyEventArgs)
            removeErrorMarkandHandlers()
        End Sub


        private sub addErrorMark()
             m_old_backcolor_of_txtBox  = m_txtbox.BackColor
             m_txtbox.BackColor =me.C_BACKCOLOR_ERROR
        End Sub

        private sub removeErrorMark()
            m_txtbox.BackColor = m_old_backcolor_of_txtBox
        End Sub

        
        private shared  function  getPictureBox(byval i_height as Integer, byval i_width as integer) as PictureBox
            Dim v_pictureBox As New PictureBox()
            v_pictureBox.Image = ipimages.getImageResource(C_ERROR_CONTROL_IMAGE_INDEX)
            v_picturebox.SizeMode = PictureBoxSizeMode.StretchImage
            v_picturebox.Size = new Size(i_width, i_height)
            return v_pictureBox
        end function

        private sub addPB(byval i_picturebox as PictureBox, byval i_top as Integer, byval i_left as Integer)
            i_pictureBox.top  = i_top
            i_picturebox.left = i_left
            i_picturebox.BringToFront
            m_txtBox.FindForm.Controls.Add(i_picturebox)
        End Sub
        
        public shared sub  markAsErrorTxtBox( byval i_txtBox as textbox)
             dim v_err as New CErrorTextBoxHandler(i_txtBox)
        End sub
    End Class
