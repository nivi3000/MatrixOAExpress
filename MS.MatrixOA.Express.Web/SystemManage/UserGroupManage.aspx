<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserGroupManage.aspx.cs" Inherits="MS.MatrixOA.Express.Web.SystemManage.UserGroupManage" %>

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
        <f:Grid ID="grdUserGroup" Title="用户组管理" AllowPaging="true" EnableCheckBoxSelect="true" PageSize="20" DataKeyNames="GroupId" OnPageIndexChange="grdUserGroup_PageIndexChange" OnRowCommand="grdUserGroup_RowCommand" runat="server">
            <Columns>
                <f:RowNumberField />
                <f:BoundField DataField="GroupName" HeaderText="用户组名" />
                <f:WindowField WindowID="winEdit" Width="50px" TextAlign="Center" HeaderText="编辑" Icon="Pencil" ToolTip="编辑" DataWindowTitleField="GroupName" DataWindowTitleFormatString="编辑 - {0}" DataIFrameUrlFields="GroupId" DataIFrameUrlFormatString="UserGroupEdit.aspx?id={0}" />
                <f:LinkButtonField Icon="Delete" Width="50px" HeaderText="删除" TextAlign="Center" ConfirmText="删除选中的记录？" CommandName="Delete" />
                <f:WindowField WindowID="winPermissionEdit" Width="100px" TextAlign="Center" HeaderText="编辑用户组权限" Icon="Pencil" ToolTip="编辑编辑用户组权限" DataWindowTitleField="GroupName" DataWindowTitleFormatString="编辑用户组权限 - {0}" DataIFrameUrlFields="GroupId" DataIFrameUrlFormatString="UserGroupPermissionEdit.aspx?id={0}" />
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
        <f:Window ID="winEdit" Title="编辑" Icon="User" EnableIFrame="true" Hidden="true" runat="server" WindowPosition="GoldenSection" CloseAction="HidePostBack" EnableResize="false" Target="Top"
            IsModal="True" Width="400px" Height="119px">
        </f:Window>
        <f:Window ID="winPermissionEdit" Title="编辑" Icon="UserKey" EnableIFrame="true" Hidden="true" runat="server" WindowPosition="GoldenSection" CloseAction="HidePostBack" EnableResize="false" Target="Top"
            IsModal="True" Width="700px" Height="600px">
        </f:Window>
    </form>
</body>
</html>
