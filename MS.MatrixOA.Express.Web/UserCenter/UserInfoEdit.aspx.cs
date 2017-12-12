using FineUI;
using MS.MatrixOA.Express.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MS.MatrixOA.Express.Web
{
    public partial class UserInfoEdit : PageBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                loadData();
            }
        }

        private void loadData()
        {
            UserInfoService userInfoService = new UserInfoService();
            //TODO:用户ID
            UserInfo userInfo = userInfoService.FindBy(4);
            txtRealName.Text = userInfo.RealName;
            txtAddress.Text = userInfo.Address;
            txtPhone.Text = userInfo.Phone;
            txtOfficePhone.Text = userInfo.OfficePhone;
            txtHomePhone.Text = userInfo.HomePhone;
            txtFax.Text = userInfo.Fax;
            txtEmail.Text = userInfo.Email;
            DepartmentService departmentService = new DepartmentService();
            ddlDepartment.DataSource = departmentService.GetAll();
            ddlDepartment.DataBind();
            ddlDepartment.SelectedValue = userInfo.DepartmentId.ToString();
            txtPost.Text = userInfo.Post;
            imgPhoto.ImageUrl = string.IsNullOrEmpty(userInfo.Picture) ? "~/images/pic/user_pic_default.png" : userInfo.Picture;
        }

        protected void btnOk_Click(object sender, EventArgs e)
        {
            UserInfoService userInfoService = new UserInfoService();
            userInfoService.Update(new UserInfo
            {
                UserId = 4,
                RealName = txtRealName.Text,
                Address = txtAddress.Text,
                Phone = txtPhone.Text,
                OfficePhone = txtOfficePhone.Text,
                HomePhone = txtHomePhone.Text,
                Fax = txtFax.Text,
                Email = txtEmail.Text,
                DepartmentId = int.Parse(ddlDepartment.SelectedValue),
                Post = txtPost.Text,
                Picture = imgPhoto.ImageUrl
            });
            Alert.ShowInParent("修改成功");
        }

        protected void filePhoto_FileSelected(object sender, EventArgs e)
        {
            if (filePhoto.HasFile)
            {
                string fileName = filePhoto.ShortFileName;

                if (!ValidateFileType(fileName))
                {
                    Alert.Show("无效的文件类型！");
                    return;
                }


                fileName = fileName.Replace(":", "_").Replace(" ", "_").Replace("\\", "_").Replace("/", "_");
                fileName = DateTime.Now.Ticks.ToString() + "_" + fileName;

                filePhoto.SaveAs(Server.MapPath("~/upload/pic/" + fileName));

                imgPhoto.ImageUrl = "~/upload/pic/" + fileName;

                // 清空文件上传组件
                filePhoto.Reset();
            }
        }

        protected readonly static List<string> VALID_FILE_TYPES = new List<string> { "jpg", "bmp", "gif", "jpeg", "png" };

        protected static bool ValidateFileType(string fileName)
        {
            string fileType = String.Empty;
            int lastDotIndex = fileName.LastIndexOf(".");
            if (lastDotIndex >= 0)
            {
                fileType = fileName.Substring(lastDotIndex + 1).ToLower();
            }

            if (VALID_FILE_TYPES.Contains(fileType))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}