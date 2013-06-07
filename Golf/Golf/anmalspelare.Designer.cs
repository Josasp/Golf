namespace Golf
{
    partial class AnmalSpelare
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
            this.label12 = new System.Windows.Forms.Label();
            this.golfid_textBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lag_checkBox = new System.Windows.Forms.CheckBox();
            this.par_checkBox = new System.Windows.Forms.CheckBox();
            this.singel_checkBox = new System.Windows.Forms.CheckBox();
            this.action_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tävling_id_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 81);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 13);
            this.label12.TabIndex = 76;
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // golfid_textBox
            // 
            this.golfid_textBox.Location = new System.Drawing.Point(12, 74);
            this.golfid_textBox.Name = "golfid_textBox";
            this.golfid_textBox.Size = new System.Drawing.Size(147, 22);
            this.golfid_textBox.TabIndex = 75;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(14, 58);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 13);
            this.label13.TabIndex = 74;
            this.label13.Text = "Golf-ID";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(14, 143);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(64, 13);
            this.label17.TabIndex = 97;
            this.label17.Text = "Tävlingstyp";
            // 
            // lag_checkBox
            // 
            this.lag_checkBox.AutoSize = true;
            this.lag_checkBox.Location = new System.Drawing.Point(155, 173);
            this.lag_checkBox.Name = "lag_checkBox";
            this.lag_checkBox.Size = new System.Drawing.Size(44, 17);
            this.lag_checkBox.TabIndex = 96;
            this.lag_checkBox.Text = "Lag";
            this.lag_checkBox.UseVisualStyleBackColor = true;
            // 
            // par_checkBox
            // 
            this.par_checkBox.AutoSize = true;
            this.par_checkBox.Location = new System.Drawing.Point(92, 173);
            this.par_checkBox.Name = "par_checkBox";
            this.par_checkBox.Size = new System.Drawing.Size(42, 17);
            this.par_checkBox.TabIndex = 95;
            this.par_checkBox.Text = "Par";
            this.par_checkBox.UseVisualStyleBackColor = true;
            // 
            // singel_checkBox
            // 
            this.singel_checkBox.AutoSize = true;
            this.singel_checkBox.Location = new System.Drawing.Point(15, 173);
            this.singel_checkBox.Name = "singel_checkBox";
            this.singel_checkBox.Size = new System.Drawing.Size(58, 17);
            this.singel_checkBox.TabIndex = 94;
            this.singel_checkBox.Text = "Singel";
            this.singel_checkBox.UseVisualStyleBackColor = true;
            // 
            // action_button
            // 
            this.action_button.Location = new System.Drawing.Point(205, 244);
            this.action_button.Name = "action_button";
            this.action_button.Size = new System.Drawing.Size(75, 23);
            this.action_button.TabIndex = 99;
            this.action_button.Text = "OK";
            this.action_button.UseVisualStyleBackColor = true;
            this.action_button.Click += new System.EventHandler(this.action_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(12, 244);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(75, 23);
            this.cancel_button.TabIndex = 98;
            this.cancel_button.Text = "Avbryt";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 101;
            this.label2.Text = "Tävling-ID";
            // 
            // tävling_id_textBox
            // 
            this.tävling_id_textBox.Location = new System.Drawing.Point(12, 25);
            this.tävling_id_textBox.Name = "tävling_id_textBox";
            this.tävling_id_textBox.Size = new System.Drawing.Size(147, 22);
            this.tävling_id_textBox.TabIndex = 102;
            // 
            // AnmalSpelare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 276);
            this.Controls.Add(this.tävling_id_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.action_button);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.lag_checkBox);
            this.Controls.Add(this.par_checkBox);
            this.Controls.Add(this.singel_checkBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.golfid_textBox);
            this.Controls.Add(this.label13);
            this.Name = "AnmalSpelare";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Anmäl spelare";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox golfid_textBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.CheckBox lag_checkBox;
        private System.Windows.Forms.CheckBox par_checkBox;
        private System.Windows.Forms.CheckBox singel_checkBox;
        private System.Windows.Forms.Button action_button;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tävling_id_textBox;

    }
}