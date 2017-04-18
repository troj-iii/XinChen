using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SunCity
{
    public class SimPost
    {
        private WebClient wc_ = new WebClient();

        private string uid_ = null;

        public SimPost(string urlBase)
        {
            wc_.BaseAddress = urlBase;
        }

        public string login(string acc, string pwd)
        {
            byte[] bytes = wc_.UploadValues("app/member/login.php", new System.Collections.Specialized.NameValueCollection()
            {
                {"uid", ""},
                {"langx", "zh-cn"},
                {"mac", ""},
                {"ver", ""},
                {"JE", ""},
                {"username", acc},
                {"password", pwd},
                {"checkbox", "on"},
            });
            string res = Encoding.UTF8.GetString(bytes);

            // Get 302 ref
            Regex rgx = new Regex(@"window.location.href='(.+?)'");
            Match m = rgx.Match(res);
            string @ref = m.Groups[1].Value;

            // uid
            int beg = @ref.IndexOf("&uid=") + "&uid=".Length;
            int end = @ref.IndexOf("&", beg);
            uid_ = @ref.Substring(beg, end - beg);

            return res;
        }

        public string getMatchInfo()
        {
            // url
            string url = "/app/member/FT_browse/body_var.php";
            StringBuilder queryStr = new StringBuilder();
            queryStr.Append("?");
            queryStr.Append("uid="); queryStr.Append(uid_);
            queryStr.Append("&rtype="); queryStr.Append("r");
            queryStr.Append("&langx="); queryStr.Append("zh-cn");
            queryStr.Append("&mtype="); queryStr.Append("3");
            queryStr.Append("&delay=");
            queryStr.Append("&league_id=");


            byte[] bytes = wc_.DownloadData(url + queryStr.ToString());
            return Encoding.UTF8.GetString(bytes);
        }

        public string Order(string qid, string qnum, string oddftype, string type)
        {
            // Get Order page
            //wc_.DownloadData(url + queryStr.ToString());

            throw new NotImplementedException();
        }
    }
}
