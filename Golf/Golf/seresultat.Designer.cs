namespace Golf
{
    partial class SeResultat
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
            this.singel_radioButton = new System.Windows.Forms.RadioButton();
            this.lag_radioButton = new System.Windows.Forms.RadioButton();
            this.par_radioButton = new System.Windows.Forms.RadioButton();
            this.alla_radioButton = new System.Windows.Forms.RadioButton();
            this.man_radioButton = new System.Windows.Forms.RadioButton();
            this.kvinnor_radioButton = new System.Windows.Forms.RadioButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.action_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // singel_radioButton
            // 
            this.singel_radioButton.AutoSize = true;
            this.singel_radioButton.Location = new System.Drawing.Point(247, 19);
            this.singel_radioButton.Name = "singel_radioButton";
            this.singel_radioButton.Size = new System.Drawing.Size(54, 17);
            this.singel_radioButton.TabIndex = 70;
            this.singel_radioButton.Text = "Singel";
            this.singel_radioButton.UseVisualStyleBackColor = true;
            // 
            // lag_radioButton
            // 
            this.lag_radioButton.AutoSize = true;
            this.lag_radioButton.Location = new System.Drawing.Point(354, 19);
            this.lag_radioButton.Name = "lag_radioButton";
            this.lag_radioButton.Size = new System.Drawing.Size(43, 17);
            this.lag_radioButton.TabIndex = 69;
            this.lag_radioButton.TabStop = true;
            this.lag_radioButton.Text = "Lag";
            this.lag_radioButton.UseVisualStyleBackColor = true;
            // 
            // par_radioButton
            // 
            this.par_radioButton.AutoSize = true;
            this.par_radioButton.Location = new System.Drawing.Point(307, 19);
            this.par_radioButton.Name = "par_radioButton";
            this.par_radioButton.Size = new System.Drawing.Size(41, 17);
            this.par_radioButton.TabIndex = 68;
            this.par_radioButton.TabStop = true;
            this.par_radioButton.Text = "Par";
            this.par_radioButton.UseVisualStyleBackColor = true;
            // 
            // alla_radioButton
            // 
            this.alla_radioButton.AutoSize = true;
            this.alla_radioButton.Location = new System.Drawing.Point(12, 19);
            this.alla_radioButton.Name = "alla_radioButton";
            this.alla_radioButton.Size = new System.Drawing.Size(42, 17);
            this.alla_radioButton.TabIndex = 67;
            this.alla_radioButton.Text = "Alla";
            this.alla_radioButton.UseVisualStyleBackColor = true;
            // 
            // man_radioButton
            // 
            this.man_radioButton.AutoSize = true;
            this.man_radioButton.Location = new System.Drawing.Point(155, 19);
            this.man_radioButton.Name = "man_radioButton";
            this.man_radioButton.Size = new System.Drawing.Size(46, 17);
            this.man_radioButton.TabIndex = 66;
            this.man_radioButton.TabStop = true;
            this.man_radioButton.Text = "Män";
            this.man_radioButton.UseVisualStyleBackColor = true;
            // 
            // kvinnor_radioButton
            // 
            this.kvinnor_radioButton.AutoSize = true;
            this.kvinnor_radioButton.Location = new System.Drawing.Point(88, 19);
            this.kvinnor_radioButton.Name = "kvinnor_radioButton";
            this.kvinnor_radioButton.Size = new System.Drawing.Size(61, 17);
            this.kvinnor_radioButton.TabIndex = 65;
            this.kvinnor_radioButton.TabStop = true;
            this.kvinnor_radioButton.Text = "Kvinnor";
            this.kvinnor_radioButton.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 70);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(385, 277);
            this.listBox1.TabIndex = 64;
            // 
            // action_button
            // 
            this.action_button.Location = new System.Drawing.Point(241, 384);
            this.action_button.Name = "action_button";
            this.action_button.Size = new System.Drawing.Size(75, 23);
            this.action_button.TabIndex = 72;
            this.action_button.Text = "OK";
            this.action_button.UseVisualStyleBackColor = true;
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(322, 384);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(75, 23);
            this.cancel_button.TabIndex = 71;
            this.cancel_button.Text = "Avbryt";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // seresultat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 419);
            this.Controls.Add(this.action_button);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.singel_radioButton);
            this.Controls.Add(this.lag_radioButton);
            this.Controls.Add(this.par_radioButton);
            this.Controls.Add(this.alla_radioButton);
            this.Controls.Add(this.man_radioButton);
            this.Controls.Add(this.kvinnor_radioButton);
            this.Controls.Add(this.listBox1);
            this.Name = "seresultat";
            this.Text = "Se resultat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton singel_radioButton;
        private System.Windows.Forms.RadioButton lag_radioButton;
        private System.Windows.Forms.RadioButton par_radioButton;
        private System.Windows.Forms.RadioButton alla_radioButton;
        private System.Windows.Forms.RadioButton man_radioButton;
        private System.Windows.Forms.RadioButton kvinnor_radioButton;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button action_button;
        private System.Windows.Forms.Button cancel_button;
    }
}