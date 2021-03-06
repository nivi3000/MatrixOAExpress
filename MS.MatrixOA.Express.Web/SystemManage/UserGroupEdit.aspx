﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserGroupEdit.aspx.cs" Inherits="MS.MatrixOA.Express.Web.SystemManage.UserGroupEdit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <f:PageManager runat="server" />
        <f:SimpleForm ID="frmUserGroupEdit" ShowBorder="false" LabelWidth="70px" BodyPadding="5px" LabelAlign="Right" ShowHeader="false" runat="server">
            <Items>
                <f:TextBox ID="txtGroupName" Label="用户组名" runat="server"></f:TextBox>
            </Items>
            <Toolbars>
                <f:Toolbar Position="Bottom" ToolbarAlign="Right" runat="server">
                    <Items>
                        <f:Button ID="btnOk" Text="确定" Icon="Accept" OnClick="btnOk_Click" runat="server"></f:Button>
                        <f:Button ID="btnCancel" Text="取消" Icon="Cancel" runat="server"></f:Button>
                    </Items>
                </f:Toolbar>
            </Toolbars>
        </f:SimpleForm>
    </form>
</body>
</html>
