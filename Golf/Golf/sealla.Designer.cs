namespace Golf
{
    partial class sealla
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
            this.ickemedlem_radioButton = new System.Windows.Forms.RadioButton();
            this.medlem_radioButton = new System.Windows.Forms.RadioButton();
            this.alla_radioButton = new System.Windows.Forms.RadioButton();
            this.ok_button = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // ickemedlem_radioButton
            // 
            this.ickemedlem_radioButton.AutoSize = true;
            this.ickemedlem_radioButton.Location = new System.Drawing.Point(166, 21);
            this.ickemedlem_radioButton.Name = "ickemedlem_radioButton";
            this.ickemedlem_radioButton.Size = new System.Drawing.Size(85, 17);
            this.ickemedlem_radioButton.TabIndex = 53;
            this.ickemedlem_radioButton.TabStop = true;
            this.ickemedlem_radioButton.Text = "Icke-medlem";
            this.ickemedlem_radioButton.UseVisualStyleBackColor = true;
            // 
            // medlem_radioButton
            // 
            this.medlem_radioButton.AutoSize = true;
            this.medlem_radioButton.Location = new System.Drawing.Point(87, 21);
            this.medlem_radioButton.Name = "medlem_radioButton";
            this.medlem_radioButton.Size = new System.Drawing.Size(62, 17);
            this.medlem_radioButton.TabIndex = 52;
            this.medlem_radioButton.TabStop = true;
            this.medlem_radioButton.Text = "Medlem";
            this.medlem_radioButton.UseVisualStyleBackColor = true;
            // 
            // alla_radioButton
            // 
            this.alla_radioButton.AutoSize = true;
            this.alla_radioButton.Location = new System.Drawing.Point(23, 21);
            this.alla_radioButton.Name = "alla_radioButton";
            this.alla_radioButton.Size = new System.Drawing.Size(42, 17);
            this.alla_radioButton.TabIndex = 54;
            this.alla_radioButton.Text = "Alla";
            this.alla_radioButton.UseVisualStyleBackColor = true;
            // 
            // ok_button
            // 
            this.ok_button.Location = new System.Drawing.Point(302, 293);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(75, 23);
            this.ok_button.TabIndex = 55;
            this.ok_button.Text = "Stäng";
            this.ok_button.UseVisualStyleBackColor = true;
            this.ok_button.Click += new System.EventHandler(this.ok_button_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(23, 63);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(354, 212);
            this.listBox1.TabIndex = 56;
            // 
            // sealla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 328);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.ok_button);
            this.Controls.Add(this.alla_radioButton);
            this.Controls.Add(this.ickemedlem_radioButton);
            this.Controls.Add(this.medlem_radioButton);
            this.Name = "sealla";
            this.Text = "Se alla";
            this.Load += new System.EventHandler(this.sealla_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton ickemedlem_radioButton;
        private System.Windows.Forms.RadioButton medlem_radioButton;
        private System.Windows.Forms.RadioButton alla_radioButton;
        private System.Windows.Forms.Button ok_button;
        private System.Windows.Forms.ListBox listBox1;
    }
}