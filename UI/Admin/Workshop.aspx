<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="Workshop.aspx.cs" Inherits="Admin_Workshop" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table width="100%">
        <tr>
            <td style="text-align: right">Workshop Title:</td>
            <td>
                <asp:TextBox ID="txtWorkShopTitle" runat="server" Width="163px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="text-align: right">Workshop Date:</td>
            <td>
                <asp:TextBox ID="txtWorkShopDate" runat="server" Width="163px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="text-align: right">Workshop Duration:</td>
            <td>
                <asp:TextBox ID="txtWorkShopDuration" runat="server" Width="159px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="text-align: right">Workshop Topics:</td>
            <td>
                <asp:TextBox ID="txtWorkShopTopics" runat="server" Height="67px" TextMode="MultiLine" Width="191px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="text-align: right">
                <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />
            </td>
            <td>
                <asp:Button ID="btnUpdate" runat="server"  Text="Update" OnClick="btnUpdate_Click" />
                <asp:Button ID="btnDelete" runat="server"  Text="Delete" OnClick="btnDelete_Click" />
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateSelectButton="True" DataKeyNames="WorkShopId" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" >
                    <AlternatingRowStyle BackColor="White" />
                    <EditRowStyle BackColor="#2461BF" />
                    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#EFF3FB" />
                    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#F5F7FB" />
                    <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                    <SortedDescendingCellStyle BackColor="#E9EBEF" />
                    <SortedDescendingHeaderStyle BackColor="#4870BE" />
                </asp:GridView>
            </td>
        </tr>
    </table>
</asp:Content>

