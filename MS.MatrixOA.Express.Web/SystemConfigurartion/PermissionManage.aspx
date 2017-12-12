<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PermissionManage.aspx.cs" Inherits="MS.MatrixOA.Express.Web.SystemConfigurartion.PermissionManage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
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
        <f:Grid ID="grdPermission" Title="权限管理" AllowPaging="true" EnableCheckBoxSelect="true" PageSize="20" DataKeyNames="PermissionId" OnPageIndexChange="grdPermission_PageIndexChange" OnRowCommand="grdPermission_RowCommand" runat="server">
            <Columns>
                <f:RowNumberField />
                <f:BoundField DataField="PermissionName" HeaderText="权限名称" ExpandUnusedSpace="true" />
                <f:BoundField DataField="Description" HeaderText="权限描述" ExpandUnusedSpace="true" />
                <f:BoundField DataField="Path.PathName" HeaderText="路径" ExpandUnusedSpace="true" />
                <f:WindowField WindowID="winEdit" Width="50px" TextAlign="Center" HeaderText="编辑" Icon="Pencil" ToolTip="编辑" DataWindowTitleField="PermissionName" DataWindowTitleFormatString="编辑 - {0}" DataIFrameUrlFields="PermissionId" DataIFrameUrlFormatString="PermissionEdit.aspx?id={0}" />
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
        <f:Window ID="winEdit" Title="编辑" Icon="Pencil" EnableIFrame="true" Hidden="true" runat="server" WindowPosition="GoldenSection" CloseAction="HidePostBack" EnableResize="false" Target="Top"
            IsModal="True" Width="400px" Height="244px">
        </f:Window>
    </form>
</body>
</html>

