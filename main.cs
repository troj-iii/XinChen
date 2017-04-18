using mshtml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SunCity
{
    public partial class main : Form
    {
        private string urlBase_ = "http://www.hg6668a.com";
        private string urlReg_ = "/app/member/reg/reg.php";
        public main()
        {
            InitializeComponent();
        }
        private void beg__Click(object sender, EventArgs e)
        {
            string url = urlBase_;
            url_.Text = url;

            // Navigate home page.
            wb_.DocumentCompleted += HomeCompleted;
            wb_.Navigate(url);
        }

        private void reg__Click(object sender, EventArgs e)
        {
            string url = urlBase_ + urlReg_;
            url_.Text = url;

            wb_.DocumentCompleted += RegCompleted;
            wb_.Navigate(url);
        }

        private void HomeCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            wb_.DocumentCompleted -= HomeCompleted;
        }

        private void RegCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            wb_.DocumentCompleted -= RegCompleted;

            // Input Reg Info.
            IHTMLDocument2 doc = (IHTMLDocument2)wb_.Document.DomDocument;
            IHTMLFormElement form = doc.forms.item("main");

            IDictionary<string, string> info = GetRegInfo();

            // Account
            {
                IHTMLInputElement accEle = form.item("username");
                accEle.value = info["username"];
            }

            // Pwd
            {
                IHTMLInputElement pwdEle = form.item("password");
                pwdEle.value = info["password"];
                IHTMLInputElement pwdConfirmEle = form.item("password2");
                pwdConfirmEle.value = info["password"];
            }

            // Real Name
            {
                IHTMLInputElement aliasEle = form.item("alias");
                aliasEle.value = info["alias"];
            }

            // PwdSecurityQuestion
            {
                IHTMLSelectElement qEle = form.item("question");
                qEle.selectedIndex = int.Parse(info["question"]);
            }

            // PwdSecurityAnswer
            {
                IHTMLInputElement aEle = form.item("answer");
                aEle.value = info["answer"];
            }

            // Sex
            // Use default value.
            //{
            //    IHTMLSelectElement sexEle = form.item("answer");
            //    sexEle.selectedIndex = int.Parse(info["answer"]);
            //}

            //  CreditCard Pwd
            {
                IHTMLSelectElement aEle = form.item("drpAuthCodea");
                aEle.selectedIndex = int.Parse(info["drpAuthCodea"]);

                IHTMLSelectElement bEle = form.item("drpAuthCodeb");
                bEle.selectedIndex = int.Parse(info["drpAuthCodeb"]);

                IHTMLSelectElement cEle = form.item("drpAuthCodec");
                cEle.selectedIndex = int.Parse(info["drpAuthCodec"]);

                IHTMLSelectElement dEle = form.item("drpAuthCoded");
                dEle.selectedIndex = int.Parse(info["drpAuthCoded"]);
            }

            // BirthDay
            {
                IHTMLSelectElement yearEle = form.item("year11");
                yearEle.selectedIndex = int.Parse(info["year11"]);

                IHTMLSelectElement monthEle = form.item("maoth11");
                monthEle.selectedIndex = int.Parse(info["month11"]);

                IHTMLSelectElement dayEle = form.item("day11");
                dayEle.selectedIndex = int.Parse(info["day11"]);
            }

            // All use default.
            // Nation
            {
                IHTMLInputElement nationEle = form.item("contory");
            }

            // City
            {
                IHTMLInputElement cityEle = form.item("city");

            }
            // KnownWay
            {
                //...
            }
            // Agreement
            {

            }


            // Submit
            {
                IHTMLElement submitEle = form.item("submitBtn");
                submitEle.click();
            }
        }

        private IDictionary<string, string> GetRegInfo()
        {
            IDictionary<string, string> ret = new Dictionary<string, string>();

            // Account
            ret.Add("username", "23wesdxc");

            // Pwd
            ret.Add("password", "23wesdxc");

            // Real Name
            ret.Add("alias", "李达康");

            // PwdSecurityQuestion
            ret.Add("question", "3");

            // PwdSecurityAnswer
            ret.Add("answer", "李达康");

            // Sex

            //  CreditCard Pwd
            ret.Add("drpAuthCodea", "1");
            ret.Add("drpAuthCodeb", "1");
            ret.Add("drpAuthCodec", "1");
            ret.Add("drpAuthCoded", "1");

            // BirthDay
            ret.Add("year11", "1");
            ret.Add("month11", "1");
            ret.Add("day11", "1");

            // All use default.
            // Nation
            ret.Add("nation", "中国");

            // City
            ret.Add("city", "上海");

            // KnownWay
            // Agreement

            return ret;
        }

        private void main_Load(object sender, EventArgs e)
        {
            ShellExecute(IntPtr.Zero, "open", "rundll32.exe", " InetCpl.cpl,ClearMyTracksByProcess 255", "", 0);
        }

        [System.Runtime.InteropServices.DllImport("shell32.dll")]
        static extern IntPtr ShellExecute(IntPtr hwnd, string lpOperation, string lpFile, string lpParameters, string lpDirectory, int nShowCmd);

        private void login__Click(object sender, EventArgs e)
        {
            IHTMLDocument2 doc = (IHTMLDocument2)wb_.Document.DomDocument;

            IHTMLWindow2 frameEle = doc.frames.item("SI2_mem_index");
            IHTMLInputElement accEle = frameEle.document.body.all.item("username");
            IHTMLInputElement pwdEle = frameEle.document.body.all.item("password");

            var info = GetRegInfo();
            accEle.value = info["username"];
            pwdEle.value = info["password"];

            frameEle.execScript("do_login();");
        }


        [System.Runtime.InteropServices.DllImport("kernel32.dll")]
        public static extern bool AllocConsole();
        [System.Runtime.InteropServices.DllImport("kernel32.dll")]
        public static extern bool FreeConsole();

        private SimPost p_ = null;
        private void console__Click(object sender, EventArgs e)
        {
            AllocConsole();

            if (p_ == null)
            {
                p_ = new SimPost(urlBase_);
            }

            var dic = GetRegInfo();
            string res = p_.login(dic["username"], dic["password"]);
            Console.WriteLine("login page:");
            Console.WriteLine(res);
            Console.WriteLine();

            res = p_.getMatchInfo();
            Console.WriteLine("Match info:");
            Console.WriteLine(res);
            Console.WriteLine();
        }
    }
}
