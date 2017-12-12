<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PathManage.aspx.cs" Inherits="MS.MatrixOA.Express.Web.SystemConfigurartion.PathManage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <style type="text/css">
        body {
            padding: 20px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <f:PageManager runat="server" />
        <f:Grid ID="grdPath" Title="路径管理" AllowPaging="true" EnableCheckBoxSelect="true" PageSize="20" DataKeyNames="PathId" OnPageIndexChange="grdPath_PageIndexChange" OnRowCommand="grdPath_RowCommand" runat="server">
            <Columns>
                <f:RowNumberField />
                <f:BoundField DataField="PathName" HeaderText="路径名称" ExpandUnusedSpace="true" />
                <f:BoundField DataField="PathUrl" HeaderText="路径地址" ExpandUnusedSpace="true" />
                <f:WindowField WindowID="winEdit" Width="50px" TextAlign="Center" HeaderText="编辑" Icon="Pencil" ToolTip="编辑" DataWindowTitleField="PathName" DataWindowTitleFormatString="编辑 - {0}" DataIFrameUrlFields="PathId" DataIFrameUrlFormatString="PathEdit.aspx?id={0}" />
                <f:LinkButtonField Icon="Delete" Width="50px" HeaderText="删除" TextAlign="Center" ConfirmText="删除选中的记录？" CommandName="Delete" />
            </Columns>
            <Toolbars>
                <f:Toolbar runat="server">
                    <Items>
                        <f:Button ID="btnAdd" Text="新增" Icon="Add" runat="server"></f:Button>
                        <f:Button ID="btnDelete" Text="删除" Icon="Delete" runat="server" OnClick="btnDelete_Click"></f:Button>
                    </Items>
                </f:Toolbar>
            </Toolbars>
        </f:Grid>
        <f:Window ID="winEdit" Title="编辑" Icon="ApplicationFormEdit" EnableIFrame="true" Hidden="true" runat="server" WindowPosition="GoldenSection" CloseAction="HidePostBack" EnableResize="false" Target="Top"
            IsModal="True" Width="400px" Height="148px">
        </f:Window>
    </form>
</body>
</html>

