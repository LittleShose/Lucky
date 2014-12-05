using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Timers;
using DAL;
using Entity;

namespace 主程序
{
    public partial class SMain : Form
    {
        private List<E获奖人员> userdata = new List<E获奖人员>();
        private bool _是否锁定抽奖类型 = true;
        private bool bisrun = false;
        int _当前抽取量 = 0;

        public SMain()
        {
            InitializeComponent();

            Bind未抽奖员工数据();

            Bind抽奖类型();

            控制页面控件显示状态();

            this.timer1.Interval = 1;
            this.timer1.Tick += new EventHandler(OnTimedEvent);

            this.dgv员工列表.AutoGenerateColumns = false;
        }

        /// <summary>
        /// Bind抽奖类型
        /// </summary>
        private void Bind抽奖类型()
        {
            D奖品 dal = new D奖品();
            this.drop抽奖类型.DataSource = dal.Get抽奖类型数据();
            this.drop抽奖类型.DisplayMember = "类型名称";
            this.drop抽奖类型.SelectedIndex = 0;
            //Bind奖品(((E抽奖类型)this.drop抽奖类型.SelectedValue).ID);
        }

        /// <summary>
        /// Bind抽奖类型
        /// </summary>
        private void Bind奖品(int typeid)
        {
            D奖品 dal = new D奖品();
            this.drop奖品.DataSource = dal.Get奖品数据(typeid);
            this.drop奖品.DisplayMember = "奖品名称";
            this.drop奖品.SelectedIndex = 0;

            //E奖品 mm = (E奖品)this.drop奖品.SelectedValue;

            //Bind图片(mm.图片);
            //刷新人数(mm);
        }

        /// <summary>
        /// Bind抽奖类型
        /// </summary>
        private void Bind图片(string imgpath)
        {
            this.pictureBox1.ImageLocation = AppDomain.CurrentDomain.BaseDirectory + "images\\" + imgpath;
        }

        /// <summary>
        /// 控制页面控件显示状态
        /// </summary>
        private void 控制页面控件显示状态()
        {
            this.drop奖品.Enabled = _是否锁定抽奖类型;
            this.drop抽奖类型.Enabled = _是否锁定抽奖类型;
            this.btn抽奖.Enabled = !_是否锁定抽奖类型;
            this.btn最终确认.Enabled = false;

            if (_是否锁定抽奖类型)
            {
                this.btn选定抽奖类型.Text = "选定";
            }
            else
            {
                this.btn选定抽奖类型.Text = "取消";
            }
        }

        private void Bind未抽奖员工数据()
        {
            D获奖人员 dal = new D获奖人员();
            userdata.Clear();
            userdata = dal.Get未抽奖员工数据();
        }

