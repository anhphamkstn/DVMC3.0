
using System;
using System.Collections.Generic;
using System.Text;
using IPCOREDS;
using System.Configuration;

namespace IPCOREDS.CDBNames
{
    public class WEB_URL_CALL_CENTER
    {
        /// <summary>
        /// Service này dùng để khai báo: user nào đã có thể nghe đc cuộc gọi và sử dụng ipphone nào
        /// </summary>
        /// <param name="extension">Mã của IPPhone</param>
        /// <param name="agentCode">Username</param>
        /// <param name="queueName">Kho QUEUE</param>
        /// <returns></returns>
        public static string ADD_VAO_QUEUE_GOI(string extension, string agentCode, string queueName)
        {
            return "JoinQueue&extension=" + extension + "&agentCode=" + agentCode + "&queueName=" + queueName;
        }

        /// <summary>
        /// Hàm này dùng để thông báo: user nào đó ko thể nghe tiếp cuộc gọi nữa; ipphone đó cũng ko thể nghe đc cuộc gọi nữa
        /// </summary>
        /// <param name="extension">Mã của IPPhone</param>
        /// <param name="agentCode">Username</param>
        /// <param name="queueName">Kho QUEUE</param>
        public static string REMOVE_KHOI_QUEUE_GOI(string extension, string agentCode, string queueName)
        {
            return "RemoveQueue&extension=" + extension + "&agentCode=" + agentCode + "&queueName=" + queueName;
        }

        /// <summary>
        /// Hàm này dùng để nói: người nào đó tạm thời chưa nghe đc cuộc gọi
        /// </summary>
        public static string PAUSE_AGENT(string extension, string agentCode)
        {
            return "Pause&extension=" + extension + "&agentCode=" + agentCode + "&pauseCode=11";
        }

        /// <summary>
        /// Khai báo: người nào đó và máy nào đó tiếp tục nhận đc cuộc gọi
        /// </summary>
        public static string UNPAUSE_AGENT(string extension, string agentCode)
        {
            return "UnPause&extension=" + extension + "&agentCode=" + agentCode;
        }

        public const string GET_QUEUE_MEMS = "GetQueueMembers";

        public const string GET_REALTIME_LIST = "GetRealTimeList";

        /// <summary>
        /// Hàm này dùng để đăng ký phiên làm việc: người dùng nào đó sẽ dùng máy với IP nào? (máy cài phần mềm)
        /// </summary>
        public static string REGISTER_IP(string extension, string ipAddress)
        {
            return "Register&extension=" + extension + "&ipAddress=" + ipAddress;
        }

        /// <summary>
        /// Hàm này dùng để hủy đăng ký phiên làm việc, nghe máy cho IPPhone nào đó
        /// </summary>
        public static string UNREGISTER_IP(string extension)
        {
            return "UnRegister&extension=" + extension;
        }

        /// <summary>
        /// Hàm này dùng để get thông tin cuộc gọi dưa
        /// </summary>
        public static string GET_CALL_INFOR(string callid)
        {
            return "GetCallInfo&callID=" + callid;
        }
        public static string GET_CALL_INFOR_OVERTIME(string callid)
        {
            return "GetOutOfServiceCallInfo&callID=" + callid;
        }
        /// <summary>
        /// Hàm này dùng để add or remove blacklist
        /// ip_code = 10: add; 20: remove
        /// </summary>
        public static string ADD_REMOVE_BLACKLIST(string ip_dienthoai, int ip_code)
        {
            if(ip_code == 10)
                return "AddBlackList&phoneNum=" + ip_dienthoai;
            
            return "RemoveBlackList&phoneNum=" + ip_dienthoai;
        }

        /// <summary>
        /// Hàm này dùng để get imcomming call cho extention
        /// ip_extention là mã máy điện thoại
        /// </summary>
        public static string GET_INCOMING_CALL(string ip_extention)
        {
            return "GetIncomingCall&extension=" + ip_extention;
        }
    }
    public class C_TU_DIEN_NHOM_NGUOI_DUNG
    {
        public const decimal QUAN_TRI_HE_THONG = 100;
        public const decimal NHAP_HO_SO_HN = 105;
        public const decimal NHAP_LIEU_CVHT_HN = 481146;
    }
    public class THOI_DIEM_GOI
    {
        public const decimal GOI_BAN_NGAY = 0;
        public const decimal GOI_BUOI_TOI = 1;
    }
    public class TRANG_THAI_GOI_WS
    {
        public const string THANH_CONG = "Success";
        public const string THAT_BAI = "Failed";
    }
    public class RUN_MODE
    {
        public const string DEVELOP = "DEVELOP";
        public const string RELEASE = "RELEASE";
    }
    public class MAU_EMAIL
    {
        public const string XAC_NHAN_YC = "XAC_NHAN_YC";
        public const string HOAN_THANH_YC = "HOAN_THANH_YC";
        public const string CAP_NHAT_YC = "CAP_NHAT_YC";
    }
    public class TU_DIEN_TRANG_THAI_DON_HANG
    {
        public const decimal DANG_CHO_GQ = 54;
        public const decimal DA_DONG = 55;
        public const decimal DA_HUY = 56;
    }
    public class NGUOI_DUNG_SCM
    {
        public const string ID = "ID";
        public const string TEN_THAT = "TEN_THAT";
        public const string TEN_TRUY_CAP = "TEN_TRUY_CAP";
        public const string TRANG_THAI_NGUOI_SU_DUNG = "TRANG_THAI_NGUOI_SU_DUNG";
        public const string ID_NHOM_NGUOI_SU_DUNG = "ID_NHOM_NGUOI_SU_DUNG";
    }
    public class TU_DIEN_TRANG_THAI_GD_CAU_HOI_SV
    {
        public const decimal CHO_TRA_LOI = 59;
        public const decimal DA_TRA_LOI = 96;
        public const decimal DA_ASSIGNED = 150;
    }

