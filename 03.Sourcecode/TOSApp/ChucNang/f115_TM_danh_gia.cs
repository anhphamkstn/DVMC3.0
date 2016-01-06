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
using TOSApp.App_Code;

namespace TOSApp.ChucNang
{
    public partial class f115_TM_danh_gia : Form
    {
        public f115_TM_danh_gia()
        {
            InitializeComponent();
        }

        US_GD_DAT_HANG M_us;
        
        internal void displayForTM(IPCOREUS.US_GD_DAT_HANG m_us)
        {
            load_data_2_form(m_us);
            this.ShowDialog();
        }

        private void load_data_2_form(IPCOREUS.US_GD_DAT_HANG m_us)
        {
            m_txt_ma_don_hang.Text = m_us.strMA_DON_HANG;
            M_us = new US_GD_DAT_HANG(m_us.dcID); ;
        }

        private void m_cmd_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void m_cmd_OK_Click(object sender, EventArgs e)
        {
            try
            {
                if (m_rdb_hoan_thanh.Checked == true)
                {
                   
                    if (m_chk_gui_email_YN.Checked==true)
                    {
                        gui_email_bao_hoan_thanh();
                    }
                    update_thoi_gian_hoan_thanh(M_us);
                    update_trang_thai_don_hang(M_us);
                    ghi_log_nghiem_thu_don_hang(M_us);
                    MessageBox.Show("Hoàn thành");
                    this.Close();
                }
                else
                {
                    if (m_txt_nhan_xet.Text == "")
                    {
                        MessageBox.Show("Nhập lý do không nghiệm thu!");
                        m_txt_nhan_xet.Focus();
                    }
                    else
                    {                       
                        update_trang_thai_don_hang_chua_hoan_thanh(M_us);
                        ghi_log_nghiem_thu_don_hang_chua_hoan_thanh(M_us);
                        this.Close();
                    }

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void update_thoi_gian_hoan_thanh(US_GD_DAT_HANG M_us)
        {
            US_GD_DAT_HANG v_us = new US_GD_DAT_HANG(M_us.dcID);
            v_us.datTHOI_GIAN_HOAN_THANH = System.DateTime.Now;
            v_us.Update();
        }

        private void gui_email_bao_hoan_thanh()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            US_V_GD_DAT_HANG m_us_v_gd_dat_hang = new US_V_GD_DAT_HANG(M_us.dcID);
            v_us.FillDatasetWithQuery(v_ds, "select * from dm_mau_email where id =6");
            string TIEU_DE = v_ds.Tables[0].Rows[0]["TIEU_DE_MAIL"].ToString();
            string NOI_DUNG = v_ds.Tables[0].Rows[0]["NOI_DUNG_EMAIL"].ToString();
            string GUI_CC = v_ds.Tables[0].Rows[0]["GUI_CC"].ToString();

            TIEU_DE = TIEU_DE.Replace("MA_DON_HANG", m_us_v_gd_dat_hang.strMA_DON_HANG);
            NOI_DUNG = NOI_DUNG.Replace("MA_DON_HANG", m_us_v_gd_dat_hang.strMA_DON_HANG);
            NOI_DUNG = NOI_DUNG.Replace("USER_NHAN_VIEN", m_us_v_gd_dat_hang.strHO_TEN_USER_DAT_HANG);
            NOI_DUNG = NOI_DUNG.Replace("USER_DON_VI", m_us_v_gd_dat_hang.strMA_DON_VI);
            NOI_DUNG = NOI_DUNG.Replace("USER_DIEN_THOAI", M_us.strDIEN_THOAI);
            NOI_DUNG = NOI_DUNG.Replace("USER_THOI_GIAN_DAT_HANG", M_us.datTHOI_GIAN_TAO.ToString());
            NOI_DUNG = NOI_DUNG.Replace("LOAI_DICH_VU_HO_TRO", m_us_v_gd_dat_hang.strTEN_YEU_CAU);
            NOI_DUNG = NOI_DUNG.Replace("YEU_CAU_CU_THE", M_us.strNOI_DUNG_DAT_HANG);
            NOI_DUNG = NOI_DUNG.Replace("THOI_GIAN_HOAN_THANH_THUC_TE", M_us.datTHOI_GIAN_HOAN_THANH.ToString());
            NOI_DUNG = NOI_DUNG.Replace("LICH_SU_TRAO_DOI", "Hoàn thành");
            NOI_DUNG = NOI_DUNG.Replace("THOI_GIAN_MONG_MUON_SUA_XONG", M_us.datTHOI_DIEM_CAN_HOAN_THANH + "hoặc thời gian hoàn thành là:"+ M_us.datTHOI_GIAN_HOAN_THANH);
            NOI_DUNG = NOI_DUNG.Replace("PHAN_HOI_CUA_DVMC", M_us.strPHAN_HOI_TU_DVMC);
            NOI_DUNG = NOI_DUNG.Replace("LINK_DANH_GIA_DON_HANG", "dvmc2.topica.vn/chucnang/f201_kh_danh_gia_dv.aspx?ma=" + m_us_v_gd_dat_hang.strMA_DON_HANG); 
            string nguoi_xu_ly = "";
            List<decimal> m_lst_id_nguoi_xu_ly = new List<decimal>();
            US_DUNG_CHUNG v_us_3 = new US_DUNG_CHUNG();
            DataSet v_ds_3 = new DataSet();
            v_ds_3.Tables.Add(new DataTable());
            v_us_3.FillDatasetWithQuery(v_ds_3, "select * from V_GD_DAT_HANG_GD_LOG_DAT_HANG where ten_nguoi_tao_thao_tac_log is not null and thao_tac_het_han_yn='N' and ID_DON_HANG=" + M_us.dcID);
            for (int i = 0; i < v_ds_3.Tables[0].Rows.Count; i++)
            {
                nguoi_xu_ly+="," +v_ds_3.Tables[0].Rows[i]["TEN_NGUOI_TAO_THAO_TAC_LOG"].ToString();
            }

            NOI_DUNG = NOI_DUNG.Replace("NGUOI_XU_LY_DON_HANG", nguoi_xu_ly);
            NOI_DUNG = NOI_DUNG.Replace("NGUOI_NHAN_DAT_HANG", m_us_v_gd_dat_hang.strNGUOI_TAO);
            US_DUNG_CHUNG v_us_1 = new US_DUNG_CHUNG();
            DataSet v_ds_1 = new DataSet();
            v_ds_1.Tables.Add(new DataTable());
            v_us_1.FillDatasetWithQuery(v_ds_1, "select * from dm_khach_hang where id=" + M_us.dcID_USER_NV_DAT_HANG);
            string to_cc = "";
            to_cc = v_ds_1.Tables[0].Rows[0]["EMAIL"].ToString();

            string user_email = "dvmc@topica.edu.vn";
            string password = "topica123";
            try
            {
                HelpUtils.send_mail("Dịch Vụ Một Cửa", user_email, password, to_cc, GUI_CC, TIEU_DE, NOI_DUNG);

            }

            catch (Exception v_e)
            {

                CSystemLog_100.ExceptionHandle(v_e);
            }
        }

        private void ghi_log_nghiem_thu_don_hang_chua_hoan_thanh(US_GD_DAT_HANG v_us)
        {
            US_GD_LOG_DAT_HANG v_US = new US_GD_LOG_DAT_HANG();
            v_US.dcID_GD_DAT_HANG = v_us.dcID;
            v_US.dcID_LOAI_THAO_TAC = 313;//cần xử lý lại
            v_US.dcID_NGUOI_TAO_THAO_TAC = us_user.dcID;
            v_US.dcID_NGUOI_NHAN_THAO_TAC = v_us.dcID_NGUOI_TAO;
            v_US.datNGAY_LAP_THAO_TAC = System.DateTime.Now;
            v_US.strTHAO_TAC_HET_HAN_YN = "N";
            v_US.strGHI_CHU = "đơn hàng cần được thực hiện lại! TM chưa chấp nhận nghiệm thu với lý do: " + m_txt_nhan_xet.Text;
            v_US.Insert();
        }

        private void update_trang_thai_don_hang_chua_hoan_thanh(US_GD_DAT_HANG v_us)
        {
            US_DUNG_CHUNG v_us_dc = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us_dc.FillDatasetWithQuery(v_ds, "SELECT * FROM V_GD_DAT_HANG_GD_LOG_DAT_HANG WHERE THAO_TAC_HET_HAN_YN = 'N' AND [ID_DON_HANG] = " + v_us.dcID.ToString());
            for (int i = 0; i < v_ds.Tables[0].Rows.Count; i++)
            {
                US_GD_LOG_DAT_HANG V_us = new US_GD_LOG_DAT_HANG(CIPConvert.ToDecimal(v_ds.Tables[0].Rows[i]["ID"].ToString()));
                V_us.strTHAO_TAC_HET_HAN_YN = "Y";
                V_us.Update();
            }
            
        }

        private void ghi_log_nghiem_thu_don_hang(US_GD_DAT_HANG v_us)
        {
            US_GD_LOG_DAT_HANG v_US = new US_GD_LOG_DAT_HANG();
            v_US.dcID_GD_DAT_HANG = v_us.dcID;
            v_US.dcID_LOAI_THAO_TAC = 309;//TM đã nghiệm thu
            v_US.dcID_NGUOI_TAO_THAO_TAC = us_user.dcID;
            v_US.SetID_NGUOI_NHAN_THAO_TACNull();
            v_US.datNGAY_LAP_THAO_TAC = System.DateTime.Now;
            v_US.strTHAO_TAC_HET_HAN_YN = "N";
            v_US.strGHI_CHU = us_user.strTEN_TRUY_CAP + " đã nghiệm thu đơn hàng với nhận xét: " + m_txt_nhan_xet.Text;
            v_US.Insert();
        }

        private void update_trang_thai_don_hang(US_GD_DAT_HANG v_us)
        {
            US_DUNG_CHUNG v_us_dc = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us_dc.FillDatasetWithQuery(v_ds, "SELECT * FROM V_GD_DAT_HANG_GD_LOG_DAT_HANG WHERE THAO_TAC_HET_HAN_YN = 'N' AND [ID_DON_HANG] = " + v_us.dcID.ToString());
            for (int i = 0; i < v_ds.Tables[0].Rows.Count; i++)
            {
                US_GD_LOG_DAT_HANG V_us = new US_GD_LOG_DAT_HANG(CIPConvert.ToDecimal(v_ds.Tables[0].Rows[i]["ID"].ToString()));
                V_us.strTHAO_TAC_HET_HAN_YN = "Y";
                V_us.Update();
            }
            //cập nhật thời gian hoàn thành cho đơn hàng
            US_GD_DAT_HANG v_us1 = new US_GD_DAT_HANG(v_us.dcID);
            v_us1.datTHOI_GIAN_HOAN_THANH = System.DateTime.Now;
            v_us1.Update();
        }
    }
}
