namespace MediaPlayerWindows.ManagerUserControl
{
    partial class UcDelelePlayList
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
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.btnRemove = new Guna.UI.WinForms.GunaButton();
            this.btnAdd = new Guna.UI.WinForms.GunaButton();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(71, 15);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(0, 20);
            this.gunaLabel1.TabIndex = 1;
            // 
            // btnRemove
            // 
            this.btnRemove.AnimationHoverSpeed = 0.07F;
            this.btnRemove.AnimationSpeed = 0.03F;
            this.btnRemove.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(24)))), ((int)(((byte)(45)))));
            this.btnRemove.BorderColor = System.Drawing.Color.Black;
            this.btnRemove.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRemove.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRemove.FocusedColor = System.Drawing.Color.Empty;
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Image = global::MediaPlayerWindows.Properties.Resources.minus_40px_white;
            this.btnRemove.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnRemove.ImageSize = new System.Drawing.Size(40, 40);
            this.btnRemove.Location = new System.Drawing.Point(323, 0);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(24)))), ((int)(((byte)(45)))));
            this.btnRemove.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnRemove.OnHoverForeColor = System.Drawing.Color.White;
            this.btnRemove.OnHoverImage = null;
            this.btnRemove.OnPressedColor = System.Drawing.Color.Black;
            this.btnRemove.Size = new System.Drawing.Size(47, 50);
            this.btnRemove.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.AnimationHoverSpeed = 0.07F;
            this.btnAdd.AnimationSpeed = 0.03F;
            this.btnAdd.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(24)))), ((int)(((byte)(45)))));
            this.btnAdd.BorderColor = System.Drawing.Color.Black;
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAdd.FocusedColor = System.Drawing.Color.Empty;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = global::MediaPlayerWindows.Properties.Resources.plus_40px__whitepng;
            this.btnAdd.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAdd.ImageSize = new System.Drawing.Size(40, 40);
            this.btnAdd.Location = new System.Drawing.Point(0, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(24)))), ((int)(((byte)(45)))));
            this.btnAdd.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAdd.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAdd.OnHoverImage = null;
            this.btnAdd.OnPressedColor = System.Drawing.Color.Black;
            this.btnAdd.Size = new System.Drawing.Size(47, 50);
            this.btnAdd.TabIndex = 2;
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // UcDelelePlayList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(24)))), ((int)(((byte)(45)))));
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.gunaLabel1);
            this.Name = "UcDelelePlayList";
            this.Size = new System.Drawing.Size(370, 50);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaButton btnRemove;
        private Guna.UI.WinForms.GunaButton btnAdd;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
    }
}
