
namespace WindowApp
{
    partial class SignIn
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_pwd = new System.Windows.Forms.TextBox();
            this.tb_userId = new System.Windows.Forms.TextBox();
            this.tb_login = new System.Windows.Forms.Button();
            this.signUp = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_pwd
            // 
            this.tb_pwd.Font = new System.Drawing.Font("나눔고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_pwd.Location = new System.Drawing.Point(31, 162);
            this.tb_pwd.Name = "tb_pwd";
            this.tb_pwd.PasswordChar = '*';
            this.tb_pwd.Size = new System.Drawing.Size(219, 32);
            this.tb_pwd.TabIndex = 1;
            // 
            // tb_userId
            // 
            this.tb_userId.Font = new System.Drawing.Font("나눔고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_userId.Location = new System.Drawing.Point(31, 124);
            this.tb_userId.Name = "tb_userId";
            this.tb_userId.Size = new System.Drawing.Size(219, 32);
            this.tb_userId.TabIndex = 2;
            // 
            // tb_login
            // 
            this.tb_login.Font = new System.Drawing.Font("나눔고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_login.Location = new System.Drawing.Point(31, 222);
            this.tb_login.Name = "tb_login";
            this.tb_login.Size = new System.Drawing.Size(219, 40);
            this.tb_login.TabIndex = 5;
            this.tb_login.Text = "로그인";
            this.tb_login.UseVisualStyleBackColor = true;
            this.tb_login.Click += new System.EventHandler(this.tb_login_Click_1);
            // 
            // signUp
            // 
            this.signUp.AutoSize = true;
            this.signUp.BackColor = System.Drawing.Color.Yellow;
            this.signUp.ForeColor = System.Drawing.SystemColors.Highlight;
            this.signUp.Location = new System.Drawing.Point(110, 412);
            this.signUp.Name = "signUp";
            this.signUp.Size = new System.Drawing.Size(53, 12);
            this.signUp.TabIndex = 6;
            this.signUp.Text = "회원가입";
            this.signUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.signUp.Click += new System.EventHandler(this.signUp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(40, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 12);
            this.label1.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(286, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.signUp);
            this.Controls.Add(this.tb_login);
            this.Controls.Add(this.tb_userId);
            this.Controls.Add(this.tb_pwd);
            this.Name = "MainForm";
            this.Text = "SignIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_pwd;
        private System.Windows.Forms.TextBox tb_userId;
        private System.Windows.Forms.Button tb_login;
        private System.Windows.Forms.Label signUp;
        private System.Windows.Forms.Label label1;
    }
}

