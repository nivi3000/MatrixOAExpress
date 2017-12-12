using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MS.MatrixOA.Express.Web
{
    public partial class ManageTemplate : System.Web.UI.Page
    {
        //private PathService pathService;
        //public PathManage()
        //{
        //    pathService = new PathService();
        //}
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                xxxDataBind();
                btnAdd.OnClientClick = winEdit.GetShowReference("xxxEdit.aspx", "新增");
            }
        }

        private void xxxDataBind()
        {

        }

        protected void xxx_PageIndexChange(object sender, FineUI.GridPageEventArgs e)
        {
            xxx.PageIndex = e.NewPageIndex;
            xxxDataBind();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            
            foreach (int rowIndex in xxx.SelectedRowIndexArray)
            {
                int id = Convert.ToInt32(xxx.DataKeys[rowIndex + xxx.PageIndex * xxx.PageSize][0]);
                //userGroupService.Delete(userGroupService.FindBy(id));
            }
            xxxDataBind();
        }

        protected void xxx_RowCommand(object sender, FineUI.GridCommandEventArgs e)
        {
            
            int id = Convert.ToInt32(xxx.DataKeys[e.RowIndex][0]);
            if (e.CommandName == "Delete")
            {
                //userGroupService.Delete(userGroupService.FindBy(id));
            }
            xxxDataBind();
        }
    }
}