    public class TU_DIEN_TRANG_THAI_DM_CAU_TRA_LOI
    {
        public const decimal DA_NHAP = 21;
        public const decimal DA_DUYET = 22;
    }
    public class TU_DIEN_TRANG_THAI_USER_IPPHONE
    {
        public const decimal DANG_DUNG = 159;
        public const decimal DA_KHOA = 160;
    }
    public class TU_DIEN_XU_LU_NB
    {
        public const decimal GOI_DIEN = 148;
        public const decimal ASSIGN = 149;
    }
    public class THAM_SO_HE_THONG_ID
    {
        public const decimal WEB_CALL_URL = 1;
        public const decimal WEB_RECORDS = 2;
        public const decimal GET_INCOMING_CALL = 3;
        public const decimal VER_MAINFORM = 4;
        public const decimal EMAIL_DVMC = 5;
        public const decimal PASSWORD_DVMC = 6;
        public const decimal URL_VIEW_YC = 7;
        public const decimal URL_HOAN_THANH = 8;
        public const decimal CHU_KY = 9;
    }
    public class ID_HANG_DANH_GIA
    {
        public const decimal RAT_HAI_LONG = 123;
        public const decimal HAI_LONG = 124;
        public const decimal XONG_VIEC = 125;
        public const decimal HOI_DUOI = 126;
        public const decimal KHONG_DAT = 127;
    }
    public class LOAI_TU_DIEN_ID
    {
        public const decimal PHAN_QUYEN = 1;
        public const decimal TRANG_THAI_DM_CAU_TRA_LOI = 2;
        public const decimal TRANG_THAI_GD_YEU_CAU = 3;
        public const decimal TRANG_THAI_GD_CAU_HOI_SV = 4;
        public const decimal NHOM_CAU_HOI = 5;
        public const decimal HANG_DANH_GIA = 8;
        public const decimal LOG_LOAI_HANH_DONG = 10;
        public const decimal TO_CHUC_TRUONG = 11;
        public const decimal PHONG_BAN_NOI_BO = 12;
        public const decimal XU_LU_NB = 13;
        public const decimal TRANG_THAI_IPPHONE = 14;
        public const decimal IPPHONE = 15;        
    }
    public class LOAI_DICH_VU_ID
    {
        public const decimal TC_TT_TAM_UNG = 186;
        public const decimal TL_IN_AN_VPP = 187;
        public const decimal PR_THIET_KE = 188;
        public const decimal MAY_MOC_CSVC = 189;
        public const decimal AN_UONG_AN_CA = 190;
        public const decimal DI_CONG_TAC = 192;
        public const decimal NGHI_OM_TS = 194;
        public const decimal NV_MOI_CHUAN_BI = 195;
        public const decimal NGAY_DAU_DI_LAM = 196;
        public const decimal TUAN_DAU_DI_LAM = 197;
        public const decimal THANG_DAU_DL = 199;
    }
    public class LOAI_THOI_GIAN_HOAN_THANH_ID
    {
        public const decimal MUOI_LAM_PHUT_15 = 200;
        public const decimal BON_GIO_4h = 201;
        public const decimal MOT_NGAY_1ngay = 202;
        public const decimal MOT_TUAN_1tuan = 203;
        public const decimal MOT_THANG_1thang = 204;
    }
    public class THONG_BAO
    {
        public const int ER_DU_LIEU_CAN_CAP_NHAT = 1;
        public const int ER_KHONG_CO_QUYEN_SU_DUNG = 5;
        public const int WN_CHUA_THUC_HIEN_CUOC_GOI = 11;
        public const int SC_XUAT_CHUNG_CHI = 30;
        public const int SC_DUYET_TOAN_BO_CHUNG_CHI = 13;
        public const int SC_CAP_NHAT = 15;
        public const int ER_KHONG_JOIN_QUEUE_DUOC = 16;
        public const int ER_KHONG_REGISTER_DUOC = 17;
        public const int ER_KHONG_ADD_BLACKLIST_DUOC = 31;
        public const int ER_KO_UNPAUSE_DUOC = 32;
        public const int ER_KO_PAUSE_DUOC = 33;
        public const int SC_PAUSE_THANH_CONG = 21;
        public const int ER_GHI_LOG_HE_THONG = 22;
        public const int SC_THEM_NGUOI_DAI_DIEN = 23;
        public const int SC_SUA_NGUOI_DAI_DIEN = 24;
        public const int SC_DUYET_THONG_TIN_PHOI = 25;
        public const int SC_THEM_CAU_HOI = 26;
        public const int SC_SUA_CAU_HOI = 27;
        public const int SC_DUYET_CAU_TRA_LOI = 28;
        public const int SC_THEM_CAU_TRA_LOI = 29;
        public const int SC_UNPAUSE_THANH_CONG = 30;
        public const int ER_REMOVE_BLACKLIST_KO_THANH_CONG = 34;
        public const int SC_ADD_BLACKLIST_THANH_CONG = 35;
        public const int ER_DU_LIEU_TREN_LUOI_KO_DC_TRONG = 36;
        public const int SC_LOAD_FILE_EXCEL = 37;
        public const int ER_COT_STT_DE_TRONG = 38;
        public const int ER_CHUA_LOAD_FILE_EXCEL = 39;
        public const int SC_KIEM_TRA_DU_LIEU = 40;
        public const int ER_TON_TAI_DL_KO_HOP_LE = 41;
        public const int SC_REMOVE_BLACKLIST_THANH_CONG = 42;
        public const int CF_ADD_BLACKLIST = 43;
        public const int CF_REMOVE_BLACKLIST = 44;
    }

    public class HT_PHAN_QUYEN_HE_THONG
    {
        public const string ID = "ID";
        public const string MA_PHAN_QUYEN = "MA_PHAN_QUYEN";
        public const string GHI_CHU = "GHI_CHU";
        public const string LOAI_PHAN_QUYEN = "LOAI_PHAN_QUYEN";
    }
    public class HT_PHAN_QUYEN_CHO_NHOM
    {
        public const string ID = "ID";
        public const string ID_NHOM_NGUOI_SU_DUNG = "ID_NHOM_NGUOI_SU_DUNG";
        public const string ID_PHAN_QUYEN_HE_THONG = "ID_PHAN_QUYEN_HE_THONG";
    }
    public class HT_NHOM_NGUOI_SU_DUNG
    {
        public const string ID = "ID";
        public const string MA_NHOM = "MA_NHOM";
        public const string GHI_CHU = "GHI_CHU";
        public const string TRANG_THAI_NHOM = "TRANG_THAI_NHOM";
        public const string ID_INPUTED_BY = "ID_INPUTED_BY";
        public const string INPUTED_DATE = "INPUTED_DATE";
        public const string ID_LAST_UPDATED_BY = "ID_LAST_UPDATED_BY";
        public const string LAS_UPDATED_DATE = "LAS_UPDATED_DATE";
    }
    public class LOAI_TU_DIEN_TEXT
    {
        public const string LOG_LOAI_HANH_DONG = "LOG_LOAI_HANH_DONG";
        public const string TRANG_THAI_DON_HANG = "TRANG_THAI_DON_HANG";
        public const string TRANG_THAI_DM_CAU_TRA_LOI = "TRANG_THAI_DM_CAU_TRA_LOI";
        public const string TRANG_THAI_GD_CAU_HOI_SV = "TRANG_THAI_GD_CAU_HOI_SV";
        public const string NHOM_CAU_HOI = "NHOM_CAU_HOI";
        public const string HANG_DANH_GIA = "HANG_DANH_GIA";
        public const string TO_CHUC_TRUONG = "TO_CHUC_TRUONG";
        public const string PHONG_BAN_NOI_BO = "PHONG_BAN_NB";
        public const string XU_LU_NB = "XU_LU_NB";
        public const string TRANG_THAI_IPPHONE = "TRANG_THAI_IPPHONE";
        public const string IPPHONE = "IPPHONE";
        public const string LOAI_DICH_VU_YEU_CAU = "LOAI_DICH_VU_YEU_CAU";
        public const string LOAI_TG_HOAN_THANH = "LOAI_TG_HOAN_THANH";
    }
    public class LOG_DOI_TUONG_TAC_DONG
    {
        public const string DANG_NHAP_XUAT = "";
        public const string DM_TU_DIEN = "Danh mục từ điển";
        public const string HT_NGUOI_SU_DUNG = "Người sử dụng";
        public const string HT_THAM_SO_HE_THONG = "Tham số hệ thống";
        public const string HT_NHOM_NGUOI_SU_DUNG = "Nhóm người dùng";
        public const string DM_CAU_HOI = "Danh mục câu hỏi";
        public const string DM_CAU_TRA_LOI = "Danh mục câu trả lời";
        public const string DM_NGUOI_DAI_DIEN = "Danh mục người đại diện";
        public const string GD_CAU_HOI_HOC_VIEN = "Giao dịch câu hỏi của học viên";
        public const string GD_CUOC_GOI_YEU_CAU = "Giao dịch cuộc gọi của học viên";
        public const string GD_XU_LY_NOI_BO = "Giao dịch xử lý nội bộ";
    }

