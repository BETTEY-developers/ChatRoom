namespace SMSH
{
    partial class InfoPage
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
            this.NameFile = new System.Windows.Forms.TextBox();
            this.IntroductionFile = new System.Windows.Forms.TextBox();
            this.DownAOpen = new System.Windows.Forms.Button();
            this.UpUser = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // NameFile
            // 
            this.NameFile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NameFile.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.NameFile.Location = new System.Drawing.Point(12, 23);
            this.NameFile.Name = "NameFile";
            this.NameFile.ReadOnly = true;
            this.NameFile.Size = new System.Drawing.Size(234, 22);
            this.NameFile.TabIndex = 0;
            this.NameFile.Text = "名称：";
            // 
            // IntroductionFile
            // 
            this.IntroductionFile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IntroductionFile.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.IntroductionFile.Location = new System.Drawing.Point(12, 62);
            this.IntroductionFile.Multiline = true;
            this.IntroductionFile.Name = "IntroductionFile";
            this.IntroductionFile.ReadOnly = true;
            this.IntroductionFile.Size = new System.Drawing.Size(234, 83);
            this.IntroductionFile.TabIndex = 1;
            this.IntroductionFile.Text = "简介：";
            // 
            // DownAOpen
            // 
            this.DownAOpen.Font = new System.Drawing.Font("微软雅黑", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DownAOpen.Location = new System.Drawing.Point(230, 151);
            this.DownAOpen.Name = "DownAOpen";
            this.DownAOpen.Size = new System.Drawing.Size(141, 56);
            this.DownAOpen.TabIndex = 2;
            this.DownAOpen.Text = "下载";
            this.DownAOpen.UseVisualStyleBackColor = true;
            // 
            // UpUser
            // 
            this.UpUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UpUser.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.UpUser.Location = new System.Drawing.Point(12, 151);
            this.UpUser.Name = "UpUser";
            this.UpUser.ReadOnly = true;
            this.UpUser.Size = new System.Drawing.Size(159, 22);
            this.UpUser.TabIndex = 3;
            this.UpUser.Text = "上传者：";
            // 
            // InfoPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 219);
            this.Controls.Add(this.UpUser);
            this.Controls.Add(this.DownAOpen);
            this.Controls.Add(this.IntroductionFile);
            this.Controls.Add(this.NameFile);
            this.Name = "InfoPage";
            this.Text = "InfoPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameFile;
        private System.Windows.Forms.TextBox IntroductionFile;
        private System.Windows.Forms.Button DownAOpen;
        private System.Windows.Forms.TextBox UpUser;
    }
}