using IPCOREUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TOSApp.ChucNang
{
    public partial class f124_danh_gia_cua_khach_hang : Form
    {
        public f124_danh_gia_cua_khach_hang()
        {
            InitializeComponent();
        }
        US_GD_DAT_HANG m_us = new US_GD_DAT_HANG();
        US_GD_LOG_DAT_HANG m_us_log = new US_GD_LOG_DAT_HANG();
        private void m_cmd_ok_Click(object sender, EventArgs e)
        {
            if ((m_radio_xong_viec.Checked || m_radio_hoi_duoi.Checked || m_radio_chua_dat.Checked) && m_txt_y_kien_khac.Text == "")
            {
                MessageBox.Show("nhập lý do!");
            }
            else
            {
                update_danh_gia();
                update_log();
                insert_log();
                this.Close();
            }
        }
        internal void display(US_GD_DAT_HANG v_us, US_GD_LOG_DAT_HANG v_us_log)
        {
            m_us = v_us;
            m_us_log = v_us_log;
            this.ShowDialog();
        }
        private void update_danh_gia()
        {
            if (m_radio_chua_dat.Checked)
                m_us.dcID_DANH_GIA_TU_USER_DAT_HANG = 127;
            else if (m_radio_hoi_duoi.Checked)
                m_us.dcID_DANH_GIA_TU_USER_DAT_HANG = 126;
            else if (m_radio_xong_viec.Checked)
                m_us.dcID_DANH_GIA_TU_USER_DAT_HANG = 125;
            else if (m_radio_hai_long.Checked)
                m_us.dcID_DANH_GIA_TU_USER_DAT_HANG = 124;
            else if (m_radio_rat_hai_long.Checked)
                m_us.dcID_DANH_GIA_TU_USER_DAT_HANG = 123;
            m_us.Update();
            MessageBox.Show("Cám ơn bạn đã đánh giá!");
        }
        private void update_log()
        {
            m_us_log.strTHAO_TAC_HET_HAN_YN = "Y";
            m_us_log.Update();
        }
        private void insert_log()
        {
            m_us_log.dcID_GD_DAT_HANG = m_us.dcID;
            m_us_log.dcID_LOAI_THAO_TAC = 299;
            m_us_log.dcID_NGUOI_TAO_THAO_TAC = us_user.dcID;
            m_us_log.dcID_NGUOI_NHAN_THAO_TAC = us_user.dcID;
            m_us_log.datNGAY_LAP_THAO_TAC = System.DateTime.Now;
            m_us_log.strTHAO_TAC_HET_HAN_YN = "N";
            m_us_log.strGHI_CHU = "Khách hàng đã đánh giá";
            m_us_log.Insert();
        }
    }
}
