using FineUI;
using MS.MatrixOA.Express.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MS.MatrixOA.Express.Web.SystemConfigurartion
{
    public partial class PermissionEdit : System.Web.UI.Page
    {
        private PermissionService permissionService;
        private int id;

        public PermissionEdit()
        {
            permissionService = new PermissionService();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            id = Request["id"] != null ? int.Parse(Request["id"]) : 0;
            if (!IsPostBack)
            {
                btnCancel.OnClientClick = ActiveWindow.GetHideReference();
                ddlPathDataBind();
                if (id != 0)
                {
                    loadData(id);
                }
            }
        }

        private void ddlPathDataBind()
        {
            PathService pathService = new PathService();
            ddlPath.DataSource = pathService.FindAll();
            ddlPath.DataTextField = "PathName";
            ddlPath.DataValueField = "PathId";
            ddlPath.DataBind();
        }

        private void loadData(int id)
        {
            Permission permission = permissionService.FindBy(id);
            ddlPermissionName.SelectedValue = permission.PermissionName;
            txtDescription.Text = permission.Description;
            ddlPath.SelectedValue = permission.PathId.ToString();
        }

        protected void btnOk_Click(object sender, EventArgs e)
        {
            Permission permission = new Permission
            {
                PermissionName = ddlPermissionName.SelectedValue,
                Description=txtDescription.Text,
                PathId=int.Parse(ddlPath.SelectedValue)
            };
            if (id != 0)
            {
                permission.PermissionId = id;
                permissionService.Update(permission);
            }
            else
            {
                permissionService.Create(permission);
            }
            PageContext.RegisterStartupScript(ActiveWindow.GetHideRefreshReference());
        }
    }
}