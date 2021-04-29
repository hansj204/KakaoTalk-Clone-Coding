
namespace WindowApp.View
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.registerBtn = new System.Windows.Forms.Label();
            this.loginId = new System.Windows.Forms.TextBox();
            this.loginPw = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.infoCheck = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // registerBtn
            // 
            this.registerBtn.AutoSize = true;
            this.registerBtn.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.registerBtn.ForeColor = System.Drawing.Color.MidnightBlue;
            this.registerBtn.Location = new System.Drawing.Point(127, 414);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(55, 15);
            this.registerBtn.TabIndex = 0;
            this.registerBtn.Text = "회원가입";
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // loginId
            // 
            this.loginId.Font = new System.Drawing.Font("나눔고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.loginId.Location = new System.Drawing.Point(56, 143);
            this.loginId.Name = "loginId";
            this.loginId.Size = new System.Drawing.Size(215, 32);
            this.loginId.TabIndex = 1;
            // 
            // loginPw
            // 
            this.loginPw.Font = new System.Drawing.Font("나눔고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.loginPw.Location = new System.Drawing.Point(56, 186);
            this.loginPw.Name = "loginPw";
            this.loginPw.PasswordChar = '*';
            this.loginPw.Size = new System.Drawing.Size(215, 32);
            this.loginPw.TabIndex = 2;
            // 
            // loginBtn
            // 
            this.loginBtn.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.loginBtn.Location = new System.Drawing.Point(56, 238);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(215, 36);
            this.loginBtn.TabIndex = 3;
            this.loginBtn.Text = "확인";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // infoCheck
            // 
            this.infoCheck.AutoSize = true;
            this.infoCheck.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.infoCheck.Location = new System.Drawing.Point(54, 287);
            this.infoCheck.Name = "infoCheck";
            this.infoCheck.Size = new System.Drawing.Size(0, 15);
            this.infoCheck.TabIndex = 4;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(331, 453);
            this.Controls.Add(this.infoCheck);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.loginPw);
            this.Controls.Add(this.loginId);
            this.Controls.Add(this.registerBtn);
            this.Name = "Login";
            this.Text = "로그인";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label registerBtn;
        private System.Windows.Forms.TextBox loginId;
        private System.Windows.Forms.TextBox loginPw;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label infoCheck;
    }
}