<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="SpecialEventsAdmin.aspx.cs" Inherits="SamplePages_SpecialEventsAdmin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <h1>Special Events Administration</h1>
    <table align="center" style="width: 80%">
        <tr>
            <td align="right" style="width:50%">Select an Event:</td>
            <td>
                <asp:DropDownList ID="SpecialEventList" runat="server" Width="200px" AppendDataBoundItems="True">
                    <asp:ListItem Value="z">Select Event</asp:ListItem>
                </asp:DropDownList>
                <asp:LinkButton ID="FetchReservations" runat="server">Fetch Reservations</asp:LinkButton>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:GridView ID="ReservationListGV" runat="server" DataSourceID="ODSSpecialEvents">
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:GridView ID="ReservationList" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataSourceID="ODSReservations" PageSize="5">
                    <Columns>
                        <asp:BoundField DataField="CustomerName" HeaderText="Name">
                        <HeaderStyle HorizontalAlign="Left" />
                        </asp:BoundField>
                        <asp:BoundField DataField="ReservationDate" DataFormatString="{0:MMM dd, yyyy}" HeaderText="Date" />
                        <asp:BoundField DataField="NumberInParty" HeaderText="Size">
                        <HeaderStyle HorizontalAlign="Right" />
                        <asp:BoundField DataField="ContactPhone" HeaderText="Phone" />
                        <asp:BoundField DataField="ReservationStatus" HeaderText="Status">
                        <HeaderStyle HorizontalAlign="Center" />
                        </asp:BoundField>
                    </Columns>
                    <EmptyDataTemplate>
                        No data to display at this time.
                    </EmptyDataTemplate>
                    <PagerSettings Mode="NumericFirstLast" Position="TopAndBottom" />
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
    <asp:ObjectDataSource ID="ODSSpecialEvents" runat="server"
        OldValuesParameterFormatString="original_{0}"
        SelectMethod="SpecialEvents_List"
        TypeName="eRestaurantSystem.BLL.AdminController.cs"></asp:ObjectDataSource>
    <asp:ObjectDataSource ID="ODSReservations" runat="server"></asp:ObjectDataSource>
</asp:Content>

