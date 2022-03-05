namespace SMSH
{
    partial class SelectFile
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
            this.SelectFileButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.FilePath = new System.Windows.Forms.TextBox();
            this.SendTimingName = new System.Windows.Forms.TextBox();
            this.FileIntroduction = new System.Windows.Forms.TextBox();
            this.FileSize = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Error = new System.Windows.Forms.Label();
            this.Openfile = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SelectFileButton
            // 
            this.SelectFileButton.Font = new System.Drawing.Font("微软雅黑", 12.75F);
            this.SelectFileButton.Location = new System.Drawing.Point(12, 13);
            this.SelectFileButton.Name = "SelectFileButton";
            this.SelectFileButton.Size = new System.Drawing.Size(88, 81);
            this.SelectFileButton.TabIndex = 0;
            this.SelectFileButton.Text = "选择文件";
            this.SelectFileButton.UseVisualStyleBackColor = true;
            this.SelectFileButton.Click += new System.EventHandler(this.SelectFileButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label1.Location = new System.Drawing.Point(107, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "文件路径：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label2.Location = new System.Drawing.Point(107, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "发送时文件名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label3.Location = new System.Drawing.Point(107, 88);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "文件简介：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label4.Location = new System.Drawing.Point(107, 129);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "文件大小：";
            // 
            // FilePath
            // 
            this.FilePath.Enabled = false;
            this.FilePath.Location = new System.Drawing.Point(203, 12);
            this.FilePath.Name = "FilePath";
            this.FilePath.Size = new System.Drawing.Size(353, 21);
            this.FilePath.TabIndex = 5;
            // 
            // SendTimingName
            // 
            this.SendTimingName.Location = new System.Drawing.Point(235, 47);
            this.SendTimingName.Name = "SendTimingName";
            this.SendTimingName.Size = new System.Drawing.Size(235, 21);
            this.SendTimingName.TabIndex = 6;
            // 
            // FileIntroduction
            // 
            this.FileIntroduction.Location = new System.Drawing.Point(203, 88);
            this.FileIntroduction.Name = "FileIntroduction";
            this.FileIntroduction.Size = new System.Drawing.Size(353, 21);
            this.FileIntroduction.TabIndex = 7;
            // 
            // FileSize
            // 
            this.FileSize.Location = new System.Drawing.Point(203, 129);
            this.FileSize.Name = "FileSize";
            this.FileSize.ReadOnly = true;
            this.FileSize.Size = new System.Drawing.Size(94, 21);
            this.FileSize.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label5.Location = new System.Drawing.Point(303, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "KB";
            // 
            // Error
            // 
            this.Error.AutoSize = true;
            this.Error.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.Error.ForeColor = System.Drawing.Color.Red;
            this.Error.Location = new System.Drawing.Point(332, 129);
            this.Error.Name = "Error";
            this.Error.Size = new System.Drawing.Size(247, 20);
            this.Error.TabIndex = 10;
            this.Error.Text = "文件不可以超过500M（1048576KB）";
            this.Error.Visible = false;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.button1.Location = new System.Drawing.Point(13, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 49);
            this.button1.TabIndex = 11;
            this.button1.Text = "发送";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SelectFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 172);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Error);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.FileSize);
            this.Controls.Add(this.FileIntroduction);
            this.Controls.Add(this.SendTimingName);
            this.Controls.Add(this.FilePath);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SelectFileButton);
            this.Name = "SelectFile";
            this.Text = "SelectFile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SelectFileButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox FilePath;
        private System.Windows.Forms.TextBox SendTimingName;
        private System.Windows.Forms.TextBox FileIntroduction;
        private System.Windows.Forms.TextBox FileSize;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Error;
        private System.Windows.Forms.OpenFileDialog Openfile;
        private System.Windows.Forms.Button button1;
    }
}