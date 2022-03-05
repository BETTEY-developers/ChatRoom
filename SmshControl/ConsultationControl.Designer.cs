namespace SmshControl.Consultation
{
    partial class ConsultationControl
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
            this.tile = new System.Windows.Forms.TextBox();
            this.ThisIntroduction = new System.Windows.Forms.TextBox();
            this.Next = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // tile
            // 
            this.tile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tile.Font = new System.Drawing.Font("微软雅黑", 25.25F);
            this.tile.Location = new System.Drawing.Point(4, 4);
            this.tile.Name = "tile";
            this.tile.ReadOnly = true;
            this.tile.Size = new System.Drawing.Size(267, 45);
            this.tile.TabIndex = 0;
            // 
            // ThisIntroduction
            // 
            this.ThisIntroduction.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ThisIntroduction.Location = new System.Drawing.Point(3, 55);
            this.ThisIntroduction.Multiline = true;
            this.ThisIntroduction.Name = "ThisIntroduction";
            this.ThisIntroduction.ReadOnly = true;
            this.ThisIntroduction.Size = new System.Drawing.Size(371, 92);
            this.ThisIntroduction.TabIndex = 1;
            // 
            // Next
            // 
            this.Next.AutoSize = true;
            this.Next.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.Next.Location = new System.Drawing.Point(478, 120);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(91, 27);
            this.Next.TabIndex = 2;
            this.Next.TabStop = true;
            this.Next.Text = "详情 -->";
            this.Next.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Next_LinkClicked);
            // 
            // ConsultationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Next);
            this.Controls.Add(this.ThisIntroduction);
            this.Controls.Add(this.tile);
            this.Name = "ConsultationControl";
            this.Size = new System.Drawing.Size(572, 150);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tile;
        private System.Windows.Forms.TextBox ThisIntroduction;
        public System.Windows.Forms.LinkLabel Next;
    }
}
