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
    public partial class f102_dm_loai_yeu_cau : Form
    {
        public f102_dm_loai_yeu_cau()
        {
            InitializeComponent();
        }

        private void f102_dm_loai_yeu_cau_Load(object sender, EventArgs e)
        {

            load_data_griv();
        }

        private void load_data_griv()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithTableName(v_ds, "V_DM_LOAI_YEU_CAU");
            m_grc_dm_loai_yeu_cau.DataSource = v_ds.Tables[0];
            if(us_user.dcIDNhom == 5)
            {

            }
            else
            {
                m_pan_button.Visible = false;
                m_grv_dm_loai_yeu_cau.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
            }
        }

        private void simpbtn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow v_dr = m_grv_dm_loai_yeu_cau.GetDataRow(m_grv_dm_loai_yeu_cau.FocusedRowHandle);
                decimal v_id = CIPConvert.ToDecimal(v_dr[DM_LOAI_YEU_CAU.ID].ToString());
                US_DM_LOAI_YEU_CAU v_us = new US_DM_LOAI_YEU_CAU(v_id);
                v_us.strTRANG_THAI_HSD = "Y";
                v_us.Update();
                MessageBox.Show("Xóa thành công " + v_dr[DM_LOAI_YEU_CAU.ID].ToString());
                load_data_griv();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_grv_dm_loai_yeu_cau_DoubleClick(object sender, EventArgs e)
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
                DataRow v_dr_grv = m_grv_dm_loai_yeu_cau.GetDataRow(m_grv_dm_loai_yeu_cau.FocusedRowHandle);
                if (v_dr_grv == null)
                {
                    try
                    {
                        f102_dm_loai_yeu_cau_de v_f = new f102_dm_loai_yeu_cau_de();
                        v_f.displayinsert();
                        load_data_griv();
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
                        DataRow v_dr = m_grv_dm_loai_yeu_cau.GetDataRow(m_grv_dm_loai_yeu_cau.FocusedRowHandle);
                        US_DM_LOAI_YEU_CAU v_us1 = new US_DM_LOAI_YEU_CAU(CIPConvert.ToDecimal(v_dr[DM_LOAI_YEU_CAU.ID].ToString()));
                        US_DM_LOAI_YEU_CAU v_us2 = new US_DM_LOAI_YEU_CAU(CIPConvert.ToDecimal(v_dr[DM_LOAI_YEU_CAU.ID_CHA].ToString()));
                        f102_dm_loai_yeu_cau_de v_f = new f102_dm_loai_yeu_cau_de();
                        v_f.displayupdate(v_us1, v_us2);
                        load_data_griv();
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
