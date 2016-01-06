using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IP.Core.IPCommon;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Design;
using DevExpress.XtraScheduler;
namespace TOSApp.ChucNang
{
    public partial class f102_chon_danh_sach_nguoi_xu_ly_new : Form
    {
        public f102_chon_danh_sach_nguoi_xu_ly_new()
        {
            InitializeComponent();
            System.Globalization.CultureInfo culture =
    new System.Globalization.CultureInfo(System.Globalization.CultureInfo.CurrentCulture.LCID);
            culture.DateTimeFormat.LongTimePattern = "HH:mm:ss";
            System.Threading.Thread.CurrentThread.CurrentCulture = culture;
          
        }

        private void m_cmd_exit_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        internal void Display(ref List<decimal> v_lst_id_nguoi_xu_ly)
        {
            for (int j = 0; j < v_lst_id_nguoi_xu_ly.Count;j++ )
            {
                for (int i = 0; i < v_lst_id_nguoi_xu_ly.Count; i++)
                    if (m_grv_ht_nguoi_su_dung.GetDataRow(i)["ID"].Equals(v_lst_id_nguoi_xu_ly[j].ToString()))
                        m_grv_ht_nguoi_su_dung.SelectRow(i);

            }
                this.ShowDialog();

            if (DialogResult== System.Windows.Forms.DialogResult.OK)
            {

                for (int i = 0; i < m_grv_ht_nguoi_su_dung.SelectedRowsCount; i++)
                {
                    v_lst_id_nguoi_xu_ly.Add(CIPConvert.ToDecimal(m_grv_ht_nguoi_su_dung.GetDataRow(m_grv_ht_nguoi_su_dung.GetSelectedRows()[i])["ID"].ToString()));
                }
            }
        }

        private void m_cmd_oke_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        internal void Display(ref List<decimal> m_lst_id_nguoi_xu_ly, decimal m_id_dich_vu)
        {
            load_data_2_grid(m_id_dich_vu);
            for (int j = 0; j < m_lst_id_nguoi_xu_ly.Count; j++)
            {
                for (int i = 0; i < m_grv_ht_nguoi_su_dung.RowCount; i++)
                    if (m_grv_ht_nguoi_su_dung.GetDataRow(i)["ID_BO"].Equals(m_lst_id_nguoi_xu_ly[j]))
                        m_grv_ht_nguoi_su_dung.SelectRow(i);

            }
            this.ShowDialog();
            m_lst_id_nguoi_xu_ly.Clear();
            if (DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                for (int i = 0; i < m_grv_ht_nguoi_su_dung.SelectedRowsCount; i++)
                {
                    m_lst_id_nguoi_xu_ly.Add(CIPConvert.ToDecimal(m_grv_ht_nguoi_su_dung.GetDataRow(m_grv_ht_nguoi_su_dung.GetSelectedRows()[i])["ID_BO"].ToString()));
                }
            }
         
        }

        private void load_data_2_grid(decimal m_id_dich_vu)
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());

            //  v_us.FillDatasetWithTableName(v_ds, "V_HT_NGUOI_SU_DUNG");
            v_us.FillDatasetWithQuery(v_ds, " select distinct ID_BO, BO from V_DICH_VU_BO_PM_TD where ID_DICH_VU=" + m_id_dich_vu);
            m_grc_ht_nguoi_su_dung.DataSource = v_ds.Tables[0];

            Color.AliceBlue.ToArgb();
            DataSet v_ds_appointment = new DataSet();
            v_ds_appointment.Tables.Add(new DataTable());

            DataSet v_ds_resource = new DataSet();
            v_ds_resource.Tables.Add(new DataTable());
            v_us.FillAppointmentByDichVu(v_ds_appointment, m_id_dich_vu);
           v_us.FillResourcesByDichVu(v_ds_resource, m_id_dich_vu);
            SetUpMapping();
            schedulerStorage1.Appointments.DataSource = v_ds_appointment.Tables[0];
            schedulerStorage1.Resources.DataSource = v_ds_resource.Tables[0];
            m_sch.ActiveViewType = SchedulerViewType.Timeline;
            m_sch.GroupType = SchedulerGroupType.Resource;
            m_sch.Start = System.DateTime.Now;
           
              
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
         //  schedulerStorage1.Resources.Mappings.Color = "Color";

        }

       
        private void f102_chon_danh_sach_nguoi_xu_ly_new_Load(object sender, EventArgs e)
        {

        }
    }
}
