
namespace WindowApp.View
{
    partial class Register
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
            this.cancelBtn = new System.Windows.Forms.Button();
            this.addInfoBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.newId = new System.Windows.Forms.TextBox();
            this.newPwd = new System.Windows.Forms.TextBox();
            this.overlapCheckBtn = new System.Windows.Forms.Button();
            this.warn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancelBtn
            // 
            this.cancelBtn.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cancelBtn.Location = new System.Drawing.Point(146, 162);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 0;
            this.cancelBtn.Text = "취소";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // addInfoBtn
            // 
            this.addInfoBtn.Enabled = false;
            this.addInfoBtn.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.addInfoBtn.Location = new System.Drawing.Point(227, 162);
            this.addInfoBtn.Name = "addInfoBtn";
            this.addInfoBtn.Size = new System.Drawing.Size(75, 23);
            this.addInfoBtn.TabIndex = 1;
            this.addInfoBtn.Text = "생성";
            this.addInfoBtn.UseVisualStyleBackColor = true;
            this.addInfoBtn.Click += new System.EventHandler(this.addInfoBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(42, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "아이디";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(42, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "비밀번호";
            // 
            // newId
            // 
            this.newId.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.newId.Location = new System.Drawing.Point(118, 43);
            this.newId.Name = "newId";
            this.newId.Size = new System.Drawing.Size(196, 26);
            this.newId.TabIndex = 4;
            // 
            // newPwd
            // 
            this.newPwd.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.newPwd.Location = new System.Drawing.Point(118, 98);
            this.newPwd.Name = "newPwd";
            this.newPwd.Size = new System.Drawing.Size(196, 26);
            this.newPwd.TabIndex = 5;
            // 
            // overlapCheckBtn
            // 
            this.overlapCheckBtn.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.overlapCheckBtn.Location = new System.Drawing.Point(320, 46);
            this.overlapCheckBtn.Name = "overlapCheckBtn";
            this.overlapCheckBtn.Size = new System.Drawing.Size(75, 23);
            this.overlapCheckBtn.TabIndex = 6;
            this.overlapCheckBtn.Text = "중복검사";
            this.overlapCheckBtn.UseVisualStyleBackColor = true;
            this.overlapCheckBtn.Click += new System.EventHandler(this.overlapCheck_Click);
            // 
            // warn
            // 
            this.warn.AutoSize = true;
            this.warn.ForeColor = System.Drawing.Color.Red;
            this.warn.Location = new System.Drawing.Point(121, 72);
            this.warn.Name = "warn";
            this.warn.Size = new System.Drawing.Size(0, 12);
            this.warn.TabIndex = 7;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(448, 216);
            this.Controls.Add(this.warn);
            this.Controls.Add(this.overlapCheckBtn);
            this.Controls.Add(this.newPwd);
            this.Controls.Add(this.newId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addInfoBtn);
            this.Controls.Add(this.cancelBtn);
            this.Name = "Register";
            this.Text = "회원가입";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Register_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button addInfoBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox newId;
        private System.Windows.Forms.TextBox newPwd;
        private System.Windows.Forms.Button overlapCheckBtn;
        private System.Windows.Forms.Label warn;
    }
}