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
    public partial class DepartmentManage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                grdDepartmentDataBind();
                btnAdd.OnClientClick = winEdit.GetShowReference("DepartmentEdit.aspx", "新增");
            }
        }

        private void grdDepartmentDataBind()
        {
            DepartmentService departmentOp = new DepartmentService();
            grdDepartment.DataSource = departmentOp.GetAll();
            grdDepartment.DataBind();
        }

        protected void grdDepartment_RowCommand(object sender, FineUI.GridCommandEventArgs e)
        {
            DepartmentService departmentService = new DepartmentService();
            int id = Convert.ToInt32(grdDepartment.DataKeys[e.RowIndex][0]);
            if (e.CommandName == "Up")
            {
                departmentService.UpSort(id);
            }
            if (e.CommandName == "Down")
            {
                departmentService.DownSort(id);
            }
            if (e.CommandName == "Delete")
            {
                if (departmentService.HasSubDepartment(id))
                {
                    Alert.ShowInTop("该部门包含其他子部门，无法删除。请先删除其子部门。");
                }
                else
                {
                    departmentService.Delete(id);
                }
            }
            grdDepartmentDataBind();
        }

        protected void grdDepartment_PageIndexChange(object sender, FineUI.GridPageEventArgs e)
        {
            grdDepartment.PageIndex = e.NewPageIndex;
        }
    }
}