using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

using IP.Core.IPCommon;
using IP.Core.IPUserService;
using IP.Core.IPData;

using System.Data;
using IPCOREDS.CDBNames;
using IPCOREDS;
using IPCOREUS;



public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            this.Title = "Cổng tra cứu các vấn đề, câu hỏi của học viên cho QLHT";
            if (!IsPostBack)
            {
                if (Session["AccounLogin"] == null || Session["AccounLogin"].ToString().Equals("N"))
                {
                    Response.Redirect("~/Account/Login.aspx");
                }
                else set_initial_page_load();  
            }
        }
        catch (Exception v_e)
        {
            CSystemLog_301.ExceptionHandle(this, v_e);
        }
    }

    #region Members


    #endregion

    #region Private Methods
    
    private void set_initial_page_load()
    {
    }
    
    
    #endregion

    #region Events
    
    #endregion
}