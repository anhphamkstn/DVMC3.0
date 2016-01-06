using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Drawing;
using System.Drawing.Imaging;
using System.Text;
using System.IO;

public partial class UC_ReloadCaptcha : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        var fcaptcha = MapPath("~/Css/Login-Box/Captcha.bmp");

        var bmpCaptcha = new Bitmap(fcaptcha);
        var g = Graphics.FromImage(bmpCaptcha);
        var code = RandomizeText(5);

        var gray = new SolidBrush(Color.DimGray);
        var rand = new Random();
        var counter = 0;

        for (int i = 0; i < code.Length; i++)
        {
            g.DrawString(code[i].ToString(),
               new Font("Verdena", 10 + rand.Next(20)),
               gray, new PointF(40 + counter, 10));
            counter += 20;
        }

        // Assign Code
        Session["Captcha"] = code;

        // Response
        Response.Clear();
        Response.ContentType = "image/jpeg";

        bmpCaptcha.Save(Response.OutputStream, ImageFormat.Jpeg);
        bmpCaptcha.Dispose();
        g.Dispose();

        Response.End();
    }

    private string RandomizeText(int ip_int_tlen)
    {
        var randomText = new StringBuilder();
        var alphabets = "abcdefghijklmnopqrstuvwxyz";
        var r = new Random();

        for (int j = 0; j < ip_int_tlen; j++)
        {
            randomText.Append(alphabets[r.Next(alphabets.Length)]);
        }
        return randomText.ToString();
    }
}