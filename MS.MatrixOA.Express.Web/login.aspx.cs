using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;
using FineUI;
using MS.MatrixOA.Express.Business;

namespace MS.MatrixOA.Express.Web
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadData();
            }
        }


        private void LoadData()
        {
            InitCaptchaCode();
        }

        /// <summary>
        /// 初始化验证码
        /// </summary>
        private void InitCaptchaCode()
        {
            // 创建一个 6 位的随机数并保存在 Session 对象中
            Session["CaptchaImageText"] = GenerateRandomCode();
            imgCaptcha.ImageUrl = "~/captcha/captcha.ashx?w=150&h=30&t=" + DateTime.Now.Ticks;
        }

        /// <summary>
        /// 创建一个 6 位的随机数
        /// </summary>
        /// <returns></returns>
        private string GenerateRandomCode()
        {
            string s = String.Empty;
            Random random = new Random();
            for (int i = 0; i < 6; i++)
            {
                s += random.Next(10).ToString();
            }
            return s;
        }

        protected void btnRefresh_Click(object sender, EventArgs e)
        {
            InitCaptchaCode();
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtCaptcha.Text != Session["CaptchaImageText"].ToString())
            {
                Alert.ShowInTop("验证码错误！");
                return;
            }
            UserService userOp = new UserService();
            if (userOp.CheckPwd(txtUserName.Text, txtPassword.Text))
            {
                Session["User"] = userOp.GetUserByUserName(txtUserName.Text);
                Response.Redirect("default.aspx");
            }
            else
            {
                Alert.ShowInTop("用户名或密码错误！", MessageBoxIcon.Error);
            }
        }

        protected void btnRegist_Click(object sender, EventArgs e)
        {
            Response.Redirect("User/regist.aspx");
        }

    }
}
