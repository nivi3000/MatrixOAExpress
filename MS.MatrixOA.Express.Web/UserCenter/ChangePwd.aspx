<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ChangePwd.aspx.cs" Inherits="MS.MatrixOA.Express.Web.ChangePwd" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <f:PageManager runat="server" />
        <f:Window Title="修改密码" IsModal="false" WindowPosition="GoldenSection" Icon="UserKey" Width="350px" EnableClose="false" runat="server">
            <Items>
                <f:SimpleForm ID="frmChangePwd" LabelAlign="Right" BodyPadding="5px" runat="server" ShowBorder="false" ShowHeader="false">
                    <Items>
                        <f:TextBox ID="txtOldPwd" Label="当前密码" TextMode="Password" Required="true" runat="server"></f:TextBox>
                        <f:TextBox ID="txtNewPwd" Label="新密码" TextMode="Password" Required="true" Regex="[\da-zA-Z]{6,16}" RegexMessage="输入6-16位字母或数字" runat="server"></f:TextBox>
                        <f:TextBox ID="txtNewPwdAgain" Label="重复新密码" TextMode="Password" Required="true" CompareControl="txtNewPwd" CompareOperator="Equal" CompareMessage="二次密码不一致" runat="server"></f:TextBox>
                    </Items>
                </f:SimpleForm>
            </Items>
            <Toolbars>
                <f:Toolbar Position="Bottom" ToolbarAlign="Right" runat="server">
                    <Items>
                        <f:Button ID="btnOk" Type="Submit" Text="确定" Icon="Accept" ValidateForms="frmChangePwd" OnClick="btnOk_Click" runat="server"></f:Button>
                    </Items>
                </f:Toolbar>
            </Toolbars>
        </f:Window>    
    </form>
</body>
</html>
