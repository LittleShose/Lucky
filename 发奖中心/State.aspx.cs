using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

namespace 发奖中心
{
    public partial class State : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<script type=\"text/javascript\">" + Environment.NewLine);
            sb.Append("window.onload=function run(){" + Environment.NewLine);
            sb.Append("countDown(1,'" + (Request["r"] == null ? "" : GetReturnURL(Request.QueryString["r"])) + "');}" + Environment.NewLine);
            sb.Append("</script>" + Environment.NewLine);
            sb.Append("<script type=\"text/javascript\">" + Environment.NewLine);
            sb.Append("function countDown(secs, url)" + Environment.NewLine);
            sb.Append("{window.history.forward(1);document.getElementById(\"Times\").innerText = secs;if (--secs > 0){setTimeout(\"countDown(\" + secs + \",'\" + url + \"')\", 1000);}else{location.href = url;}}" + Environment.NewLine);
            sb.Append("</script>" + Environment.NewLine);

            this.litScript.Text = sb.ToString();
            string rr = Request.QueryString["r"];
            this.hlReturnPage.NavigateUrl = rr;
        }
    }
}