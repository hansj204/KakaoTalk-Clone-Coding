using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using WindowApp.Controller;

namespace WindowApp.View
{
    public partial class Login : Form
    {

        MainForm mainForm;

        public Login()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            int userIdExist = 0;
            string cryptPw = "";

            using (var context = new mssqlDBContext()) {

                var uid = loginId.Text;
                // var item = context.logininfo.SingleOrDefault(p => p.userid == uid);
                var item = context.logininfo.Where(p => p.userid == uid);

                userIdExist = item.Count();

                if (userIdExist == 1) {
                    foreach (var i in item) {
                        cryptPw = i.userpassword;
                    }
                }

                context.SaveChanges();
            }

            if (userIdExist == 0) {
                infoCheck.Text = "잘못된 정보가 입력되었습니다.";
            } else {
                var des = new DES(Properties.Resources.DesKey);
                var descrypt = des.result(DesType.Decrypt, cryptPw);

                descrypt.Replace("\0", "").Trim();

                if (descrypt.Equals(loginPw.Text)) {
                    infoCheck.Text = "로그인되었습니다.";

                    ///데이터베이스에서 친구정보를 로드 && 친구정보를 화면에 출력
                    this.Hide();
                    mainForm = new MainForm(this);
                    mainForm.Show();
                } else {
                    infoCheck.Text = "아이디와 패스워드를 확인하여 다시 입력하세요.";
                }
            }
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            Register register = new Register(this);
            register.Show();
            this.Hide();
        }

        /*--------------------------------------------------------------------------------------------
        private void addInfo_Click(object sender, EventArgs e)
        {
            using (var context = new mssqlDBContext())
            {
                context.Database.Log += (log) =>
                {
                    Console.WriteLine($"log : {log}");
                };

                var loginInfo = new tb_logininfo()
                {
                    userid = "id02",
                    userpassword = "pw02"
                };

                context.logininfo.Add(loginInfo);
                context.SaveChanges();
            }
        }

        private void modifyInfo_Click(object sender, EventArgs e)
        {
            using (var context = new mssqlDBContext())
            {
                context.Database.Log += (log) =>
                {
                    Console.WriteLine($"log : {log}");
                };

                var loginInfo = context.logininfo.First();
                loginInfo.userpassword = "pw1111";
                context.SaveChanges();
            }
        }

        private void deleteInfo_Click(object sender, EventArgs e)
        {
            using (var context = new mssqlDBContext())
            {
                context.Database.Log += (log) =>
                {
                    Console.WriteLine($"log : {log}");
                };

                var loginInfo = context.logininfo
                                       .Where(b => b.userid == loginId.Text)
                                       .FirstOrDefault();
                context.logininfo.Remove(loginInfo);
                context.SaveChanges();
            }
        }
        -------------------------------------------------------------------------------------------- */
    }
}
