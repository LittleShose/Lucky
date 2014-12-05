using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace 发奖中心
{
    public class BasePage : System.Web.UI.Page
    {
        #region 返回页通用方法
        public static string SetReturnURL(string str)
        {
            str = str.Replace("=", "@");
            return str.Replace("&", "*");
        }

        public static string GetReturnURL(string str)
        {
            str = str.Replace("@", "=");
            return str.Replace("*", "&");
        }
        #endregion
    }
}