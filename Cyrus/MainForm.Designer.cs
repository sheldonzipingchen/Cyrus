namespace Cyrus
{
    partial class mainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainTabs = new System.Windows.Forms.TabControl();
            this.recentTabPage = new System.Windows.Forms.TabPage();
            this.todayTabPage = new System.Windows.Forms.TabPage();
            this.textTabPage = new System.Windows.Forms.TabPage();
            this.graphicTabPage = new System.Windows.Forms.TabPage();
            this.mainTabs.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabs
            // 
            this.mainTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainTabs.Controls.Add(this.recentTabPage);
            this.mainTabs.Controls.Add(this.todayTabPage);
            this.mainTabs.Controls.Add(this.textTabPage);
            this.mainTabs.Controls.Add(this.graphicTabPage);
            this.mainTabs.Location = new System.Drawing.Point(7, 12);
            this.mainTabs.Name = "mainTabs";
            this.mainTabs.SelectedIndex = 0;
            this.mainTabs.Size = new System.Drawing.Size(246, 519);
            this.mainTabs.TabIndex = 0;
            // 
            // recentTabPage
            // 
            this.recentTabPage.Location = new System.Drawing.Point(4, 26);
            this.recentTabPage.Name = "recentTabPage";
            this.recentTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.recentTabPage.Size = new System.Drawing.Size(238, 489);
            this.recentTabPage.TabIndex = 0;
            this.recentTabPage.Text = "最近";
            this.recentTabPage.UseVisualStyleBackColor = true;
            // 
            // todayTabPage
            // 
            this.todayTabPage.Location = new System.Drawing.Point(4, 26);
            this.todayTabPage.Name = "todayTabPage";
            this.todayTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.todayTabPage.Size = new System.Drawing.Size(192, 431);
            this.todayTabPage.TabIndex = 1;
            this.todayTabPage.Text = "今天";
            this.todayTabPage.UseVisualStyleBackColor = true;
            // 
            // textTabPage
            // 
            this.textTabPage.Location = new System.Drawing.Point(4, 26);
            this.textTabPage.Name = "textTabPage";
            this.textTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.textTabPage.Size = new System.Drawing.Size(192, 431);
            this.textTabPage.TabIndex = 2;
            this.textTabPage.Text = "文本";
            this.textTabPage.UseVisualStyleBackColor = true;
            // 
            // graphicTabPage
            // 
            this.graphicTabPage.Location = new System.Drawing.Point(4, 26);
            this.graphicTabPage.Name = "graphicTabPage";
            this.graphicTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.graphicTabPage.Size = new System.Drawing.Size(192, 431);
            this.graphicTabPage.TabIndex = 3;
            this.graphicTabPage.Text = "图像";
            this.graphicTabPage.UseVisualStyleBackColor = true;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 533);
            this.Controls.Add(this.mainTabs);
            this.Name = "mainForm";
            this.Text = "Cyrus";
            this.mainTabs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl mainTabs;
        private TabPage recentTabPage;
        private TabPage todayTabPage;
        private TabPage textTabPage;
        private TabPage graphicTabPage;
    }
}