namespace MediaPlayerWindows.ManagerUserControl
{
    partial class UcDownload
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcDownload));
            this.btnDownload = new Guna.UI.WinForms.GunaButton();
            this.boxLink = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDownload
            // 
            this.btnDownload.AnimationHoverSpeed = 0.07F;
            this.btnDownload.AnimationSpeed = 0.03F;
            this.btnDownload.BaseColor = System.Drawing.Color.Silver;
            this.btnDownload.BorderColor = System.Drawing.Color.Black;
            this.btnDownload.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDownload.FocusedColor = System.Drawing.Color.Empty;
            this.btnDownload.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownload.ForeColor = System.Drawing.Color.Black;
            this.btnDownload.Image = ((System.Drawing.Image)(resources.GetObject("btnDownload.Image")));
            this.btnDownload.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDownload.Location = new System.Drawing.Point(387, 240);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDownload.OnHoverBorderColor = System.Drawing.Color.Silver;
            this.btnDownload.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnDownload.OnHoverImage = null;
            this.btnDownload.OnPressedColor = System.Drawing.Color.Black;
            this.btnDownload.Size = new System.Drawing.Size(224, 79);
            this.btnDownload.TabIndex = 5;
            this.btnDownload.Text = "Download";
            this.btnDownload.TextOffsetX = 10;
            // 
            // boxLink
            // 
            this.boxLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxLink.Location = new System.Drawing.Point(296, 138);
            this.boxLink.Name = "boxLink";
            this.boxLink.Size = new System.Drawing.Size(570, 29);
            this.boxLink.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(85, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Link Download";
            // 
            // UcDownload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.boxLink);
            this.Controls.Add(this.label1);
            this.Name = "UcDownload";
            this.Size = new System.Drawing.Size(950, 454);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaButton btnDownload;
        private System.Windows.Forms.TextBox boxLink;
        private System.Windows.Forms.Label label1;
    }
}
