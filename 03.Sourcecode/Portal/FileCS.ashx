<%@ WebHandler Language="C#" Class="FileCS" %>

using System;
using System.Web;
using IPCOREDS;
using IPCOREUS;
using IP.Core.IPCommon;

public class FileCS : IHttpHandler
{

    #region Member
    CLichSuCuocGoi objLichSugoi = new CLichSuCuocGoi();
    #endregion

    public void ProcessRequest(HttpContext context)
    {
        int ip_obj_id = int.Parse(context.Request.QueryString["Id"]);
        byte[] bytes;
        string contentType = "audio/x-wav";
        string v_str_file = "";
        US_GD_CUOC_GOI_YEU_CAU v_us_cuoc_goi = new US_GD_CUOC_GOI_YEU_CAU(CIPConvert.ToDecimal(ip_obj_id));
        v_str_file = HelpUtils.get_file_record(v_us_cuoc_goi.strVOICE_CALL_LINK);
        bytes = System.IO.File.ReadAllBytes(v_str_file);
        context.Response.Clear();
        context.Response.Buffer = true;
        context.Response.AppendHeader("Content-Disposition", "attachment; filename=" + v_str_file);
        context.Response.ContentType = contentType;
        context.Response.BinaryWrite(bytes);
        context.Response.End();
    }
   
    public bool IsReusable {
        get {
            return false;
        }
    }

}