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
    public class D获奖人员 : DBase
    {
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public E获奖人员 Exists(string str姓名, string str工号)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,姓名,工号,部门,奖品ID,已领取 from 获奖人员 ");
            strSql.Append(" where  姓名='" + str姓名 + "' and 工号='" + str工号 + "'");

            E获奖人员 mm;

            using (SqlDataReader rdr = SQLHelper.ExecuteReader(DB_Path, CommandType.Text, strSql.ToString(), null))
            {
                if (rdr.Read())
                {
                    mm = new E获奖人员();
                    mm.ID = rdr.GetInt32(0);
                    mm.姓名 = rdr.GetString(1);
                    mm.工号 = rdr.GetString(2);
                    mm.部门 = rdr.GetString(3);
                    mm.奖品ID = rdr.GetInt32(4);
                    mm.已领取 = rdr.GetBoolean(5);
                }
                else
                {
                    mm = null;
                }
            }
            return mm;
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(E获奖人员 model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into 获奖人员(");
            strSql.Append("姓名,工号,部门,奖品ID,已领取)");
            strSql.Append(" values (");
            strSql.Append("@姓名,@工号,@部门,@奖品ID,@已领取)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@姓名", SqlDbType.NVarChar,50),
					new SqlParameter("@工号", SqlDbType.VarChar,50),
					new SqlParameter("@部门", SqlDbType.NVarChar,100),
					new SqlParameter("@奖品ID", SqlDbType.Int,4),
					new SqlParameter("@已领取", SqlDbType.Bit,1)};
            parameters[0].Value = model.姓名;
            parameters[1].Value = model.工号;
            parameters[2].Value = model.部门;
            parameters[3].Value = model.奖品ID;
            parameters[4].Value = model.已领取;

            object obj = SQLHelper.ExecuteScalar(DB_Path, CommandType.Text, strSql.ToString(), parameters);
            if (obj == null)
            {
                return 1;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }

        /// <summary>
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool LQ(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("UPDATE 获奖人员 set ");
            strSql.Append("已领取=1 ");
            strSql.Append("where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = id;

            return (SQLHelper.ExecuteNonQuery(DB_Path, CommandType.Text, strSql.ToString(), parameters) > 0);
        }

        /// <summary>
        /// Get已抽取量
        /// </summary>
        public int Get已抽取量(int id)
        {
            string strSql = "SELECT COUNT(*) FROM 获奖人员 WHERE 奖品ID=" + id.ToString();
            return Convert.ToInt32(SQLHelper.ExecuteScalar(DB_Path, CommandType.Text, strSql, null));
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        /// <param name="tparms"></param>
        /// <returns></returns>
        public List<E获奖人员> Get未抽奖员工数据()
        {
            List<E获奖人员> mml = new List<E获奖人员>();

            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT ID,姓名,工号,部门,奖品ID,已领取 ");
            strSql.Append("FROM 获奖人员 WHERE 奖品ID=0");

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
                        E获奖人员 mm = new E获奖人员();
                        mm.ID = rdr.GetInt32(0);
                        mm.姓名 = rdr.GetString(1);
                        mm.工号 = rdr.GetString(2);
                        mm.部门 = rdr.GetString(3);
                        mm.奖品ID = rdr.GetInt32(4);
                        mm.已领取 = rdr.GetBoolean(5);
                        mml.Add(mm);
                    }
                }
            }

            return mml;
        }
    }
}