        /// <summary>
        /// btnClose_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// btn选定抽奖类型_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn选定抽奖类型_Click(object sender, EventArgs e)
        {
            if (_是否锁定抽奖类型 == false)
            {
                if (MessageBox.Show("是否切换其它抽奖类型？", "切换抽奖类型", MessageBoxButtons.YesNo) == DialogResult.No)
                { return; }
            }

            this.dgv员工列表.DataSource = new System.Data.DataTable();

            _是否锁定抽奖类型 = !_是否锁定抽奖类型;

            Bind未抽奖员工数据();

            控制页面控件显示状态();

            this.btn抽奖.Focus();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="总奖项"></param>
        /// <param name="已抽取"></param>
        /// <param name="单次抽取量"></param>
        /// <returns></returns>
        private int[] 判断能抽多少(int 单次抽取量)
        {
            D获奖人员 dal = new D获奖人员();
            E奖品 mm = (E奖品)this.drop奖品.SelectedValue;

            int _已抽取 = dal.Get已抽取量(mm.ID);

            if ((mm.奖品总数 - _已抽取) > 单次抽取量)
            {
                _当前抽取量 = 单次抽取量;
            }
            else
            {
                if (单次抽取量 > 0)
                {
                    _当前抽取量 = mm.奖品总数 - _已抽取;
                }
                else
                {
                    _当前抽取量 = 0;
                }
            }

            int icount = userdata.Count;

            if (icount < _当前抽取量)
            {
                _当前抽取量 = icount;
            }

            int[] ir = new int[2];

            ir[0] = _当前抽取量;
            ir[1] = _已抽取;

            return ir;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="mm"></param>
        private void 刷新人数(E奖品 mm)
        {
            D获奖人员 dal = new D获奖人员();
            string 总奖项 = mm.奖品总数.ToString();

            int[] ir = 判断能抽多少(mm.单次抽取量);

            this.txt单次抽取量.Text = ir[0].ToString();
            this.lib抽奖总数提示.Text = ir[1].ToString() + "/" + 总奖项;
        }

        /// <summary>
        /// btn抽奖_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn抽奖_Click(object sender, EventArgs e)
        {
            if (this.txt单次抽取量.Text.Trim().Length > 0)
            {
                System.Text.RegularExpressions.Regex reg = new System.Text.RegularExpressions.Regex(@"^\d+$");
                if (reg.IsMatch(this.txt单次抽取量.Text.Trim()))
                {
                    int[] ir = 判断能抽多少(int.Parse(this.txt单次抽取量.Text));

                    _当前抽取量 = ir[0];

                    if (_当前抽取量 > 0)
                    {
                        ControlEvent();
                    }
                    else
                    {
                        MessageBox.Show("奖品已经抽取完毕");
                    }
                }
                else
                {
                    MessageBox.Show("请输入单次查询项目数量");
                }
            }
        }

        /// <summary>
        /// 控件事件
        /// </summary>
        void ControlEvent()
        {
            if (false == bisrun)
            {
                Doit();
            }
            else
            {
                Pause();
            }

            this.btn抽奖.Focus();
        }

        private int GetRandomNum(string strContains, int icount)
        {
            Random ran = new Random();
            int ir = 0;
            bool bx = false;
            while (bx == false)
            {
                ir = ran.Next(icount);
                bx = !strContains.Contains("$" + ir.ToString() + "$,");
            }
            return ir;
        }

        /// <summary>
        /// 事件处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnTimedEvent(object sender, EventArgs e)
        {
            int icount = userdata.Count;

            string strCheckSS = "";

            List<E获奖人员> tempuser = new List<E获奖人员>();

            while (tempuser.Count < _当前抽取量)
            {
                int iix = GetRandomNum(strCheckSS, icount);

                E获奖人员 mm = new E获奖人员();
                mm.ID = userdata[iix].ID;
                mm.部门 = userdata[iix].部门;
                mm.工号 = userdata[iix].工号;
                mm.奖品ID = userdata[iix].奖品ID;
                mm.姓名 = userdata[iix].姓名;
                mm.已领取 = userdata[iix].已领取;

                tempuser.Add(mm);

                strCheckSS = strCheckSS + "$" + iix.ToString() + "$,";
            }

            this.dgv员工列表.DataSource = tempuser;
        }

        /// <summary>
        /// 执行
        /// </summary>
        void Doit()
        {
            if (MessageBox.Show("您确认要开始新一轮抽奖吗？", "抽奖", MessageBoxButtons.YesNo) == DialogResult.No)
            { return; }

            this.btn最终确认.Enabled = false;
            this.timer1.Start();
            this.btn选定抽奖类型.Enabled = false;
            bisrun = true;

            this.btn抽奖.Text = "锁定";
        }

        /// <summary>
        /// 暂停
        /// </summary>
        void Pause()
        {
            this.btn最终确认.Enabled = true;
            this.timer1.Stop();
            this.btn选定抽奖类型.Enabled = true;
            // this.timer1.Dispose();
            bisrun = false;

            this.btn抽奖.Text = "抽奖开始";
        }

        /// <summary>
        /// btn最终确认_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn最终确认_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("要执行最终确认的操作吗？", "最终确认", MessageBoxButtons.YesNo) == DialogResult.No)
            { return; }

            StringBuilder sb = new StringBuilder();
            System.DateTime dt = System.DateTime.Now;
            for (int i = 0; i < this.dgv员工列表.Rows.Count; i++)
            {
                sb.Append("UPDATE 获奖人员 SET updatetime='" + dt.ToString() + "',奖品ID=" + ((E奖品)this.drop奖品.SelectedValue).ID.ToString() + " WHERE ID=" + dgv员工列表.Rows[i].Cells["ID"].Value.ToString() + ";" + Environment.NewLine);
            }

            if (sb.Length > 0)
            {
                new DBase().RunSQL(sb.ToString());
            }

            this.btn最终确认.Enabled = false;
            this.dgv员工列表.DataSource = null;
            刷新人数((E奖品)this.drop奖品.SelectedValue);

            Bind未抽奖员工数据();
        }

        /// <summary>
        /// drop抽奖类型_SelectedIndexChanged
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void drop抽奖类型_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.drop抽奖类型.Items.Count > 0)
            {
                Bind奖品(((E抽奖类型)this.drop抽奖类型.SelectedValue).ID);
            }
        }

        /// <summary>
        /// drop奖品_SelectedIndexChanged
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void drop奖品_SelectedIndexChanged(object sender, EventArgs e)
        {
            Bind图片(((E奖品)this.drop奖品.SelectedValue).图片);
            刷新人数((E奖品)this.drop奖品.SelectedValue);
        }
    }
}