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
    public partial class f100_dm_cau_hoi_de : Form
    {
        public f100_dm_cau_hoi_de()
        {
            InitializeComponent();
        }

        DataEntryFormMode m_e_form_mode = new DataEntryFormMode();
        US_DM_CAU_HOI m_us_cau_hoi = new US_DM_CAU_HOI();
        US_CM_DM_TU_DIEN m_us_cmtd = new US_CM_DM_TU_DIEN();
        US_DM_CAU_TRA_LOI m_us_cau_tra_loi = new US_DM_CAU_TRA_LOI();
        

        private void f100_dm_cau_hoi_de_Load(object sender, EventArgs e)
        {
            if(us_user.dcIDNhom == 1)
            {
                txt_cau_tra_loi.ReadOnly = true;
            }
            else
            {
                txt_cau_hoi.ReadOnly = true;
                m_cbo_nhom_cau_hoi.Enabled = false;
            }
        }

        private void load_data_cbo()
        {
            WinFormControls.load_data_to_combobox_with_query(m_cbo_nhom_cau_hoi, "ID", "TEN", WinFormControls.eTAT_CA.NO, "SELECT   ID, TEN FROM CM_DM_TU_DIEN WHERE ID_LOAI_TU_DIEN = 5");
            //WinFormControls.load_data_to_combobox_with_query(cbo_to_chuc, "ID", "TEN", WinFormControls.eTAT_CA.NO, "SELECT  ID, TEN FROM CM_DM_TU_DIEN  WHERE ID_LOAI_TU_DIEN= 11 ");
        }

        public void DisPlayForInsert()
        {

            m_e_form_mode = DataEntryFormMode.InsertDataState;
            load_data_cbo();
            this.ShowDialog();
        }

        internal void DisPlayForUpdate(IPCOREUS.US_DM_CAU_HOI v_us_cau_hoi, IPCOREUS.US_DM_CAU_TRA_LOI v_us_cau_tra_loi)
        {
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            m_cbo_nhom_cau_hoi.Enabled = false;
            m_us_cau_hoi = v_us_cau_hoi;
            m_us_cau_tra_loi = v_us_cau_tra_loi;
            us_to_form(v_us_cau_hoi, v_us_cau_tra_loi);
            if (us_user.dcIDNhom == 1)
            {
                txt_cau_hoi.ReadOnly = true;
                m_pan_luu.Visible = false;
            }
            this.ShowDialog();
        }

        private void us_to_form(IPCOREUS.US_DM_CAU_HOI v_us_cau_hoi, IPCOREUS.US_DM_CAU_TRA_LOI v_us_cau_tra_loi)
        {
            load_data_cbo();
            m_cbo_nhom_cau_hoi.SelectedValue = CIPConvert.ToDecimal(v_us_cau_hoi.dcID_NHOM_CAU_HOI.ToString());
            txt_cau_hoi.Text = v_us_cau_hoi.strNOI_DUNG_CAU_HOI;
            txt_cau_tra_loi.Text = v_us_cau_tra_loi.strCAU_TRA_LOI;
        }
        private bool kiemtradulieu()
        {
            if (txt_cau_hoi.Text == "")
            {
                MessageBox.Show("Nhập câu hỏi!");
                return false;
            }
            return true;
        }

        private void form_to_us_cau_hoi()
        {
            //bảng câu hỏi
            m_us_cau_hoi.strNOI_DUNG_CAU_HOI = txt_cau_hoi.Text;
            m_us_cau_hoi.dcID_NHOM_CAU_HOI = CIPConvert.ToDecimal(m_cbo_nhom_cau_hoi.SelectedValue.ToString());
            if (m_e_form_mode == DataEntryFormMode.InsertDataState)
            { 
                m_us_cau_hoi.datNGAY_TAO = System.DateTime.Now;
                m_us_cau_hoi.dcNGUOI_TAO = us_user.dcID;
            }
            m_us_cau_hoi.dcNGUOI_CAP_NHAT_CUOI = us_user.dcID;
            m_us_cau_hoi.datNGAY_CAP_NHAP_CUOI = System.DateTime.Now;
        }

        private void form_to_us_cau_tra_loi()
        {
            //bảng câu trả lời
            m_us_cau_tra_loi.dcID_CAU_HOI = m_us_cau_hoi.dcID;
            m_us_cau_tra_loi.strCAU_TRA_LOI = txt_cau_tra_loi.Text;
            m_us_cau_tra_loi.datNGAY_TAO = System.DateTime.Now;
            m_us_cau_tra_loi.dcNGUOI_TAO = us_user.dcID;
            if (txt_cau_tra_loi.Text !=null)
                m_us_cau_tra_loi.dcID_TRANG_THAI = 22;
            else
                m_us_cau_tra_loi.dcID_TRANG_THAI = 21;

        }

        private void simpbtn_luu_Click(object sender, EventArgs e)
        {
            try
            {
                if (kiemtradulieu() == true)
                {

                    if (m_e_form_mode == DataEntryFormMode.InsertDataState)
                    {
                        form_to_us_cau_hoi();
                        m_us_cau_hoi.Insert();
                        form_to_us_cau_tra_loi();
                        m_us_cau_tra_loi.Insert();
                    }
                    else
                    {
                        form_to_us_cau_hoi();
                        m_us_cau_hoi.Update();
                        form_to_us_cau_tra_loi();
                        m_us_cau_tra_loi.Update();
                    }
                    MessageBox.Show("Thành công!");
                    this.Close();
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }

        }

        private void simpbtn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
