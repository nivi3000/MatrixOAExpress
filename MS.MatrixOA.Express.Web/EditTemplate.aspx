<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditTemplate.aspx.cs" Inherits="MS.MatrixOA.Express.Web.EditTemplate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <f:PageManager runat="server" />
        <f:SimpleForm ID="xxx" ShowBorder="false" LabelWidth="70px" BodyPadding="5px" LabelAlign="Right" ShowHeader="false" runat="server">
            <Items>

            </Items>
            <Toolbars>
                <f:Toolbar Position="Bottom" ToolbarAlign="Right" runat="server">
                    <Items>
                        <f:Button ID="btnOk" Text="确定" Icon="Accept" ValidateForms="xxx" OnClick="btnOk_Click" runat="server"></f:Button>
                        <f:Button ID="btnCancel" Text="取消" Icon="Cancel" runat="server"></f:Button>
                    </Items>
                </f:Toolbar>
            </Toolbars>
        </f:SimpleForm>
    </form>
</body>
</html>
