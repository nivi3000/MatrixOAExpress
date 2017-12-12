<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PermissionEdit.aspx.cs" Inherits="MS.MatrixOA.Express.Web.SystemConfigurartion.PermissionEdit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <f:PageManager runat="server" />
        <f:SimpleForm ID="frmPermissionEdit" ShowBorder="false" LabelWidth="70px" BodyPadding="10px" LabelAlign="Right" ShowHeader="false" runat="server">
            <Items>
                <f:DropDownList ID="ddlPermissionName" Label="权限名称" EnableEdit="true" ForceSelection="false" Required="true" runat="server">
                    <f:ListItem Text="浏览" Value="浏览" />
                    <f:ListItem Text="新增" Value="新增" />
                    <f:ListItem Text="删除" Value="删除" />
                    <f:ListItem Text="修改" Value="修改" />
                    <f:ListItem Text="查询" Value="查询" />
                </f:DropDownList>
                <f:TextArea ID="txtDescription" Label="权限说明" Height="80px" runat="server"></f:TextArea>
                <f:DropDownList ID="ddlPath" Label="路径" runat="server"></f:DropDownList>
            </Items>
            <Toolbars>
                <f:Toolbar Position="Bottom" ToolbarAlign="Right" runat="server">
                    <Items>
                        <f:Button ID="btnOk" Text="确定" Icon="Accept" ValidateForms="frmPermissionEdit" OnClick="btnOk_Click" runat="server"></f:Button>
                        <f:Button ID="btnCancel" Text="取消" Icon="Cancel" runat="server"></f:Button>
                    </Items>
                </f:Toolbar>
            </Toolbars>
        </f:SimpleForm>
    </form>
</body>
</html>
