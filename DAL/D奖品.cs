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
    public class D奖品 : DBase
    {
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public List<E抽奖类型> Get抽奖类型数据()
        {
            List<E抽奖类型> mml = new List<E抽奖类型>();

            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT ID,类型名称 ");
            strSql.Append("FROM 抽奖类型");

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
                        E抽奖类型 mm = new E抽奖类型();
                        mm.ID = rdr.GetInt32(0);
                        mm.类型名称 = rdr.GetString(1);
                        mml.Add(mm);
                    }
                }
            }

            return mml;
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public List<E奖品> Get奖品数据(int typeid)
        {
            List<E奖品> mml = new List<E奖品>();

            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT ID,奖品类型ID,奖品名称,奖品总数,单次抽取量,图片 ");
            strSql.Append("FROM 奖品 where 奖品类型ID=" + typeid.ToString());

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
                        E奖品 mm = new E奖品();
                        mm.ID = rdr.GetInt32(0);
                        mm.奖品类型ID = rdr.GetInt32(1);
                        mm.奖品名称 = rdr.GetString(2);
                        mm.奖品总数 = rdr.GetInt32(3);
                        mm.单次抽取量 = rdr.GetInt32(4); 
                        mm.图片 = rdr.GetString(5);
                        mml.Add(mm);
                    }
                }
            }

            return mml;
        }
    }
}
