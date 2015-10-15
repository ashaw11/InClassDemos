<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="WaiterAdmin.aspx.cs" Inherits="ComandPages_WaiterAdmin" %>

<%@ Register src="../UserControls/MessageUserControl.ascx" tagname="MessageUserControl" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    
    <h1>Waiter Admin<h1>
    <uc1:MessageUserControl ID="MessageUserControl1" runat="server" />

        <asp:Label ID="Label1" runat="server" Text="Select Waiter for Update"></asp:Label>
        <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
        <asp:LinkButton ID="FetchWaiter" runat="server">Fetch Waiter</asp:LinkButton>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server"></asp:ObjectDataSource>
    <table align="center" style="width: 70%">
        <tr>
            <td>ID:</td>
            <td>
                <asp:Label ID="WaiterID" runat="server" Text=""></asp:Label>
            </td>
        </tr>
        <tr>
            <td>First Name:</td>
            <td>
                <asp:TextBox ID="FirstName" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Last Name:</td>
            <td>
                <asp:TextBox ID="LastName" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Phone Number:</td>
            <td>
                <asp:TextBox ID="Phone" runat="server" OnTextChanged="TextBox3_TextChanged"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Address:</td>
            <td>
                <asp:TextBox ID="Address" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Date Hired (mm/dd/yyyy)</td>
            <td>
                <asp:TextBox ID="DateHired" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Date Released (mm/dd/yyyy)</td>
            <td>
                <asp:TextBox ID="DateReleased" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:LinkButton ID="InsertWaiter" runat="server">Insert</asp:LinkButton>
            </td>
            <td>
                <asp:LinkButton ID="UpdateWaiter" runat="server">Update</asp:LinkButton>
            </td>
        </tr>
    </table>
</asp:Content>