    public class LOG_TRUY_CAP
    {
        public const decimal DANG_NHAP = 69;
        public const decimal DANG_XUAT = 70;
        public const decimal THEM = 71;
        public const decimal SUA = 72;
        public const decimal XOA = 73;
        public const decimal DUYET = 74;
        public const decimal IMPORT = 80;
        public const decimal HOC_VIEN_GOI_DEN = 144;
        public const decimal USER_GOI_NOI_BO = 145;
        public const decimal USER_GOI_CHO_HOC_VIEN = 146;
        public const decimal ADD_VAO_QUEUE = 151;
        public const decimal REMOVE_QUEUE = 154;
        public const decimal PAUSE_AGENT = 155;
        public const decimal UNPAUSE_AGENT = 156;
        public const decimal REGISTER_IP = 157;
        public const decimal UNREGISTER_IP = 158;
        public const decimal LOI_HE_THONG = 164;
        public const decimal ADD_BLACKLIST = 165;
        public const decimal REMOVE_BLACKLIST = 167;
        public const decimal ASSIGN_QLHT = 169;

    }

    public class CM_DM_LOAI_TD
    {
        public const string ID = "ID";
        public const string MA_LOAI = "MA_LOAI";
        public const string TEN_LOAI = "TEN_LOAI";
    }
    public class CM_DM_TU_DIEN
    {
        public const string ID = "ID";
        public const string MA_TU_DIEN = "MA_TU_DIEN";
        public const string ID_LOAI_TU_DIEN = "ID_LOAI_TU_DIEN";
        public const string TEN_NGAN = "TEN_NGAN";
        public const string TEN = "TEN";
        public const string GHI_CHU = "GHI_CHU";
    }
    public class DM_COMPANY_INFO
    {
        public const string ID = "ID";
        public const string SHORT_NAME = "SHORT_NAME";
        public const string FULL_NAME = "FULL_NAME";
        public const string ADDRESS = "ADDRESS";
        public const string MOBLIE = "MOBLIE";
        public const string EMAIL = "EMAIL";
        public const string TAX_CODE = "TAX_CODE";
    }
    public class DOC_COLUMN_COMMENT
    {
        public const string COLUMN_NAME = "COLUMN_NAME";
        public const string TABLE_NAME = "TABLE_NAME";
        public const string COLUMN_COMMENT = "COLUMN_COMMENT";
    }
    public class DOC_TABLE_COMMENT
    {
        public const string TABLE_NAME = "TABLE_NAME";
        public const string TABLE_COMMENT = "TABLE_COMMENT";
    }

    public class HT_BACKUP_HISTORY
    {
        public const string ID = "ID";
        public const string NGUOI_BACKUP = "NGUOI_BACKUP";
        public const string NGAY_BACKUP = "NGAY_BACKUP";
        public const string NOI_LUU = "NOI_LUU";
        public const string TEN_FILE = "TEN_FILE";
        public const string GhI_CHU = "GhI_CHU";
    }
    public class HT_BUSINESS_PROCESS_LOCK
    {
        public const string LOCK_NAME = "LOCK_NAME";
        public const string GRANTED_SYS_DATETIME = "GRANTED_SYS_DATETIME";
    }
    public class HT_NGUOI_SU_DUNG
    {
        public const string ID = "ID";
        public const string TEN_TRUY_CAP = "TEN_TRUY_CAP";
        public const string TEN = "TEN";
        public const string MAT_KHAU = "MAT_KHAU";
        public const string NGAY_TAO = "NGAY_TAO";
        public const string NGUOI_TAO = "NGUOI_TAO";
        public const string TRANG_THAI = "TRANG_THAI";
        public const string EMAIL = "EMAIL";
        public const string MAT_KHAU_EMAIL = "MAT_KHAU_EMAIL";
    }

    public class HT_QUYEN_USER
    {
        public const string ID = "ID";
        public const string ID_USER = "ID_USER";
        public const string ID_QUYEN = "ID_QUYEN";
    }
    public class HT_THAM_SO_HE_THONG
    {
        public const string ID = "ID";
        public const string LOAI_THAM_SO = "LOAI_THAM_SO";
        public const string MA_THAM_SO = "MA_THAM_SO";
        public const string PHAN_HE = "PHAN_HE";
        public const string GHI_CHU = "GHI_CHU";
        public const string KIEU_DU_LIEU = "KIEU_DU_LIEU";
        public const string GIA_TRI = "GIA_TRI";
        public const string CO_THE_NULL_YN = "CO_THE_NULL_YN";
    }
    public class RPT_NHAC_VIEC
    {
        public const string ID = "ID";
        public const string ID_NGUOI_XEM = "ID_NGUOI_XEM";
        public const string NGAY = "NGAY";
        public const string TEN_TRAI_PHIEU = "TEN_TRAI_PHIEU";
        public const string NOI_DUNG_NHAC = "NOI_DUNG_NHAC";
    }
    public class UT_SEQUENCES
    {
        public const string SEQ_NAME = "SEQ_NAME";
        public const string SEQ_VALUE = "SEQ_VALUE";
    }
    public class HT_LOG_API_CALL_CENTER
    {
        public const string ID = "ID";
        public const string ID_DANG_NHAP = "ID_DANG_NHAP";
        public const string THOI_GIAN = "THOI_GIAN";
        public const string MO_TA = "MO_TA";
        public const string GHI_CHU = "GHI_CHU";
    }


