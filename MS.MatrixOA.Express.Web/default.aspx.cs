using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using MS.MatrixOA.Express.Business;

namespace MS.MatrixOA.Express.Web
{
    public partial class _default : System.Web.UI.Page
    {
        private bool isCleared = false;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                leftMenuTreeDataBind();
            }
        }

        private void leftMenuTreeDataBind()
        {
            //FineUI.TreeNode tnUserCenter = new FineUI.TreeNode();
            //tnUserCenter.Text = "用户中心";
            //tnUserCenter.Nodes.Add(new FineUI.TreeNode { Text = "用户信息", NavigateUrl = "~/UserCenter/UserInfoEdit.aspx" });
            //tnUserCenter.Nodes.Add(new FineUI.TreeNode { Text = "修改密码", NavigateUrl = "~/UserCenter/ChangePwd.aspx" });
            //leftMenuTree.Nodes.Add(tnUserCenter);

            //FineUI.TreeNode tnSystemManage = new FineUI.TreeNode();
            //tnSystemManage.Text = "系统管理";
            //tnSystemManage.Nodes.Clear();
            //tnSystemManage.Nodes.Add(new FineUI.TreeNode { Text = "部门管理", NavigateUrl = "~/SystemManage/DepartmentManage.aspx" });
            //tnSystemManage.Nodes.Add(new FineUI.TreeNode { Text = "用户管理", NavigateUrl = "~/SystemManage/UserManage.aspx" });
            //tnSystemManage.Nodes.Add(new FineUI.TreeNode { Text = "用户组管理", NavigateUrl = "~/SystemManage/UserGroupManage.aspx" });

            //leftMenuTree.Nodes.Add(tnSystemManage);
            XElement root = XElement.Load(Server.MapPath("MainMenu.xml"));
            foreach (var item in root.Elements())
            {
                FineUI.TreeNode tn = new FineUI.TreeNode();
                tn.Text = item.Attribute("Text").Value;
                tn.IconUrl = item.Attribute("ImageUrl").Value;
                if (item.Attribute("NavigateUrl") != null)
                {
                    tn.NavigateUrl = item.Attribute("NavigateUrl").Value;
                }
                //GroupInPermission groupPermission = groupPermissionService.FindBy(v => v.Permission.PermissionName == "浏览" && v.GroupId == 2 && v.Permission.Path.PathName == tn.Text);
                //if (groupPermission != null && !groupPermission.Enabled)
                //{
                //    continue;
                //}
                loadSubMenu(item, tn);
                leftMenuTree.Nodes.Add(tn);
            }
            clearLeftMenuTree();
        }

        private void clearLeftMenuTree()
        {
            while (true)
            {
                isCleared = true;
                for (int i = 0; i < leftMenuTree.Nodes.Count; i++)
                {
                    clearTreeNode(leftMenuTree.Nodes[i]);

                }
                if (isCleared)
                {
                    break;
                }
            }
        }

        private void clearTreeNode(FineUI.TreeNode tn)
        {
            if (string.IsNullOrEmpty(tn.NavigateUrl) && tn.Nodes.Count == 0)
            {
                if (tn.ParentNode == null)
                {
                    leftMenuTree.Nodes.Remove(tn);
                }
                else
                {
                    tn.ParentNode.Nodes.Remove(tn);
                }
                isCleared = false;
            }
            else
            {
                for (int i = 0; i < tn.Nodes.Count; i++)
                {
                    clearTreeNode(tn.Nodes[i]);
                }
            }
        }

        private void loadSubMenu(XElement parentItem, FineUI.TreeNode parentNode)
        {
            //BaseRepository<GroupInPermission> groupPermissionService = new BaseRepository<GroupInPermission>();

            foreach (var item in parentItem.Elements())
            {
                FineUI.TreeNode tn = new FineUI.TreeNode();
                tn.Text = item.Attribute("Text").Value;
                tn.IconUrl = item.Attribute("ImageUrl").Value;
                if (item.Attribute("NavigateUrl") != null)
                {
                    tn.NavigateUrl = item.Attribute("NavigateUrl").Value;
                }
                //GroupInPermission groupPermission = groupPermissionService.FindBy(v => v.Permission.PermissionName == "浏览" && v.GroupId == 2 && v.Permission.Path.PathName == tn.Text);
                //if (groupPermission != null && !groupPermission.Enabled)
                //{
                //    continue;
                //}
                loadSubMenu(item, tn);
                parentNode.Nodes.Add(tn);
            }
        }
    }
}