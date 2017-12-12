using FineUI;
using MS.MatrixOA.Express.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MS.MatrixOA.Express.Web.SystemSetting
{
    public partial class DepartmentEdit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlParentDataBind();
                ddlLeaderDataBind();
                btnCancel.OnClientClick = ActiveWindow.GetHideReference();
                int id;
                if (int.TryParse(Request["id"], out id))
                {
                    loadData(id);
                }
            }
        }

        private void loadData(int id)
        {
            DepartmentService departmentService = new DepartmentService();
            Department department = departmentService.GetBy(id);
            txtDepartmentName.Text = department.DepartmentName;
            txtDescription.Text = department.Description;
            ddlLeader.SelectedValue = department.LeaderId.ToString();
            ddlParent.SelectedValue = department.ParentId.ToString();
        }

        private void ddlLeaderDataBind()
        {
            UserService userOp = new UserService();
            ddlLeader.DataTextField = "RealName";
            ddlLeader.DataValueField = "UserId";
            ddlLeader.DataSource = userOp.FindAll();
            ddlLeader.DataBind();
            ddlLeader.Items.Insert(0, new FineUI.ListItem("无", "0"));
        }

        private void ddlParentDataBind()
        {
            DepartmentService departmentOp = new DepartmentService();
            ddlParent.DataTextField = "DepartmentName";
            ddlParent.DataValueField = "DepartmentId";
            ddlParent.DataSimulateTreeLevelField = "TreeLevel";
            ddlParent.DataSource = departmentOp.GetAll();
            ddlParent.DataBind();
            ddlParent.Items.Insert(0, new FineUI.ListItem("无", "0"));
        }

        protected void btnOk_Click(object sender, EventArgs e)
        {
            DepartmentService departmentService = new DepartmentService();
            Department department=new Department
                {
                    DepartmentName = txtDepartmentName.Text,
                    Description = txtDescription.Text,
                    ParentId = int.Parse(ddlParent.SelectedValue),
                    LeaderId = int.Parse(ddlLeader.SelectedValue),
                    SortCode = departmentService.GetSortCode(int.Parse(ddlParent.SelectedValue))
                };
            int id;
            if (int.TryParse(Request["id"], out id))
            {
                department.DepartmentId = id;
                departmentService.Update(department);
            }
            else
            {
                departmentService.Create(department);
            }

            PageContext.RegisterStartupScript(ActiveWindow.GetHideRefreshReference());
        }
    }
}