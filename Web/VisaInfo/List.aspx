<%@ Page Title="VisaInfo" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="TravletAgence.Web.VisaInfo.List" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<script language="javascript" src="/js/CheckBox.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<!--Title -->

            <!--Title end -->

            <!--Add  -->

            <!--Add end -->

            <!--Search -->
            <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>
                    <td style="width: 80px" align="right" class="tdbg">
                         <b>关键字：</b>
                    </td>
                    <td class="tdbg">                       
                    <asp:TextBox ID="txtKeyword" runat="server"></asp:TextBox>
                    &nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnSearch" runat="server" Text="查询"  OnClick="btnSearch_Click" >
                    </asp:Button>                    
                        
                    </td>
                    <td class="tdbg">
                    </td>
                </tr>
            </table>
            <!--Search end-->
            <br />
            <asp:GridView ID="gridView" runat="server" AllowPaging="True" Width="100%" CellPadding="3"  OnPageIndexChanging ="gridView_PageIndexChanging"
                    BorderWidth="1px" DataKeyNames="VisaInfo_id" OnRowDataBound="gridView_RowDataBound"
                    AutoGenerateColumns="false" PageSize="10"  RowStyle-HorizontalAlign="Center" OnRowCreated="gridView_OnRowCreated">
                    <Columns>
                    <asp:TemplateField ControlStyle-Width="30" HeaderText="选择"    >
                                <ItemTemplate>
                                    <asp:CheckBox ID="DeleteThis" onclick="javascript:CCA(this);" runat="server" />
                                </ItemTemplate>
                            </asp:TemplateField> 
                            
		<asp:BoundField DataField="VisaInfo_id" HeaderText="VisaInfo_id" SortExpression="VisaInfo_id" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Visa_id" HeaderText="Visa_id" SortExpression="Visa_id" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="GroupNo" HeaderText="GroupNo" SortExpression="GroupNo" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Name" HeaderText="姓名" SortExpression="Name" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="EnglishName" HeaderText="英语姓名" SortExpression="EnglishName" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Sex" HeaderText="性别" SortExpression="Sex" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Birthday" HeaderText="生日" SortExpression="Birthday" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="PassportNo" HeaderText="护照号" SortExpression="PassportNo" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="LicenceTime" HeaderText="发证日期" SortExpression="LicenceTime" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ExpiryDate" HeaderText="有效期" SortExpression="ExpiryDate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Birthplace" HeaderText="出生地" SortExpression="Birthplace" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="IssuePlace" HeaderText="签发地" SortExpression="IssuePlace" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Post" HeaderText="职位" SortExpression="Post" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Phone" HeaderText="电话" SortExpression="Phone" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="GuideNo" HeaderText="领队编号" SortExpression="GuideNo" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Client" HeaderText="客户" SortExpression="Client" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Salesperson" HeaderText="销售员" SortExpression="Salesperson" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Types" HeaderText="签证类型" SortExpression="Types" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Sale_id" HeaderText="Sale_id" SortExpression="Sale_id" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="DepartmentId" HeaderText="DepartmentId" SortExpression="DepartmentId" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Tips" HeaderText="备注" SortExpression="Tips" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="EntryTime" HeaderText="EntryTime" SortExpression="EntryTime" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="EmbassyTime" HeaderText="EmbassyTime" SortExpression="EmbassyTime" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="InTime" HeaderText="InTime" SortExpression="InTime" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="OutTime" HeaderText="归国时间" SortExpression="OutTime" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="RealOut" HeaderText="RealOut" SortExpression="RealOut" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="RealOutTime" HeaderText="RealOutTime" SortExpression="RealOutTime" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Country" HeaderText="Country" SortExpression="Country" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Call" HeaderText="Call" SortExpression="Call" ItemStyle-HorizontalAlign="Center"  /> 
                            
                            <asp:HyperLinkField HeaderText="详细" ControlStyle-Width="50" DataNavigateUrlFields="VisaInfo_id" DataNavigateUrlFormatString="Show.aspx?id={0}"
                                Text="详细"  />
                            <asp:HyperLinkField HeaderText="编辑" ControlStyle-Width="50" DataNavigateUrlFields="VisaInfo_id" DataNavigateUrlFormatString="Modify.aspx?id={0}"
                                Text="编辑"  />
                            <asp:TemplateField ControlStyle-Width="50" HeaderText="删除"   Visible="false"  >
                                <ItemTemplate>
                                    <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Delete"
                                         Text="删除"></asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                </asp:GridView>
               <table border="0" cellpadding="0" cellspacing="1" style="width: 100%;">
                <tr>
                    <td style="width: 1px;">                        
                    </td>
                    <td align="left">
                        <asp:Button ID="btnDelete" runat="server" Text="删除" OnClick="btnDelete_Click"/>                       
                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>
