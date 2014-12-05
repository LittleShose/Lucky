using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DAL;
using Entity;

namespace 管理端
{
    public partial class SMain : Form
    {
        public SMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn导入_Click(object sender, EventArgs e)
        {
            string str = "Provider=Microsoft.Jet.OLEDB.4.0;Data source=";
            str += "员工.xls;";
            str += "Extended Properties=\"Excel 8.0;HDR=Yes;IMEX=1;\" ";
            OleDbConnection conn = new OleDbConnection(str);
            try
            {
                conn.Open();
                OleDbDataAdapter mda = new OleDbDataAdapter("select * from [Data$]", conn);
                DataTable userdata = new DataTable();
                mda.Fill(userdata);

                StringBuilder sb = new StringBuilder();

                new DBase().RunSQL("delete from 获奖人员");

                foreach (DataRow item in userdata.Rows)
                {
                    E获奖人员 mm;
                    D获奖人员 dal = new D获奖人员();
                    mm = dal.Exists(item["姓名"].ToString(), item["工号"].ToString());
                    if (mm == null)
                    {
                        mm = new E获奖人员();
                        mm.部门 = item["部门"].ToString().Trim();
                        mm.工号 = item["工号"].ToString().Trim();
                        mm.奖品ID = 0;
                        mm.姓名 = item["姓名"].ToString().Trim();
                        mm.已领取 = false;
                        dal.Add(mm);
                    }
                }

                MessageBox.Show("导入成功");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