    public class V_DM_CAU_TRA_LOI
    {
        public const string ID = "ID";
        public const string ID_CAU_HOI = "ID_CAU_HOI";
        public const string NOI_DUNG_CAU_HOI = "NOI_DUNG_CAU_HOI";
        public const string CAU_TRA_LOI = "CAU_TRA_LOI";
        public const string NGUOI_TAO = "NGUOI_TAO";
        public const string TEN_NGUOI_TAO = "TEN_NGUOI_TAO";
        public const string NGAY_TAO = "NGAY_TAO";
        public const string ID_TRANG_THAI = "ID_TRANG_THAI";
        public const string TRANG_THAI = "TRANG_THAI";
        public const string LINK_TL_THAM_KHAO = "LINK_TL_THAM_KHAO";
    }
    public class V_DM_NGUOI_DAI_DIEN
    {
        public const string ID = "ID";
        public const string ID_DON_VI = "ID_DON_VI";
        public const string TEN_DON_VI = "TEN_DON_VI";
        public const string NDD_HO_TEN = "NDD_HO_TEN";
        public const string NDD_DIEN_THOAI = "NDD_DIEN_THOAI";
        public const string NDD_EMAIL = "NDD_EMAIL";
        public const string NDD_CHUC_VU = "NDD_CHUC_VU";
    }
    public class DM_CAU_HOI
    {
        public const string ID = "ID";
        public const string ID_TO_CHUC = "ID_TO_CHUC";
        public const string ID_NHOM_CAU_HOI = "ID_NHOM_CAU_HOI";
        public const string NOI_DUNG_CAU_HOI = "NOI_DUNG_CAU_HOI";
        public const string NGAY_TAO = "NGAY_TAO";
        public const string NGUOI_TAO = "NGUOI_TAO";
        public const string NGAY_CAP_NHAP_CUOI = "NGAY_CAP_NHAP_CUOI";
        public const string NGUOI_CAP_NHAT_CUOI = "NGUOI_CAP_NHAT_CUOI";
    }

    public class DM_NGUOI_DUNG_STATION
    {
        public const string ID = "ID";
        public const string ID_NGUOI_DUNG = "ID_NGUOI_DUNG";
        public const string STATION_CODE = "STATION_CODE";
    }
    public class V_DM_CAU_HOI
    {
        public const string ID = "ID";
        public const string ID_TO_CHUC = "ID_TO_CHUC";
        public const string ID_NHOM_CAU_HOI = "ID_NHOM_CAU_HOI";
        public const string NOI_DUNG_CAU_HOI = "NOI_DUNG_CAU_HOI";
        public const string NGAY_TAO = "NGAY_TAO";
        public const string NGUOI_TAO = "NGUOI_TAO";
        public const string NGAY_CAP_NHAP_CUOI = "NGAY_CAP_NHAP_CUOI";
        public const string NGUOI_CAP_NHAT_CUOI = "NGUOI_CAP_NHAT_CUOI";
        public const string CAU_TRA_LOI = "CAU_TRA_LOI";
        public const string ID_TRANG_THAI_CAU_TRA_LOI = "ID_TRANG_THAI_CAU_TRA_LOI";
        public const string LINK_TL_THAM_KHAO = "LINK_TL_THAM_KHAO";
        public const string TEN_TO_CHUC = "TEN_TO_CHUC";
        public const string TEN_NHOM_CAU_HOI = "TEN_NHOM_CAU_HOI";
        public const string TEN_NGUOI_TAO = "TEN_NGUOI_TAO";
        public const string TEN_NGUOI_CAP_NHAT_CUOI = "TEN_NGUOI_CAP_NHAT_CUOI";
    }

    public class V_DM_CAU_HOI_KO_TRA_LOI
    {
        public const string ID = "ID";
        public const string ID_TO_CHUC = "ID_TO_CHUC";
        public const string ID_NHOM_CAU_HOI = "ID_NHOM_CAU_HOI";
        public const string NOI_DUNG_CAU_HOI = "NOI_DUNG_CAU_HOI";
        public const string NGAY_TAO = "NGAY_TAO";
        public const string NGUOI_TAO = "NGUOI_TAO";
        public const string NGAY_CAP_NHAP_CUOI = "NGAY_CAP_NHAP_CUOI";
        public const string NGUOI_CAP_NHAT_CUOI = "NGUOI_CAP_NHAT_CUOI";
        public const string TEN_TO_CHUC = "TEN_TO_CHUC";
        public const string TEN_NHOM_CAU_HOI = "TEN_NHOM_CAU_HOI";
        public const string TEN_NGUOI_TAO = "TEN_NGUOI_TAO";
        public const string TEN_NGUOI_CAP_NHAT_CUOI = "TEN_NGUOI_CAP_NHAT_CUOI";
    }
    public class V_GD_CAU_HOI_YEU_CAU
    {
        public const string ID = "ID";
        public const string ID_YEU_CAU = "ID_YEU_CAU";
        public const string ID_LOAI_CAU_HOI = "ID_LOAI_CAU_HOI";
        public const string ID_CAU_HOI = "ID_CAU_HOI";
        public const string NOI_DUNG_CAU_HOI = "NOI_DUNG_CAU_HOI";
        public const string ID_NGUOI_TRA_LOI = "ID_NGUOI_TRA_LOI";
        public const string NOI_DUNG_TRA_LOI = "NOI_DUNG_TRA_LOI";
        public const string ID_TRANG_THAI = "ID_TRANG_THAI";
        public const string THOI_DIEM_HEN_GOI_LAI = "THOI_DIEM_HEN_GOI_LAI";
        public const string GHI_CHU_LICH_HEN = "GHI_CHU_LICH_HEN";
        public const string ID_DANH_GIA = "ID_DANH_GIA";
        public const string GHI_CHU_Y_KIEN_KHAC = "GHI_CHU_Y_KIEN_KHAC";
        public const string GHI_CHU = "GHI_CHU";
        public const string GHI_CHU2 = "GHI_CHU2";
        public const string HO_TEN_SINH_VIEN = "HO_TEN_SINH_VIEN";
        public const string SO_DIEN_THOAI = "SO_DIEN_THOAI";
        public const string MA_SINH_VIEN = "MA_SINH_VIEN";
        public const string NGAY_SINH = "NGAY_SINH";
        public const string NOI_SINH = "NOI_SINH";
        public const string LOP = "LOP";
        public const string TRUONG = "TRUONG";
        public const string Nguoi_goi = "Nguoi_goi";
        public const string CUOC_GOI_VAO_YN = "CUOC_GOI_VAO_YN";
        public const string ID_CUOC_GOI_LIEN_QUAN = "ID_CUOC_GOI_LIEN_QUAN";
        public const string ID_CAU_HOI_LIEN_QUAN = "ID_CAU_HOI_LIEN_QUAN";
        public const string ID_TRANG_THAI_CUOC_GOI = "ID_TRANG_THAI_CUOC_GOI";
        public const string TEN_TRUY_CAP = "TEN_TRUY_CAP";
        public const string TEN = "TEN";
        public const string START_TIME = "START_TIME";
        public const string TRANG_THAI_CAU_HOI = "TRANG_THAI_CAU_HOI";
        public const string HO_TEN_QLHT = "HO_TEN_QLHT";
        public const string DIEN_THOAI_QLHT = "DIEN_THOAI_QLHT";
        public const string THOI_GIAN_QLHT_TRA_LOI = "THOI_GIAN_QLHT_TRA_LOI";
        public const string ASSIGN_QLHT_YN = "ASSIGN_QLHT_YN";
    }

