﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs"
    Inherits="MS.MatrixOA.Express.Web.login" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <f:PageManager ID="PageManager1" runat="server" />
        <f:Window ID="Window1" runat="server" Title="登录表单" Icon="LockKey" EnableDrag="false" IsModal="false" EnableClose="false"
            WindowPosition="GoldenSection" Width="350px">
            <Items>
                <f:SimpleForm ID="SimpleForm1" runat="server" ShowBorder="false" BodyPadding="10px"
                    LabelWidth="60px" ShowHeader="false">
                    <Items>
                        <f:TextBox ID="txtUserName" Label="用户名" Required="true" runat="server">
                        </f:TextBox>
                        <f:TextBox ID="txtPassword" Label="密码" TextMode="Password" Required="true" runat="server">
                        </f:TextBox>
                        <f:TextBox ID="txtCaptcha" Label="验证码" Required="true" runat="server">
                        </f:TextBox>
                        <f:Panel CssStyle="padding-left:65px;" ShowBorder="false" ShowHeader="false"
                            runat="server">
                            <Items>
                                <f:Image ID="imgCaptcha" CssStyle="float:left;width:160px;" runat="server">
                                </f:Image>
                                <f:LinkButton CssStyle="float:left;margin-top:8px;" ID="btnRefresh" Text="看不清？"
                                    runat="server" OnClick="btnRefresh_Click">
                                </f:LinkButton>
                            </Items>
                        </f:Panel>
                    </Items>
                </f:SimpleForm>
            </Items>
            <Toolbars>
                <f:Toolbar ID="Toolbar1" runat="server" Position="Bottom" ToolbarAlign="Right">
                    <Items>
                        <f:Button ID="btnLogin" Text="登录" Icon="Key" Type="Submit" ValidateForms="SimpleForm1" ValidateTarget="Top"
                            runat="server" OnClick="btnLogin_Click">
                        </f:Button>
                        <f:Button ID="btnRegist" Text="注册" Icon="UserAdd" OnClick="btnRegist_Click" runat="server"></f:Button>
                    </Items>
                </f:Toolbar>
            </Toolbars>
        </f:Window>
    </form>
</body>
</html>
