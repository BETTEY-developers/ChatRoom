namespace SMSH
{
    partial class EmojiForm
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
            this.emojiView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // emojiView
            // 
            this.emojiView.Font = new System.Drawing.Font("Segoe UI Emoji", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emojiView.HideSelection = false;
            this.emojiView.Location = new System.Drawing.Point(12, 12);
            this.emojiView.Name = "emojiView";
            this.emojiView.Size = new System.Drawing.Size(310, 337);
            this.emojiView.TabIndex = 0;
            this.emojiView.UseCompatibleStateImageBehavior = false;
            this.emojiView.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // EmojiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 361);
            this.Controls.Add(this.emojiView);
            this.Name = "EmojiForm";
            this.Text = "EmojiForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView emojiView;
    }
}