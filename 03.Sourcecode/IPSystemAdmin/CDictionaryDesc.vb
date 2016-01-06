'NHIỆM VỤ CỦA CLASS
'   
'
' Lấy các description của 1 loại từ điển
' Phục vụ cho điền dữ liệu
'
'

Option Explicit On 
Option Strict On

Imports IP.Core.IPCommon
Imports IP.Core.IPException
Imports IP.Core.ipdata
Imports IP.Core.ipuserservice


Public Class CDictionaryDesc

    dim m_list_of_desc as CListOfDataFromDB
    public sub new ( byval strLoaiTuDien as String, _
                     optional byval i_trans as SqlClient.SqlTransaction = nothing)
        
        dim v_us as new US_CM_DM_TU_DIEN
        if  not (i_trans is nothing) then
            v_us.SetTransaction(i_trans)
        End If
        dim v_ds as DS_CM_DM_TU_DIEN = v_us.getLoaiTuDienDS(strloaitudien)
        m_list_of_desc = new CListOfDataFromDB(v_ds, "MA_TU_DIEN", "TEN_NGAN")
    End Sub   

    public function getDesc(byval strMaTuDien as string) as String
        return  convert.ToString(m_list_of_desc(strMaTuDien))
    End Function

End Class
