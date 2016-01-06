'NHI?M V? C?A CLASS
'   
'
' tabPage
'
'
'

Public Class CTabPageUtils
    public shared sub loadForm_2_TabPage( byval i_form as System.Windows.Forms.Form, _
                                          byval i_tabpage as System.Windows.Forms.TabPage)
        debug.Assert( not (i_form is nothing), "Khong khoi tao form")
        debug.Assert( not (i_tabpage is nothing), "Khong khoi tao tabpage")
        i_form.toplevel = False
        i_form.Dock = Windows.Forms.DockStyle.Fill
        i_form.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        i_tabpage.Controls.Clear
        i_tabpage.Controls.Add (i_form)
    End Sub
End Class
