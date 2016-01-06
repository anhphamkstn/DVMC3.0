using IP.Core.IPCommon;
using IPCOREUS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using WEB_DVMC.hethong;

namespace WEB_DVMC
{
    /// <summary>
    /// Summary description for nghiep_vu_bo
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class nghiep_vu_bo : System.Web.Services.WebService
    {

        [WebMethod]
        public void bo_tiep_nhan(decimal id_don_hang, decimal user_id, string user_name, decimal id_nhom)
        {

            update_log_tiep_nhan(id_don_hang, user_id, id_nhom);
            ghi_log_da_nhan_xu_ly(id_don_hang, user_id, user_name);
        }

        private void ghi_log_da_nhan_xu_ly(decimal id_don_hang, decimal user_id, string user_name)
        {
            US_GD_LOG_DAT_HANG v_us = new US_GD_LOG_DAT_HANG();
            v_us.dcID_LOAI_THAO_TAC = 296;
            v_us.dcID_GD_DAT_HANG = id_don_hang;
            v_us.dcID_NGUOI_TAO_THAO_TAC = user_id;
            v_us.dcID_NGUOI_NHAN_THAO_TAC = user_id;
            v_us.datNGAY_LAP_THAO_TAC = System.DateTime.Now;
            v_us.strTHAO_TAC_HET_HAN_YN = "N";
            v_us.strGHI_CHU = user_name + " đã nhận xử lý";
            v_us.Insert();
        }

        private void update_log_tiep_nhan(decimal id_don_hang, decimal user_id, decimal id_nhom)
        {
            US_GD_LOG_DAT_HANG v_US = new US_GD_LOG_DAT_HANG();
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            if (id_nhom == 2)
            {
                v_us.FillDatasetWithQuery(v_ds, "SELECT *FROM GD_LOG_DAT_HANG WHERE ID_GD_DAT_HANG =" + id_don_hang + "And ID_LOAI_THAO_TAC in (295,311) And THAO_TAC_HET_HAN_YN = 'N' AND ID_NGUOI_NHAN_THAO_TAC = " + user_id);
            }
            else if (id_nhom == 3)
            {
                v_us.FillDatasetWithQuery(v_ds, "SELECT *FROM GD_LOG_DAT_HANG WHERE ID_GD_DAT_HANG =" + id_don_hang + "And ID_LOAI_THAO_TAC in (303) And THAO_TAC_HET_HAN_YN = 'N' AND ID_NGUOI_NHAN_THAO_TAC = " + user_id);
            }
            else if (id_nhom == 5)
            {
                v_us.FillDatasetWithQuery(v_ds, "SELECT *FROM GD_LOG_DAT_HANG WHERE ID_GD_DAT_HANG =" + id_don_hang + "And ID_LOAI_THAO_TAC in (305) And THAO_TAC_HET_HAN_YN = 'N' AND ID_NGUOI_NHAN_THAO_TAC = " + user_id);
            }
            for (int i = 0; i < v_ds.Tables[0].Rows.Count; i++)
            {
                v_US = new US_GD_LOG_DAT_HANG(CIPConvert.ToDecimal(v_ds.Tables[0].Rows[i][0].ToString()));
                v_US.strTHAO_TAC_HET_HAN_YN = "Y";
                v_US.Update();
            }
        }


        [WebMethod]
        public void tu_choi_xu_ly(decimal id_log, string m_li_do)
        {
            decimal id_nguoi_tao;
            try
            {
                US_V_GD_DAT_HANG_GD_LOG_DAT_HANG m_us = new US_V_GD_DAT_HANG_GD_LOG_DAT_HANG(id_log);
                if (m_us.dcID_LOAI_THAO_TAC == 313)
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
                ghi_log_tu_choi(m_us, m_li_do);
                update_log(id_log);
            }
            catch (Exception ex)
            {

            }
        }
        [WebMethod]
        public void bao_da_xu_ly(decimal id_log, decimal id_don_hang, decimal user_id , string user_name)
        {
            update_log(id_log);
            ghi_log_da_hoan_thanh_don_hang_BO(id_don_hang,user_id,user_name);
        }

        private void ghi_log_da_hoan_thanh_don_hang_BO(decimal id_don_hang,decimal id_user, string user_name)
        {
            US_GD_LOG_DAT_HANG v_us = new US_GD_LOG_DAT_HANG();
            v_us.dcID_LOAI_THAO_TAC = 297;//BO đã xử lý
            v_us.dcID_GD_DAT_HANG = id_don_hang;
            v_us.dcID_NGUOI_TAO_THAO_TAC = id_user;
            v_us.dcID_NGUOI_NHAN_THAO_TAC = id_user;
            v_us.datNGAY_LAP_THAO_TAC = System.DateTime.Now;
            v_us.strTHAO_TAC_HET_HAN_YN = "N";
            v_us.strGHI_CHU = user_name + " đã xử lý xong! chờ TM nghiệm thu";
            v_us.Insert();
        }

        

        private void update_log(decimal id_log)
        {
            US_GD_LOG_DAT_HANG v_us_tu_choi = new US_GD_LOG_DAT_HANG(id_log);
            v_us_tu_choi.strTHAO_TAC_HET_HAN_YN = "Y";
            //v_us_tu_choi.strGHI_CHU = "BO đã từ chối";
            v_us_tu_choi.Update();
        }

        private void ghi_log_tu_choi(US_V_GD_DAT_HANG_GD_LOG_DAT_HANG v_us, string reason)
        {
            US_GD_LOG_DAT_HANG v_US = new US_GD_LOG_DAT_HANG();
            v_US.dcID_LOAI_THAO_TAC = 310;//CHỜ FO điều phối lại
            v_US.dcID_GD_DAT_HANG = v_us.dcID_DON_HANG;
            v_US.dcID_NGUOI_TAO_THAO_TAC = v_us.dcID_NGUOI_NHAN_THAO_TAC;
            v_US.dcID_NGUOI_NHAN_THAO_TAC = CIPConvert.ToDecimal(v_us.dcID_NGUOI_TAO);
            v_US.datNGAY_LAP_THAO_TAC = System.DateTime.Now;
            v_US.strTHAO_TAC_HET_HAN_YN = "N";
            v_US.strGHI_CHU = v_us.strTEN_NGUOI_NHAN_THAO_TAC + " đã từ chối với lý do " + reason;
            v_US.Insert();
        }

        [WebMethod]
        public void cap_nhat_xu_ly(decimal id_don_hang, string m_li_do, decimal user_id)
        {
            US_GD_LOG_DAT_HANG v_us = new US_GD_LOG_DAT_HANG();
            v_us.datNGAY_LAP_THAO_TAC = System.DateTime.Now;
            v_us.dcID_GD_DAT_HANG = id_don_hang;
            v_us.dcID_LOAI_THAO_TAC = 344;
            v_us.dcID_NGUOI_NHAN_THAO_TAC = user_id;
            v_us.dcID_NGUOI_TAO_THAO_TAC = user_id;
            v_us.strTHAO_TAC_HET_HAN_YN = "Y";
            v_us.strGHI_CHU = m_li_do;
            v_us.Insert();
           
        }

        [WebMethod]
        public void bo_chuyen_pm(decimal id_log, string m_li_do, decimal user_id, decimal pm_id, decimal id_don_hang)
        {
            update_log_gui_cho_pm(id_log,user_id);
            insert_log_gui_cho_pm(id_don_hang,pm_id,m_li_do);
          //  us_user.gui_mail_thong_bao_chuyen_don_hang(m_us, us_user.dcID, pm_id);
        }

        private void update_log_gui_cho_pm(decimal id, decimal user_id)
        {
            US_GD_LOG_DAT_HANG v_US = new US_GD_LOG_DAT_HANG(id);
            if (us_user.dcIDNhom == 1)
            {
                US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
                DataSet v_ds = new DataSet();
                v_ds.Tables.Add(new DataTable());
                v_us.FillDatasetWithQuery(v_ds, "SELECT *FROM GD_LOG_DAT_HANG WHERE ID_GD_DAT_HANG =" + v_US.dcID_GD_DAT_HANG.ToString() + "AND ID_LOAI_THAO_TAC in(310,313) AND THAO_TAC_HET_HAN_YN = 'N'");
                for (int i = 0; i < v_ds.Tables[0].Rows.Count; i++)
                {
                    v_US = new US_GD_LOG_DAT_HANG(CIPConvert.ToDecimal(v_ds.Tables[0].Rows[i][0].ToString()));
                    v_US.strTHAO_TAC_HET_HAN_YN = "Y";
                    v_US.Update();
                }
            }
            else if (us_user.dcIDNhom == 2)
            {
                v_US.strTHAO_TAC_HET_HAN_YN = "Y";
                v_US.Update();
            }

        }

        private void insert_log_gui_cho_pm(decimal id_don_hang,decimal id_pm, string str_gui_kem)
        {
            US_DUNG_CHUNG v_us_dc = new US_DUNG_CHUNG();
            US_GD_LOG_DAT_HANG v_US = new US_GD_LOG_DAT_HANG();
            v_US.dcID_LOAI_THAO_TAC = 303;//đã chuyển cho PM
            v_US.dcID_GD_DAT_HANG = id_don_hang;
            v_US.dcID_NGUOI_TAO_THAO_TAC = us_user.dcID;
            v_US.dcID_NGUOI_NHAN_THAO_TAC = id_pm;
            v_US.datNGAY_LAP_THAO_TAC = System.DateTime.Now;
            v_US.strTHAO_TAC_HET_HAN_YN = "N";
            v_US.strGHI_CHU = us_user.strTEN_TRUY_CAP + " gửi đơn hàng cho PM " + v_us_dc.get_ten_nguoi_su_dung(id_pm) + ", gửi kèm:  " + str_gui_kem;
            v_US.Insert();
        }
      

    }
}
