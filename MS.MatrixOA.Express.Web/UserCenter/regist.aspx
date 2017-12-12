<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Regist.aspx.cs" Inherits="MS.MatrixOA.Express.Web.regist" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <f:PageManager runat="server" />
        <f:Window ID="winRegist" WindowPosition="GoldenSection" Title="用户注册" Icon="UserAdd" Width="350px" EnableClose="false" EnableDrag="false" runat="server">
            <Items>
                <f:SimpleForm ID="frmRegist" LabelWidth="80px" ShowBorder="false" ShowHeader="false" LabelAlign="Right" BodyPadding="10px"  runat="server">
                    <Items>
                        <f:TextBox ID="txtUserName" Label="用户名" Required="true" runat="server"></f:TextBox>
                        <f:TextBox ID="txtPwd" Label="密码" TextMode="Password" Required="true" runat="server"></f:TextBox>
                        <f:TextBox ID="txtPwdAgain" Label="重复密码" TextMode="Password" Required="true" CompareControl="txtPwd" CompareOperator="Equal" CompareMessage="二次密码输入不一致" runat="server"></f:TextBox>
                    </Items>
                </f:SimpleForm>
            </Items>
            <Toolbars>
                <f:Toolbar ID="tbRegist" Position="Bottom" ToolbarAlign="Right" runat="server">
                    <Items>
                        <f:Button ID="btnRegist" Text="确定" Icon="Accept" OnClick="btnRegist_Click" Type="Submit" ValidateForms="frmRegist" runat="server"></f:Button>
                        <f:Button ID="btnCancel" Text="取消" Icon="Cancel" OnClick="btnCancel_Click" runat="server"></f:Button>
                    </Items>
                </f:Toolbar>
            </Toolbars>
        </f:Window>
    </form>
</body>
</html>
