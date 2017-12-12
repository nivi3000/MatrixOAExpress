using MS.MatrixOA.Express.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MS.MatrixOA.Express.Web.SystemManage
{
    public partial class UserManage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                grdUserDataBind();
                btnAdd.OnClientClick = winEdit.GetShowReference("UserEdit.aspx", "新增");
            }
        }

        private void grdUserDataBind()
        {
            UserService userService = new UserService();
            int recordCount;
            grdUser.DataSource = userService.FindAll<int>(grdUser.PageSize, grdUser.PageIndex, out recordCount,true,v=>v.UserId);
            grdUser.RecordCount = recordCount;
            grdUser.DataBind();
        }

        protected void grdUser_PageIndexChange(object sender, FineUI.GridPageEventArgs e)
        {
            grdUser.PageIndex = e.NewPageIndex;
            grdUserDataBind();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            UserService userService = new UserService();
            foreach(int rowIndex in grdUser.SelectedRowIndexArray)
            {
                int id = Convert.ToInt32(grdUser.DataKeys[rowIndex + grdUser.PageIndex * grdUser.PageSize][0]);
                userService.Delete(userService.FindBy(id));
            }
            grdUserDataBind();
        }

        protected void grdUser_RowCommand(object sender, FineUI.GridCommandEventArgs e)
        {
            UserService userService = new UserService();
            int id = Convert.ToInt32(grdUser.DataKeys[e.RowIndex][0]);
            if(e.CommandName=="Delete")
            {
                userService.Delete(userService.FindBy(id));
            }
            grdUserDataBind();
        }
    }
}