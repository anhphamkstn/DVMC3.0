using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IPCOREUS;
using IP.Core.IPCommon;
using DevExpress.XtraScheduler;


namespace TOSApp.ChucNang
{
    public partial class f114_ds_BO : Form
    {
        public f114_ds_BO()
        {
            InitializeComponent();
        }

        US_V_GD_DAT_HANG_GD_LOG_DAT_HANG m_us = new US_V_GD_DAT_HANG_GD_LOG_DAT_HANG();
        List<decimal> m_lst_ds_BO = new List<decimal>();
        List<decimal> m_lst_id_log_dat_hang = new List<decimal>();

        decimal m_id_gd_dat_hang;

        List<decimal> m_lst_BO_da_duoc_dieu_phoi;

        private void load_data_2_grid()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            m_lst_BO_da_duoc_dieu_phoi = new List<decimal>();
            lay_ds_BO_da_dc_dieu_phoi(m_lst_BO_da_duoc_dieu_phoi);
            string m_str_query = " select distinct ID_BO,BO from V_DICH_VU_BO_PM_TD where ID_DICH_VU = " + m_us.dcID_NHOM_DV_YEU_CAU.ToString() + " And ID_BO not in ( ";
            if (m_lst_BO_da_duoc_dieu_phoi.Count == 0)
            {
                m_str_query += "0 )";
            }
            for (int i = 0; i < m_lst_BO_da_duoc_dieu_phoi.Count; i++)
            {
                if (i < m_lst_BO_da_duoc_dieu_phoi.Count - 1)
                {
                    m_str_query += m_lst_BO_da_duoc_dieu_phoi[i].ToString() + ",";
                }
                else m_str_query += m_lst_BO_da_duoc_dieu_phoi[i].ToString() + ")";

            }

            v_us.FillDatasetWithQuery(v_ds, m_str_query);


            m_grc_ds_BO.DataSource = v_ds.Tables[0];
            DataSet v_ds_appointment = new DataSet();
            v_ds_appointment.Tables.Add(new DataTable());

            DataSet v_ds_resource = new DataSet();
            v_ds_resource.Tables.Add(new DataTable());
            v_us.FillAppointmentByDichVu(v_ds_appointment, m_us.dcID_NHOM_DV_YEU_CAU);
            v_us.FillResourcesByDichVu(v_ds_resource, m_us.dcID_NHOM_DV_YEU_CAU);
            SetUpMapping();
            schedulerStorage1.Appointments.DataSource = v_ds_appointment.Tables[0];
            schedulerStorage1.Resources.DataSource = v_ds_resource.Tables[0];
            m_sch.ActiveViewType = SchedulerViewType.Day;
            m_sch.GroupType = SchedulerGroupType.Resource;

        }

        private void SetUpMapping()
        {
            schedulerStorage1.Appointments.Mappings.Description = "NOI_DUNG_DAT_HANG";
            schedulerStorage1.Appointments.Mappings.End = "EndDate";
            schedulerStorage1.Appointments.Mappings.Label = "Label";
            schedulerStorage1.Appointments.Mappings.Location = "TEN_CHI_NHANH";
            schedulerStorage1.Appointments.Mappings.RecurrenceInfo = "RecurrenceInfo";
            schedulerStorage1.Appointments.Mappings.ReminderInfo = "ReminderInfo";
            schedulerStorage1.Appointments.Mappings.ResourceId = "ID_NGUOI_TAO_THAO_TAC";
            schedulerStorage1.Appointments.Mappings.Start = "StartDate";
            schedulerStorage1.Appointments.Mappings.Status = "Status";
            schedulerStorage1.Appointments.Mappings.Subject = "Subject";
            schedulerStorage1.Appointments.Mappings.Type = "Type";
            schedulerStorage1.Resources.Mappings.Caption = "TEN_TRUY_CAP";
            schedulerStorage1.Resources.Mappings.Id = "ID_NGUOI_SU_DUNG";
            schedulerStorage1.Resources.Mappings.Image = "Image";
        }

