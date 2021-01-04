namespace MediaPlayerWindows.ManagerUserControl
{
    partial class UcSystemButton
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
            this.components = new System.ComponentModel.Container();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyIcon2 = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnExit = new Guna.UI.WinForms.GunaButton();
            this.btnMiximize = new Guna.UI.WinForms.GunaButton();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // notifyIcon2
            // 
            this.notifyIcon2.Text = "notifyIcon2";
            this.notifyIcon2.Visible = true;
            // 
            // btnExit
            // 
            this.btnExit.Animated = true;
            this.btnExit.AnimationHoverSpeed = 0.07F;
            this.btnExit.AnimationSpeed = 0.03F;
            this.btnExit.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(24)))), ((int)(((byte)(45)))));
            this.btnExit.BorderColor = System.Drawing.Color.Black;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FocusedColor = System.Drawing.Color.Empty;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = global::MediaPlayerWindows.Properties.Resources.delete_40px;
            this.btnExit.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnExit.ImageSize = new System.Drawing.Size(20, 20);
            this.btnExit.Location = new System.Drawing.Point(1170, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(188)))), ((int)(((byte)(109)))));
            this.btnExit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnExit.OnHoverForeColor = System.Drawing.Color.White;
            this.btnExit.OnHoverImage = null;
            this.btnExit.OnPressedColor = System.Drawing.Color.Black;
            this.btnExit.Size = new System.Drawing.Size(30, 30);
            this.btnExit.TabIndex = 0;
            // 
            // btnMiximize
            // 
            this.btnMiximize.Animated = true;
            this.btnMiximize.AnimationHoverSpeed = 0.07F;
            this.btnMiximize.AnimationSpeed = 0.03F;
            this.btnMiximize.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(24)))), ((int)(((byte)(45)))));
            this.btnMiximize.BorderColor = System.Drawing.Color.Black;
            this.btnMiximize.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMiximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMiximize.FocusedColor = System.Drawing.Color.Empty;
            this.btnMiximize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMiximize.ForeColor = System.Drawing.Color.White;
            this.btnMiximize.Image = global::MediaPlayerWindows.Properties.Resources.subtract_40px;
            this.btnMiximize.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnMiximize.ImageSize = new System.Drawing.Size(20, 20);
            this.btnMiximize.Location = new System.Drawing.Point(1140, 0);
            this.btnMiximize.Name = "btnMiximize";
            this.btnMiximize.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(188)))), ((int)(((byte)(109)))));
            this.btnMiximize.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnMiximize.OnHoverForeColor = System.Drawing.Color.White;
            this.btnMiximize.OnHoverImage = null;
            this.btnMiximize.OnPressedColor = System.Drawing.Color.Black;
            this.btnMiximize.Size = new System.Drawing.Size(30, 30);
            this.btnMiximize.TabIndex = 0;
            // 
            // UcSystemButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(24)))), ((int)(((byte)(45)))));
            this.Controls.Add(this.btnMiximize);
            this.Controls.Add(this.btnExit);
            this.Name = "UcSystemButton";
            this.Size = new System.Drawing.Size(1200, 30);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.NotifyIcon notifyIcon2;
        private Guna.UI.WinForms.GunaButton btnExit;
        private Guna.UI.WinForms.GunaButton btnMiximize;
    }
}
