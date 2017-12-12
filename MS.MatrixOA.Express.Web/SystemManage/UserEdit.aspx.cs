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
    public partial class UserEdit : System.Web.UI.Page
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
            UserService userService = new UserService();
            User user = userService.FindBy(id);
            txtUserName.Text = user.UserName;
            txtPassword.Text = user.Password;
            chkAudit.Checked = user.Audit;
        }

        protected void btnOk_Click(object sender, EventArgs e)
        {
            UserService userService = new UserService();
            User user = new User
            {
                UserName = txtUserName.Text,
                Password = txtPassword.Text,
                Audit = chkAudit.Checked
            };
            int id;
            if (int.TryParse(Request["id"], out id))
            {
                user.UserId = id;
                userService.Update(user);
            }
            else
            {
                User userAdded = userService.Create(user);
                UserInfoService userInfoService = new UserInfoService();
                userInfoService.Create(new UserInfo { UserId = userAdded.UserId });
            }

            PageContext.RegisterStartupScript(ActiveWindow.GetHideRefreshReference());
        }

    }
}