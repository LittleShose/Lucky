using System;
using System.Text;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using DBUtility;
using System.Configuration;

namespace DAL
{
    public class DBase
    {
        protected string DB_Path = ConfigurationManager.ConnectionStrings["conn"].ToString();

        /// <summary>
        /// 执行SQL
        /// </summary>
        public bool RunSQL(string strSql)
        {
            return (SQLHelper.ExecuteNonQuery(DB_Path, CommandType.Text, strSql, null) > 0);
        }
    }
}
