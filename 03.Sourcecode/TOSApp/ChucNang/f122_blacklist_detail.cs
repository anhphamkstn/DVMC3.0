using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IPCOREUS;

namespace TOSApp.ChucNang
{
    public partial class f122_blacklist_detail : Form
    {
        public f122_blacklist_detail()
        {
            InitializeComponent();
        }

        private void m_cmd_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void m_cmd_OK_Click(object sender, EventArgs e)
        {
            if (kiem_tra_truoc_luu()==true)
            {
                US_DM_BLACK_LIST v_us = new US_DM_BLACK_LIST();
                v_us.strSO_DIEN_THOAI = m_txt_so_dien_thoai.Text;
                v_us.strHO_TEN_CHU_DIEN_THOAI = m_txt_ho_ten.Text;
                v_us.strGHI_CHU_LY_DO = m_txt_ly_do.Text;
                v_us.strADD_YN = "N";
                v_us.datNGAY_ADD = System.DateTime.Now;
                v_us.dcID_NGUOI_ADD = us_user.dcID;
                v_us.Insert();
                this.Close();
            }
           
        }

        private bool kiem_tra_truoc_luu()
        {
            if (m_txt_so_dien_thoai.Text=="")
            {
                return false;
            }
            else if (m_txt_ly_do.Text =="")
            {
                return false;
            }
            return true;
        }

        private void format_key(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true; 

        }

       
    }
}
