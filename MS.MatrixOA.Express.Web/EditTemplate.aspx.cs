using FineUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MS.MatrixOA.Express.Web
{
    public partial class EditTemplate : System.Web.UI.Page
    {
        //private PathService pathService;
        private int id;
        protected void Page_Load(object sender, EventArgs e)
        {
            id = Request["id"] != null ? int.Parse(Request["id"]) : 0;
            if (!IsPostBack)
            {
                btnCancel.OnClientClick = ActiveWindow.GetHideReference();
                if (id != 0)
                {
                    loadData(id);
                }
            }
        }

        private void loadData(int id)
        {
            //UserGroupService userGroupService = new UserGroupService();
            //UserGroup userGroup = userGroupService.FindBy(id);

        }

        protected void btnOk_Click(object sender, EventArgs e)
        {
            //UserGroupService service = new UserGroupService();
            //UserGroup userGroup = new UserGroup { GroupName = txtGroupName.Text };
            if (id != 0)
            {
                //userGroup.GroupId = id;
                //service.Update(userGroup);
            }
            else
            {
                //service.Create(userGroup);
            }
            PageContext.RegisterStartupScript(ActiveWindow.GetHideRefreshReference());
        }
    }
}