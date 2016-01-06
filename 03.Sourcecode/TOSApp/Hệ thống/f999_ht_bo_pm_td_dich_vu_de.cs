using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using IP.Core.IPCommon;
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

namespace TOSApp.Hệ_thống
{
    public partial class f999_ht_bo_pm_td_dich_vu_de : Form
    {
        public f999_ht_bo_pm_td_dich_vu_de()
        {
            InitializeComponent();
        }
        public static List<decimal> m_lst_id_nguoi_xu_ly_cap_1 = new List<decimal>();
        public static List<decimal> m_lst_id_nguoi_xu_ly_cap_2 = new List<decimal>();
        public static List<decimal> m_lst_id_nguoi_xu_ly_cap_3 = new List<decimal>();
        public static DataEntryFormMode m_e_form_mode = new DataEntryFormMode();
        public static US_DM_LOAI_YEU_CAU m_us_dich_vu = new US_DM_LOAI_YEU_CAU();
        public static US_HT_BO_DICH_VU m_us_bo_dich_vu = new US_HT_BO_DICH_VU();

        private void m_cmd_luu_Click(object sender, EventArgs e)
        {
            try
            {
                if (kiemtradulieu())
                {
                    if(m_e_form_mode == DataEntryFormMode.InsertDataState)
                    {
                        //insert dich vu
                        insert_dich_vu();
                        insert_nguoi_xu_ly_cap(grv_danh_sach_bo,2);
                        insert_nguoi_xu_ly_cap(grv_danh_sach_pm,3);
                        insert_nguoi_xu_ly_cap(grv_danh_sach_td,5);
                       
                    }
                    else
                    {
                        //update dich vu
                        update_dich_vu();
                        update_nguoi_xu_ly_cap(grv_danh_sach_bo,2);
                        update_nguoi_xu_ly_cap(grv_danh_sach_pm,3);
                        update_nguoi_xu_ly_cap(grv_danh_sach_td,5);
                    }
                    MessageBox.Show("thành công");
                    this.Close();
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_100.ExceptionHandle(v_e);
            }
        }

        private void update_dich_vu()
        {
            US_DM_LOAI_YEU_CAU v_us = new US_DM_LOAI_YEU_CAU(CIPConvert.ToDecimal( m_us_dich_vu.dcID.ToString()));
            v_us.strTEN_YEU_CAU = txt_dich_vu.Text;
            if (m_txt_diem_khoi_luong.Text != "")
                v_us.dcDIEM_KHOI_LUONG = CIPConvert.ToDecimal(m_txt_diem_khoi_luong.Text);
            else
                v_us.SetDIEM_KHOI_LUONGNull();
            if (m_cbox_thoi_gian_xu_ly.Checked && m_cbox_thoi_gian_xly.SelectedValue != null)
            {
                v_us.dcID_THOI_GIAN_XU_LY = CIPConvert.ToDecimal(m_cbox_thoi_gian_xly.SelectedValue.ToString());
            }
            else
            {
                v_us.SetID_THOI_GIAN_XU_LYNull();
            }
            v_us.Update();
        }

        private void update_nguoi_xu_ly_cap(GridView v_grv, decimal v_cap_sd)
        {
            delete_ht_bo_dich_vu(v_grv, v_cap_sd);
            for (int i = 0; i < v_grv.RowCount; i++)
            {
                US_HT_BO_DICH_VU v_us_bo_dv = new US_HT_BO_DICH_VU();
                v_us_bo_dv.dcID_DICH_VU = m_us_dich_vu.dcID;
                v_us_bo_dv.dcID_NGUOI_SU_DUNG = CIPConvert.ToDecimal(v_grv.GetDataRow(i)["ID_NGUOI_SU_DUNG"].ToString());
                v_us_bo_dv.dcCAP_SU_DUNG = v_cap_sd;
                v_us_bo_dv.strTRANG_THAI_HSD = "N";
                v_us_bo_dv.Insert();
            }

        }

        private void insert_nguoi_xu_ly_cap(GridView v_grv,decimal v_cap_sd)
        {

            for (int i = 0; i < v_grv.RowCount; i++)
            {
                US_HT_BO_DICH_VU v_us_bo_dv = new US_HT_BO_DICH_VU();
                v_us_bo_dv.dcID_DICH_VU = m_us_dich_vu.dcID;
                v_us_bo_dv.dcID_NGUOI_SU_DUNG = CIPConvert.ToDecimal(v_grv.GetDataRow(i)["ID_NGUOI_SU_DUNG"].ToString());
                v_us_bo_dv.dcCAP_SU_DUNG = v_cap_sd;
                v_us_bo_dv.strTRANG_THAI_HSD = "N";
                v_us_bo_dv.Insert();
            }
        }

        private void delete_ht_bo_dich_vu(GridView v_grv,decimal v_cap_sd)
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            string v_query = "SELECT hbdv.ID FROM HT_BO_DICH_VU hbdv WHERE hbdv.ID_DICH_VU =" + m_us_dich_vu.dcID.ToString() + "AND hbdv.CAP_SU_DUNG=" + v_cap_sd.ToString();
            v_us.FillDatasetWithQuery(v_ds, v_query);
            for (int i = 0; i < v_ds.Tables[0].Rows.Count; i++)
            {
                US_HT_BO_DICH_VU v_us_bo_dv = new US_HT_BO_DICH_VU(CIPConvert.ToDecimal(v_ds.Tables[0].Rows[i]["ID"].ToString()));
                v_us_bo_dv.Delete();
            }
        }

