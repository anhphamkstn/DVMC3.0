using IP.Core.IPCommon;
using IPCOREDS.CDBNames;
using IPCOREUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace TOSApp.DanhMuc
{
    public partial class f102_dm_loai_yeu_cau_de : Form
    {
        public f102_dm_loai_yeu_cau_de()
        {
            InitializeComponent();
        }
        US_DM_LOAI_YEU_CAU m_us = new US_DM_LOAI_YEU_CAU();
        DataEntryFormMode m_e_form_mode = new DataEntryFormMode();
        private void f102_dm_loai_yeu_cau_de_Load(object sender, EventArgs e)
        {
            if (us_user.dcIDNhom == 5)
            { }
            else
            {
                cbo_loai_dich_vu.Enabled =false;
                cbo_nhom_dich_vu.Enabled = false; ;
                cbo_thoi_gian_xu_ly.Enabled = false; ;
                txt_dich_vu.ReadOnly = true;
                txt_diem_khoi_luong.ReadOnly = true;
                m_pan_button.Visible = false;
            }
        }

        private void form_to_us()
        {
            m_us.dcID_CHA = CIPConvert.ToDecimal(cbo_nhom_dich_vu.SelectedValue.ToString());
            m_us.strTEN_YEU_CAU = txt_dich_vu.Text;
            if (txt_diem_khoi_luong.Text != "")
                m_us.dcDIEM_KHOI_LUONG = CIPConvert.ToDecimal(txt_diem_khoi_luong.Text);
            else
                m_us.SetDIEM_KHOI_LUONGNull();
            if(m_cbox_thoi_gian_xu_ly.Checked)
            { 
                m_us.dcID_THOI_GIAN_XU_LY = CIPConvert.ToDecimal(cbo_thoi_gian_xu_ly.SelectedValue.ToString());
            }
            else
            {
                m_us.SetID_THOI_GIAN_XU_LYNull();
            }
            m_us.strTRANG_THAI_HSD = "N";

        }

        private bool kiemtradulieu()
        {

            return true;
        }

        internal void displayinsert()
        {
            m_e_form_mode = DataEntryFormMode.InsertDataState;
            load_data_combobox();
            this.ShowDialog();
        }

        internal void displayupdate(US_DM_LOAI_YEU_CAU v_us1, US_DM_LOAI_YEU_CAU v_us2)
        {
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            m_us = v_us1;
            us_to_form(v_us1, v_us2);
            this.ShowDialog();
        }

        private void us_to_form(US_DM_LOAI_YEU_CAU v_us1, US_DM_LOAI_YEU_CAU v_us2)
        {
            load_data_combobox();
            cbo_loai_dich_vu.SelectedValue = v_us2.dcID_CHA;
            cbo_nhom_dich_vu.SelectedValue = v_us1.dcID_CHA;
            txt_dich_vu.Text = v_us1.strTEN_YEU_CAU;
            if (CIPConvert.ToDecimal(v_us1.dcDIEM_KHOI_LUONG.ToString()) != 0)
                txt_diem_khoi_luong.Text = v_us1.dcDIEM_KHOI_LUONG.ToString();
            if (CIPConvert.ToDecimal(v_us1.dcID_THOI_GIAN_XU_LY.ToString()) == 0)
            {
                m_cbox_thoi_gian_xu_ly.Checked = false;
                cbo_thoi_gian_xu_ly.Enabled = false;
            }
            else
            {
                m_cbox_thoi_gian_xu_ly.Checked = true;
                cbo_thoi_gian_xu_ly.Enabled = true;
                cbo_thoi_gian_xu_ly.SelectedValue = v_us1.dcID_THOI_GIAN_XU_LY;
            }
               
        }

        private void load_data_combobox()
        {
            WinFormControls.load_data_to_combobox_with_query(cbo_loai_dich_vu, "ID", "TEN_YEU_CAU", WinFormControls.eTAT_CA.NO, "SELECT ID,TEN_YEU_CAU FROM DM_LOAI_YEU_CAU WHERE ID_CHA IS NULL");
            WinFormControls.load_data_to_combobox_with_query(cbo_thoi_gian_xu_ly, "ID", "TEN", WinFormControls.eTAT_CA.NO, "SELECT ID,TEN FROM CM_DM_TU_DIEN WHERE ID_LOAI_TU_DIEN = 20");
        }

        private void cbo_loai_dich_vu_SelectedIndexChanged(object sender, EventArgs e)
        {
            WinFormControls.load_data_to_combobox_with_query(cbo_nhom_dich_vu, "ID", "TEN_YEU_CAU", WinFormControls.eTAT_CA.NO, "SELECT ID,TEN_YEU_CAU FROM DM_LOAI_YEU_CAU WHERE ID_CHA =" + cbo_loai_dich_vu.SelectedValue.ToString());
        }

        private void txt_diem_khoi_luong_KeyPress(object sender, KeyPressEventArgs e)
        {
            string decimalString = Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator;
            char decimalChar = Convert.ToChar(decimalString);

            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar)) { }
            else if (e.KeyChar == decimalChar && txt_diem_khoi_luong.Text.IndexOf(decimalString) == -1)
            { }
            else
            {
                e.Handled = true;
            }

        }

        private void simpbtn_luu_Click(object sender, EventArgs e)
        {
            try
            {
                if (kiemtradulieu() == true)
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
            }
            catch (Exception v_e)
            {
                CSystemLog_100.ExceptionHandle(v_e);
            }
        }

        private void simpbtn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void m_cbox_thoi_gian_xu_ly_CheckedChanged(object sender, EventArgs e)
        {
            if (m_cbox_thoi_gian_xu_ly.Checked == false)
            {
                cbo_thoi_gian_xu_ly.Enabled = false;
            }
            else
            {
                cbo_thoi_gian_xu_ly.Enabled = true;
            }
        }
    }
}
