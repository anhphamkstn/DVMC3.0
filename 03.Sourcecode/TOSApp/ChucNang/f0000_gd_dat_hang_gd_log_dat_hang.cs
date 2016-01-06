using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IP.Core.IPCommon;
using IPCOREUS;
using TOSApp.HT;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace TOSApp.ChucNang
{
    public partial class f0000_gd_dat_hang_gd_log_dat_hang : Form
    {
        public decimal kieu_load_form = 0;

        #region member email
        US_DM_MAU_EMAIL m_us_dm_mau_mail = new US_DM_MAU_EMAIL();
        DataSet m_ds_dm_mau_mail_xac_nhan = new DataSet();
        DataSet m_ds_dm_mau_mail_hoan_thanh = new DataSet();
        DataSet m_ds_dm_mau_mail_cap_nhat_don_hang = new DataSet();
        #endregion

        public f0000_gd_dat_hang_gd_log_dat_hang(int i)
        {
            InitializeComponent();
            kieu_load_form = i;
            load_data_2_grid();
            format_controll_for_each_user(us_user.dcIDNhom);
        }

        private void format_controll_for_each_user(decimal p)
        {
            format_gridview();
            format_controll(p);
        }

        private void GetAllControl(Control c, List<Control> list)
        {
            foreach (Control control in c.Controls)
            {
                list.Add(control);

                if (control.GetType() == typeof(Panel))
                    GetAllControl(control, list);
            }
        }

        private void format_controll(decimal p)
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithQuery(v_ds, "select * from V_HT_PHAN_QUYEN_CHO_NHOM where id_NHOM_NGUOI_SU_DUNG=" + us_user.dcIDNhom);
            List<Control> list = new List<Control>();
            GetAllControl(this, list);
            foreach (Control control in list)
            {
                if (control.GetType() == typeof(SimpleButton) || control.GetType() == typeof(Panel))
                {
                    for (int i = 0; i < v_ds.Tables[0].Rows.Count; i++)
                    {
                        if (control.Name == v_ds.Tables[0].Rows[i]["CONTROL_NAME"].ToString())
                        {
                            control.Visible = true;
                        }                       
                    }
                }
              }
           
            }
        private void format_gridview()
        {
            MA_DON_HANG.Visible = true;
            HO_TEN_USER_DAT_HANG.Visible = true;
            DON_VI.Visible = true;
            DIEN_THOAI.Visible = true;
            THOI_DIEM_CAN_HOAN_THANH.Visible = true;
            TEN_NHOM_DICH_VU.Visible = true;
            NOI_DUNG_DAT_HANG.Visible = true;
            THOI_GIAN_CAN_HOAN_THANH.Visible = true;
            CHI_NHANH.Visible = true;
            PHUONG_THUC_DAT_HANG.Visible = true;
            NGUOI_TAO_THAO_TAC_LOG.Visible = false;
            GHI_CHU.Visible = true;
            THOI_DIEM_TU_CHOI.Visible = true;
            CAP_NHAT_CUOI.Visible = true;
            if (us_user.dcIDNhom!=1)
            {
               GHI_CHU.Visible = false;
                THOI_DIEM_TU_CHOI.Visible = false;
            }
        }

        US_V_GD_DAT_HANG_GD_LOG_DAT_HANG m_us = new US_V_GD_DAT_HANG_GD_LOG_DAT_HANG();
        public decimal m_id_nguoi_dieu_phoi;

        public void load_data_2_grid()
        {
            
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());

            string m_query = "select * from V_GD_DAT_HANG_GD_LOG_DAT_HANG where THAO_TAC_HET_HAN_YN = 'N'";
            if (us_user.dcIDNhom == 1) //fo
                m_query += " AND  ID_LOAI_THAO_TAC in(310,313)";

            else if (us_user.dcIDNhom == 2) //bo
                if (kieu_load_form==1)
                m_query = m_query + "And ID_LOAI_THAO_TAC in (295,311) And ID_NGUOI_NHAN_THAO_TAC = " + us_user.dcID.ToString();
                else m_query = m_query + " And ID_LOAI_THAO_TAC in (296) And ID_NGUOI_TAO_THAO_TAC = " + us_user.dcID.ToString();
                   
            else if (us_user.dcIDNhom == 3) //pm
                if (kieu_load_form==1)
                m_query = m_query + "And ID_LOAI_THAO_TAC in( 303) And ID_NGUOI_NHAN_THAO_TAC = " + us_user.dcID.ToString();
                else m_query = m_query + " And ID_LOAI_THAO_TAC in (304) And ID_NGUOI_TAO_THAO_TAC = " + us_user.dcID.ToString();
                   

            else if (us_user.dcIDNhom == 5) //td
                if (kieu_load_form==1)
                m_query = m_query + "And ID_LOAI_THAO_TAC in (305) And ID_NGUOI_NHAN_THAO_TAC = " + us_user.dcID.ToString();
                else m_query = m_query + " And ID_LOAI_THAO_TAC in (306) And ID_NGUOI_TAO_THAO_TAC = " + us_user.dcID.ToString();
                   
                 //tm
            else
                if (kieu_load_form==2)
                {
                    m_query = m_query + "And (ID_LOAI_THAO_TAC = 321 OR (ID_LOAI_THAO_TAC = 297 AND ID_LOAI_THAO_TAC = ALL (SELECT* FROM dbo.f_get_table_trang_thai_don_hang(ID_DON_HANG)))) ";
                }

            m_query += "order by NGAY_LAP_THAO_TAC DESC";
            v_us.FillDatasetWithQuery(v_ds,m_query);
            m_grc_gd_dat_hang_gd_log_dat_hang.DataSource = v_ds.Tables[0];
        }


        
        US_GD_LOG_DAT_HANG m_us_log = new US_GD_LOG_DAT_HANG();

        /// <Chú ý cho tất cả các hàm ghi log>
        /// trong tất cả các hàm ghi lại log thì cần xem xét lại người ghi log và id của loại thao tác
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        ///

        #region thêm mới đơn hàng
        private void m_cmd_them_moi_don_hang_Click(object sender, EventArgs e)
        {

            try
            {
                f100_don_dat_hang_new v_f100 = new f100_don_dat_hang_new();
                v_f100.displayForInsert();
                load_data_2_grid();

            }
            catch (Exception v_e)
            {

                CSystemLog_100.ExceptionHandle(v_e);
            }
        }
        #endregion

        #region chỉnh sửa đơn hàng
        private void m_cmd_chinh_sua_don_hang_Click(object sender, EventArgs e)
        {
          
        }
        #endregion

        #region FO điều phối lại
        private void m_cmd_dieu_phoi_lai_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow v_dr = m_grv_gd_dat_hang_gd_log_dat_hang.GetDataRow(m_grv_gd_dat_hang_gd_log_dat_hang.FocusedRowHandle);
                US_V_GD_DAT_HANG_GD_LOG_DAT_HANG v_us = new US_V_GD_DAT_HANG_GD_LOG_DAT_HANG(CIPConvert.ToDecimal(v_dr["ID"].ToString()));
                f114_ds_BO v_f114 = new f114_ds_BO();
                v_f114.display_dieu_huong(v_us);
                load_data_2_grid();
              //  MessageBox.Show("Thành công");
               
            }
            catch (Exception v_e)
            {

                CSystemLog_100.ExceptionHandle(v_e);
            }
        }
        #endregion

        #region điều phối cho PM
        private void m_cmd_dieu_phoi_cho_PM_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow v_dr = m_grv_gd_dat_hang_gd_log_dat_hang.GetDataRow(m_grv_gd_dat_hang_gd_log_dat_hang.FocusedRowHandle);
                US_V_GD_DAT_HANG_GD_LOG_DAT_HANG v_us = new US_V_GD_DAT_HANG_GD_LOG_DAT_HANG(CIPConvert.ToDecimal(v_dr["ID"].ToString()));
                f112_FO_chuyen_don_hang_cho_PM v_f = new f112_FO_chuyen_don_hang_cho_PM();
                v_f.displayForUpdate(v_us);
                //update_trang_thai_don_hang(v_us);
                load_data_2_grid();
            }
            catch (Exception v_e)
            {
                CSystemLog_100.ExceptionHandle(v_e);
            }
        }

        private void fill_data_to_m_us()
        {
            DataRow v_dr = m_grv_gd_dat_hang_gd_log_dat_hang.GetDataRow(m_grv_gd_dat_hang_gd_log_dat_hang.FocusedRowHandle);
            m_us = new US_V_GD_DAT_HANG_GD_LOG_DAT_HANG(CIPConvert.ToDecimal(v_dr["ID"].ToString()));
        }
        #endregion

        #region BO tiếp nhận xử lý
        private void m_cmd_BO_tiep_nhan_Click(object sender, EventArgs e)
        {
            try
            {
                fill_data_to_m_us();
                update_log_tiep_nhan();
                ghi_log_da_nhan_xu_ly();
                load_data_2_grid();
                //m_id_nguoi_dieu_phoi = m_us.dcID_NGUOI_TAO_THAO_TAC;
                MessageBox.Show("Đã tiếp nhận!");
            }
            catch (Exception v_e)
            {

                CSystemLog_100.ExceptionHandle(v_e);
            }
        }
        private void update_log_tiep_nhan()
        {
            US_GD_LOG_DAT_HANG v_US = new US_GD_LOG_DAT_HANG(m_us.dcID);
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            if (us_user.dcIDNhom == 2)
            {
                v_us.FillDatasetWithQuery(v_ds, "SELECT *FROM GD_LOG_DAT_HANG WHERE ID_GD_DAT_HANG =" + v_US.dcID_GD_DAT_HANG.ToString() + "And ID_LOAI_THAO_TAC in (295,311) And THAO_TAC_HET_HAN_YN = 'N' AND ID_NGUOI_NHAN_THAO_TAC = " + us_user.dcID.ToString());
            }
            else if (us_user.dcIDNhom == 3)
            {
                v_us.FillDatasetWithQuery(v_ds, "SELECT *FROM GD_LOG_DAT_HANG WHERE ID_GD_DAT_HANG =" + v_US.dcID_GD_DAT_HANG.ToString() + "And ID_LOAI_THAO_TAC in (303) And THAO_TAC_HET_HAN_YN = 'N' AND ID_NGUOI_NHAN_THAO_TAC = " + us_user.dcID.ToString());
            }
            else if (us_user.dcIDNhom == 5)
            {
                v_us.FillDatasetWithQuery(v_ds, "SELECT *FROM GD_LOG_DAT_HANG WHERE ID_GD_DAT_HANG =" + v_US.dcID_GD_DAT_HANG.ToString() + "And ID_LOAI_THAO_TAC in (305) And THAO_TAC_HET_HAN_YN = 'N' AND ID_NGUOI_NHAN_THAO_TAC = " + us_user.dcID.ToString());
            }
            for (int i = 0; i < v_ds.Tables[0].Rows.Count; i++)
            {
                v_US = new US_GD_LOG_DAT_HANG(CIPConvert.ToDecimal(v_ds.Tables[0].Rows[i][0].ToString()));
                v_US.strTHAO_TAC_HET_HAN_YN = "Y";
                v_US.Update();
            }
           
        }
        private void  ghi_log_da_nhan_xu_ly()
        {
            US_GD_LOG_DAT_HANG v_us = new US_GD_LOG_DAT_HANG();
            v_us.dcID_LOAI_THAO_TAC = 296;
            v_us.dcID_GD_DAT_HANG = m_us.dcID_DON_HANG;
            v_us.dcID_NGUOI_TAO_THAO_TAC = us_user.dcID;
            v_us.dcID_NGUOI_NHAN_THAO_TAC = us_user.dcID;
            v_us.datNGAY_LAP_THAO_TAC = System.DateTime.Now;
            v_us.strTHAO_TAC_HET_HAN_YN = "N";
            v_us.strGHI_CHU = us_user.strTEN_TRUY_CAP + " đã nhận xử lý";
            v_us.Insert();
        }

        #endregion

        #region BO từ chối đơn hàng
        private void m_cmd_BO_tu_choi_Click(object sender, EventArgs e)
        {
            decimal id_nguoi_tao;
            try
            {
                fill_data_to_m_us();
                if(m_us.dcID_LOAI_THAO_TAC == 313)
                {
                    US_DUNG_CHUNG v_us_dung_chung = new US_DUNG_CHUNG();
                    DataSet v_ds = new DataSet();
                    v_ds.Tables.Add(new DataTable());
                    v_us_dung_chung.FillDatasetWithQuery(v_ds, "SELECT id FROM GD_LOG_DAT_HANG gldh WHERE gldh.ID_LOAI_THAO_TAC in (295,311) AND gldh.ID_GD_DAT_HANG = " + m_us.dcID_DON_HANG + "ORDER BY id DESC");
                    US_GD_LOG_DAT_HANG v_us_log = new US_GD_LOG_DAT_HANG(CIPConvert.ToDecimal(v_ds.Tables[0].Rows[0]["ID"].ToString()));
                    id_nguoi_tao = v_us_log.dcID_NGUOI_TAO_THAO_TAC;
                }
                else
                {
                    id_nguoi_tao = m_us.dcID_NGUOI_TAO;
                }
                f107_tu_choi_don_hang v_f107 = new f107_tu_choi_don_hang();
                v_f107.displayForRefuse(m_us, id_nguoi_tao);
                load_data_2_grid();
             
            }
            catch (Exception v_e)
            {
                CSystemLog_100.ExceptionHandle(v_e);
            }

        }

        #endregion 

        #region TM đánh giá cho các đơn hàng được báo cáo
        private void m_cmd_TM_danh_gia_Click(object sender, EventArgs e)
        {
            try
            {
                fill_data_to_m_us();
                f115_TM_danh_gia v_f115 = new f115_TM_danh_gia();
                US_GD_DAT_HANG v_us = new US_GD_DAT_HANG(m_us.dcID_DON_HANG);
                v_f115.displayForTM(v_us);
                load_data_2_grid();
              
            }
            catch (Exception v_e )
            {

                CSystemLog_100.ExceptionHandle(v_e);
            }
        }
        private void m_cmd_bao_cao_hoan_thanh_Click(object sender, EventArgs e)
        {
            try
            {
                fill_data_to_m_us();
                update_hoan_thanh_don_hang_BO();
                ghi_log_da_hoan_thanh_don_hang_BO();
                us_user.gui_mail_thong_bao_xu_ly_xong_don_hang(m_us, us_user.dcID);
                load_data_2_grid();
                MessageBox.Show("Hoàn thành!");
            }
            catch (Exception v_e)
            {

                CSystemLog_100.ExceptionHandle(v_e);
            }
        }


        private void ghi_log_da_hoan_thanh_don_hang_BO()
        {
            US_GD_LOG_DAT_HANG v_us = new US_GD_LOG_DAT_HANG();
            v_us.dcID_LOAI_THAO_TAC = 297;//BO đã xử lý
            v_us.dcID_GD_DAT_HANG = m_us.dcID_DON_HANG;
            v_us.dcID_NGUOI_TAO_THAO_TAC = us_user.dcID;
            v_us.dcID_NGUOI_NHAN_THAO_TAC = us_user.dcID;  
            v_us.datNGAY_LAP_THAO_TAC = System.DateTime.Now;
            v_us.strTHAO_TAC_HET_HAN_YN = "N";
            v_us.strGHI_CHU = us_user.strTEN_TRUY_CAP + " đã xử lý xong! chờ TM nghiệm thu";
            v_us.Insert();
        }

        private void update_hoan_thanh_don_hang_BO()
        {
            US_GD_LOG_DAT_HANG v_us = new US_GD_LOG_DAT_HANG(m_us.dcID);
            v_us.strTHAO_TAC_HET_HAN_YN = "Y";
            //v_us.strGHI_CHU = "BO đã xử lý xong đơn hàng và chờ TM nghiệm thu!";
            v_us.Update();
        }
        #endregion

        #region PM tiếp nhận đơn hàng & xử lý
        private void m_cmd_PM_tiep_nhan_Click(object sender, EventArgs e)
        {
            try
            {
                fill_data_to_m_us();
                update_log_tiep_nhan();
                ghi_log_PM_da_nhan_xu_ly(m_us);
                load_data_2_grid();
                MessageBox.Show("Hoàn thành!");
            }
            catch (Exception v_e)
            {

                CSystemLog_100.ExceptionHandle(v_e);
            }
        }

        private void ghi_log_PM_da_nhan_xu_ly(US_V_GD_DAT_HANG_GD_LOG_DAT_HANG m_us)
        {
            US_GD_LOG_DAT_HANG v_us = new US_GD_LOG_DAT_HANG();
            v_us.dcID_LOAI_THAO_TAC = 304;
            v_us.dcID_GD_DAT_HANG = m_us.dcID_DON_HANG;
            v_us.dcID_NGUOI_TAO_THAO_TAC = us_user.dcID;//thang pm co id 15
            v_us.dcID_NGUOI_NHAN_THAO_TAC = us_user.dcID;
            v_us.datNGAY_LAP_THAO_TAC = System.DateTime.Now;
            v_us.strTHAO_TAC_HET_HAN_YN = "N";
            v_us.strGHI_CHU =us_user.strTEN_TRUY_CAP + " đã nhận xử lý";
            v_us.Insert();
        }
        //private void update_log_PM_tiep_nhan()
        //{
        //    US_GD_LOG_DAT_HANG v_us = new US_GD_LOG_DAT_HANG(m_us.dcID);
        //    v_us.strTHAO_TAC_HET_HAN_YN = "Y";
        //    //v_us.strGHI_CHU = "PM đã tiếp nhận xử lý";
        //    v_us.Update();
        //}
        #endregion

        #region TD tiếp nhận đơn hàng và xử lý
        private void m_cmd_admin_tiep_nhan_xu_ly_Click(object sender, EventArgs e)
        {
            try
            {
                fill_data_to_m_us();
                DataRow v_dr = m_grv_gd_dat_hang_gd_log_dat_hang.GetDataRow(m_grv_gd_dat_hang_gd_log_dat_hang.FocusedRowHandle);
                US_GD_DAT_HANG v_us = new US_GD_DAT_HANG(CIPConvert.ToDecimal(v_dr["ID_DON_HANG"].ToString()));
                f100_don_dat_hang_new v_f100 = new f100_don_dat_hang_new();
                v_f100.displayForUpdate(v_us, 1);
                update_log_tiep_nhan();
                ghi_log_admin_da_nhan_xu_ly();
                load_data_2_grid();
                MessageBox.Show("Đã tiếp nhận đơn hàng!");
            }
            catch (Exception v_e)
            {

                CSystemLog_100.ExceptionHandle(v_e);
            }
        }

        private void ghi_log_admin_da_nhan_xu_ly()
        {
            US_GD_LOG_DAT_HANG v_us = new US_GD_LOG_DAT_HANG();
            v_us.dcID_LOAI_THAO_TAC = 306;//TD xử lý
            v_us.dcID_GD_DAT_HANG = m_us.dcID_DON_HANG;
            v_us.dcID_NGUOI_TAO_THAO_TAC = us_user.dcID;//TD có id = 21
            v_us.dcID_NGUOI_NHAN_THAO_TAC = us_user.dcID;
            v_us.datNGAY_LAP_THAO_TAC = System.DateTime.Now;
            v_us.strTHAO_TAC_HET_HAN_YN = "N";
            v_us.strGHI_CHU =us_user.strTEN_TRUY_CAP + " đã nhận xử lý";
            v_us.Insert();
        }

        //private void update_log_admin_tiep_nhan()
        //{
        //    US_GD_LOG_DAT_HANG v_us = new US_GD_LOG_DAT_HANG(m_us.dcID);          
        //    v_us.strTHAO_TAC_HET_HAN_YN = "Y";
        //    //v_us.strGHI_CHU = "admin đã tiếp nhận xử lý";
        //    v_us.Update();
        //}
        #endregion

        #region TD hủy đơn hàng
        private void m_cmd_admin_huy_hon_hang_Click(object sender, EventArgs e)
        {
            try
            {
                fill_data_to_m_us();
                f103_TD_ly_do_tu_choi f103 = new f103_TD_ly_do_tu_choi();
                US_GD_DAT_HANG v_us_gd_dat_hang = new US_GD_DAT_HANG(m_us.dcID_DON_HANG);
                f103.Display(v_us_gd_dat_hang);
                load_data_2_grid();     
            }
            catch (Exception v_e)
            {

                CSystemLog_100.ExceptionHandle(v_e);
            }
        }

      

        #endregion

        #region TD hoàn thành đơn hàng
        private void m_cmd_admin_hoan_thanh_Click(object sender, EventArgs e)
        {
            try
            {
                fill_data_to_m_us();
                update_hoan_thanh_don_hang_TD();
                ghi_log_admin_da_hoan_thanh_don_hang_TD();
                us_user.gui_mail_thong_bao_xu_ly_xong_don_hang(m_us, us_user.dcID);
                MessageBox.Show("Hoàn thành!");
                load_data_2_grid();
            }
            catch (Exception v_e )
            {

                CSystemLog_100.ExceptionHandle(v_e);
            }
        }

        private void ghi_log_admin_da_hoan_thanh_don_hang_TD()
        {
            US_GD_LOG_DAT_HANG v_us = new US_GD_LOG_DAT_HANG();
            v_us.dcID_LOAI_THAO_TAC = 297;//đã nghiệm thu
            v_us.dcID_GD_DAT_HANG = m_us.dcID_DON_HANG;
            v_us.dcID_NGUOI_TAO_THAO_TAC = us_user.dcID;
            v_us.dcID_NGUOI_NHAN_THAO_TAC = us_user.dcID;
            v_us.datNGAY_LAP_THAO_TAC = System.DateTime.Now;
            v_us.strTHAO_TAC_HET_HAN_YN = "N";
            v_us.strGHI_CHU = us_user.strTEN_TRUY_CAP +  " đã hoàn thành đơn hàng, chờ TM nghiệm thu";
            v_us.Insert();
        }

        private void update_hoan_thanh_don_hang_TD()
        {
            US_GD_LOG_DAT_HANG v_us = new US_GD_LOG_DAT_HANG(m_us.dcID);           
            v_us.strTHAO_TAC_HET_HAN_YN = "Y";
            //v_us.strGHI_CHU = "TD đã xử lý xong";
            v_us.Update();
        }
        #endregion

        #region PM bao cáo hoàn hành MO
        private void m_cmd_PM_bao_Cao_hoan_thanh_Click(object sender, EventArgs e)
        {
            try
            {
                fill_data_to_m_us();
                // update_thoi_gian_hoan_thanh_don_hang();
                update_hoan_thanh_don_hang_PM();
                ghi_log_admin_da_hoan_thanh_don_hang_PM();
                us_user.gui_mail_thong_bao_xu_ly_xong_don_hang(m_us, us_user.dcID);
                MessageBox.Show("Hoàn thành!");
                load_data_2_grid();
            }
            catch (Exception v_e)
            {

                CSystemLog_100.ExceptionHandle(v_e);
            }
        }

        private void update_thoi_gian_hoan_thanh_don_hang()
        {
            US_GD_DAT_HANG v_us = new US_GD_DAT_HANG(m_us.dcID_DON_HANG);
            v_us.datTHOI_GIAN_HOAN_THANH = System.DateTime.Now;
            v_us.Update();
        }
        /// <summary>
        /// hàm này còn sai trạng thái của loại thao tác vì trong từ điển còn thiếu
        /// </summary>
        private void ghi_log_admin_da_hoan_thanh_don_hang_PM()
        {
            US_GD_LOG_DAT_HANG v_us = new US_GD_LOG_DAT_HANG();
            v_us.dcID_LOAI_THAO_TAC = 297;//
            v_us.dcID_GD_DAT_HANG = m_us.dcID_DON_HANG;
            v_us.dcID_NGUOI_TAO_THAO_TAC = us_user.dcID;
            v_us.dcID_NGUOI_NHAN_THAO_TAC = us_user.dcID;
            v_us.datNGAY_LAP_THAO_TAC = System.DateTime.Now;
            v_us.strTHAO_TAC_HET_HAN_YN = "N";
            v_us.strGHI_CHU = us_user.strTEN_TRUY_CAP + " đã hoàn thành đơn hàng, chờ TM nghiệm thu";
            v_us.Insert(); 
        }

        private void update_hoan_thanh_don_hang_PM()
        {

            US_GD_LOG_DAT_HANG v_us = new US_GD_LOG_DAT_HANG(m_us.dcID);
            v_us.strTHAO_TAC_HET_HAN_YN = "Y";
            //v_us.strGHI_CHU = "PM đã hoàn thành,chờ TM nghiệm thu";
            v_us.Update();
        }
        #endregion

        private void m_cmd_PM_gui_cho_admin_Click(object sender, EventArgs e)
        {
            try
            {

                DataRow v_dr = m_grv_gd_dat_hang_gd_log_dat_hang.GetDataRow(m_grv_gd_dat_hang_gd_log_dat_hang.FocusedRowHandle);
                US_V_GD_DAT_HANG_GD_LOG_DAT_HANG v_us = new US_V_GD_DAT_HANG_GD_LOG_DAT_HANG(CIPConvert.ToDecimal(v_dr["ID"].ToString()));
                f116_ds_TD v_f = new f116_ds_TD();
                v_f.displayForUpdate(v_us);
                load_data_2_grid();
            }
            catch (Exception v_e)
            {

                CSystemLog_100.ExceptionHandle(v_e);
            }
        }

        #region format controll for each user

        private void format_controll_FO()
        {
           m_panel_FO.Visible = true;
            m_panel_BO.Visible = false;
            m_panel_PM.Visible = false;
            m_panel_TD.Visible = false;
            m_panel_TM.Visible = false;
            MA_DON_HANG.Visible = true;
            HO_TEN_USER_DAT_HANG.Visible = true;
            DON_VI.Visible = true;
            DIEN_THOAI.Visible = true;
            THOI_DIEM_CAN_HOAN_THANH.Visible = true;
            TEN_NHOM_DICH_VU.Visible = true;
            NOI_DUNG_DAT_HANG.Visible = true;
            THOI_GIAN_CAN_HOAN_THANH.Visible = true;
         //   NGUOI_TAO_DON_HANG.Visible = true;
            CHI_NHANH.Visible = true;
            PHUONG_THUC_DAT_HANG.Visible = true;
          
            GHI_CHU.Visible = false;

        }
        private void format_controll_BO()
        {
            m_panel_FO.Visible = false;
            m_panel_BO.Visible = true;
            m_panel_PM.Visible = false;
            m_panel_TD.Visible = false;
            m_panel_TM.Visible = false;
            MA_DON_HANG.Visible = true;
            HO_TEN_USER_DAT_HANG.Visible = true;
            DON_VI.Visible = true;
            DIEN_THOAI.Visible = true;
            THOI_DIEM_CAN_HOAN_THANH.Visible = true;
            TEN_NHOM_DICH_VU.Visible = true;
            NOI_DUNG_DAT_HANG.Visible = true;
            THOI_GIAN_CAN_HOAN_THANH.Visible = true;
            //NGUOI_TAO_DON_HANG.Visible = true;
            CHI_NHANH.Visible = true;
            PHUONG_THUC_DAT_HANG.Visible = true;
           
            NGUOI_TAO_THAO_TAC_LOG.Visible = false;
           
            GHI_CHU.Visible = false;


        }
        private void format_controll_PM()
        {
            m_panel_FO.Visible = false;
            m_panel_BO.Visible = false;
            m_panel_PM.Visible = true;
            m_panel_TD.Visible = false;
            m_panel_TM.Visible = false;
            MA_DON_HANG.Visible = true;
            HO_TEN_USER_DAT_HANG.Visible = true;
            DON_VI.Visible = true;
            DIEN_THOAI.Visible = true;
            THOI_DIEM_CAN_HOAN_THANH.Visible = true;
            TEN_NHOM_DICH_VU.Visible = true;
            NOI_DUNG_DAT_HANG.Visible = true;
            THOI_GIAN_CAN_HOAN_THANH.Visible = true;
            //NGUOI_TAO_DON_HANG.Visible = true;
            CHI_NHANH.Visible = true;
            PHUONG_THUC_DAT_HANG.Visible = true;
          
            NGUOI_TAO_THAO_TAC_LOG.Visible = false;
          
            GHI_CHU.Visible = false;

        }
        private void format_controll_TD()
        {
            m_panel_FO.Visible = false;
            m_panel_BO.Visible = false;
            m_panel_PM.Visible = false;
            m_panel_TD.Visible = true;
            m_panel_TM.Visible = false;
            MA_DON_HANG.Visible = true;
            HO_TEN_USER_DAT_HANG.Visible = true;
            DON_VI.Visible = true;
            DIEN_THOAI.Visible = true;
            THOI_DIEM_CAN_HOAN_THANH.Visible = true;
            TEN_NHOM_DICH_VU.Visible = true;
            NOI_DUNG_DAT_HANG.Visible = true;
            THOI_GIAN_CAN_HOAN_THANH.Visible = true;
            //NGUOI_TAO_DON_HANG.Visible = true;
            CHI_NHANH.Visible = true;
            PHUONG_THUC_DAT_HANG.Visible = true;
          
            NGUOI_TAO_THAO_TAC_LOG.Visible = false;
          
            GHI_CHU.Visible = false;
        }

        private void format_controll_TM()
        {
            m_panel_FO.Visible = false;
            m_panel_BO.Visible = false;
            m_panel_PM.Visible = false;
            m_panel_TD.Visible = false;
            m_panel_TM.Visible = true;
            MA_DON_HANG.Visible = true;
            HO_TEN_USER_DAT_HANG.Visible = true;
            DON_VI.Visible = true;
            DIEN_THOAI.Visible = true;
            THOI_DIEM_CAN_HOAN_THANH.Visible = true;
            TEN_NHOM_DICH_VU.Visible = true;
            NOI_DUNG_DAT_HANG.Visible = true;
            THOI_GIAN_CAN_HOAN_THANH.Visible = true;
            //NGUOI_TAO_DON_HANG.Visible = true;
            CHI_NHANH.Visible = true;
            PHUONG_THUC_DAT_HANG.Visible = true;
           
            NGUOI_TAO_THAO_TAC_LOG.Visible = false;
           
            GHI_CHU.Visible = false;

        }

        #endregion 

        private void m_cmd_PM_dieu_phoi_lai_Click(object sender, EventArgs e)
        {

            try
            {
                DataRow v_dr = m_grv_gd_dat_hang_gd_log_dat_hang.GetDataRow(m_grv_gd_dat_hang_gd_log_dat_hang.FocusedRowHandle);
                US_V_GD_DAT_HANG_GD_LOG_DAT_HANG v_us = new US_V_GD_DAT_HANG_GD_LOG_DAT_HANG(CIPConvert.ToDecimal(v_dr["ID"].ToString()));

                f114_ds_BO v_f114 = new f114_ds_BO();
                v_f114.display_dieu_huong(v_us);
                load_data_2_grid();

            }
            catch (Exception v_e)
            {

                CSystemLog_100.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_PM_dieu_phoi_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow v_dr = m_grv_gd_dat_hang_gd_log_dat_hang.GetDataRow(m_grv_gd_dat_hang_gd_log_dat_hang.FocusedRowHandle);
                US_V_GD_DAT_HANG_GD_LOG_DAT_HANG v_us = new US_V_GD_DAT_HANG_GD_LOG_DAT_HANG(CIPConvert.ToDecimal(v_dr["ID"].ToString()));

                f114_ds_BO v_f114 = new f114_ds_BO();
                v_f114.display_dieu_huong(v_us);
                load_data_2_grid();

            }
            catch (Exception v_e)
            {

                CSystemLog_100.ExceptionHandle(v_e);
            }
        }
        //load lại data sau mỗi một thời gian nào đó
        private void timer1_Tick(object sender, EventArgs e)
        {
            load_data_2_grid();
        }

        private void m_cmd_cap_nhat_TD_Click(object sender, EventArgs e)
        {
            try
            {
                decimal v_deadline = 0;
                DataRow v_dr = m_grv_gd_dat_hang_gd_log_dat_hang.GetDataRow(m_grv_gd_dat_hang_gd_log_dat_hang.FocusedRowHandle);
                US_GD_DAT_HANG v_us = new US_GD_DAT_HANG(CIPConvert.ToDecimal(v_dr["ID_DON_HANG"].ToString()));
                f100_don_dat_hang_new v_f100 = new f100_don_dat_hang_new();
                v_f100.displayForUpdate(v_us, v_deadline);
                load_data_2_grid();
            }
            catch (Exception v_e)
            {
                CSystemLog_100.ExceptionHandle(v_e);
            }
           
        }

        private void m_cmd_cap_nhat_PM_Click(object sender, EventArgs e)
        {
            try
            {
                decimal v_deadline = 0;
                DataRow v_dr = m_grv_gd_dat_hang_gd_log_dat_hang.GetDataRow(m_grv_gd_dat_hang_gd_log_dat_hang.FocusedRowHandle);
                US_GD_DAT_HANG v_us = new US_GD_DAT_HANG(CIPConvert.ToDecimal(v_dr["ID_DON_HANG"].ToString()));
                f100_don_dat_hang_new v_f100 = new f100_don_dat_hang_new();
                v_f100.displayForUpdate(v_us, v_deadline);
                load_data_2_grid();
            }
            catch (Exception v_e)
            {
                CSystemLog_100.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_cap_nhat_BO_Click(object sender, EventArgs e)
        {
            try
            {
                decimal v_deadline = 0;
                DataRow v_dr = m_grv_gd_dat_hang_gd_log_dat_hang.GetDataRow(m_grv_gd_dat_hang_gd_log_dat_hang.FocusedRowHandle);
                US_GD_DAT_HANG v_us = new US_GD_DAT_HANG(CIPConvert.ToDecimal(v_dr["ID_DON_HANG"].ToString()));
                f100_don_dat_hang_new v_f100 = new f100_don_dat_hang_new();
                v_f100.displayForUpdate(v_us, v_deadline);
                load_data_2_grid();
            }
            catch (Exception v_e)
            {
                CSystemLog_100.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_cap_nhat_xu_ly_Click(object sender, EventArgs e)
        {
            try
            {
                f101_cap_nhat_xu_don_hang v_f = new f101_cap_nhat_xu_don_hang();
                DataRow v_dr = m_grv_gd_dat_hang_gd_log_dat_hang.GetDataRow(m_grv_gd_dat_hang_gd_log_dat_hang.FocusedRowHandle);
                US_GD_DAT_HANG v_us = new US_GD_DAT_HANG(CIPConvert.ToDecimal(v_dr["ID_DON_HANG"].ToString()));
                v_f.Display_for_update(v_us);
                load_data_2_grid();
            }
            catch (Exception v_e)
            {
                CSystemLog_100.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_TD_cap_nhat_xu_ly_Click(object sender, EventArgs e)
        {
            try
            {
                f101_cap_nhat_xu_don_hang v_f = new f101_cap_nhat_xu_don_hang();
                DataRow v_dr = m_grv_gd_dat_hang_gd_log_dat_hang.GetDataRow(m_grv_gd_dat_hang_gd_log_dat_hang.FocusedRowHandle);
                US_GD_DAT_HANG v_us = new US_GD_DAT_HANG(CIPConvert.ToDecimal(v_dr["ID_DON_HANG"].ToString()));
                v_f.Display_for_update(v_us);
                load_data_2_grid();
            }
            catch (Exception v_e)
            {
                CSystemLog_100.ExceptionHandle(v_e);
            }
           
        }

        private void m_cmd_PM_cap_nhat_xu_ly_Click(object sender, EventArgs e)
        {
            try
            {
                f101_cap_nhat_xu_don_hang v_f = new f101_cap_nhat_xu_don_hang();
                DataRow v_dr = m_grv_gd_dat_hang_gd_log_dat_hang.GetDataRow(m_grv_gd_dat_hang_gd_log_dat_hang.FocusedRowHandle);
                US_GD_DAT_HANG v_us = new US_GD_DAT_HANG(CIPConvert.ToDecimal(v_dr["ID_DON_HANG"].ToString()));
                v_f.Display_for_update(v_us);
                load_data_2_grid();
            }
            catch (Exception v_e)
            {
                CSystemLog_100.ExceptionHandle(v_e);
            }
            
        }

        private void m_cmd_bo_chuyen_pm_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow v_dr = m_grv_gd_dat_hang_gd_log_dat_hang.GetDataRow(m_grv_gd_dat_hang_gd_log_dat_hang.FocusedRowHandle);
                US_V_GD_DAT_HANG_GD_LOG_DAT_HANG v_us = new US_V_GD_DAT_HANG_GD_LOG_DAT_HANG(CIPConvert.ToDecimal(v_dr["ID"].ToString()));
                f112_FO_chuyen_don_hang_cho_PM v_f = new f112_FO_chuyen_don_hang_cho_PM();
                v_f.displayForUpdate(v_us);
                load_data_2_grid();
            }
            catch (Exception v_e)
            {

                CSystemLog_100.ExceptionHandle(v_e);
            }
        }

        private void m_grv_gd_dat_hang_gd_log_dat_hang_DoubleClick(object sender, EventArgs e)
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
                DataRow v_dr = m_grv_gd_dat_hang_gd_log_dat_hang.GetDataRow(m_grv_gd_dat_hang_gd_log_dat_hang.FocusedRowHandle);
                US_GD_DAT_HANG v_us = new US_GD_DAT_HANG(CIPConvert.ToDecimal(v_dr["ID_DON_HANG"].ToString()));
                f100_don_dat_hang_new v_f100 = new f100_don_dat_hang_new();
                v_f100.displayForUpdate2(v_us);
                this.Show();
            }
        }


        private void m_grv_gd_dat_hang_gd_log_dat_hang_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            GridView view = sender as GridView;
            // Check whether a row is right-clicked.
            if (e.MenuType == DevExpress.XtraGrid.Views.Grid.GridMenuType.Row)
            {
                int rowHandle = e.HitInfo.RowHandle;
                // Delete existing menu items, if any.
                e.Menu.Items.Clear();
                // Add a submenu with a single menu item.
                e.Menu.Items.Add(WinFormControls.CreateRowSubMenu(view, rowHandle));
            }
        }
    
        private void m_cmd_TM_huy_hon_hang_Click(object sender, EventArgs e)
        {
            try
            {
                fill_data_to_m_us();
                f103_TD_ly_do_tu_choi f103 = new f103_TD_ly_do_tu_choi();
                US_GD_DAT_HANG v_us_gd_dat_hang = new US_GD_DAT_HANG(m_us.dcID_DON_HANG);
                f103.Display(v_us_gd_dat_hang);
                load_data_2_grid();     
            }
            catch (Exception v_e)
            {

                CSystemLog_100.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_TM_cap_nhat_xu_ly_Click(object sender, EventArgs e)
        {
            try
            {
                f101_cap_nhat_xu_don_hang v_f = new f101_cap_nhat_xu_don_hang();
                DataRow v_dr = m_grv_gd_dat_hang_gd_log_dat_hang.GetDataRow(m_grv_gd_dat_hang_gd_log_dat_hang.FocusedRowHandle);
                US_GD_DAT_HANG v_us = new US_GD_DAT_HANG(CIPConvert.ToDecimal(v_dr["ID_DON_HANG"].ToString()));
                v_f.Display_for_update(v_us);
                load_data_2_grid();
            }
            catch (Exception v_e)
            {
                CSystemLog_100.ExceptionHandle(v_e);
            }
           
        }

        private void m_cmd_FO_huy_hon_hang_Click(object sender, EventArgs e)
        {
            try
            {
                fill_data_to_m_us();
                f103_TD_ly_do_tu_choi f103 = new f103_TD_ly_do_tu_choi();
                US_GD_DAT_HANG v_us_gd_dat_hang = new US_GD_DAT_HANG(m_us.dcID_DON_HANG);
                f103.Display(v_us_gd_dat_hang);
                load_data_2_grid();
            }
            catch (Exception v_e)
            {

                CSystemLog_100.ExceptionHandle(v_e);
            }
        }

        private void m_grv_gd_dat_hang_gd_log_dat_hang_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }

        private void m_grv_gd_dat_hang_gd_log_dat_hang_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void m_grv_gd_dat_hang_gd_log_dat_hang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
                load_data_2_grid();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                fill_data_to_m_us();
                f103_TD_ly_do_tu_choi f103 = new f103_TD_ly_do_tu_choi();
                US_GD_DAT_HANG v_us_gd_dat_hang = new US_GD_DAT_HANG(m_us.dcID_DON_HANG);
                f103.DisplayForRemoveDP(v_us_gd_dat_hang);
                load_data_2_grid();
            }
            catch (Exception v_e)
            {

                CSystemLog_100.ExceptionHandle(v_e);
            }
        }


        private void btnRefresh_Click(object sender, EventArgs e)
        {
            load_data_2_grid();
        }

    }
}
