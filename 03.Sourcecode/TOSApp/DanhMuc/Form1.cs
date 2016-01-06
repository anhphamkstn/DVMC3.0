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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            load_data_2_grid();
        }

        private void load_data_2_grid()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();//Khai báo US
            DataSet v_ds = new DataSet();
            DataTable v_dt = new DataTable();
            v_ds.Tables.Add(v_dt);
            v_us.FillDatasetWithTableName(v_ds, "V_DM_CAU_HOI");

            m_grc.DataSource = v_ds.Tables[0];
            m_grv.ExpandAllGroups();    
        }

        private void m_cmd_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                //lay ra du lieu cua dong muon xoa bang thay da bam vao
                DataRow v_dr = m_grv.GetDataRow(m_grv.FocusedRowHandle);
                // lay ra id cua dong du lieu vua chon gan vao v_id duoi dang chuoi
                decimal v_id = CIPConvert.ToDecimal(v_dr["ID"].ToString());

                US_DM_CAU_HOI v_us = new US_DM_CAU_HOI(v_id);



                DialogResult result = new DialogResult();
                result = MessageBox.Show("Bạn chắc chắn muốn xóa?","Xác nhận", MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2);


                if (result == DialogResult.Yes)
                {
                    v_us.Delete();
                    MessageBox.Show("Bạn vừa xóa thành công");
                    load_data_2_grid();
                }
            }
            catch (Exception v_ex)
            {
                CSystemLog_301.ExceptionHandle(v_ex);
            }
  
        }
    }
}
