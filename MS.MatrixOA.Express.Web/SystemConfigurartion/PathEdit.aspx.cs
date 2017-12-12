using FineUI;
using MS.MatrixOA.Express.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MS.MatrixOA.Express.Web.SystemConfigurartion
{
    public partial class PathEdit : System.Web.UI.Page
    {
        private PathService pathService;
        private int id;
        public PathEdit()
        {
            pathService = new PathService();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            id=Request["id"]!=null?int.Parse(Request["id"]):0;
            if (!IsPostBack)
            {
                btnCancel.OnClientClick = ActiveWindow.GetHideReference();
                if (id!=0)
                {
                    loadData(id);
                }
            }
        }

        private void loadData(int id)
        {
            Path path = pathService.FindBy(id);
            txtPathName.Text = path.PathName;
            txtPathUrl.Text = path.PathUrl;
        }

        protected void btnOk_Click(object sender, EventArgs e)
        {
            Path path = new Path
            {
                PathName = txtPathName.Text,
                PathUrl = txtPathUrl.Text
            };
            if (id!=0)
            {
                path.PathId = id;
                pathService.Update(path);
            }
            else
            {
                pathService.Create(path);
            }
            PageContext.RegisterStartupScript(ActiveWindow.GetHideRefreshReference());
        }
    }
}