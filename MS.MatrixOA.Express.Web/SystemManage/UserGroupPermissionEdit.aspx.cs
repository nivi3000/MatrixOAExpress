using MS.MatrixOA.Express.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MS.MatrixOA.Express.Web.SystemManage
{
    public partial class UserGroupPermissionEdit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                chkInit();
                int id=int.Parse(Request["id"]);
                UserGroupPermissionService userGroupPermissionService=new UserGroupPermissionService();
                List<UserGroupPermission> userGroupPermissionList=userGroupPermissionService.FindAll(v=>v.GroupId==id).ToList();
                if (userGroupPermissionList.Count!=0)
                {
                    
                }
                else
                {
                    userGroupPermissionInit();
                    
                }
            }
        }

        private void userGroupPermissionInit()
        {
            int id = int.Parse(Request["id"]);
            UserGroupPermissionService userGroupPermissionService = new UserGroupPermissionService();
            userGroupPermissionService.Create(new UserGroupPermission { GroupId = id, Permission = "用户中心", Enabled = false });
            userGroupPermissionService.Create(new UserGroupPermission { GroupId = id, Permission = "用户信息", Enabled = false });
            userGroupPermissionService.Create(new UserGroupPermission { GroupId = id, Permission = "修改密码", Enabled = false });
            userGroupPermissionService.Create(new UserGroupPermission { GroupId = id, Permission = "系统管理", Enabled = false });
            userGroupPermissionService.Create(new UserGroupPermission { GroupId = id, Permission = "部门管理", Enabled = false });
            userGroupPermissionService.Create(new UserGroupPermission { GroupId = id, Permission = "用户管理", Enabled = false });
            userGroupPermissionService.Create(new UserGroupPermission { GroupId = id, Permission = "用户组管理", Enabled = false });
            userGroupPermissionService.Create(new UserGroupPermission { GroupId = id, Permission = "部门管理/新增", Enabled = false });
            userGroupPermissionService.Create(new UserGroupPermission { GroupId = id, Permission = "部门管理/删除", Enabled = false });
            userGroupPermissionService.Create(new UserGroupPermission { GroupId = id, Permission = "部门管理/修改", Enabled = false });
            userGroupPermissionService.Create(new UserGroupPermission { GroupId = id, Permission = "部门管理/排序", Enabled = false });
            userGroupPermissionService.Create(new UserGroupPermission { GroupId = id, Permission = "用户管理/新增", Enabled = false });
            userGroupPermissionService.Create(new UserGroupPermission { GroupId = id, Permission = "用户管理/删除", Enabled = false });
            userGroupPermissionService.Create(new UserGroupPermission { GroupId = id, Permission = "用户管理/修改", Enabled = false });
            userGroupPermissionService.Create(new UserGroupPermission { GroupId = id, Permission = "用户管理/新增", Enabled = false });
            userGroupPermissionService.Create(new UserGroupPermission { GroupId = id, Permission = "用户管理/新增", Enabled = false });

        }

        protected void btnOk_Click(object sender, EventArgs e)
        {
            int id=int.Parse(Request["id"]);
            UserGroupPermissionService userGroupPermissionService = new UserGroupPermissionService();
            UserGroupPermission userGroupPermission = userGroupPermissionService.FindBy(id, "用户中心");
            userGroupPermission.Enabled = chkUserCenter.Checked;
            userGroupPermissionService.Update(userGroupPermission);

        }

        protected void chk_CheckedChanged(object sender, FineUI.CheckedEventArgs e)
        {
            chkInit();
        }

        private void chkInit()
        {
            chkUserInfo.Enabled = chkUserCenter.Checked;
            chkChangePassword.Enabled = chkUserCenter.Checked;
            chkDepartment.Enabled = chkSystemManage.Checked;
            chkDepartmentOperator.Enabled = chkDepartment.Checked&&chkDepartment.Enabled;
            chkUser.Enabled = chkSystemManage.Checked;
            chkUserOperator.Enabled = chkUser.Checked&&chkUser.Enabled;
            chkUserGroup.Enabled = chkSystemManage.Checked;
            chkUserGroupOperator.Enabled = chkUserGroup.Checked&&chkUserGroup.Enabled;
        }

    }
}