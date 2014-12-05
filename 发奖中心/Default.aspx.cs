using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL;
using Entity;

namespace 发奖中心
{
    public partial class Default : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                绑定奖品类型();
                InitSearchPara();
            }
        }

        private void 绑定奖品类型()
        {
            D奖品 dal = new D奖品();
            this.drop奖品类型.DataSource = dal.Get抽奖类型数据();
            this.drop奖品类型.DataTextField = "类型名称";
            this.drop奖品类型.DataValueField = "ID";
            this.drop奖品类型.DataBind();
            this.drop奖品类型.Items.Insert(0, "选择");
        }

        private void 绑定奖品(int typeid)
        {
            D奖品 dal = new D奖品();
            this.drop奖品.DataSource = dal.Get奖品数据(typeid);
            this.drop奖品.DataTextField = "奖品名称";
            this.drop奖品.DataValueField = "ID";
            this.drop奖品.DataBind();
            this.drop奖品.Items.Insert(0, "选择");
        }

        /// <summary>
        /// 初始化搜索控制
        /// </summary>
        private void InitSearchPara()
        {
            Dictionary<string, object> parms = new Dictionary<string, object>();

            if (Request["jplx"] != null)
            {
                this.drop奖品类型.SelectedValue = Request.QueryString["jplx"]; parms["jplx"] = Request.QueryString["jplx"];
                绑定奖品(int.Parse(Request.QueryString["jplx"]));
            }
            else
            { parms["jplx"] = ""; }

            if (Request["jp"] != null)
            { this.drop奖品.SelectedValue = Request.QueryString["jp"]; parms["jp"] = Request.QueryString["jp"]; }
            else
            { parms["jp"] = ""; }

            if (Request["xm"] != null)
            { this.txt姓名.Text = Request.QueryString["xm"]; parms["xm"] = Request.QueryString["xm"]; }
            else
            { parms["xm"] = ""; }

            if (Request["bm"] != null)
            { this.txt部门.Text = Request.QueryString["bm"]; parms["bm"] = Request.QueryString["bm"]; }
            else
            { parms["bm"] = ""; }

            if (Request["gh"] != null)
            { this.txt工号.Text = Request.QueryString["gh"]; parms["gh"] = Request.QueryString["gh"]; }
            else
            { parms["gh"] = ""; }

            if (Request["spa"] != null)
            {
                BindData(parms);
            }
        }

        /// <summary>
        /// BindData
        /// </summary>
        private void BindData(Dictionary<string, object> parms)
        {
            string strwhere = "1=1";

            if (parms["jplx"].ToString().Length > 0)
            {
                strwhere = strwhere + " and 奖品类型ID=" + parms["jplx"].ToString();
            }
            if (parms["jp"].ToString().Length > 0)
            {
                strwhere = strwhere + " and 奖品ID=" + parms["jp"].ToString();
            }
            if (parms["xm"].ToString().Length > 0)
            {
                strwhere = strwhere + " and 姓名 like '%" + parms["xm"].ToString() + "%'";
            }
            if (parms["bm"].ToString().Length > 0)
            {
                strwhere = strwhere + " and 部门 like '%" + parms["bm"].ToString() + "%'";
            }
            if (parms["gh"].ToString().Length > 0)
            {
                strwhere = strwhere + " and 工号 like '%" + parms["gh"].ToString() + "%'";
            }

            Dv抽奖数据 dal = new Dv抽奖数据();
            this.rptDatalist.DataSource = dal.GetList(strwhere);
            this.rptDatalist.DataBind();
        }

        /// <summary>
        /// btnSearch_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnSearch_Click(object sender, EventArgs e)
        {
            string strURL = "Default.aspx?spa=1&xm=" + this.txt姓名.Text.Trim() + "&bm=" + this.txt部门.Text.Trim() + "&gh=" + this.txt工号.Text.Trim();

            if (this.drop奖品类型.SelectedIndex > 0)
            {
                strURL = strURL + "&jplx=" + this.drop奖品类型.SelectedValue;

                if (this.drop奖品.SelectedIndex > 0)
                {
                    strURL = strURL + "&jp=" + this.drop奖品.SelectedValue;
                }
            }

            Response.Redirect(strURL, true);
        }

        /// <summary>
        /// rptDatalist_ItemCommand
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        protected void rptDatalist_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            D获奖人员 dal = new D获奖人员();

            if (e.CommandName == "LQ")
            {
                if (dal.LQ(int.Parse(e.CommandArgument.ToString())))
                {
                    Response.Redirect("State.aspx?r=" + SetReturnURL(Request.Url.ToString()));
                }
                else
                {
                    Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "message alert", "<script type=\"text/javascript\">alert(操作失败'');</script>");
                }
            }
        }

        /// <summary>
        /// rptDatalist_ItemDataBound
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void rptDatalist_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                Ev抽奖数据 mm = (Ev抽奖数据)e.Item.DataItem;

                Button rowBTNL = (Button)e.Item.FindControl("btnL");
                Label rowLBLL = (Label)e.Item.FindControl("lblL");

                if (mm.已领取)
                {
                    rowBTNL.Visible = false;
                    rowLBLL.Visible = true;
                }
                else
                {
                    rowBTNL.Visible = true;
                    rowLBLL.Visible = false;
                }
            }
        }

        protected void drop奖品类型_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.drop奖品类型.SelectedIndex > 0)
            {
                绑定奖品(int.Parse(this.drop奖品类型.SelectedValue));
            }
            else
            {
                this.drop奖品.Items.Clear();
            }
        }
    }
}