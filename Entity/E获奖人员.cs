using System;

namespace Entity
{
    [Serializable]
    public class E获奖人员
    {
        public E获奖人员()
		{}

        private int _id;
        private string _姓名;
        private string _工号;
        private string _部门;
        private int _奖品id;
        private bool _已领取;
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
        public bool 已领取
        {
            set { _已领取 = value; }
            get { return _已领取; }
        }
    }
}
