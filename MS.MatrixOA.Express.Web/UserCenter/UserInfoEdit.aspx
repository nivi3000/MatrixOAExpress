<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserInfoEdit.aspx.cs" Inherits="MS.MatrixOA.Express.Web.UserInfoEdit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
         <f:PageManager ID="PageManager1" runat="server" />
        <f:Window Title="填写用户信息" IsModal="true" EnableDrag="false" WindowPosition="GoldenSection" Icon="UserEdit"  EnableClose="false" runat="server">
            <Items>
                <f:Form ID="frmUserInfo" ShowBorder="false" BodyPadding="5px" ShowHeader="false" LabelWidth="70px" LabelAlign="Right" runat="server">
                    <Items>
                        <f:Panel Layout="Column" ShowBorder="false" Width="580px" ShowHeader="false" runat="server">
                            <Items>
                                <f:Panel ColumnWidth="70%" ShowBorder="false" ShowHeader="false" runat="server">
                                    <Items>
                                        <f:TextBox ID="txtRealName" Width="350px" Label="姓名" runat="server"></f:TextBox>
                                        <f:DropDownList ID="ddlDepartment" Width="350px" Label="部门" EnableSimulateTree="true" DataSimulateTreeLevelField="TreeLevel" DataTextField="DepartmentName" DataValueField="DepartmentId" runat="server"></f:DropDownList>
                                        <f:TextBox ID="txtPost" Width="350px" Label="职位" runat="server"></f:TextBox>
                                        <f:TextBox ID="txtEmail" Width="350px" RegexPattern="EMAIL" RegexMessage="电子邮箱格式不正确" Label="电子邮箱" runat="server"></f:TextBox>
                                        <f:TextBox ID="txtPhone" Width="350px" Label="手机" runat="server"></f:TextBox>
                                        <f:TextBox ID="txtOfficePhone" Width="350px" Label="办公电话" runat="server"></f:TextBox>
                                        <f:TextBox ID="txtFax" Width="350px" Label="传真" runat="server"></f:TextBox>
                                        <f:TextBox ID="txtAddress" Width="350px" Label="家庭地址" runat="server"></f:TextBox>
                                        <f:TextBox ID="txtHomePhone" Width="350px" Label="家庭电话" runat="server"></f:TextBox>
                                    </Items>
                                </f:Panel>
                                <f:Panel ColumnWidth="30%" ShowBorder="false" ShowHeader="false" runat="server">
                                    <Items>
                                        <f:Image ID="imgPhoto" ImageUrl="~/images/pic/user_pic_default.png" ImageCssStyle="border:solid 1px #ccc;padding:5px;" Width="128px" Height="128px" runat="server"></f:Image>
                                        <f:FileUpload ID="filePhoto" ButtonText="上传个人头像" ButtonOnly="true" ButtonIcon="PictureAdd" AcceptFileTypes="" AutoPostBack="true" OnFileSelected="filePhoto_FileSelected"  runat="server"></f:FileUpload>
                                    </Items>
                                </f:Panel>
                            </Items>
                        </f:Panel>
                    </Items>
                </f:Form>
            </Items>
                    <Toolbars>
                        <f:Toolbar Position="Bottom" ToolbarAlign="Right" runat="server">
                            <Items>
                                <f:Button ID="btnOk" Type="Submit" Text="确定" Icon="Accept" ValidateForms="frmUserInfo" OnClick="btnOk_Click" runat="server"></f:Button>
                            </Items>
                        </f:Toolbar>
                    </Toolbars>
        </f:Window> 
    </form>
</body>
</html>
