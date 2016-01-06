using IP.Core.IPCommon;
using IPCOREDS.CDBNames;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TOSApp.App_Code;

namespace TOSApp.Hệ_thống
{
    public partial class f258_nhap_ma_ipphone : Form
    {
        public f258_nhap_ma_ipphone()
        {
            InitializeComponent();
        }

        public void display_for_nhap_ip()
        {
            this.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (m_tb_ipphone.Text != "")
                {
                    //check ipphone còn đã active chưa.
                    CallCenterUtils.add_or_remove_agent_ipphone_2_queue(m_tb_ipphone.Text, us_user.strTEN_TRUY_CAP, KHO_QUEUE.MIEN_BAC, 10);
                    us_user.ipphone = m_tb_ipphone.Text;
                    this.Close();
                }
                else MessageBox.Show("Mã ipphone còn trống");
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
              
                    this.Close();
         
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
    }
}
