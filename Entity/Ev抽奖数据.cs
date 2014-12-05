using System;

namespace Entity
{
    [Serializable]
    public class Ev抽奖数据
    {
        public Ev抽奖数据()
        { }

        private string _类型名称;
        private int _奖品类型id;
        private string _奖品名称;
        private int _奖品总数;
        private int _单次抽取量;
        private string _姓名;
        private string _工号;
        private string _部门;
        private int _奖品id;
        private int _id;
        private bool _已领取;
        /// <summary>
        /// 
        /// </summary>
        public string 类型名称
        {
            set { _类型名称 = value; }
            get { return _类型名称; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int 奖品类型ID
        {
            set { _奖品类型id = value; }
            get { return _奖品类型id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string 奖品名称
        {
            set { _奖品名称 = value; }
            get { return _奖品名称; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int 奖品总数
        {
            set { _奖品总数 = value; }
            get { return _奖品总数; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int 单次抽取量
        {
            set { _单次抽取量 = value; }
            get { return _单次抽取量; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string 姓名
        {
            set { _姓名 = value; }
            get { return _姓名; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string 工号
        {
            set { _工号 = value; }
            get { return _工号; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string 部门
        {
            set { _部门 = value; }
            get { return _部门; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int 奖品ID
        {
            set { _奖品id = value; }
            get { return _奖品id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int ID
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public bool 已领取
        {
            set { _已领取 = value; }
            get { return _已领取; }
        }
    }
}
