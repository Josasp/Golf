namespace Golf
{
    partial class GolfReception
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.medlemsregisterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tidsbokningToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tävlingsverksamhetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.medlemsregisterToolStripMenuItem,
            this.tidsbokningToolStripMenuItem,
            this.tävlingsverksamhetToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1012, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // medlemsregisterToolStripMenuItem
            // 
            this.medlemsregisterToolStripMenuItem.Name = "medlemsregisterToolStripMenuItem";
            this.medlemsregisterToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.medlemsregisterToolStripMenuItem.Text = "Medlemsregister";
            this.medlemsregisterToolStripMenuItem.Click += new System.EventHandler(this.medlemsregisterToolStripMenuItem_Click);
            // 
            // tidsbokningToolStripMenuItem
            // 
            this.tidsbokningToolStripMenuItem.Name = "tidsbokningToolStripMenuItem";
            this.tidsbokningToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.tidsbokningToolStripMenuItem.Text = "Tidsbokning";
            this.tidsbokningToolStripMenuItem.Click += new System.EventHandler(this.tidsbokningToolStripMenuItem_Click);
            // 
            // tävlingsverksamhetToolStripMenuItem
            // 
            this.tävlingsverksamhetToolStripMenuItem.Name = "tävlingsverksamhetToolStripMenuItem";
            this.tävlingsverksamhetToolStripMenuItem.Size = new System.Drawing.Size(124, 20);
            this.tävlingsverksamhetToolStripMenuItem.Text = "Tävlingsverksamhet";
            this.tävlingsverksamhetToolStripMenuItem.Click += new System.EventHandler(this.tävlingsverksamhetToolStripMenuItem_Click);
            // 
            // GolfReception
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 749);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GolfReception";
            this.Text = "Golfreception";
            this.Load += new System.EventHandler(this.golfreception_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem medlemsregisterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tidsbokningToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tävlingsverksamhetToolStripMenuItem;

    }
}

