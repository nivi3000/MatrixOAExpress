<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DepartmentEdit.aspx.cs" Inherits="MS.MatrixOA.Express.Web.SystemSetting.DepartmentEdit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <f:PageManager runat="server" />
        <f:SimpleForm ID="frmEdit" ShowBorder="false" ShowHeader="false" BodyPadding="10px" LabelAlign="Right" runat="server">
            <Items>
                <f:TextBox ID="txtDepartmentName" Label="部门名称" runat="server"></f:TextBox>
                <f:TextArea ID="txtDescription" Label="部门描述" runat="server"></f:TextArea>
                <f:DropDownList ID="ddlParent" Label="上级部门" EnableSimulateTree="true" runat="server"></f:DropDownList>
                <f:DropDownList ID="ddlLeader" Label="部门负责人" runat="server"></f:DropDownList>
            </Items>
            <Toolbars>
                <f:Toolbar Position="Bottom" ToolbarAlign="Right" runat="server">
                    <Items>
                        <f:Button ID="btnOk" Text="确定" Icon="Accept" Type="Submit" OnClick="btnOk_Click" runat="server"></f:Button>
                        <f:Button ID="btnCancel" Text="取消" Icon="Cancel" runat="server"></f:Button>
                    </Items>
                </f:Toolbar>
            </Toolbars>
        </f:SimpleForm>
    </form>
</body>
</html>
