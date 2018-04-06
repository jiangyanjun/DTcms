using System;
namespace DTcms.Model
{
    /// <summary>
    /// OAuth授权用户信息
    /// </summary>
    [Serializable]
    public partial class user_oauth
    {
        public user_oauth()
        { }
        #region Model
        private int _id;
        private int _user_id;
        private string _user_name;
        private string _oauth_name = "0";
        private string _oauth_access_token;
        private string _oauth_openid;
        private DateTime _add_time = DateTime.Now;
        private string _naem;
        private string _Image;
        private string _gender;
        /// <summary>
        /// 自增ID
        /// </summary>
        public int id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 用户ID
        /// </summary>
        public int user_id
        {
            set { _user_id = value; }
            get { return _user_id; }
        }
        /// <summary>
        /// 用户名
        /// </summary>
        public string user_name
        {
            set { _user_name = value; }
            get { return _user_name; }
        }
        /// <summary>
        /// QQ用户名
        /// </summary>
        public string naem
        {
            set { _naem = value; }
            get { return _naem; }
        }
        /// <summary>
        /// QQ用户图像
        /// </summary>
        public string Image
        {
            set { _Image = value; }
            get { return _Image; }
        }
        /// <summary>
        /// 性别
        /// </summary>
        public string gender
        {
            set { _gender = value; }
            get { return _gender; }
        }
        /// <summary>
        /// 开放平台名称
        /// </summary>
        public string oauth_name
        {
            set { _oauth_name = value; }
            get { return _oauth_name; }
        }
        /// <summary>
        /// access_token
        /// </summary>
        public string oauth_access_token
        {
            set { _oauth_access_token = value; }
            get { return _oauth_access_token; }
        }
        /// <summary>
        /// 授权key
        /// </summary>
        public string oauth_openid
        {
            set { _oauth_openid = value; }
            get { return _oauth_openid; }
        }
        /// <summary>
        /// 授权时间
        /// </summary>
        public DateTime add_time
        {
            set { _add_time = value; }
            get { return _add_time; }
        }
        #endregion Model

    }
}