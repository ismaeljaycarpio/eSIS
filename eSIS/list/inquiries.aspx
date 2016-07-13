<%@ Page Title="Inquiries" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="inquiries.aspx.cs" Inherits="eSIS.list.inquiries" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-md-12">
            <div class="panel panel-default">
                <div class="panel-heading">
                    Inquiries
                </div>
                <div class="panel-body">
                    <div class="form-inline">
                        <div class="form-group">
                            <asp:TextBox ID="txtSearch" runat="server" CssClass="form-control" placeholder="Search..."></asp:TextBox>
                            <asp:Button ID="btnSearch" runat="server" CssClass="btn btn-primary" Text="Search" OnClick="btnSearch_Click" />
                        </div>
                    </div>
                    <br />
                    <div class="table table-responsive">
                        <asp:GridView ID="gvInq"
                            EmptyDataText="No Record(s) found"
                            GridLines="None"
                            CssClass="table"
                            AllowPaging="true"
                            AllowSorting="true"
                            ShowHeaderWhenEmpty="true"
                            DataKeyNames="Id"
                            AutoGenerateColumns="false"
                            DataSourceID="InqDataSource"
                            runat="server">
                            <Columns>
                                <asp:BoundField DataField="InquiryID" HeaderText="Inquiry ID" SortExpression="InquiryID" />
                                <asp:BoundField DataField="Company" HeaderText="Company" SortExpression="Company" />
                            </Columns>
                            <PagerStyle CssClass="pagination-ys" />
                        </asp:GridView>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <asp:LinqDataSource ID="InqDataSource"
        OnSelecting="InqDataSource_Selecting"        
        runat="server">
    </asp:LinqDataSource>
</asp:Content>
