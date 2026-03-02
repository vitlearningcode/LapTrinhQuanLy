namespace PresentationLayer
{
    partial class frmMain
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
            menuStrip1 = new MenuStrip();
            chươngTrìnhToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            chứcVụToolStripMenuItem = new ToolStripMenuItem();
            nhânViênToolStripMenuItem = new ToolStripMenuItem();
            nghiệpVụToolStripMenuItem = new ToolStripMenuItem();
            báoCáoToolStripMenuItem = new ToolStripMenuItem();
            giúpĐỡToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(40, 40);
            menuStrip1.Items.AddRange(new ToolStripItem[] { chươngTrìnhToolStripMenuItem, toolStripMenuItem1, nghiệpVụToolStripMenuItem, báoCáoToolStripMenuItem, giúpĐỡToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(2, 1, 0, 1);
            menuStrip1.Size = new Size(497, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // chươngTrìnhToolStripMenuItem
            // 
            chươngTrìnhToolStripMenuItem.Name = "chươngTrìnhToolStripMenuItem";
            chươngTrìnhToolStripMenuItem.Size = new Size(90, 22);
            chươngTrìnhToolStripMenuItem.Text = "Chương trình";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { chứcVụToolStripMenuItem, nhânViênToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(74, 22);
            toolStripMenuItem1.Text = "Danh mục";
            // 
            // chứcVụToolStripMenuItem
            // 
            chứcVụToolStripMenuItem.Name = "chứcVụToolStripMenuItem";
            chứcVụToolStripMenuItem.Size = new Size(128, 22);
            chứcVụToolStripMenuItem.Text = "Chức vụ";
            chứcVụToolStripMenuItem.Click += chứcVụToolStripMenuItem_Click;
            // 
            // nhânViênToolStripMenuItem
            // 
            nhânViênToolStripMenuItem.Name = "nhânViênToolStripMenuItem";
            nhânViênToolStripMenuItem.Size = new Size(128, 22);
            nhânViênToolStripMenuItem.Text = "Nhân viên";
            nhânViênToolStripMenuItem.Click += nhânViênToolStripMenuItem_Click;
            // 
            // nghiệpVụToolStripMenuItem
            // 
            nghiệpVụToolStripMenuItem.Name = "nghiệpVụToolStripMenuItem";
            nghiệpVụToolStripMenuItem.Size = new Size(74, 22);
            nghiệpVụToolStripMenuItem.Text = "Nghiệp vụ";
            // 
            // báoCáoToolStripMenuItem
            // 
            báoCáoToolStripMenuItem.Name = "báoCáoToolStripMenuItem";
            báoCáoToolStripMenuItem.Size = new Size(63, 22);
            báoCáoToolStripMenuItem.Text = "Báo Cáo";
            // 
            // giúpĐỡToolStripMenuItem
            // 
            giúpĐỡToolStripMenuItem.Name = "giúpĐỡToolStripMenuItem";
            giúpĐỡToolStripMenuItem.Size = new Size(61, 22);
            giúpĐỡToolStripMenuItem.Text = "Giúp đỡ";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(497, 266);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(1);
            Name = "frmMain";
            Text = "frmMain";
            Load += frmMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem chươngTrìnhToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem nghiệpVụToolStripMenuItem;
        private ToolStripMenuItem báoCáoToolStripMenuItem;
        private ToolStripMenuItem giúpĐỡToolStripMenuItem;
        private ToolStripMenuItem chứcVụToolStripMenuItem;
        private ToolStripMenuItem nhânViênToolStripMenuItem;
    }
}