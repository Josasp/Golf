namespace Golf
{
    partial class AnmälDeltagare
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
            this.findPlayerComponent1 = new Golf.FindPlayerComponent();
            this.can_button = new System.Windows.Forms.Button();
            this.anm_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // findPlayerComponent1
            // 
            this.findPlayerComponent1.GolfId = "";
            this.findPlayerComponent1.Location = new System.Drawing.Point(12, 12);
            this.findPlayerComponent1.Name = "findPlayerComponent1";
            this.findPlayerComponent1.Size = new System.Drawing.Size(240, 163);
            this.findPlayerComponent1.TabIndex = 0;
            this.findPlayerComponent1.TitleText = "Deltagare";
            // 
            // can_button
            // 
            this.can_button.Location = new System.Drawing.Point(12, 181);
            this.can_button.Name = "can_button";
            this.can_button.Size = new System.Drawing.Size(75, 23);
            this.can_button.TabIndex = 1;
            this.can_button.Text = "Avbryt";
            this.can_button.UseVisualStyleBackColor = true;
            this.can_button.Click += new System.EventHandler(this.can_button_Click);
            // 
            // anm_button
            // 
            this.anm_button.Location = new System.Drawing.Point(93, 181);
            this.anm_button.Name = "anm_button";
            this.anm_button.Size = new System.Drawing.Size(159, 23);
            this.anm_button.TabIndex = 2;
            this.anm_button.Text = "Anmäl till tävling";
            this.anm_button.UseVisualStyleBackColor = true;
            this.anm_button.Click += new System.EventHandler(this.anm_button_Click);
            // 
            // AnmälDeltagare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 213);
            this.Controls.Add(this.anm_button);
            this.Controls.Add(this.can_button);
            this.Controls.Add(this.findPlayerComponent1);
            this.Name = "AnmälDeltagare";
            this.Text = "Anmäl deltagare";
            this.ResumeLayout(false);

        }

        #endregion

        private FindPlayerComponent findPlayerComponent1;
        private System.Windows.Forms.Button can_button;
        private System.Windows.Forms.Button anm_button;
    }
}