    public class CSinhVien
    {
        public const string ID_HOC_VIEN = "id_hoc_vien";
        public const string MA_HOC_VIEN = "ma_hoc_vien";
        public const string HO_VA_DEM = "ho_va_dem";
        public const string TEN_HOC_VIEN = "ten_hoc_vien";
        public const string DIEN_THOAI_DI_DONG = "dien_thoai_di_dong";
        public const string NGAY_THANG_NAM_SINH = "ngay_thang_nam_sinh";
        public const string NOI_SINH = "noi_sinh";
        public const string MA_LOP = "ma_lop";
        public const string ID_LOP_QUAN_LY = "id_lop_quan_ly";
        public const string TEN_TRUONG = "ten_truong";
        public const string MA_TRUONG = "ma_truong";
        public const string HO_TEN_SINH_VIEN = "ho_ten_sinh_vien";
        public const string HO_TEN_QLHT = "ten_that";
        public const string DIEN_THOAI_QLHT = "dien_thoai";
    }
    public class KHO_QUEUE
    {
        public const string MIEN_BAC = "dvmc_6882_mb";
        public const string MIEN_NAM = "dvmc_6882_mn";
    }
    public class V_GD_LICH_GOI_NOI_BO
    {
        public const string ID = "ID";
        public const string ID_CAU_HOI = "ID_CAU_HOI";
        public const string ID_CUOC_GOI = "ID_CUOC_GOI";
        public const string ID_NGUOI_LIEN_QUAN = "ID_NGUOI_LIEN_QUAN";
        public const string NDD_HO_TEN = "NDD_HO_TEN";
        public const string SO_DIEN_THOAI_GOI = "SO_DIEN_THOAI_GOI";
        public const string DUNG_SO_KHAC_YN = "DUNG_SO_KHAC_YN";
        public const string NOI_DUNG_TRAO_DOI = "NOI_DUNG_TRAO_DOI";
        public const string DATETIME_RESPOND = "DATETIME_RESPOND";
        public const string DON_VI_LIEN_QUAN = "DON_VI_LIEN_QUAN";
        public const string VOICE_CALL_LINK = "VOICE_CALL_LINK";
    }
    public class GD_XU_LY_NOI_BO
    {
        public const string ID = "ID";
        public const string ID_CAU_HOI = "ID_CAU_HOI";
        public const string ID_CUOC_GOI = "ID_CUOC_GOI";
        public const string ID_USER_GOI = "ID_USER_GOI";
        public const string SO_DIEN_THOAI_GOI = "SO_DIEN_THOAI_GOI";
        public const string ID_HANH_DONG_NOI_BO = "ID_HANH_DONG_NOI_BO";
        public const string ID_NGUOI_LIEN_QUAN = "ID_NGUOI_LIEN_QUAN";
        public const string DUNG_SO_KHAC_YN = "DUNG_SO_KHAC_YN";
        public const string NOI_DUNG_TRAO_DOI = "NOI_DUNG_TRAO_DOI";
        public const string GHI_CHU = "GHI_CHU";
        public const string CALL_ID = "CALL_ID";
        public const string VOICE_CALL_LINK = "VOICE_CALL_LINK";
        public const string START_TIME = "START_TIME";
        public const string END_TIME = "END_TIME";
        public const string STATION_ID = "STATION_ID";
        public const string DURATION = "DURATION";
        public const string STATUS = "STATUS";
        public const string ERROR_CODE = "ERROR_CODE";
        public const string ERROR_DESC = "ERROR_DESC";
        public const string DATETIME_RESPOND = "DATETIME_RESPOND";
        public const string RINGTIME = "RINGTIME";
    }
    public class DM_QLHT_SCM
    {
        public const string ID = "ID";
        public const string MA_LOP = "MA_LOP";
        public const string ACCOUNT = "ACCOUNT";
        public const string TEN_THAT = "TEN_THAT";
        public const string MA_TRUONG = "MA_TRUONG";
        public const string DIEN_THOAI = "DIEN_THOAI";
    }
    public class TU_DIEN_TRANG_THAI_ACCOUNT_QLHT
    {
        public const string NORMAL = "NORMAL";
        public const string ACCESS_DENIED = "ACCESS_DENIED";
    }
    public class V_GD_XU_LY_NOI_BO
    {
        public const string ID = "ID";
        public const string ID_CAU_HOI = "ID_CAU_HOI";
        public const string ID_CUOC_GOI = "ID_CUOC_GOI";
        public const string ID_USER_GOI = "ID_USER_GOI";
        public const string SO_DIEN_THOAI_GOI = "SO_DIEN_THOAI_GOI";
        public const string ID_HANH_DONG_NOI_BO = "ID_HANH_DONG_NOI_BO";
        public const string ID_NGUOI_LIEN_QUAN = "ID_NGUOI_LIEN_QUAN";
        public const string DUNG_SO_KHAC_YN = "DUNG_SO_KHAC_YN";
        public const string NOI_DUNG_TRAO_DOI = "NOI_DUNG_TRAO_DOI";
        public const string GHI_CHU = "GHI_CHU";
        public const string CALL_ID = "CALL_ID";
        public const string VOICE_CALL_LINK = "VOICE_CALL_LINK";
        public const string START_TIME = "START_TIME";
        public const string END_TIME = "END_TIME";
        public const string STATION_ID = "STATION_ID";
        public const string DURATION = "DURATION";
        public const string STATUS = "STATUS";
        public const string ERROR_CODE = "ERROR_CODE";
        public const string ERROR_DESC = "ERROR_DESC";
        public const string DATETIME_RESPOND = "DATETIME_RESPOND";
        public const string RINGTIME = "RINGTIME";
        public const string NOI_DUNG_CAU_HOI = "NOI_DUNG_CAU_HOI";
        public const string HO_TEN_SINH_VIEN = "HO_TEN_SINH_VIEN";
        public const string SO_DIEN_THOAI = "SO_DIEN_THOAI";
        public const string MA_SINH_VIEN = "MA_SINH_VIEN";
        public const string NGAY_SINH = "NGAY_SINH";
        public const string NOI_SINH = "NOI_SINH";
        public const string LOP = "LOP";
        public const string TRUONG = "TRUONG";
        public const string ID_TRANG_THAI_CAU_HOI = "ID_TRANG_THAI_CAU_HOI";
        public const string THOI_GIAN_HV_HOI = "THOI_GIAN_HV_HOI";
        public const string TRANG_THAI_CAU_HOI = "TRANG_THAI_CAU_HOI";
    }
    public class V_DM_BLACK_LIST
    {
        public const string ID = "ID";
        public const string SO_DIEN_THOAI = "SO_DIEN_THOAI";
        public const string ID_NGUOI_ADD = "ID_NGUOI_ADD";
        public const string ID_NGUOI_REMOVE = "ID_NGUOI_REMOVE";
        public const string NGAY_ADD = "NGAY_ADD";
        public const string NGAY_REMOVE = "NGAY_REMOVE";
        public const string ADD_YN = "ADD_YN";
        public const string HO_TEN_CHU_DIEN_THOAI = "HO_TEN_CHU_DIEN_THOAI";
        public const string GHI_CHU_LY_DO = "GHI_CHU_LY_DO";
        public const string ACCOUNT_NGUOI_ADD = "ACCOUNT_NGUOI_ADD";
        public const string TEN_NGUOI_ADD = "TEN_NGUOI_ADD";
        public const string ACCOUNT_NGUOI_REMOVE = "ACCOUNT_NGUOI_REMOVE";
        public const string TEN_NGUOI_REMOVE = "TEN_NGUOI_REMOVE";
    }

