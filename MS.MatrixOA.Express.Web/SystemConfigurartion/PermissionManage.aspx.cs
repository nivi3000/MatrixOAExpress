using MS.MatrixOA.Express.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MS.MatrixOA.Express.Web.SystemConfigurartion
{
    public partial class PermissionManage : System.Web.UI.Page
    {
        private PermissionService permissionService;
        public PermissionManage()
        {
            permissionService = new PermissionService();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                grdPermissionDataBind();
                btnAdd.OnClientClick = winEdit.GetShowReference("PermissionEdit.aspx", "新增");
            }
        }

        private void grdPermissionDataBind()
        {
            grdPermission.DataSource = permissionService.FindAll();
            grdPermission.DataBind();
        }

        protected void grdPermission_PageIndexChange(object sender, FineUI.GridPageEventArgs e)
        {
            grdPermission.PageIndex = e.NewPageIndex;
            grdPermissionDataBind();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {

            foreach (int rowIndex in grdPermission.SelectedRowIndexArray)
            {
                int id = Convert.ToInt32(grdPermission.DataKeys[rowIndex + grdPermission.PageIndex * grdPermission.PageSize][0]);
                permissionService.Delete(permissionService.FindBy(id));
            }
            grdPermissionDataBind();
        }

        protected void grdPermission_RowCommand(object sender, FineUI.GridCommandEventArgs e)
        {

            int id = Convert.ToInt32(grdPermission.DataKeys[e.RowIndex][0]);
            if (e.CommandName == "Delete")
            {
                permissionService.Delete(permissionService.FindBy(id));
            }
            grdPermissionDataBind();
        }
    }
}