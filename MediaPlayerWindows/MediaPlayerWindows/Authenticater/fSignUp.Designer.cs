namespace MediaPlayerWindows
{
    partial class fSignUp
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.tBPass2 = new System.Windows.Forms.TextBox();
            this.tBPass = new System.Windows.Forms.TextBox();
            this.tBName = new System.Windows.Forms.TextBox();
            this.lbPass2 = new System.Windows.Forms.Label();
            this.lbPass = new System.Windows.Forms.Label();
            this.lbLoginName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnSignUp);
            this.panel1.Controls.Add(this.tBPass2);
            this.panel1.Controls.Add(this.tBPass);
            this.panel1.Controls.Add(this.tBName);
            this.panel1.Controls.Add(this.lbPass2);
            this.panel1.Controls.Add(this.lbPass);
            this.panel1.Controls.Add(this.lbLoginName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(392, 287);
            this.panel1.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Roboto", 12F);
            this.btnExit.Location = new System.Drawing.Point(203, 232);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(132, 32);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnSignUp
            // 
            this.btnSignUp.Font = new System.Drawing.Font("Roboto", 12F);
            this.btnSignUp.Location = new System.Drawing.Point(45, 232);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(132, 32);
            this.btnSignUp.TabIndex = 2;
            this.btnSignUp.Text = "Đăng ký";
            this.btnSignUp.UseVisualStyleBackColor = true;
            // 
            // tBPass2
            // 
            this.tBPass2.Font = new System.Drawing.Font("Roboto", 12F);
            this.tBPass2.Location = new System.Drawing.Point(180, 146);
            this.tBPass2.Name = "tBPass2";
            this.tBPass2.Size = new System.Drawing.Size(184, 27);
            this.tBPass2.TabIndex = 1;
            // 
            // tBPass
            // 
            this.tBPass.Font = new System.Drawing.Font("Roboto", 12F);
            this.tBPass.Location = new System.Drawing.Point(180, 95);
            this.tBPass.Name = "tBPass";
            this.tBPass.Size = new System.Drawing.Size(184, 27);
            this.tBPass.TabIndex = 1;
            // 
            // tBName
            // 
            this.tBName.Font = new System.Drawing.Font("Roboto", 12F);
            this.tBName.Location = new System.Drawing.Point(180, 43);
            this.tBName.Name = "tBName";
            this.tBName.Size = new System.Drawing.Size(184, 27);
            this.tBName.TabIndex = 1;
            // 
            // lbPass2
            // 
            this.lbPass2.AutoSize = true;
            this.lbPass2.Font = new System.Drawing.Font("Roboto", 12F);
            this.lbPass2.Location = new System.Drawing.Point(27, 149);
            this.lbPass2.Name = "lbPass2";
            this.lbPass2.Size = new System.Drawing.Size(139, 20);
            this.lbPass2.TabIndex = 0;
            this.lbPass2.Text = "Nhập lại mật khẩu";
            // 
            // lbPass
            // 
            this.lbPass.AutoSize = true;
            this.lbPass.Font = new System.Drawing.Font("Roboto", 12F);
            this.lbPass.Location = new System.Drawing.Point(27, 98);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(76, 20);
            this.lbPass.TabIndex = 0;
            this.lbPass.Text = "Mật khẩu";
            // 
            // lbLoginName
            // 
            this.lbLoginName.AutoSize = true;
            this.lbLoginName.Font = new System.Drawing.Font("Roboto", 12F);
            this.lbLoginName.Location = new System.Drawing.Point(27, 46);
            this.lbLoginName.Name = "lbLoginName";
            this.lbLoginName.Size = new System.Drawing.Size(117, 20);
            this.lbLoginName.TabIndex = 0;
            this.lbLoginName.Text = "Tên đăng nhập";
            // 
            // fSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 288);
            this.Controls.Add(this.panel1);
            this.Name = "fSignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng ký";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.TextBox tBPass2;
        private System.Windows.Forms.TextBox tBPass;
        private System.Windows.Forms.TextBox tBName;
        private System.Windows.Forms.Label lbPass2;
        private System.Windows.Forms.Label lbPass;
        private System.Windows.Forms.Label lbLoginName;
    }
}