namespace SMSH
{
    partial class Form1
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MessageBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Namef = new System.Windows.Forms.TextBox();
            this.Link = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.MsgText = new System.Windows.Forms.TextBox();
            this.Sed = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Port = new System.Windows.Forms.TextBox();
            this.synchronousPort = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SendFile = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MessageBox);
            this.groupBox1.Location = new System.Drawing.Point(217, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(447, 296);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "聊天框";
            // 
            // MessageBox
            // 
            this.MessageBox.Location = new System.Drawing.Point(6, 20);
            this.MessageBox.Multiline = true;
            this.MessageBox.Name = "MessageBox";
            this.MessageBox.ReadOnly = true;
            this.MessageBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.MessageBox.Size = new System.Drawing.Size(435, 270);
            this.MessageBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "昵称：";
            // 
            // Namef
            // 
            this.Namef.Location = new System.Drawing.Point(101, 41);
            this.Namef.MaxLength = 100;
            this.Namef.Name = "Namef";
            this.Namef.Size = new System.Drawing.Size(100, 21);
            this.Namef.TabIndex = 2;
            // 
            // Link
            // 
            this.Link.Font = new System.Drawing.Font("宋体", 20F);
            this.Link.Location = new System.Drawing.Point(11, 131);
            this.Link.Name = "Link";
            this.Link.Size = new System.Drawing.Size(101, 42);
            this.Link.TabIndex = 3;
            this.Link.Text = "连接";
            this.Link.UseVisualStyleBackColor = true;
            this.Link.Click += new System.EventHandler(this.Link_Click);
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("宋体", 20F);
            this.Exit.Location = new System.Drawing.Point(12, 179);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(135, 42);
            this.Exit.TabIndex = 4;
            this.Exit.Text = "退出连接";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // MsgText
            // 
            this.MsgText.Location = new System.Drawing.Point(0, 59);
            this.MsgText.Multiline = true;
            this.MsgText.Name = "MsgText";
            this.MsgText.Size = new System.Drawing.Size(360, 65);
            this.MsgText.TabIndex = 5;
            this.MsgText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MsgText_KeyDown);
            // 
            // Sed
            // 
            this.Sed.Location = new System.Drawing.Point(366, 59);
            this.Sed.Name = "Sed";
            this.Sed.Size = new System.Drawing.Size(75, 65);
            this.Sed.TabIndex = 6;
            this.Sed.Text = "发送";
            this.Sed.UseVisualStyleBackColor = true;
            this.Sed.Click += new System.EventHandler(this.Sed_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 17.25F);
            this.label2.Location = new System.Drawing.Point(7, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 30);
            this.label2.TabIndex = 7;
            this.label2.Text = "端口号：";
            // 
            // Port
            // 
            this.Port.Location = new System.Drawing.Point(101, 92);
            this.Port.MaxLength = 100;
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(100, 21);
            this.Port.TabIndex = 8;
            // 
            // synchronousPort
            // 
            this.synchronousPort.Font = new System.Drawing.Font("宋体", 13F);
            this.synchronousPort.Location = new System.Drawing.Point(11, 227);
            this.synchronousPort.Name = "synchronousPort";
            this.synchronousPort.Size = new System.Drawing.Size(200, 42);
            this.synchronousPort.TabIndex = 9;
            this.synchronousPort.Text = "通过服务器同步端口号";
            this.synchronousPort.UseVisualStyleBackColor = true;
            this.synchronousPort.Click += new System.EventHandler(this.synchronousPort_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SendFile);
            this.groupBox2.Controls.Add(this.MsgText);
            this.groupBox2.Controls.Add(this.Sed);
            this.groupBox2.Location = new System.Drawing.Point(217, 308);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(447, 130);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "发送框";
            // 
            // SendFile
            // 
            this.SendFile.Location = new System.Drawing.Point(6, 20);
            this.SendFile.Name = "SendFile";
            this.SendFile.Size = new System.Drawing.Size(434, 33);
            this.SendFile.TabIndex = 7;
            this.SendFile.Text = "发送文件";
            this.SendFile.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.synchronousPort);
            this.Controls.Add(this.Port);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Link);
            this.Controls.Add(this.Namef);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "聊天室 0.0.1版";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox MessageBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Namef;
        private System.Windows.Forms.Button Link;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.TextBox MsgText;
        private System.Windows.Forms.Button Sed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Port;
        private System.Windows.Forms.Button synchronousPort;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button SendFile;
    }
}

