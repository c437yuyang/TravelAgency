<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="TravletAgence.Web.VisaInfo.Show" Title="显示页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>                   
                    <td class="tdbg">
                               
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		VisaInfo_id
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblVisaInfo_id" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Visa_id
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblVisa_id" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		GroupNo
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblGroupNo" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		姓名
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblName" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		英语姓名
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblEnglishName" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		性别
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSex" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		生日
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblBirthday" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		护照号
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPassportNo" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		发证日期
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblLicenceTime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		有效期
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblExpiryDate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		出生地
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblBirthplace" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		签发地
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblIssuePlace" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		职位
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPost" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		电话
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPhone" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		领队编号
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblGuideNo" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		客户
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblClient" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		销售员
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSalesperson" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		签证类型
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblTypes" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Sale_id
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSale_id" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		DepartmentId
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblDepartmentId" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		备注
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblTips" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		EntryTime
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblEntryTime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		EmbassyTime
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblEmbassyTime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		InTime
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblInTime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		归国时间
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblOutTime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		RealOut
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblRealOut" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		RealOutTime
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblRealOutTime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Country
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblCountry" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Call
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblCall" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




