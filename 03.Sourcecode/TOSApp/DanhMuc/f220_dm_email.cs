using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraRichEdit.Export;
using DevExpress.XtraRichEdit.Export.Html;

namespace TOSApp.DanhMuc
{
    public partial class f220_dm_email : DevExpress.XtraEditors.XtraForm
    {
        public f220_dm_email()
        {
            InitializeComponent();
        }

        List<DataRow> m_lst_dr = new List<DataRow>();
        List<iParameter> m_lst_field = new List<iParameter>();

        public void display(List<iParameter> ip_lst_field, List<DataRow> ip_lst_dr)
        {
            m_lst_dr = ip_lst_dr;
            m_lst_field = ip_lst_field;
            m_lb_control.DisplayMember = "ParameterName";
            m_lb_control.ValueMember = "ParameterValue";
            m_lb_control.DataSource = m_lst_field;
            this.ShowDialog();
        }

        private void m_cmd_send_email_Click(object sender, EventArgs e)
        {
            string v_noi_dung = ExportHtml();
            decimal v_count_email_gui_duoc = 0;
            for (int i = 0; i < m_lst_dr.Count; i++)
            {
                string v_email = m_lst_dr[i]["EMAIL"].ToString();
                var v_noi_dung_merge = MergeMail(v_noi_dung, i);
                try
                {
                    Mail.sendEmail("daotao@topica.edu.vn", "topicahn", v_email, m_txt_tieu_de_mail.Text, v_noi_dung_merge);
                    v_count_email_gui_duoc += 1;
                }
                catch (Exception)
                {

                    MessageBox.Show("Địa chỉ email" + v_email + "không đúng! Vui lòng kiểm tra lại thông tin!");
                }

            }
            if (v_count_email_gui_duoc == m_lst_dr.Count)
            {
                MessageBox.Show("Bạn đã gửi thành công email cho " + v_count_email_gui_duoc.ToString() + " học viên!");
            }
            else
            {
                MessageBox.Show("Bạn đã gửi thành công email cho " + v_count_email_gui_duoc.ToString() + " học viên! Còn " + (m_lst_dr.Count - v_count_email_gui_duoc).ToString() + " nhân viên không gửi được vì địa chỉ email không đúng!");
            }
        }

        private string MergeMail(string ip_noi_dung, int ip_index)
        {
            string v_noi_dung = ip_noi_dung;
            for (int i = 0; i < m_lst_field.Count; i++)
            {
                var v_text = "&lt;" + m_lst_field[i].ParameterValue.ToString().Trim() + "&gt;";
                var v_replace = m_lst_dr[ip_index][m_lst_field[i].ParameterValue].ToString();
                v_noi_dung = v_noi_dung.Replace(v_text, v_replace);
            }
            return v_noi_dung;
        }

        //private string get_email(decimal ip_id_nhan_vien)
        //{
        //    //US_DM_NHAN_VIEN v_us = new US_DM_NHAN_VIEN(ip_id_nhan_vien);
        //    //return v_us.strEMAIL;
        //    return "thaiph@bkindex.com";
        //}

        private string ExportHtml()
        {
            string stringHtml = String.Empty;
            HtmlDocumentExporterOptions options = new HtmlDocumentExporterOptions();
            options.ExportRootTag = ExportRootTag.Body;
            options.CssPropertiesExportType = CssPropertiesExportType.Inline;
            var exporter = new HtmlExporter(this.m_txt_noi_dung.Model, options);
            return stringHtml = exporter.Export();
        }

        private void m_cmd_insert_Click(object sender, EventArgs e)
        {
            m_txt_noi_dung.Text += "<" + m_lb_control.SelectedValue.ToString().Trim() + ">";
        }

       

        
    }
}