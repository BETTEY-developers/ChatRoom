namespace SmshControl
{
    partial class FileControl
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileControl));
            this.Info = new System.Windows.Forms.Button();
            this.NameFile = new System.Windows.Forms.TextBox();
            this.IntroductionFile = new System.Windows.Forms.TextBox();
            this.Picture = new System.Windows.Forms.PictureBox();
            this.UserUpdate = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // Info
            // 
            this.Info.Location = new System.Drawing.Point(513, 3);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(115, 29);
            this.Info.TabIndex = 0;
            this.Info.Text = "文件详情";
            this.Info.UseVisualStyleBackColor = true;
            // 
            // NameFile
            // 
            this.NameFile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NameFile.Location = new System.Drawing.Point(45, 11);
            this.NameFile.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.NameFile.Name = "NameFile";
            this.NameFile.ReadOnly = true;
            this.NameFile.Size = new System.Drawing.Size(100, 14);
            this.NameFile.TabIndex = 2;
            this.NameFile.Text = "None";
            // 
            // IntroductionFile
            // 
            this.IntroductionFile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IntroductionFile.Location = new System.Drawing.Point(168, 11);
            this.IntroductionFile.Name = "IntroductionFile";
            this.IntroductionFile.ReadOnly = true;
            this.IntroductionFile.Size = new System.Drawing.Size(196, 14);
            this.IntroductionFile.TabIndex = 3;
            this.IntroductionFile.Text = "None";
            // 
            // Picture
            // 
            this.Picture.Image = ((System.Drawing.Image)(resources.GetObject("Picture.Image")));
            this.Picture.Location = new System.Drawing.Point(3, 3);
            this.Picture.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.Picture.Name = "Picture";
            this.Picture.Size = new System.Drawing.Size(29, 29);
            this.Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Picture.TabIndex = 1;
            this.Picture.TabStop = false;
            // 
            // UserUpdate
            // 
            this.UserUpdate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserUpdate.Location = new System.Drawing.Point(388, 11);
            this.UserUpdate.Name = "UserUpdate";
            this.UserUpdate.ReadOnly = true;
            this.UserUpdate.Size = new System.Drawing.Size(100, 14);
            this.UserUpdate.TabIndex = 4;
            // 
            // FileControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.UserUpdate);
            this.Controls.Add(this.IntroductionFile);
            this.Controls.Add(this.NameFile);
            this.Controls.Add(this.Picture);
            this.Controls.Add(this.Info);
            this.Name = "FileControl";
            this.Size = new System.Drawing.Size(631, 42);
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Info;
        private System.Windows.Forms.PictureBox Picture;
        private System.Windows.Forms.TextBox NameFile;
        private System.Windows.Forms.TextBox IntroductionFile;
        private System.Windows.Forms.TextBox UserUpdate;
    }
}
