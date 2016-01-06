<%@ Page Title="" Language="C#" MasterPageFile="~/Home2.master" AutoEventWireup="true" CodeFile="MessageError.aspx.cs" Inherits="MessageError" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
  <style type="text/css">
        .style1
        {
            width: 63%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
<table style="width: 319px" >
        <tr class="title_ttql">
            <td >
              ERROR 404
            </td>
        </tr>
     </table>
     
    <!-- Bang Dat -->
    <table border="0" cellpadding="0" cellspacing="0" width="100%">
        <tbody>
            <tr>
                <td style="padding-left: 8px; padding-right: 5px;" valign="top">
                    <table border="0" cellpadding="0" cellspacing="0" width="300">
                        <tbody>
                            <tr>
                                <td valign="top">
                                    <table border="0" cellpadding="0" cellspacing="3" align="left" 
                                        style="height: 28px; width: 314px">
                                        <tbody>
                                            <tr>
                                                <td>
                                                <asp:Label ID = "lblErrorMessage" runat ="server" style="color:Red; font-size:17px" text = "Đã xảy ra lỗi khi thao tác với hệ thống!"></asp:Label>
                                                    &nbsp;</td>
                                            </tr>
                                        </tbody>
                                    </table>
                                </td>
                            </tr>
                            <tr>
                                <td style="height: 5px;">
                                </td&nbsp;</td>
                            </tr>
                            <tr>
                                <td>
                                   
                                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td>
                                    <table border="0" cellpadding="0" cellspacing="0" width="98%">
                                        <tbody>
                                            <tr>
                                                <td>
                                                    
                                                </td>
                                            </tr>
                                        </tbody>
                                    </table>
                                </td>
                            </tr>
                            <tr>
                                <td style="height: 5px;">
                                    &nbsp;</td>
                            </tr>
                        </tbody>
                    </table>
                </td>
                <td style="padding-left: 5px; padding-right: 8px; border-left: 1px solid rgb(229, 229, 229);"
                    valign="top" class="style1">
                    <table id="Table5" style="width: 100%; border-collapse: collapse;" border="0" cellspacing="0">
                        <tbody>
                            <tr>
                                <td>
                                    <table cellpadding="0" cellspacing="0" width="100%">
                                        <tbody>
                                            <tr>
                                                <td class="OtherNews_td">                                                    
                                                    <br>
                                                    
                                                </td>
                                            </tr>
                                        </tbody>
                                    </table>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <table cellpadding="0" cellspacing="0" width="100%">
                                        <tbody>
                                            <tr>
                                                <td class="OtherNews_td">
                                                    <br>
                                                </td>
                                            </tr>
                                        </tbody>
                                    </table>
                                </td>
                            </tr>
                          
                        </tbody>
                    </table>
                </td>
                <td style="width: 60%; padding-left: 5px; padding-right: 8px; border-left: 1px solid rgb(229, 229, 229);"
                    valign="top">
                                    <table id="Table6" style="width: 100%; border-collapse: collapse;" border="0" cellspacing="0">
                        <tbody>
                            
                        </tbody>
                    </table>
                </td>
            </tr>
        </tbody>
    </table>
</asp:Content>

