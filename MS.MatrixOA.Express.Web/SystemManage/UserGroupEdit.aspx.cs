using FineUI;
using MS.MatrixOA.Express.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MS.MatrixOA.Express.Web.SystemManage
{
    public partial class UserGroupEdit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
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
            UserGroupService userGroupService = new UserGroupService();
            UserGroup userGroup = userGroupService.FindBy(id);
            txtGroupName.Text = userGroup.GroupName;
        }

        protected void btnOk_Click(object sender, EventArgs e)
        {
            UserGroupService service = new UserGroupService();
            UserGroup userGroup = new UserGroup { GroupName = txtGroupName.Text };
            int id;
            if (int.TryParse(Request["id"], out id))
            {
                userGroup.GroupId = id;
                service.Update(userGroup);
            }
            else
            {
                service.Create(userGroup);
            }
            PageContext.RegisterStartupScript(ActiveWindow.GetHideRefreshReference());
        }
    }
}