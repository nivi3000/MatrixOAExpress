using MS.MatrixOA.Express.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FineUI;

namespace MS.MatrixOA.Express.Web
{
    public partial class ChangePwd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnOk_Click(object sender, EventArgs e)
        {
            User currentUser = (User)Session["User"];
            UserService userOp = new UserService();
            if (userOp.CheckPwd(currentUser.UserName, txtOldPwd.Text))
            {
                userOp.ChangePwd(currentUser.UserId, txtNewPwd.Text);
                frmChangePwd.Reset();
                Alert.Show("密码修改成功");
            }
            else
            {
                txtOldPwd.MarkInvalid("当前密码不正确");
                Alert.Show("当前密码不正确");
            }
        }

    }
}