    public class GD_CUOC_GOI_YEU_CAU
    {
        public const string ID = "ID";
        public const string CUOC_GOI_VAO_YN = "CUOC_GOI_VAO_YN";
        public const string CALL_ID = "CALL_ID";
        public const string VOICE_CALL_LINK = "VOICE_CALL_LINK";
        public const string START_TIME = "START_TIME";
        public const string END_TIME = "END_TIME";
        public const string STATION_ID = "STATION_ID";
        public const string DURATION = "DURATION";
        public const string STATUS = "STATUS";
        public const string ERROR_CODE = "ERROR_CODE";
        public const string ERROR_DESC = "ERROR_DESC";
        public const string DATETIME_RESPOND = "DATETIME_RESPOND";
        public const string RINGTIME = "RINGTIME";
        public const string THOI_DIEM_GOI = "THOI_DIEM_GOI";
        public const string ID_DAT_HANG = "ID_DAT_HANG";
    }

    public class GD_CAU_HOI_HOC_VIEN
    {
        public const string ID = "ID";
        public const string ID_YEU_CAU = "ID_YEU_CAU";
        public const string ID_LOAI_CAU_HOI = "ID_LOAI_CAU_HOI";
        public const string ID_CAU_HOI = "ID_CAU_HOI";
        public const string NOI_DUNG_CAU_HOI = "NOI_DUNG_CAU_HOI";
        public const string ID_NGUOI_TRA_LOI = "ID_NGUOI_TRA_LOI";
        public const string NOI_DUNG_TRA_LOI = "NOI_DUNG_TRA_LOI";
        public const string ID_TRANG_THAI = "ID_TRANG_THAI";
        public const string THOI_DIEM_HEN_GOI_LAI = "THOI_DIEM_HEN_GOI_LAI";
        public const string GHI_CHU_LICH_HEN = "GHI_CHU_LICH_HEN";
        public const string ID_DANH_GIA = "ID_DANH_GIA";
        public const string GHI_CHU_Y_KIEN_KHAC = "GHI_CHU_Y_KIEN_KHAC";
        public const string GHI_CHU = "GHI_CHU";
        public const string GHI_CHU2 = "GHI_CHU2";
        public const string THOI_GIAN_QLHT_TRA_LOI = "THOI_GIAN_QLHT_TRA_LOI";
    }
    public class V_DM_STATION
    {
        public const string ID = "ID";
        public const string STATIONCODE = "STATIONCODE";
        public const string TRANG_THAI = "TRANG_THAI";
        public const string ID_NGUOI_DUNG = "ID_NGUOI_DUNG";
        public const string HO_TEN_NGUOI_DUNG = "HO_TEN_NGUOI_DUNG";
    }
    public class DM_MAU_EMAIL
    {
        public const string ID = "ID";
        public const string TIEU_DE_MAIL = "TIEU_DE_MAIL";
        public const string NOI_DUNG_EMAIL = "NOI_DUNG_EMAIL";
        public const string GUI_CC = "GUI_CC";
        public const string MA_EMAIL = "MA_EMAIL";
    }
    public class GD_DAT_HANG
    {
        public const string ID = "ID";
        public const string MA_DON_HANG = "MA_DON_HANG";
        public const string ID_USER_NV_DAT_HANG = "ID_USER_NV_DAT_HANG";
        public const string ID_DON_VI = "ID_DON_VI";
        public const string DIEN_THOAI = "DIEN_THOAI";
        public const string HO_TEN_USER_DAT_HANG = "HO_TEN_USER_DAT_HANG";
        public const string THOI_DIEM_CAN_HOAN_THANH = "THOI_DIEM_CAN_HOAN_THANH";
        public const string ID_DV_YEU_CAU = "ID_DV_YEU_CAU";
        public const string NOI_DUNG_DAT_HANG = "NOI_DUNG_DAT_HANG";
        public const string ID_LOAI_THOI_GIAN_CAN_HOAN_THANH = "ID_LOAI_THOI_GIAN_CAN_HOAN_THANH";
        public const string PHAN_HOI_TU_DVMC = "PHAN_HOI_TU_DVMC";
        public const string THOI_GIAN_HOAN_THANH = "THOI_GIAN_HOAN_THANH";
        public const string ID_DANH_GIA_TU_USER_DAT_HANG = "ID_DANH_GIA_TU_USER_DAT_HANG";
        public const string Y_KIEN_KHAC_TU_USER_DAT_HANG = "Y_KIEN_KHAC_TU_USER_DAT_HANG";
        public const string THOI_GIAN_TAO = "THOI_GIAN_TAO";
        public const string ID_PHUONG_THUC_DAT_HANG = "ID_PHUONG_THUC_DAT_HANG";
        public const string ID_NGUOI_TAO = "ID_NGUOI_TAO";
        public const string ID_CHI_NHANH = "ID_CHI_NHANH";
    }

    
    public class DM_NGUOI_DAT_HANG
    {
        public const string ID = "ID";
        public const string USER_TOPICA = "USER_TOPICA";
        public const string HO_TEN = "HO_TEN";
        public const string SO_DIEN_THOAI = "SO_DIEN_THOAI";
        public const string ID_DON_VI = "ID_DON_VI";
    }
    public class DM_LOAI_YEU_CAU
    {
        public const string ID = "ID";
        public const string ID_CHA = "ID_CHA";
        public const string TEN_YEU_CAU = "TEN_YEU_CAU";
        public const string DIEM_KHOI_LUONG = "DIEM_KHOI_LUONG";
        public const string ID_THOI_GIAN_XU_LY = "ID_THOI_GIAN_XU_LY";
        public const string TRANG_THAI_HSD = "TRANG_THAI_HSD";
    }
    public class DM_DON_VI
    {
        public const string ID = "ID";
        public const string MA_DON_VI = "MA_DON_VI";
        public const string ID_DV_CHA = "ID_DV_CHA";
    }
    public class V_GD_NGUOI_XU_LY_DON_HANG
    {
        public const string ID = "ID";
        public const string ID_DON_HANG = "ID_DON_HANG";
        public const string ID_NGUOI_XU_LY = "ID_NGUOI_XU_LY";
        public const string MA_DON_HANG = "MA_DON_HANG";
        public const string USER_XU_LY = "USER_XU_LY";
    }
    public class dm_ma_don_hang
    {
        public const string ID = "ID";
        public const string MA_DON_HANG = "MA_DON_HANG";
    }
    public class GD_LOG_DAT_HANG
    {
        public const string ID = "ID";
        public const string ID_LOAI_THAO_TAC = "ID_LOAI_THAO_TAC";
        public const string ID_GD_DAT_HANG = "ID_GD_DAT_HANG";
        public const string ID_NGUOI_TAO_THAO_TAC = "ID_NGUOI_TAO_THAO_TAC";
        public const string ID_NGUOI_NHAN_THAO_TAC = "ID_NGUOI_NHAN_THAO_TAC";
        public const string NGAY_LAP_THAO_TAC = "NGAY_LAP_THAO_TAC";
        public const string THAO_TAC_HET_HAN_YN = "THAO_TAC_HET_HAN_YN";
        public const string GHI_CHU = "GHI_CHU";
    }

