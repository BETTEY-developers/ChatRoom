namespace SMSH
{
    partial class SendRtfMessageWindow
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
            this.Finsh = new System.Windows.Forms.Button();
            this.Rtf = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.默认格式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SetFont = new System.Windows.Forms.ToolStripMenuItem();
            this.SetForeColor = new System.Windows.Forms.ToolStripMenuItem();
            this.SetBackColor = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Parse = new System.Windows.Forms.ToolStripMenuItem();
            this.Cut = new System.Windows.Forms.ToolStripMenuItem();
            this.Clone = new System.Windows.Forms.ToolStripMenuItem();
            this.Remove = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.选中格式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SetSlectedForeColor = new System.Windows.Forms.ToolStripMenuItem();
            this.SetSelectedFont = new System.Windows.Forms.ToolStripMenuItem();
            this.SetSelectedBackColor = new System.Windows.Forms.ToolStripMenuItem();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsRtf = new System.Windows.Forms.ToolStripMenuItem();
            this.ReadWithRtf = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsAsRtf = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.SaveAsJson = new System.Windows.Forms.ToolStripMenuItem();
            this.ReadWithJson = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsAsJson = new System.Windows.Forms.ToolStripMenuItem();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Finsh
            // 
            this.Finsh.Location = new System.Drawing.Point(682, 403);
            this.Finsh.Name = "Finsh";
            this.Finsh.Size = new System.Drawing.Size(106, 35);
            this.Finsh.TabIndex = 2;
            this.Finsh.Text = "完成";
            this.Finsh.UseVisualStyleBackColor = true;
            // 
            // Rtf
            // 
            this.Rtf.Location = new System.Drawing.Point(12, 28);
            this.Rtf.Name = "Rtf";
            this.Rtf.Size = new System.Drawing.Size(776, 410);
            this.Rtf.TabIndex = 3;
            this.Rtf.Text = "";
            this.Rtf.SelectionChanged += Rtf_SelectionChanged;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.设置ToolStripMenuItem,
            this.编辑ToolStripMenuItem,
            this.文件ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 25);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 设置ToolStripMenuItem
            // 
            this.设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.默认格式ToolStripMenuItem});
            this.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
            this.设置ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.设置ToolStripMenuItem.Text = "设置";
            // 
            // 默认格式ToolStripMenuItem
            // 
            this.默认格式ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SetFont,
            this.SetForeColor,
            this.SetBackColor});
            this.默认格式ToolStripMenuItem.Name = "默认格式ToolStripMenuItem";
            this.默认格式ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.默认格式ToolStripMenuItem.Text = "默认格式";
            // 
            // SetFont
            // 
            this.SetFont.Name = "SetFont";
            this.SetFont.Size = new System.Drawing.Size(136, 22);
            this.SetFont.Text = "设置字体";
            this.SetFont.Click += new System.EventHandler(this.SetFont_Click);
            // 
            // SetForeColor
            // 
            this.SetForeColor.Name = "SetForeColor";
            this.SetForeColor.Size = new System.Drawing.Size(136, 22);
            this.SetForeColor.Text = "设置颜色";
            this.SetForeColor.Click += new System.EventHandler(this.SetForeColor_Click);
            // 
            // SetBackColor
            // 
            this.SetBackColor.Name = "SetBackColor";
            this.SetBackColor.Size = new System.Drawing.Size(136, 22);
            this.SetBackColor.Text = "设置背景色";
            this.SetBackColor.Click += new System.EventHandler(this.SetBackColor_Click);
            // 
            // 编辑ToolStripMenuItem
            // 
            this.编辑ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Parse,
            this.Cut,
            this.Clone,
            this.Remove,
            this.toolStripSeparator1,
            this.选中格式ToolStripMenuItem});
            this.编辑ToolStripMenuItem.Name = "编辑ToolStripMenuItem";
            this.编辑ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.编辑ToolStripMenuItem.Text = "编辑";
            // 
            // Parse
            // 
            this.Parse.Name = "Parse";
            this.Parse.Size = new System.Drawing.Size(124, 22);
            this.Parse.Text = "粘贴";
            this.Parse.Click += new System.EventHandler(this.Parse_Click);
            // 
            // Cut
            // 
            this.Cut.Name = "Cut";
            this.Cut.Size = new System.Drawing.Size(124, 22);
            this.Cut.Text = "剪切";
            this.Cut.Click += new System.EventHandler(this.Cut_Click);
            // 
            // Clone
            // 
            this.Clone.Name = "Clone";
            this.Clone.Size = new System.Drawing.Size(124, 22);
            this.Clone.Text = "复制";
            this.Clone.Click += new System.EventHandler(this.Clone_Click);
            // 
            // Remove
            // 
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(124, 22);
            this.Remove.Text = "删除";
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(121, 6);
            // 
            // 选中格式ToolStripMenuItem
            // 
            this.选中格式ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SetSlectedForeColor,
            this.SetSelectedFont,
            this.SetSelectedBackColor});
            this.选中格式ToolStripMenuItem.Name = "选中格式ToolStripMenuItem";
            this.选中格式ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.选中格式ToolStripMenuItem.Text = "选中格式";
            // 
            // SetSlectedForeColor
            // 
            this.SetSlectedForeColor.Name = "SetSlectedForeColor";
            this.SetSlectedForeColor.Size = new System.Drawing.Size(136, 22);
            this.SetSlectedForeColor.Text = "编辑颜色";
            this.SetSlectedForeColor.Click += new System.EventHandler(this.SetSlectedForeColor_Click);
            // 
            // SetSelectedFont
            // 
            this.SetSelectedFont.Name = "SetSelectedFont";
            this.SetSelectedFont.Size = new System.Drawing.Size(136, 22);
            this.SetSelectedFont.Text = "编辑字体";
            // 
            // SetSelectedBackColor
            // 
            this.SetSelectedBackColor.Name = "SetSelectedBackColor";
            this.SetSelectedBackColor.Size = new System.Drawing.Size(136, 22);
            this.SetSelectedBackColor.Text = "编辑背景色";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveAsRtf,
            this.ReadWithRtf,
            this.SaveAsAsRtf,
            this.toolStripSeparator2,
            this.SaveAsJson,
            this.ReadWithJson,
            this.SaveAsAsJson});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // SaveAsRtf
            // 
            this.SaveAsRtf.Name = "SaveAsRtf";
            this.SaveAsRtf.Size = new System.Drawing.Size(184, 22);
            this.SaveAsRtf.Text = "保存";
            // 
            // ReadWithRtf
            // 
            this.ReadWithRtf.Name = "ReadWithRtf";
            this.ReadWithRtf.Size = new System.Drawing.Size(184, 22);
            this.ReadWithRtf.Text = "读取";
            // 
            // SaveAsAsRtf
            // 
            this.SaveAsAsRtf.Name = "SaveAsAsRtf";
            this.SaveAsAsRtf.Size = new System.Drawing.Size(184, 22);
            this.SaveAsAsRtf.Text = "另存为";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(181, 6);
            // 
            // SaveAsJson
            // 
            this.SaveAsJson.Name = "SaveAsJson";
            this.SaveAsJson.Size = new System.Drawing.Size(184, 22);
            this.SaveAsJson.Text = "保存为json格式文件";
            // 
            // ReadWithJson
            // 
            this.ReadWithJson.Name = "ReadWithJson";
            this.ReadWithJson.Size = new System.Drawing.Size(184, 22);
            this.ReadWithJson.Text = "读取json格式文件";
            // 
            // SaveAsAsJson
            // 
            this.SaveAsAsJson.Name = "SaveAsAsJson";
            this.SaveAsAsJson.Size = new System.Drawing.Size(184, 22);
            this.SaveAsAsJson.Text = "另存为";
            // 
            // SendRtfMessageWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Finsh);
            this.Controls.Add(this.Rtf);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SendRtfMessageWindow";
            this.Text = "SendRtfMessageWindow";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Finsh;
        private System.Windows.Forms.RichTextBox Rtf;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 默认格式ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SetFont;
        private System.Windows.Forms.ToolStripMenuItem SetForeColor;
        private System.Windows.Forms.ToolStripMenuItem SetBackColor;
        private System.Windows.Forms.ToolStripMenuItem 编辑ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Parse;
        private System.Windows.Forms.ToolStripMenuItem Cut;
        private System.Windows.Forms.ToolStripMenuItem Clone;
        private System.Windows.Forms.ToolStripMenuItem Remove;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 选中格式ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SetSlectedForeColor;
        private System.Windows.Forms.ToolStripMenuItem SetSelectedFont;
        private System.Windows.Forms.ToolStripMenuItem SetSelectedBackColor;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveAsRtf;
        private System.Windows.Forms.ToolStripMenuItem ReadWithRtf;
        private System.Windows.Forms.ToolStripMenuItem SaveAsAsRtf;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem SaveAsJson;
        private System.Windows.Forms.ToolStripMenuItem ReadWithJson;
        private System.Windows.Forms.ToolStripMenuItem SaveAsAsJson;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.ColorDialog colorDialog;
    }
}