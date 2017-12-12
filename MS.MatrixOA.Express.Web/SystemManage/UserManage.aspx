<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserManage.aspx.cs" Inherits="MS.MatrixOA.Express.Web.SystemManage.UserManage" %>

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
        <f:Grid ID="grdUser" Title="用户管理" AllowPaging="true" EnableCheckBoxSelect="true" IsDatabasePaging="true" PageSize="20" DataKeyNames="UserId" OnPageIndexChange="grdUser_PageIndexChange" OnRowCommand="grdUser_RowCommand" runat="server">
            <Columns>
                <f:RowNumberField />
                <f:BoundField DataField="UserName" ExpandUnusedSpace="true" HeaderText="用户名" />
                <f:BoundField DataField="Password" ExpandUnusedSpace="true" HeaderText="密码" />
                <f:CheckBoxField DataField="Audit" HeaderText="审核" />
                <f:WindowField WindowID="winEdit" Width="50px" TextAlign="Center" HeaderText="编辑" Icon="Pencil" ToolTip="编辑" DataWindowTitleField="UserName" DataWindowTitleFormatString="编辑 - {0}" DataIFrameUrlFields="UserId" DataIFrameUrlFormatString="UserEdit.aspx?id={0}" />
                <f:LinkButtonField Icon="Delete" Width="50px" HeaderText="删除" TextAlign="Center" ConfirmText="删除选中的记录？" CommandName="Delete" />
                <f:WindowField WindowID="winUserInfoEdit" Width="100px" TextAlign="Center" HeaderText="编辑用户信息" Icon="Pencil" ToolTip="编辑" DataWindowTitleField="UserName" DataWindowTitleFormatString="编辑用户信息 - {0}" DataIFrameUrlFields="UserId" DataIFrameUrlFormatString="UserInfoEdit.aspx?id={0}" />
                <f:WindowField WindowID="winUserPermissionEdit" Width="100px" TextAlign="Center" HeaderText="编辑用户权限" Icon="Pencil" ToolTip="编辑" DataWindowTitleField="UserName" DataWindowTitleFormatString="编辑用户权限 - {0}" DataIFrameUrlFields="UserId" DataIFrameUrlFormatString="UserPermissionEdit.aspx?id={0}" />
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
        <f:Window ID="winEdit" Title="编辑" Icon="UserAdd" EnableIFrame="true" Hidden="true" runat="server" WindowPosition="GoldenSection" CloseAction="HidePostBack" EnableResize="false" Target="Top"
            IsModal="True" Width="400px" Height="208px">
        </f:Window>
        <f:Window ID="winUserInfoEdit" Title="编辑" Icon="UserAdd" EnableIFrame="true" Hidden="true" runat="server" WindowPosition="GoldenSection" CloseAction="HidePostBack" EnableResize="false" Target="Top"
            IsModal="True" Width="620px" Height="508px">
        </f:Window>
    </form>
</body>
</html>
