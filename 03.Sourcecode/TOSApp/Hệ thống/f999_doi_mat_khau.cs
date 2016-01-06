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
    public partial class f999_doi_mat_khau : Form
    {
        public f999_doi_mat_khau()
        {
            InitializeComponent();
        }
        US_HT_NGUOI_SU_DUNG v_us = new US_HT_NGUOI_SU_DUNG(us_user.dcID);

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (txt_mat_khau_hien_tai.Text == "")
                lab_eror.Text="Vui lòng nhập mật khẩu hiện tại trước khi thay đổi!";
            else if (txt_mat_khau_moi.Text == "")
                lab_eror.Text="Nhập mật khẩu mới nếu bạn muốn thay đổi!";
            else if (txt_nhap_lai_mat_khau_moi.Text == "")
                lab_eror.Text="Xác nhận mật khẩu mới!";
            else
            {
                if (us_user.GetMD5( txt_mat_khau_hien_tai.Text) != v_us.strMAT_KHAU)
                    lab_eror.Text="Mật khẩu hiện tại sai!";
                else if(txt_nhap_lai_mat_khau_moi.Text != txt_mat_khau_moi.Text)
                    lab_eror.Text="xác nhận mật khẩu mới sai!";
                else
                {
                    v_us.strMAT_KHAU = us_user.GetMD5(txt_nhap_lai_mat_khau_moi.Text);
                    v_us.Update();
                    this.Close();
                }

            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
     
    }
}
