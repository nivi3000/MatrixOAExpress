<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DepartmentManage.aspx.cs" Inherits="MS.MatrixOA.Express.Web.SystemSetting.DepartmentManage" %>

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
        <f:Grid ID="grdDepartment" Title="部门管理" AllowPaging="true" PageSize="20" DataKeyNames="DepartmentId" OnPageIndexChange="grdDepartment_PageIndexChange" OnRowCommand="grdDepartment_RowCommand" runat="server">
            <Columns>
                <f:BoundField DataField="DepartmentName" DataSimulateTreeLevelField="TreeLevel" HeaderText="部门名称" ExpandUnusedSpace="true" />
                <f:BoundField DataField="Description" HeaderText="部门描述"  ExpandUnusedSpace="true"/>
                <f:BoundField DataField="LeaderName" HeaderText="部门负责人" />
                <f:LinkButtonField HeaderText="升" Width="50px" TextAlign="Center" CommandName="Up" Icon="ArrowUp" Text="" />
                <f:LinkButtonField HeaderText="降" Width="50px" TextAlign="Center" CommandName="Down" Icon="ArrowDown" Text="" />
                <f:WindowField WindowID="winEdit" Width="50px" TextAlign="Center" HeaderText="编辑" Icon="Pencil" ToolTip="编辑" DataWindowTitleField="DepartmentName" DataWindowTitleFormatString="编辑 - {0}" DataIFrameUrlFields="DepartmentId" DataIFrameUrlFormatString="DepartmentEdit.aspx?id={0}" />
                <f:LinkButtonField Icon="Delete" Width="50px" HeaderText="删除" TextAlign="Center" ConfirmText="删除选中的记录？" CommandName="Delete" />
            </Columns>
            <Toolbars>
                <f:Toolbar runat="server">
                    <Items>
                        <f:Button ID="btnAdd" Text="新增" Icon="Add" runat="server"></f:Button>
                    </Items>
                </f:Toolbar>
            </Toolbars>
        </f:Grid>
        <f:Window ID="winEdit" Title="编辑" EnableIFrame="true" Hidden="true" runat="server" CloseAction="HidePostBack" EnableMaximize="true" EnableResize="false" Target="Top"
            IsModal="True" Width="700px" Height="261px">
        </f:Window>
    </form>
</body>
</html>
