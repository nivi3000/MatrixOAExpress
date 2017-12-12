using MS.MatrixOA.Express.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MS.MatrixOA.Express.Web
{
    public partial class regist : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegist_Click(object sender, EventArgs e)
        {
            UserService user = new UserService();
            UserInfoService userInfoService = new UserInfoService();
            if (user.CheckUserNameForRegist(txtUserName.Text.Trim()))
            {
                user.Add(new User
                {
                    UserName = txtUserName.Text.Trim(),
                    Password = txtPwd.Text,
                    Audit = false
                });
                int userId=user.GetUserByUserName(txtUserName.Text.Trim()).UserId;
                userInfoService.Create(new UserInfo { UserId = userId });
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/login.aspx");
        }
    }
}