        private void lay_ds_BO_da_dc_dieu_phoi(List<decimal> m_lst_BO_da_duoc_dieu_phoi)
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithQuery(v_ds, " select * from V_GD_DAT_HANG_GD_LOG_DAT_HANG where ID_LOAI_THAO_TAC in (296,295)  and  THAO_TAC_HET_HAN_YN = 'N' and ID_DON_HANG=" + m_us.dcID_DON_HANG);
            for (int i = 0; i < v_ds.Tables[0].Rows.Count; i++)
            {
                if (CIPConvert.ToDecimal(v_ds.Tables[0].Rows[i]["ID_LOAI_THAO_TAC"].ToString()) == 295)
                {
                    m_lst_BO_da_duoc_dieu_phoi.Add(CIPConvert.ToDecimal(v_ds.Tables[0].Rows[i]["ID_NGUOI_NHAN_THAO_TAC"].ToString()));
                }
                else
                {
                    m_lst_BO_da_duoc_dieu_phoi.Add(CIPConvert.ToDecimal(v_ds.Tables[0].Rows[i]["ID_NGUOI_TAO_THAO_TAC"].ToString()));
                }
            }
        }

        private void m_cmd_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        internal void display_dieu_huong(US_V_GD_DAT_HANG_GD_LOG_DAT_HANG v_us)
        {
            load_data_2_ma_don_hang(v_us);
            load_data_2_grid();
            this.ShowDialog();
        }
        US_DUNG_CHUNG v_us_dc = new US_DUNG_CHUNG();

        private void load_data_2_ma_don_hang(US_V_GD_DAT_HANG_GD_LOG_DAT_HANG v_us)
        {
            m_us = new US_V_GD_DAT_HANG_GD_LOG_DAT_HANG(v_us.dcID);
            m_txt_ma_don_hang.Text = v_us.strMA_DON_HANG;
            m_id_gd_dat_hang = v_us.dcID_DON_HANG;
            // m_us = new US_V_GD_DAT_HANG_GD_LOG_DAT_HANG(v_us.dcID);

        }


        private void m_cmd_OK_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < m_grv_ds_BO.SelectedRowsCount; i++)
                {
                    m_lst_ds_BO.Add(CIPConvert.ToDecimal(m_grv_ds_BO.GetDataRow(m_grv_ds_BO.GetSelectedRows()[i])["ID_BO"].ToString()));
                }
                update_don_hang(m_us);
                for (int i = 0; i < m_lst_ds_BO.Count; i++)
                {
                    ghi_log_dieu_phoi_lai(m_lst_ds_BO[i], m_us);
                }
                MessageBox.Show("thành công !");
                this.Close();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }

        }

        private void ghi_log_dieu_phoi_lai(decimal p, US_V_GD_DAT_HANG_GD_LOG_DAT_HANG m_us)
        {
            US_DUNG_CHUNG v_us_dc = new US_DUNG_CHUNG();
            US_GD_LOG_DAT_HANG v_US = new US_GD_LOG_DAT_HANG();
            v_US.dcID_LOAI_THAO_TAC = 311;//fo đã điều phối lại
            v_US.dcID_GD_DAT_HANG = m_us.dcID_DON_HANG;
            v_US.dcID_NGUOI_TAO_THAO_TAC = us_user.dcID;
            v_US.dcID_NGUOI_NHAN_THAO_TAC = p;
            v_US.datNGAY_LAP_THAO_TAC = System.DateTime.Now;
            v_US.strTHAO_TAC_HET_HAN_YN = "N";
            v_US.strGHI_CHU = us_user.strTEN_TRUY_CAP + " đơn hàng đã được điều phối lại cho " + v_us_dc.get_ten_nguoi_su_dung(p);
            v_US.Insert();
        }
        private void update_don_hang(US_V_GD_DAT_HANG_GD_LOG_DAT_HANG m_us)
        {
            US_GD_LOG_DAT_HANG v_US = new US_GD_LOG_DAT_HANG(m_us.dcID);
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            if (us_user.dcIDNhom == 1)
            {
                v_us.FillDatasetWithQuery(v_ds, "SELECT *FROM GD_LOG_DAT_HANG WHERE ID_GD_DAT_HANG =" + v_US.dcID_GD_DAT_HANG.ToString() + "AND ID_LOAI_THAO_TAC in(310,313) AND THAO_TAC_HET_HAN_YN = 'N' AND ID_NGUOI_NHAN_THAO_TAC=" + us_user.dcID.ToString());
            }
            else if (us_user.dcIDNhom == 3)
            {
                v_us.FillDatasetWithQuery(v_ds, "SELECT *FROM GD_LOG_DAT_HANG WHERE ID_GD_DAT_HANG =" + v_US.dcID_GD_DAT_HANG.ToString() + "And ID_LOAI_THAO_TAC in (303) And THAO_TAC_HET_HAN_YN = 'N' AND ID_NGUOI_NHAN_THAO_TAC = " + us_user.dcID.ToString());
            }
            for (int i = 0; i < v_ds.Tables[0].Rows.Count; i++)
            {
                v_US = new US_GD_LOG_DAT_HANG(CIPConvert.ToDecimal(v_ds.Tables[0].Rows[i][0].ToString()));
                v_US.strTHAO_TAC_HET_HAN_YN = "Y";
                v_US.Update();
            }

        }
        private void m_grv_ds_BO_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }
    }
}
