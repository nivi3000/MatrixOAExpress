<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ManageTemplate.aspx.cs" Inherits="MS.MatrixOA.Express.Web.ManageTemplate" %>

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
        <f:Grid ID="xxx" Title="xxx" AllowPaging="true" EnableCheckBoxSelect="true" PageSize="20" DataKeyNames="xxx" OnPageIndexChange="xxx_PageIndexChange" OnRowCommand="xxx_RowCommand" runat="server">
            <Columns>
                <f:RowNumberField />

                <f:WindowField WindowID="winEdit" Width="50px" TextAlign="Center" HeaderText="编辑" Icon="Pencil" ToolTip="编辑" DataWindowTitleField="xxx" DataWindowTitleFormatString="编辑 - {0}" DataIFrameUrlFields="xxx" DataIFrameUrlFormatString="xxx.aspx?id={0}" />
                <f:LinkButtonField Icon="Delete" Width="50px" HeaderText="删除" TextAlign="Center" ConfirmText="删除选中的记录？" CommandName="Delete" />
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
        <f:Window ID="winEdit" Title="编辑" Icon="User" EnableIFrame="true" Hidden="true" runat="server" WindowPosition="GoldenSection" CloseAction="HidePostBack" EnableResize="false" Target="Top"
            IsModal="True" Width="400px" Height="119px">
        </f:Window>
    </form>
</body>
</html>
