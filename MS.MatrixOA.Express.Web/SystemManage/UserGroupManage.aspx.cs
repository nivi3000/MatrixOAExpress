using MS.MatrixOA.Express.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MS.MatrixOA.Express.Web.SystemManage
{
    public partial class UserGroupManage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                grdUserGroupDataBind();
                btnAdd.OnClientClick = winEdit.GetShowReference("UserGroupEdit.aspx", "新增");
            }
        }

        private void grdUserGroupDataBind()
        {
            UserGroupService userGroupService = new UserGroupService();
            grdUserGroup.DataSource = userGroupService.FindAll();
            grdUserGroup.DataBind();
        }

        protected void grdUserGroup_PageIndexChange(object sender, FineUI.GridPageEventArgs e)
        {
            grdUserGroup.PageIndex = e.NewPageIndex;
            grdUserGroupDataBind();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            UserGroupService userGroupService = new UserGroupService();
            foreach (int rowIndex in grdUserGroup.SelectedRowIndexArray)
            {
                int id = Convert.ToInt32(grdUserGroup.DataKeys[rowIndex + grdUserGroup.PageIndex * grdUserGroup.PageSize][0]);
                userGroupService.Delete(userGroupService.FindBy(id));
            }
            grdUserGroupDataBind();
        }

        protected void grdUserGroup_RowCommand(object sender, FineUI.GridCommandEventArgs e)
        {
            UserGroupService userGroupService = new UserGroupService();
            int id = Convert.ToInt32(grdUserGroup.DataKeys[e.RowIndex][0]);
            if (e.CommandName == "Delete")
            {
                userGroupService.Delete(userGroupService.FindBy(id));
            }
            grdUserGroupDataBind();
        }
    }
}