    public class V_GD_DAT_HANG_GD_LOG_DAT_HANG
    {
        public const string ID_DON_HANG = "ID_DON_HANG";
        public const string MA_DON_HANG = "MA_DON_HANG";
        public const string ID_USER_NV_DAT_HANG = "ID_USER_NV_DAT_HANG";
        public const string HO_TEN_USER_DAT_HANG = "HO_TEN_USER_DAT_HANG";
        public const string ID_DON_VI = "ID_DON_VI";
        public const string MA_DON_VI = "MA_DON_VI";
        public const string DIEN_THOAI = "DIEN_THOAI";
        public const string ID_NHOM_DV_YEU_CAU = "ID_NHOM_DV_YEU_CAU";
        public const string TEN_NHOM_DICH_VU_YEU_CAU = "TEN_NHOM_DICH_VU_YEU_CAU";
        public const string NOI_DUNG_DAT_HANG = "NOI_DUNG_DAT_HANG";
        public const string ID_LOAI_THOI_GIAN_CAN_HOAN_THANH = "ID_LOAI_THOI_GIAN_CAN_HOAN_THANH";
        public const string LOAI_THOI_GIAN_CAN_HOAN_THANH = "LOAI_THOI_GIAN_CAN_HOAN_THANH";
        public const string PHAN_HOI_TU_DVMC = "PHAN_HOI_TU_DVMC";
        public const string ID_DANH_GIA_TU_USER_DAT_HANG = "ID_DANH_GIA_TU_USER_DAT_HANG";
        public const string TEN_DANH_GIA_TU_USER_DAT_HANG = "TEN_DANH_GIA_TU_USER_DAT_HANG";
        public const string Y_KIEN_KHAC_TU_USER_DAT_HANG = "Y_KIEN_KHAC_TU_USER_DAT_HANG";
        public const string THOI_GIAN_TAO = "THOI_GIAN_TAO";
        public const string ID_PHUONG_THUC_DAT_HANG = "ID_PHUONG_THUC_DAT_HANG";
        public const string TEN_PHUONG_THUC_DAT_HANG = "TEN_PHUONG_THUC_DAT_HANG";
        public const string ID_NGUOI_TAO = "ID_NGUOI_TAO";
        public const string NGUOI_TAO_THAO_TAC = "NGUOI_TAO_THAO_TAC";
        public const string ID_CHI_NHANH = "ID_CHI_NHANH";
        public const string TEN_CHI_NHANH = "TEN_CHI_NHANH";
        public const string ID = "ID";
        public const string ID_LOAI_THAO_TAC = "ID_LOAI_THAO_TAC";
        public const string TEN_LOAI_THAO_TAC_LOG = "TEN_LOAI_THAO_TAC_LOG";
        public const string THAO_TAC_HET_HAN_YN = "THAO_TAC_HET_HAN_YN";
        public const string NGAY_LAP_THAO_TAC = "NGAY_LAP_THAO_TAC";
        public const string GHI_CHU = "GHI_CHU";
        public const string ID_NGUOI_NHAN_THAO_TAC = "ID_NGUOI_NHAN_THAO_TAC";
        public const string TEN_NGUOI_NHAN_THAO_TAC = "TEN_NGUOI_NHAN_THAO_TAC";
        public const string ID_NGUOI_TAO_THAO_TAC = "ID_NGUOI_TAO_THAO_TAC";
        public const string TEN_NGUOI_TAO_THAO_TAC_LOG = "TEN_NGUOI_TAO_THAO_TAC_LOG";
        public const string THOI_DIEM_CAN_HOAN_THANH = "THOI_DIEM_CAN_HOAN_THANH";
        public const string THOI_GIAN_HOAN_THANH = "THOI_GIAN_HOAN_THANH";
        public const string EMAIL = "EMAIL";
    }

    public class V_GD_DAT_HANG
    {
        public const string ID = "ID";
        public const string MA_DON_HANG = "MA_DON_HANG";
        public const string ID_USER_NV_DAT_HANG = "ID_USER_NV_DAT_HANG";
        public const string ID_DON_VI = "ID_DON_VI";
        public const string MA_DON_VI = "MA_DON_VI";
        public const string DIEN_THOAI = "DIEN_THOAI";
        public const string HO_TEN_USER_DAT_HANG = "HO_TEN_USER_DAT_HANG";
        public const string THOI_DIEM_CAN_HOAN_THANH = "THOI_DIEM_CAN_HOAN_THANH";
        public const string ID_DV_YEU_CAU = "ID_DV_YEU_CAU";
        public const string TEN_YEU_CAU = "TEN_YEU_CAU";
        public const string NOI_DUNG_DAT_HANG = "NOI_DUNG_DAT_HANG";
        public const string ID_LOAI_THOI_GIAN_CAN_HOAN_THANH = "ID_LOAI_THOI_GIAN_CAN_HOAN_THANH";
        public const string LOAI_THOI_GIAN_CAN_HOAN_THANH = "LOAI_THOI_GIAN_CAN_HOAN_THANH";
        public const string PHAN_HOI_TU_DVMC = "PHAN_HOI_TU_DVMC";
        public const string THOI_GIAN_HOAN_THANH = "THOI_GIAN_HOAN_THANH";
        public const string ID_DANH_GIA_TU_USER_DAT_HANG = "ID_DANH_GIA_TU_USER_DAT_HANG";
        public const string DANH_GIA_TU_USER_DAT_HANG = "DANH_GIA_TU_USER_DAT_HANG";
        public const string Y_KIEN_KHAC_TU_USER_DAT_HANG = "Y_KIEN_KHAC_TU_USER_DAT_HANG";
        public const string THOI_GIAN_TAO = "THOI_GIAN_TAO";
        public const string ID_PHUONG_THUC_DAT_HANG = "ID_PHUONG_THUC_DAT_HANG";
        public const string PHUONG_THUC_DAT_HANG = "PHUONG_THUC_DAT_HANG";
        public const string ID_NGUOI_TAO = "ID_NGUOI_TAO";
        public const string NGUOI_TAO = "NGUOI_TAO";
        public const string ID_CHI_NHANH = "ID_CHI_NHANH";
        public const string TEN_CHI_NHANH = "TEN_CHI_NHANH";
        public const string EMAIL = "EMAIL";
        public const string USER_NAME = "USER_NAME";
        public const string CAP_NHAT_CUOI = "CAP_NHAT_CUOI";
        public const string NGUOI_XU_LY = "NGUOI_XU_LY";
        public const string TRANG_THAI_DON_HANG = "TRANG_THAI_DON_HANG";
    }



