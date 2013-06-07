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
            this.seAllaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.läggTillSpelareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sökSpelareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tidsbokningToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tävlingsverksamhetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registreraTävlingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sökTävlingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tävlingslistaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.medlemsregisterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seAllaToolStripMenuItem,
            this.läggTillSpelareToolStripMenuItem,
            this.sökSpelareToolStripMenuItem});
            this.medlemsregisterToolStripMenuItem.Name = "medlemsregisterToolStripMenuItem";
            this.medlemsregisterToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.medlemsregisterToolStripMenuItem.Text = "Medlemsregister";
            // 
            // seAllaToolStripMenuItem
            // 
            this.seAllaToolStripMenuItem.Name = "seAllaToolStripMenuItem";
            this.seAllaToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.seAllaToolStripMenuItem.Text = "Se alla";
            this.seAllaToolStripMenuItem.Click += new System.EventHandler(this.seAllaToolStripMenuItem_Click);
            // 
            // läggTillSpelareToolStripMenuItem
            // 
            this.läggTillSpelareToolStripMenuItem.Name = "läggTillSpelareToolStripMenuItem";
            this.läggTillSpelareToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.läggTillSpelareToolStripMenuItem.Text = "Lägg till spelare";
            this.läggTillSpelareToolStripMenuItem.Click += new System.EventHandler(this.läggTillSpelareToolStripMenuItem_Click);
            // 
            // sökSpelareToolStripMenuItem
            // 
            this.sökSpelareToolStripMenuItem.Name = "sökSpelareToolStripMenuItem";
            this.sökSpelareToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.sökSpelareToolStripMenuItem.Text = "Sök spelare";
            this.sökSpelareToolStripMenuItem.Click += new System.EventHandler(this.sökSpelareToolStripMenuItem_Click);
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
            this.tävlingsverksamhetToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registreraTävlingToolStripMenuItem,
            this.sökTävlingToolStripMenuItem,
            this.tävlingslistaToolStripMenuItem});
            this.tävlingsverksamhetToolStripMenuItem.Name = "tävlingsverksamhetToolStripMenuItem";
            this.tävlingsverksamhetToolStripMenuItem.Size = new System.Drawing.Size(124, 20);
            this.tävlingsverksamhetToolStripMenuItem.Text = "Tävlingsverksamhet";
            // 
            // registreraTävlingToolStripMenuItem
            // 
            this.registreraTävlingToolStripMenuItem.Name = "registreraTävlingToolStripMenuItem";
            this.registreraTävlingToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.registreraTävlingToolStripMenuItem.Text = "Registrera tävling";
            this.registreraTävlingToolStripMenuItem.Click += new System.EventHandler(this.registreraTävlingToolStripMenuItem_Click);
            // 
            // sökTävlingToolStripMenuItem
            // 
            this.sökTävlingToolStripMenuItem.Name = "sökTävlingToolStripMenuItem";
            this.sökTävlingToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.sökTävlingToolStripMenuItem.Text = "Sök tävling";
            this.sökTävlingToolStripMenuItem.Click += new System.EventHandler(this.sökTävlingToolStripMenuItem_Click);
            // 
            // tävlingslistaToolStripMenuItem
            // 
            this.tävlingslistaToolStripMenuItem.Name = "tävlingslistaToolStripMenuItem";
            this.tävlingslistaToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.tävlingslistaToolStripMenuItem.Text = "Tävlingslista";
            this.tävlingslistaToolStripMenuItem.Click += new System.EventHandler(this.tävlingslistaToolStripMenuItem_Click);
            // 
            // GolfReception
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 766);
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
        private System.Windows.Forms.ToolStripMenuItem seAllaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem läggTillSpelareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sökSpelareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tidsbokningToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tävlingsverksamhetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registreraTävlingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sökTävlingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tävlingslistaToolStripMenuItem;

    }
}

