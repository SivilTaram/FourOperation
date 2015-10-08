namespace WindowsFormsApplication2
{
    partial class AboutMeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutMeForm));
            this.rtfRichTextBox1 = new CCWin.SkinControl.RtfRichTextBox();
            this.skinPictureBox1 = new CCWin.SkinControl.SkinPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.skinPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rtfRichTextBox1
            // 
            this.rtfRichTextBox1.HiglightColor = CCWin.SkinControl.RtfRichTextBox.RtfColor.White;
            this.rtfRichTextBox1.Location = new System.Drawing.Point(4, 28);
            this.rtfRichTextBox1.Name = "rtfRichTextBox1";
            this.rtfRichTextBox1.ReadOnly = true;
            this.rtfRichTextBox1.Size = new System.Drawing.Size(436, 311);
            this.rtfRichTextBox1.TabIndex = 0;
            this.rtfRichTextBox1.Text = "\n\n\n\n\n\n\n\n\nSivilTaram，BUAA130617。\n刘乾 & 玉钟焕 的作品。\n\n我的格言是：\n\n不当码农，要当高品质的工程师。\n\n这是我的博客链接地" +
    "址：http://www.cnblogs.com/SivilTaram/\n\n如果你喜欢我的小程序，请为我点个赞吧~";
            this.rtfRichTextBox1.TextColor = CCWin.SkinControl.RtfRichTextBox.RtfColor.Black;
            // 
            // skinPictureBox1
            // 
            this.skinPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.skinPictureBox1.Image = global::WindowsFormsApplication2.Properties.Resources.Aboutme;
            this.skinPictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("skinPictureBox1.InitialImage")));
            this.skinPictureBox1.Location = new System.Drawing.Point(199, 34);
            this.skinPictureBox1.Name = "skinPictureBox1";
            this.skinPictureBox1.Size = new System.Drawing.Size(230, 230);
            this.skinPictureBox1.TabIndex = 1;
            this.skinPictureBox1.TabStop = false;
            // 
            // AboutMeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(444, 343);
            this.Controls.Add(this.skinPictureBox1);
            this.Controls.Add(this.rtfRichTextBox1);
            this.Name = "AboutMeForm";
            this.Text = "AboutMe";
            ((System.ComponentModel.ISupportInitialize)(this.skinPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.RtfRichTextBox rtfRichTextBox1;
        private CCWin.SkinControl.SkinPictureBox skinPictureBox1;
    }
}