        private void insert_dich_vu()
        {
            US_DM_LOAI_YEU_CAU v_us = new US_DM_LOAI_YEU_CAU();
            v_us.dcID_CHA = CIPConvert.ToDecimal(cbo_nhom_dich_vu.SelectedValue.ToString());
            v_us.strTEN_YEU_CAU = txt_dich_vu.Text;
            if (m_txt_diem_khoi_luong.Text != "")
                v_us.dcDIEM_KHOI_LUONG = CIPConvert.ToDecimal(m_txt_diem_khoi_luong.Text);
            else
                v_us.SetDIEM_KHOI_LUONGNull();
            if (m_cbox_thoi_gian_xu_ly.Checked && m_cbox_thoi_gian_xly.SelectedValue != null)
            {
                v_us.dcID_THOI_GIAN_XU_LY = CIPConvert.ToDecimal(m_cbox_thoi_gian_xly.SelectedValue.ToString());
            }
            else
            {
                v_us.SetID_THOI_GIAN_XU_LYNull();
            }
            v_us.strTRANG_THAI_HSD = "N";
            v_us.Insert();
            m_us_dich_vu = v_us;
        }

        private bool kiemtradulieu()
        {
            
            if (txt_dich_vu.Text == "")
            {
                MessageBox.Show("Nhập dịch vụ");
                return false;
            }
            return true;
        }

