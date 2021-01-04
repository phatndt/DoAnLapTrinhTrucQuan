namespace MediaPlayerWindows.ManagerUserControl
{
    partial class UcTitleInfomationSong
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaLabel1.Font = new System.Drawing.Font("Roboto", 15F, System.Drawing.FontStyle.Bold);
            this.gunaLabel1.Location = new System.Drawing.Point(0, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(55, 50);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Ảnh";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.Font = new System.Drawing.Font("Roboto", 15F, System.Drawing.FontStyle.Bold);
            this.gunaLabel2.Location = new System.Drawing.Point(180, 0);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(177, 50);
            this.gunaLabel2.TabIndex = 0;
            this.gunaLabel2.Text = "Tên bài hát";
            this.gunaLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.Font = new System.Drawing.Font("Roboto", 15F, System.Drawing.FontStyle.Bold);
            this.gunaLabel3.Location = new System.Drawing.Point(595, 0);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(107, 50);
            this.gunaLabel3.TabIndex = 0;
            this.gunaLabel3.Text = "Tên ca sĩ";
            this.gunaLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.Font = new System.Drawing.Font("Roboto", 15F, System.Drawing.FontStyle.Bold);
            this.gunaLabel4.Location = new System.Drawing.Point(785, 0);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(121, 50);
            this.gunaLabel4.TabIndex = 0;
            this.gunaLabel4.Text = "Thời lượng";
            this.gunaLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UcTitleInfomationSong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.Name = "UcTitleInfomationSong";
            this.Size = new System.Drawing.Size(924, 50);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
    }
}
