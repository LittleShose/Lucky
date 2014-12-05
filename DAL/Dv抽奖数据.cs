using System;
using System.Web;
using System.Text;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using DBUtility;
using Entity;

namespace DAL
{
    public class Dv抽奖数据 : DBase
    {
        /// <summary>
        /// 获得数据列表
        /// </summary>
        /// <param name="tparms"></param>
        /// <returns></returns>
        public List<Ev抽奖数据> GetList(string strWhere)
        {
            List<Ev抽奖数据> mml = new List<Ev抽奖数据>();

            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT 类型名称,奖品类型ID,奖品名称,奖品总数,单次抽取量,姓名,工号,部门,奖品ID,ID,已领取 ");
            strSql.Append("FROM v抽奖数据 ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }

            using (SqlConnection conn = new SqlConnection(DB_Path))
            {
                SqlCommand cmd = new SqlCommand();
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = strSql.ToString();

                using (SqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                {
                    while (rdr.Read())
                    {
                        Ev抽奖数据 mm = new Ev抽奖数据();
                        mm.类型名称 = rdr.GetString(0);
                        mm.奖品类型ID = rdr.GetInt32(1);
                        mm.奖品名称 = rdr.GetString(2);
                        mm.奖品总数 = rdr.GetInt32(3);
                        mm.单次抽取量 = rdr.GetInt32(4);
                        mm.姓名 = rdr.GetString(5);
                        mm.工号 = rdr.GetString(6);
                        mm.部门 = rdr.GetString(7);
                        mm.奖品ID = rdr.GetInt32(8);
                        mm.ID = rdr.GetInt32(9);
                        mm.已领取 = rdr.GetBoolean(10);
                        mml.Add(mm);
                    }
                }
            }

            return mml;
        }
    }
}
