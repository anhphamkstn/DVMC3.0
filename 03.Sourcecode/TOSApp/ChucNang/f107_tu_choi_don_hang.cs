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
    public partial class f107_tu_choi_don_hang : Form
    {
        public f107_tu_choi_don_hang()
        {
            InitializeComponent();
           
        }

        US_GD_LOG_DAT_HANG m_US = new US_GD_LOG_DAT_HANG();
        US_V_GD_DAT_HANG_GD_LOG_DAT_HANG v_us = new US_V_GD_DAT_HANG_GD_LOG_DAT_HANG();
        internal void displayForRefuse(IPCOREUS.US_GD_LOG_DAT_HANG m_us)
        {
            us_to_form(m_us);
            this.ShowDialog();
        }

        private void us_to_form(US_GD_LOG_DAT_HANG m_us)
        {
            m_US = m_us;
            m_txt_ma_don_hang.Text = m_us.dcID_GD_DAT_HANG.ToString();
            m_txt_nguoi_nhan_tao_tac.Text = "người nhận thao tác có id là:"+v_us.strNGUOI_TAO_THAO_TAC;
            m_txt_ly_do_tu_choi.Focus();
        }

        private void m_cmd_gui_Click(object sender, EventArgs e)
        {
            try
            {
                if (m_txt_ly_do_tu_choi.Text == "")
                {
                    MessageBox.Show("Hãy nhập lý do từ chối!");
                    m_txt_ly_do_tu_choi.Focus();
                }
                else
                {
                    update_log_tu_choi();
                    ghi_log_tu_choi();
                    this.Close();
                    MessageBox.Show("Hoàn thành!");
                }
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }

        }

        private void update_log_tu_choi()
        {
            US_GD_LOG_DAT_HANG v_us_tu_choi = new US_GD_LOG_DAT_HANG(v_us.dcID);
            v_us_tu_choi.strTHAO_TAC_HET_HAN_YN = "Y";
            //v_us_tu_choi.strGHI_CHU = "BO đã từ chối";
            v_us_tu_choi.Update();

        }

        private void ghi_log_tu_choi()
        {
            US_GD_LOG_DAT_HANG v_US = new US_GD_LOG_DAT_HANG();
            v_US.dcID_LOAI_THAO_TAC = 310;//CHỜ FO điều phối lại
            v_US.dcID_GD_DAT_HANG = v_us.dcID_DON_HANG;
            v_US.dcID_NGUOI_TAO_THAO_TAC = TOSApp.us_user.dcID;
            v_US.dcID_NGUOI_NHAN_THAO_TAC = CIPConvert.ToDecimal(v_us.dcID_NGUOI_TAO);
            v_US.datNGAY_LAP_THAO_TAC = System.DateTime.Now;
            v_US.strTHAO_TAC_HET_HAN_YN = "N";
            v_US.strGHI_CHU = us_user.strTEN_TRUY_CAP + " đã từ chối với lý do " +  m_txt_ly_do_tu_choi.Text;
            v_US.Insert();
        }

        private void m_cmd_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        internal void displayForRefuse(US_V_GD_DAT_HANG_GD_LOG_DAT_HANG m_us, decimal id_nguoi_tao)
        {
            us_to_form(m_us, id_nguoi_tao);
            this.ShowDialog();
        }

        private void us_to_form(US_V_GD_DAT_HANG_GD_LOG_DAT_HANG m_us, decimal id_nguoi_tao)
        {
            v_us = new US_V_GD_DAT_HANG_GD_LOG_DAT_HANG( m_us.dcID);
            m_txt_ma_don_hang.Text = m_us.strMA_DON_HANG;//?? văn
            m_txt_nguoi_nhan_tao_tac.Text = m_us.strNGUOI_TAO_THAO_TAC;
            m_txt_ly_do_tu_choi.Focus();
        }
    }
}
