using IP.Core.IPCommon;
using IPCOREUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TOSApp.DanhMuc
{
    public partial class f101_dm_mau_email_de : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public f101_dm_mau_email_de()
        {
            InitializeComponent();
        }

        US_DM_MAU_EMAIL m_us = new US_DM_MAU_EMAIL();
        DataEntryFormMode m_e_form_mode = new DataEntryFormMode();
        internal void DisPlayForInsert()
        {
            m_e_form_mode = DataEntryFormMode.InsertDataState;
            this.ShowDialog();
        }

        internal void DisPlayForUpdate(US_DM_MAU_EMAIL v_us)
        {
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            us_to_form(v_us);
            m_us = v_us;
            this.ShowDialog();

        }

        private void us_to_form(US_DM_MAU_EMAIL v_us)
        {
            m_txt_gui_cc.Text = v_us.strGUI_CC;
            m_txt_tieu_de_mail.Text = v_us.strTIEU_DE_MAIL;
            m_txt_ma_email.Text = v_us.strMA_EMAIL;
            m_richedit_noi_dung_email.HtmlText = v_us.strNOI_DUNG_EMAIL;

        }

        private void form_to_us()
        {
            m_us.strGUI_CC = m_txt_gui_cc.Text;
            m_us.strMA_EMAIL = m_txt_ma_email.Text;
            m_us.strTIEU_DE_MAIL = m_txt_tieu_de_mail.Text;
            m_us.strNOI_DUNG_EMAIL = m_richedit_noi_dung_email.HtmlText;
        }

        private void f101_dm_mau_email_de_Load(object sender, EventArgs e)
        {
            if (us_user.dcIDNhom == 5)
            { }
            else
            {
                m_pan_button.Visible = false;
                m_txt_gui_cc.ReadOnly = true;
                m_txt_ma_email.ReadOnly = true;
                m_txt_tieu_de_mail.ReadOnly = true;
                m_richedit_noi_dung_email.ReadOnly = true;
            }
        }

        private void simpbtn_luu_Click(object sender, EventArgs e)
        {

            if (m_e_form_mode == DataEntryFormMode.InsertDataState)
            {
                form_to_us();
                m_us.Insert();

            }
            else
            {
                form_to_us();
                m_us.Update();
            }
            MessageBox.Show("Thành công!");
            this.Close();
        }

        private void simpbtn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
