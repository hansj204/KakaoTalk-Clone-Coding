using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowApp.Controller;
using WindowApp.Model;
using WindowApp.View;

namespace WindowApp
{
    public partial class SignIn : Form
    {

        SignIn mf;

        public SignIn()
        {
        }

        public SignIn(SignIn mainForm)
        {
            InitializeComponent();
        }

        private void tb_login_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            using (var context = new mssqlDBContext())
            {
                context.Database.Log += (log) =>
                {
                    Console.WriteLine($"log : {log}");
                };

                var loginInfo = context.logininfo
                                       .Where(b => b.userid == tb_userId.Text)
                                       .FirstOrDefault();
                context.logininfo.Remove(loginInfo);
                context.SaveChanges();
            }
        }

        private void signUp_Click(object sender, EventArgs e)
        {
            SignUp signup = new SignUp(this);
            signup.Show();
            this.Hide();
        }

        private void tb_login_Click_1(object sender, EventArgs e)
        {
            int userIdExist = 0;
            string cryptPw = "";
            using (var context = new mssqlDBContext())
            {

                var uid = tb_userId.Text;
//                var item = context.logininfo.SingleOrDefault(p => p.userid == uid);
                var item2 = context.logininfo.Where(p => p.userid == uid);

                int cnt = item2.Count();
                userIdExist = item2.Count();

                if(userIdExist == 1)
                {
                    foreach(var i in item2)
                    {
                        cryptPw = i.userpassword;
                    }
                }

                context.SaveChanges();
            }

            if(userIdExist == 0)
            {
                label1.Text = "잘못된 정보가 입력되었습니다.";
            } else
            {
                var des = new DES(Properties.Resources.DesKey);
                var descrypt = des.result(DesType.Decrypt, cryptPw);

                descrypt.Replace("\0", "").Trim();

                if (descrypt.Equals(tb_pwd.Text)) {
                    label1.Text = "로그인되었습니다.";
                    //데이터베이스에서 친구정보를 로드

                    //친구정보를 화면에 출력
                    this.Hide();
                    mf = new SignIn(this);
                    mf.Show();
                } else {
                    label1.Text = "아이디와 패스워드를 확인하여 다시 입력하세요.";
                }
            }
        }
    }
}
