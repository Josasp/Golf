namespace Golf
{
    partial class SeAnmaldaSpelare
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.action_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.alla_checkBox = new System.Windows.Forms.CheckBox();
            this.kvinnor_checkBox = new System.Windows.Forms.CheckBox();
            this.man_checkBox = new System.Windows.Forms.CheckBox();
            this.singel_checkBox = new System.Windows.Forms.CheckBox();
            this.par_checkBox = new System.Windows.Forms.CheckBox();
            this.lag_checkBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tävling_id_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(130, 35);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(157, 251);
            this.listBox1.TabIndex = 57;
            // 
            // action_button
            // 
            this.action_button.Location = new System.Drawing.Point(212, 308);
            this.action_button.Name = "action_button";
            this.action_button.Size = new System.Drawing.Size(75, 23);
            this.action_button.TabIndex = 65;
            this.action_button.Text = "OK";
            this.action_button.UseVisualStyleBackColor = true;
            this.action_button.Click += new System.EventHandler(this.action_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(7, 308);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(75, 23);
            this.cancel_button.TabIndex = 64;
            this.cancel_button.Text = "Avbryt";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // alla_checkBox
            // 
            this.alla_checkBox.AutoSize = true;
            this.alla_checkBox.Location = new System.Drawing.Point(6, 75);
            this.alla_checkBox.Name = "alla_checkBox";
            this.alla_checkBox.Size = new System.Drawing.Size(43, 17);
            this.alla_checkBox.TabIndex = 66;
            this.alla_checkBox.Text = "Alla";
            this.alla_checkBox.UseVisualStyleBackColor = true;
            // 
            // kvinnor_checkBox
            // 
            this.kvinnor_checkBox.AutoSize = true;
            this.kvinnor_checkBox.Location = new System.Drawing.Point(7, 125);
            this.kvinnor_checkBox.Name = "kvinnor_checkBox";
            this.kvinnor_checkBox.Size = new System.Drawing.Size(62, 17);
            this.kvinnor_checkBox.TabIndex = 67;
            this.kvinnor_checkBox.Text = "Kvinnor";
            this.kvinnor_checkBox.UseVisualStyleBackColor = true;
            // 
            // man_checkBox
            // 
            this.man_checkBox.AutoSize = true;
            this.man_checkBox.Location = new System.Drawing.Point(7, 148);
            this.man_checkBox.Name = "man_checkBox";
            this.man_checkBox.Size = new System.Drawing.Size(47, 17);
            this.man_checkBox.TabIndex = 68;
            this.man_checkBox.Text = "Män";
            this.man_checkBox.UseVisualStyleBackColor = true;
            // 
            // singel_checkBox
            // 
            this.singel_checkBox.AutoSize = true;
            this.singel_checkBox.Location = new System.Drawing.Point(7, 195);
            this.singel_checkBox.Name = "singel_checkBox";
            this.singel_checkBox.Size = new System.Drawing.Size(55, 17);
            this.singel_checkBox.TabIndex = 69;
            this.singel_checkBox.Text = "Singel";
            this.singel_checkBox.UseVisualStyleBackColor = true;
            // 
            // par_checkBox
            // 
            this.par_checkBox.AutoSize = true;
            this.par_checkBox.Location = new System.Drawing.Point(7, 218);
            this.par_checkBox.Name = "par_checkBox";
            this.par_checkBox.Size = new System.Drawing.Size(42, 17);
            this.par_checkBox.TabIndex = 70;
            this.par_checkBox.Text = "Par";
            this.par_checkBox.UseVisualStyleBackColor = true;
            // 
            // lag_checkBox
            // 
            this.lag_checkBox.AutoSize = true;
            this.lag_checkBox.Location = new System.Drawing.Point(7, 241);
            this.lag_checkBox.Name = "lag_checkBox";
            this.lag_checkBox.Size = new System.Drawing.Size(44, 17);
            this.lag_checkBox.TabIndex = 71;
            this.lag_checkBox.Text = "Lag";
            this.lag_checkBox.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 91;
            this.label2.Text = "Tävling-ID";
            // 
            // tävling_id_textBox
            // 
            this.tävling_id_textBox.Location = new System.Drawing.Point(6, 25);
            this.tävling_id_textBox.Name = "tävling_id_textBox";
            this.tävling_id_textBox.Size = new System.Drawing.Size(48, 20);
            this.tävling_id_textBox.TabIndex = 92;
            // 
            // SeAnmaldaSpelare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 339);
            this.Controls.Add(this.tävling_id_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lag_checkBox);
            this.Controls.Add(this.par_checkBox);
            this.Controls.Add(this.singel_checkBox);
            this.Controls.Add(this.man_checkBox);
            this.Controls.Add(this.kvinnor_checkBox);
            this.Controls.Add(this.alla_checkBox);
            this.Controls.Add(this.action_button);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.listBox1);
            this.Name = "SeAnmaldaSpelare";
            this.Text = "Se anmälda spelare";
            this.Load += new System.EventHandler(this.SeAnmaldaSpelare_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button action_button;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.CheckBox alla_checkBox;
        private System.Windows.Forms.CheckBox kvinnor_checkBox;
        private System.Windows.Forms.CheckBox man_checkBox;
        private System.Windows.Forms.CheckBox singel_checkBox;
        private System.Windows.Forms.CheckBox par_checkBox;
        private System.Windows.Forms.CheckBox lag_checkBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tävling_id_textBox;
    }
}