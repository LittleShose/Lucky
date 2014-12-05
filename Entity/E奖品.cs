using System;

namespace Entity
{
    [Serializable]
    public class E奖品
    {
        public E奖品()
		{}

        private int _id;
        private int _奖品类型id;
        private string _奖品名称;
        private int _奖品总数;
        private int _单次抽取量;
        private string _图片;
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
        public string 图片
        {
            set { _图片 = value; }
            get { return _图片; }
        }
    }
}
