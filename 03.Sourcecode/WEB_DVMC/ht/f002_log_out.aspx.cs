using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WEB_DVMC.ht
{
    public partial class f002_log_out : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                Session.Clear();
                Session.RemoveAll();
                Session.Abandon();
                Response.Redirect("~/ht/f000_login.aspx");
            }

            catch (Exception ex)
            {

            }
        }
    }
}