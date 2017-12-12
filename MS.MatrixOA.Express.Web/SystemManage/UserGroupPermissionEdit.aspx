<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserGroupPermissionEdit.aspx.cs" Inherits="MS.MatrixOA.Express.Web.SystemManage.UserGroupPermissionEdit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <style type="text/css">
        .chk {
            margin-top: 20px;
            border-top: 1px solid #ccc;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <f:PageManager runat="server" />
        <f:Form ID="frmUserGroupPermissionEdit" ShowBorder="false" LabelAlign="Right" BodyPadding="5px" ShowHeader="false" runat="server">
            <Items>
                <f:CheckBox ID="chkUserCenter" Label="用户中心" CssStyle="font-weight:bold;" OnCheckedChanged="chk_CheckedChanged" AutoPostBack="true" runat="server"></f:CheckBox>
                <f:CheckBox ID="chkUserInfo" Label="用户信息" runat="server"></f:CheckBox>
                <f:CheckBox ID="chkChangePassword" Label="修改密码" runat="server"></f:CheckBox>
                <f:CheckBox ID="chkSystemManage" CssClass="chk" Label="系统管理" AutoPostBack="true" OnCheckedChanged="chk_CheckedChanged" runat="server"></f:CheckBox>
                <f:Panel Layout="Column" ShowBorder="false" ShowHeader="false" runat="server">
                    <Items>
                        <f:CheckBox ID="chkDepartment" Label="部门管理" OnCheckedChanged="chk_CheckedChanged" ColumnWidth="20%" AutoPostBack="true" runat="server"></f:CheckBox>
                        <f:CheckBoxList ID="chkDepartmentOperator" Label="" ColumnWidth="80%" runat="server">
                            <f:CheckItem Text="新增" Value="新增" />
                            <f:CheckItem Text="删除" Value="删除" />
                            <f:CheckItem Text="修改" Value="修改" />
                            <f:CheckItem Text="排序" Value="排序" />
                        </f:CheckBoxList>
                    </Items>
                </f:Panel>
                <f:Panel Layout="Column" ShowBorder="false" ShowHeader="false" runat="server">
                    <Items>
                        <f:CheckBox ID="chkUser" Label="用户管理" ColumnWidth="20%" OnCheckedChanged="chk_CheckedChanged" AutoPostBack="true" runat="server"></f:CheckBox>
                        <f:CheckBoxList ID="chkUserOperator" Label="" ColumnWidth="80%" runat="server">
                            <f:CheckItem Text="新增" Value="新增" />
                            <f:CheckItem Text="删除" Value="删除" />
                            <f:CheckItem Text="修改" Value="修改" />
                            <f:CheckItem Text="编辑用户信息" Value="编辑用户信息" />
                            <f:CheckItem Text="编辑用户权限" Value="编辑用户权限" />
                        </f:CheckBoxList>
                    </Items>
                </f:Panel>
                <f:Panel Layout="Column" ShowBorder="false" ShowHeader="false" runat="server">
                    <Items>
                        <f:CheckBox ID="chkUserGroup" Label="用户组管理" ColumnWidth="20%" OnCheckedChanged="chk_CheckedChanged" AutoPostBack="true" runat="server"></f:CheckBox>
                        <f:CheckBoxList ID="chkUserGroupOperator" Label="" ColumnWidth="80%" runat="server">
                            <f:CheckItem Text="新增" Value="新增" />
                            <f:CheckItem Text="删除" Value="删除" />
                            <f:CheckItem Text="修改" Value="修改" />
                            <f:CheckItem Text="编辑用户组权限" Value="编辑用户组权限" />
                        </f:CheckBoxList>
                    </Items>
                </f:Panel>


            </Items>
            <Toolbars>
                <f:Toolbar Position="Bottom" ToolbarAlign="Right" runat="server">
                    <Items>
                        <f:Button ID="btnOk" Text="确定" Icon="Accept" OnClick="btnOk_Click" runat="server"></f:Button>
                        <f:Button ID="btnCancel" Text="取消" Icon="Cancel" runat="server"></f:Button>
                    </Items>
                </f:Toolbar>
            </Toolbars>
        </f:Form>
    </form>
</body>
</html>
