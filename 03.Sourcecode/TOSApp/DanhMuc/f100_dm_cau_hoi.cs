using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
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
using System.Windows.Forms;

namespace TOSApp.DanhMuc
{
    public partial class f100_dm_cau_hoi : Form
    {
        public f100_dm_cau_hoi()
        {
            InitializeComponent();
        }

        private void f100_dm_cau_hoi_Load(object sender, EventArgs e)
        {
            load_data_grid();
        }

        private void load_data_grid()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithTableName(v_ds, "V_DM_CAU_HOI");
            m_grc_dm_cau_hoi.DataSource = v_ds.Tables[0];
            if (us_user.dcIDNhom == 1)
            {
                m_pan_xoa.Visible = false;
            }
            else
            {
                m_pan_xoa.Visible = true;
                m_grv_dm_cau_hoi.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
            }
               
        }

        private void simpbtn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow v_dr = m_grv_dm_cau_hoi.GetDataRow(m_grv_dm_cau_hoi.FocusedRowHandle);
                decimal v_id = CIPConvert.ToDecimal(v_dr[DM_CAU_HOI.ID].ToString());
                US_DM_CAU_HOI v_us = new US_DM_CAU_HOI(v_id);
                // xóa bảng câu trả lời
                DataSet v_ds = new DataSet();
                v_ds.Tables.Add(new DataTable());
                US_DUNG_CHUNG v_us_dc = new US_DUNG_CHUNG();
                v_us_dc.FillDatasetWithQuery(v_ds, "select * from dm_cau_tra_loi where id_cau_hoi=" + v_id.ToString());
                for (int i = 0; i < v_ds.Tables[0].Rows.Count; i++)
                {
                    decimal v_datarow = CIPConvert.ToDecimal(v_ds.Tables[0].Rows[i]["ID"].ToString());
                    US_DM_CAU_TRA_LOI v_d_r = new US_DM_CAU_TRA_LOI(v_datarow);
                    v_d_r.Delete();
                }
                // xóa bảng câu hỏi
                v_us.Delete();
                MessageBox.Show("Da xoa thanh cong " + v_dr[DM_CAU_HOI.ID].ToString());
                load_data_grid();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void m_grv_dm_cau_hoi_DoubleClick(object sender, EventArgs e)
        {
           GridView view = (GridView)sender;
           Point pt = view.GridControl.PointToClient(Control.MousePosition);
           DoRowDoubleClick(view, pt);
        }

        private void DoRowDoubleClick(GridView view, Point pt)
        {
            GridHitInfo info = view.CalcHitInfo(pt);
            if (info.InRow || info.InRowCell)
            {
                DataRow v_dr_grv = m_grv_dm_cau_hoi.GetDataRow(m_grv_dm_cau_hoi.FocusedRowHandle);
                if (v_dr_grv == null)
                {
                    try
                    {
                        f100_dm_cau_hoi_de v_f = new f100_dm_cau_hoi_de();
                        v_f.DisPlayForInsert();
                        load_data_grid();
                    }
                    catch (Exception v_e)
                    {
                        CSystemLog_301.ExceptionHandle(v_e);
                    }
                }
                else
                {
                    try
                    {
                        DataRow v_dr = m_grv_dm_cau_hoi.GetDataRow(m_grv_dm_cau_hoi.FocusedRowHandle);
                        US_DM_CAU_HOI v_us_cau_hoi = new US_DM_CAU_HOI(CIPConvert.ToDecimal(v_dr[DM_CAU_HOI.ID].ToString()));
                        US_DM_CAU_TRA_LOI v_us_cau_tra_loi = new US_DM_CAU_TRA_LOI(CIPConvert.ToDecimal(v_dr["ID_CAU_TRA_LOI"].ToString()));
                        f100_dm_cau_hoi_de v_f = new f100_dm_cau_hoi_de();
                        v_f.DisPlayForUpdate(v_us_cau_hoi, v_us_cau_tra_loi);
                        load_data_grid();
                    }
                    catch (Exception v_e)
                    {
                        CSystemLog_301.ExceptionHandle(v_e);
                    }
                }
            }
        }
    }
}