        private void m_cmd_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                US_DM_LOAI_YEU_CAU v_us = new US_DM_LOAI_YEU_CAU(CIPConvert.ToDecimal(m_us_dich_vu.dcID.ToString()));
                v_us.strTRANG_THAI_HSD = "Y";
                v_us.Update();
                delete_ht_bo_dich_vu(grv_danh_sach_bo, 2);
                delete_ht_bo_dich_vu(grv_danh_sach_pm, 3);
                delete_ht_bo_dich_vu(grv_danh_sach_td, 5);
                MessageBox.Show("thành công");
                this.Close();
            }
            catch (Exception v_e)
            {
                CSystemLog_100.ExceptionHandle(v_e);
            }
        }

        private void load_data_to_grv_ds_nv(decimal v_id_nhom, List<decimal> v_list_id_nguoi_xu_ly)
        {
            
            if (v_list_id_nguoi_xu_ly.Count != 0)
            {
                US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
                DataSet v_ds = new DataSet();
                v_ds.Tables.Add(new DataTable());
                string v_query = "SELECT distinct hbdv.ID_NGUOI_SU_DUNG, hnsd.TEN_TRUY_CAP  FROM HT_BO_DICH_VU hbdv,HT_NGUOI_SU_DUNG hnsd WHERE hnsd.ID = hbdv.ID_NGUOI_SU_DUNG AND hbdv.ID_NGUOI_SU_DUNG IN (";
                for (int i = 0; i < v_list_id_nguoi_xu_ly.Count; i++)
                {
                    v_query += v_list_id_nguoi_xu_ly[i].ToString() + ",";
                    if (i == v_list_id_nguoi_xu_ly.Count - 1)
                        v_query += v_list_id_nguoi_xu_ly[i].ToString();
                }
                v_query += ")";
                v_us.FillDatasetWithQuery(v_ds, v_query);
                if (v_id_nhom == 2)
                {
                    grc_danh_sach_bo.DataSource = v_ds.Tables[0];
                }
                else if (v_id_nhom == 3)
                {
                    grc_danh_sach_pm.DataSource = v_ds.Tables[0];
                }
                else if (v_id_nhom == 5)
                {
                    grc_danh_sach_td.DataSource = v_ds.Tables[0];
                }
            }
        }

        private void load_data_to_form()
        {
            WinFormControls.load_data_to_combobox_with_query(cbo_loai_dich_vu, "ID", "TEN_YEU_CAU", WinFormControls.eTAT_CA.NO, "SELECT ID,TEN_YEU_CAU FROM DM_LOAI_YEU_CAU WHERE ID_CHA IS NULL");
            WinFormControls.load_data_to_combobox_with_query(m_cbox_thoi_gian_xly, "ID", "TEN", WinFormControls.eTAT_CA.NO, "SELECT ID,TEN FROM CM_DM_TU_DIEN WHERE ID_LOAI_TU_DIEN = 20 ORDER BY GHI_CHU");
        }

        private void f999_ht_bo_pm_td_dich_vu_de_Load(object sender, EventArgs e)
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            if (us_user.dcIDNhom == 3 && v_us.get_id_pm_dich_vu(11, us_user.dcID) == 0 || us_user.dcIDNhom == 5 && v_us.get_id_td_dich_vu(11, us_user.dcID) == 0)
            {
                if (m_e_form_mode == DataEntryFormMode.UpdateDataState) 
                {
                    txt_dich_vu.ReadOnly = true;
                    cbo_loai_dich_vu.Enabled = false;
                    cbo_nhom_dich_vu.Enabled = false;
                    m_cbox_thoi_gian_xly.Enabled = false;
                    m_cbox_thoi_gian_xu_ly.Enabled = false;
                    m_txt_diem_khoi_luong.Enabled = false;
                }
                m_pan_xoa.Visible = false;
                m_pan_them_td.Visible = false;
                grc_danh_sach_td.Enabled = false;
                if (us_user.dcIDNhom == 3)
                {
                    m_pan_them_pm.Visible = false;
                    grc_danh_sach_pm.Enabled = false;
                }
            }
            
        }

        private void cbo_loai_dich_vu_SelectedIndexChanged(object sender, EventArgs e)
        {

            WinFormControls.load_data_to_combobox_with_query(cbo_nhom_dich_vu, "ID", "TEN_YEU_CAU", WinFormControls.eTAT_CA.NO, "SELECT ID,TEN_YEU_CAU FROM DM_LOAI_YEU_CAU WHERE ID_CHA =" + cbo_loai_dich_vu.SelectedValue.ToString());
        }

        internal void displayInsert()
        {
            m_e_form_mode = DataEntryFormMode.InsertDataState;
            load_data_to_form();
            m_pan_xoa.Visible = false;
            this.ShowDialog();
        }

        internal void displayUpdate(US_DM_LOAI_YEU_CAU v_us_dich_vu)
        {
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            load_data_to_form();
            m_us_dich_vu = v_us_dich_vu;
            us_to_form(v_us_dich_vu);
            this.ShowDialog();
        }

        private void us_to_form(US_DM_LOAI_YEU_CAU v_us_dich_vu)
        {
            US_DM_LOAI_YEU_CAU v_us = new US_DM_LOAI_YEU_CAU(v_us_dich_vu.dcID_CHA);
            cbo_loai_dich_vu.SelectedValue = v_us.dcID_CHA;
            cbo_nhom_dich_vu.SelectedValue = v_us_dich_vu.dcID_CHA;
            txt_dich_vu.Text = v_us_dich_vu.strTEN_YEU_CAU;
            m_cbox_thoi_gian_xly.SelectedValue = v_us_dich_vu.dcID_THOI_GIAN_XU_LY;
            if (v_us_dich_vu.dcDIEM_KHOI_LUONG.ToString() != "0")
                m_txt_diem_khoi_luong.Text = v_us_dich_vu.dcDIEM_KHOI_LUONG.ToString();
            load_data_to_grv_ds_nv_update(2, v_us_dich_vu.dcID);
            load_data_to_grv_ds_nv_update(3, v_us_dich_vu.dcID);
            load_data_to_grv_ds_nv_update(5, v_us_dich_vu.dcID);


        }

        private void load_data_to_grv_ds_nv_update(decimal v_id_nhom, decimal v_id_dich_vu)
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            string v_query = "SELECT hbdv.ID_NGUOI_SU_DUNG, hnsd.TEN_TRUY_CAP  FROM HT_BO_DICH_VU hbdv,HT_NGUOI_SU_DUNG hnsd WHERE hbdv.ID_DICH_VU =" + v_id_dich_vu.ToString() + "AND hbdv.CAP_SU_DUNG=" + v_id_nhom.ToString() + "AND hnsd.ID = hbdv.ID_NGUOI_SU_DUNG"; ;
            v_us.FillDatasetWithQuery(v_ds, v_query);
            if (v_id_nhom == 2)
            {
                grc_danh_sach_bo.DataSource = v_ds.Tables[0];
            }
            else if (v_id_nhom == 3)
            {
                grc_danh_sach_pm.DataSource = v_ds.Tables[0];
            }
            else if (v_id_nhom == 5)
            {
                grc_danh_sach_td.DataSource = v_ds.Tables[0];
            }
        }
        
        private void m_cbox_thoi_gian_xu_ly_CheckedChanged(object sender, EventArgs e)
        {
            if (m_cbox_thoi_gian_xu_ly.Checked == false)
            {
                m_cbox_thoi_gian_xly.Enabled = false;
            }
            else
            {
                m_cbox_thoi_gian_xly.Enabled = true;
            }
        }

        private void m_btn_edit_xoa_nguoi_xu_ly_cap_2_Click(object sender, EventArgs e)
        {
            grv_danh_sach_pm.DeleteRow(grv_danh_sach_pm.FocusedRowHandle);
        }

        private void m_btn_edit_xoa_bo_nguoi_xu_ly_cap_3_Click(object sender, EventArgs e)
        {
            grv_danh_sach_td.DeleteRow(grv_danh_sach_td.FocusedRowHandle);
        }

        private void m_btn_edit_xoa_nguoi_xu_ly_cap_1_Click(object sender, EventArgs e)
        {
            grv_danh_sach_bo.DeleteRow(grv_danh_sach_bo.FocusedRowHandle);
        }

        private void m_cmd_them_bo_Click(object sender, EventArgs e)
        {
            m_lst_id_nguoi_xu_ly_cap_1.Clear();
            for (int i = 0; i < grv_danh_sach_bo.RowCount; i++)
            {
                m_lst_id_nguoi_xu_ly_cap_1.Add(CIPConvert.ToDecimal(grv_danh_sach_bo.GetDataRow(i)["ID_NGUOI_SU_DUNG"].ToString()));
            }
            f999_ht_bo_pm_td_dich_vu_them_nhan_vien v_f = new f999_ht_bo_pm_td_dich_vu_them_nhan_vien();
            v_f.load_to_form(2, m_lst_id_nguoi_xu_ly_cap_1);
            v_f.ShowDialog();
            load_data_to_grv_ds_nv(2, m_lst_id_nguoi_xu_ly_cap_1);
        }

        private void m_cmd_them_pm_Click(object sender, EventArgs e)
        {
            m_lst_id_nguoi_xu_ly_cap_2.Clear();
            for (int i = 0; i < grv_danh_sach_pm.RowCount; i++)
            {
                m_lst_id_nguoi_xu_ly_cap_2.Add(CIPConvert.ToDecimal(grv_danh_sach_pm.GetDataRow(i)["ID_NGUOI_SU_DUNG"].ToString()));
            }
            f999_ht_bo_pm_td_dich_vu_them_nhan_vien v_f = new f999_ht_bo_pm_td_dich_vu_them_nhan_vien();
            v_f.load_to_form(3, m_lst_id_nguoi_xu_ly_cap_2);
            v_f.ShowDialog();
            load_data_to_grv_ds_nv(3, m_lst_id_nguoi_xu_ly_cap_2);
        }

        private void m_cmd_them_td_Click(object sender, EventArgs e)
        {
            m_lst_id_nguoi_xu_ly_cap_3.Clear();
            for (int i = 0; i < grv_danh_sach_td.RowCount; i++)
            {
                m_lst_id_nguoi_xu_ly_cap_3.Add(CIPConvert.ToDecimal(grv_danh_sach_td.GetDataRow(i)["ID_NGUOI_SU_DUNG"].ToString()));
            }
            f999_ht_bo_pm_td_dich_vu_them_nhan_vien v_f = new f999_ht_bo_pm_td_dich_vu_them_nhan_vien();
            v_f.load_to_form(5, m_lst_id_nguoi_xu_ly_cap_3);
            v_f.ShowDialog();
            load_data_to_grv_ds_nv(5, m_lst_id_nguoi_xu_ly_cap_3);
        }

        private void m_txt_diem_khoi_luong_KeyPress(object sender, KeyPressEventArgs e)
        {
            string decimalString = Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator;
            char decimalChar = Convert.ToChar(decimalString);
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar)) { }
            else if (e.KeyChar == decimalChar && m_txt_diem_khoi_luong.Text.IndexOf(decimalString) == -1)
            { }
            else
            {
                e.Handled = true;
            }
        }

    }
}
