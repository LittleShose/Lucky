using System;

namespace Entity
{
    [Serializable]
    public class E抽奖类型
    {
        public E抽奖类型()
        { }

        private int _id;
        private string _类型名称;
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
        public string 类型名称
        {
            set { _类型名称 = value; }
            get { return _类型名称; }
        }
    }
}
