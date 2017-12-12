<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PathEdit.aspx.cs" Inherits="MS.MatrixOA.Express.Web.SystemConfigurartion.PathEdit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <f:PageManager runat="server" />
        <f:SimpleForm ID="frmPathEdit" ShowBorder="false" LabelWidth="70px" BodyPadding="5px" LabelAlign="Right" ShowHeader="false" runat="server">
            <Items>
                <f:TextBox ID="txtPathName" Label="路径名称" Required="true" runat="server"></f:TextBox>
                <f:TextBox ID="txtPathUrl" Label="路径地址" Required="true" runat="server"></f:TextBox>
            </Items>
            <Toolbars>
                <f:Toolbar Position="Bottom" ToolbarAlign="Right" runat="server">
                    <Items>
                        <f:Button ID="btnOk" Text="确定" Icon="Accept" ValidateForms="frmPathEdit" OnClick="btnOk_Click" runat="server"></f:Button>
                        <f:Button ID="btnCancel" Text="取消" Icon="Cancel" runat="server"></f:Button>
                    </Items>
                </f:Toolbar>
            </Toolbars>
        </f:SimpleForm>

    </form>
</body>
</html>
