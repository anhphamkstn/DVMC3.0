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
namespace TOSApp.ChucNang
{
    public partial class f116_ds_TD : Form
    {
        public f116_ds_TD()
        {
            
            InitializeComponent();
        }
        US_V_GD_DAT_HANG_GD_LOG_DAT_HANG m_us = new US_V_GD_DAT_HANG_GD_LOG_DAT_HANG();

        private void update_log_gui_cho_pm(US_V_GD_DAT_HANG_GD_LOG_DAT_HANG m_us)
        {
            US_GD_LOG_DAT_HANG v_US = new US_GD_LOG_DAT_HANG(m_us.dcID);
            v_US.strTHAO_TAC_HET_HAN_YN = "Y";
            v_US.strGHI_CHU = "đơn hàng đã được gửi cho TD";
            v_US.Update();
        }

        private void insert_log_gui_cho_pm(US_V_GD_DAT_HANG_GD_LOG_DAT_HANG m_us)
        {
             US_DUNG_CHUNG l_us = new US_DUNG_CHUNG();
            DataSet l_ds = new DataSet();
            l_ds.Tables.Add( new DataTable());

            l_us.FillDatasetWithQuery(l_ds,"select ID_PM from HT_BO_PM_TD where id_PM ="+us_user.dcID);
            US_GD_LOG_DAT_HANG v_US = new US_GD_LOG_DAT_HANG();
            v_US.dcID_LOAI_THAO_TAC = 305;//đã chuyển cho TD
            v_US.dcID_GD_DAT_HANG = m_us.dcID_DON_HANG;
            v_US.dcID_NGUOI_TAO_THAO_TAC = us_user.dcID;//Quản lý có id 15
            v_US.dcID_NGUOI_NHAN_THAO_TAC =CIPConvert.ToDecimal( m_cbo_ds_TD.SelectedValue.ToString());
            v_US.datNGAY_LAP_THAO_TAC = System.DateTime.Now;
            v_US.strTHAO_TAC_HET_HAN_YN = "N";
            v_US.strGHI_CHU = "đơn hàng đã được gửi cho TD \n" + m_txt_gui_kem.Text;
            v_US.Insert();

        }

        internal void displayForUpdate(IPCOREUS.US_V_GD_DAT_HANG_GD_LOG_DAT_HANG v_us)
        {
            load_data_to_form(v_us);

            this.ShowDialog();
        }

        private void load_data_to_form(IPCOREUS.US_V_GD_DAT_HANG_GD_LOG_DAT_HANG v_us)
        {

            m_us = new US_V_GD_DAT_HANG_GD_LOG_DAT_HANG(v_us.dcID);
            m_txt_ma_don_hang.Text = v_us.strMA_DON_HANG;
            WinFormControls.load_data_to_combobox_with_query(m_cbo_ds_TD, "ID", "TEN", WinFormControls.eTAT_CA.NO, "SELECT hnsd.ID,hnsd.TEN FROM HT_BO_DICH_VU hbdv,HT_NGUOI_SU_DUNG hnsd WHERE hnsd.ID=hbdv.ID_NGUOI_SU_DUNG AND hbdv.ID_DICH_VU =" + v_us.dcID_NHOM_DV_YEU_CAU.ToString() + "AND hbdv.CAP_SU_DUNG = 5");
            m_txt_gui_kem.Focus();
          
        }

        private void m_cmd_Ok_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (m_txt_gui_kem.Text == "")
                {
                    MessageBox.Show("Nhập lý do gửi kèm!");
                    m_txt_gui_kem.Focus();
                }
                else
                {
                    insert_log_gui_cho_pm(m_us);
                    update_log_gui_cho_pm(m_us);
                    us_user.gui_mail_thong_bao_chuyen_don_hang(m_us, us_user.dcID, CIPConvert.ToDecimal(m_cbo_ds_TD.SelectedValue.ToString()));
                    MessageBox.Show("Hoàn thành!");
                    this.Close();
                }
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_cancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
}