    public class DM_CAU_TRA_LOI
    {
        public const string ID = "ID";
        public const string ID_CAU_HOI = "ID_CAU_HOI";
        public const string CAU_TRA_LOI = "CAU_TRA_LOI";
        public const string NGUOI_TAO = "NGUOI_TAO";
        public const string NGAY_TAO = "NGAY_TAO";
        public const string ID_TRANG_THAI = "ID_TRANG_THAI";
        public const string LINK_TL_THAM_KHAO = "LINK_TL_THAM_KHAO";
    }
    public class V_DS_DON_DAT_HANG_CHI_TIET
    {
        public const string ID = "ID";
        public const string MA_DON_HANG = "MA_DON_HANG";
        public const string ID_USER_NV_DAT_HANG = "ID_USER_NV_DAT_HANG";
        public const string ID_DON_VI = "ID_DON_VI";
        public const string MA_DON_VI = "MA_DON_VI";
        public const string DIEN_THOAI = "DIEN_THOAI";
        public const string HO_TEN_USER_DAT_HANG = "HO_TEN_USER_DAT_HANG";
        public const string THOI_GIAN_DAT_HANG = "THOI_GIAN_DAT_HANG";
        public const string ID_DV_YEU_CAU = "ID_DV_YEU_CAU";
        public const string TEN_YEU_CAU = "TEN_YEU_CAU";
        public const string NOI_DUNG_DAT_HANG = "NOI_DUNG_DAT_HANG";
        public const string ID_LOAI_THOI_GIAN_CAN_HOAN_THANH = "ID_LOAI_THOI_GIAN_CAN_HOAN_THANH";
        public const string LOAI_TG_CAN_HOAN_THANH = "LOAI_TG_CAN_HOAN_THANH";
        public const string PHAN_HOI_TU_DVMC = "PHAN_HOI_TU_DVMC";
        public const string THOI_GIAN_HOAN_THANH = "THOI_GIAN_HOAN_THANH";
        public const string ID_DANH_GIA_TU_USER_DAT_HANG = "ID_DANH_GIA_TU_USER_DAT_HANG";
        public const string DANH_GIA_TU_USER_DAT_HANG = "DANH_GIA_TU_USER_DAT_HANG";
        public const string Y_KIEN_KHAC_TU_USER_DAT_HANG = "Y_KIEN_KHAC_TU_USER_DAT_HANG";
        public const string THOI_GIAN_TAO = "THOI_GIAN_TAO";
        public const string ID_PHUONG_THUC_DAT_HANG = "ID_PHUONG_THUC_DAT_HANG";
        public const string PHUONG_THUC_DAT_HANG = "PHUONG_THUC_DAT_HANG";
        public const string ID_NGUOI_TAO = "ID_NGUOI_TAO";
        public const string NGUOI_TAO = "NGUOI_TAO";
        public const string ID_CHI_NHANH = "ID_CHI_NHANH";
        public const string TEN_CHI_NHANH = "TEN_CHI_NHANH";
        public const string TRANG_THAI_DON_HANG = "TRANG_THAI_DON_HANG";
    }
    public class HT_NGUOI_SU_DUNG_NHOM_CHI_NHANH
    {
        public const string ID = "ID";
        public const string ID_NGUOI_SU_DUNG = "ID_NGUOI_SU_DUNG";
        public const string ID_NHOM = "ID_NHOM";
        public const string ID_CHI_NHANH = "ID_CHI_NHANH";
    }
    public class DM_BLACK_LIST
    {
        public const string ID = "ID";
        public const string SO_DIEN_THOAI = "SO_DIEN_THOAI";
        public const string ID_NGUOI_ADD = "ID_NGUOI_ADD";
        public const string ID_NGUOI_REMOVE = "ID_NGUOI_REMOVE";
        public const string NGAY_ADD = "NGAY_ADD";
        public const string NGAY_REMOVE = "NGAY_REMOVE";
        public const string ADD_YN = "ADD_YN";
        public const string HO_TEN_CHU_DIEN_THOAI = "HO_TEN_CHU_DIEN_THOAI";
        public const string GHI_CHU_LY_DO = "GHI_CHU_LY_DO";
    }
    public class V_DON_HANG_TRANG_THAI
    {
        public const string MA_DON_HANG = "MA_DON_HANG";
        public const string TEN_NHOM_DICH_VU_YEU_CAU = "TEN_NHOM_DICH_VU_YEU_CAU";
        public const string NOI_DUNG_DAT_HANG = "NOI_DUNG_DAT_HANG";
        public const string THOI_GIAN_TAO = "THOI_GIAN_TAO";
        public const string THOI_GIAN_HOAN_THANH = "THOI_GIAN_HOAN_THANH";
        public const string TRANG_THAI_DON_HANG = "TRANG_THAI_DON_HANG";
        public const string ID_USER_NV_DAT_HANG = "ID_USER_NV_DAT_HANG";
        public const string ID = "ID";
        public const string HO_TEN_USER_DAT_HANG = "HO_TEN_USER_DAT_HANG";
    }
    public class V_DM_LOAI_YEU_CAU
    {
        public const string ID = "ID";
        public const string TEN_YEU_CAU = "TEN_YEU_CAU";
        public const string DIEM_KHOI_LUONG = "DIEM_KHOI_LUONG";
        public const string ID_THOI_GIAN_XU_LY = "ID_THOI_GIAN_XU_LY";
        public const string THOI_GIAN_XU_LY = "THOI_GIAN_XU_LY";
        public const string ID_CHA = "ID_CHA";
        public const string ID_DM_YEU_CAU_2 = "ID_DM_YEU_CAU_2";
        public const string ID_CHA_DM_YEU_CAU_2 = "ID_CHA_DM_YEU_CAU_2";
        public const string TEN_YEU_CAU_CHA_CHA = "TEN_YEU_CAU_CHA_CHA";
        public const string ID_DM_YEU_CAU_1 = "ID_DM_YEU_CAU_1";
        public const string ID_CHA_DM_YEU_CAU_1 = "ID_CHA_DM_YEU_CAU_1";
        public const string TEN_YEU_CAU_CHA = "TEN_YEU_CAU_CHA";
        public const string ID_TU_DIEN = "ID_TU_DIEN";
        public const string TRANG_THAI_HSD = "TRANG_THAI_HSD";
    }
    public class DM_KHACH_HANG
    {
        public const string ID = "ID";
        public const string TEN_KHACH_HANG = "TEN_KHACH_HANG";
        public const string DON_VI = "DON_VI";
        public const string DIEN_THOAI = "DIEN_THOAI";
        public const string EMAIL = "EMAIL";
    }
}
