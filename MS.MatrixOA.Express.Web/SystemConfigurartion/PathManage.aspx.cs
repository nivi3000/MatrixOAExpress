using MS.MatrixOA.Express.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MS.MatrixOA.Express.Web.SystemConfigurartion
{
    public partial class PathManage : System.Web.UI.Page
    {
        private PathService pathService;

        public PathManage()
        {
            pathService = new PathService();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                grdPathDataBind();
                btnAdd.OnClientClick = winEdit.GetShowReference("PathEdit.aspx", "新增");
            }
        }

        private void grdPathDataBind()
        {
            grdPath.DataSource = pathService.FindAll();
            grdPath.DataBind();
        }

        protected void grdPath_PageIndexChange(object sender, FineUI.GridPageEventArgs e)
        {
            grdPath.PageIndex = e.NewPageIndex;
            grdPathDataBind();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (int rowIndex in grdPath.SelectedRowIndexArray)
            {
                int id = Convert.ToInt32(grdPath.DataKeys[rowIndex + grdPath.PageIndex * grdPath.PageSize][0]);
                pathService.Delete(pathService.FindBy(id));
            }
            grdPathDataBind();
        }

        protected void grdPath_RowCommand(object sender, FineUI.GridCommandEventArgs e)
        {
            int id = Convert.ToInt32(grdPath.DataKeys[e.RowIndex][0]);
            if (e.CommandName == "Delete")
            {
                pathService.Delete(pathService.FindBy(id));
            }
            grdPathDataBind();
        }
    }
}