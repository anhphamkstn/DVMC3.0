using IPCOREUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TOSApp.Hệ_thống
{
    public partial class f999_doi_ten_dang_nhap : Form
    {
        public f999_doi_ten_dang_nhap()
        {
            InitializeComponent();
        }
        US_HT_NGUOI_SU_DUNG v_us = new US_HT_NGUOI_SU_DUNG(us_user.dcID);
        private void f999_doi_ten_dang_nhap_Load(object sender, EventArgs e)
        {
            txt_ten_dang_nhap_hien_tai.Text = v_us.strTEN_TRUY_CAP;
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (txt_ten_dang_nhap_moi.Text == "")
                lab_eror.Text="Nhập tên đăng nhập mới nếu bạn muốn thay đổi!";
            else if (txt_mat_khau.Text == "")
                lab_eror.Text="Vui lòng xác minh lại mật khẩu!";
            else
            {
                if (us_user.GetMD5(txt_mat_khau.Text) != v_us.strMAT_KHAU)
                    lab_eror.Text="Mật khẩu không đúng!";
                else  
                {
                    US_DUNG_CHUNG v_us_dungchung = new US_DUNG_CHUNG();
                    DataSet v_ds = new DataSet();
                    v_ds.Tables.Add(new DataTable());
                    v_us_dungchung.FillDatasetWithQuery(v_ds, "SELECT *FROM HT_NGUOI_SU_DUNG WHERE TEN_TRUY_CAP = " + " '" + txt_ten_dang_nhap_moi.Text + "' ");
                    if (v_ds.Tables[0].Rows.Count > 0)
                        lab_eror.Text = " Tên đăng nhập này đã tồn tại trong hệ thống! ";
                    else
                    {
                        try
                        {
                            v_us.strTEN_TRUY_CAP = txt_ten_dang_nhap_moi.Text;
                            v_us.Update();
                            this.Close();
                        }
                        catch (Exception v_e)
                        {
                            CSystemLog_100.ExceptionHandle(v_e);

                        }
                    }
                }
                
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
