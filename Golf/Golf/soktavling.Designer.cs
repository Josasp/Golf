namespace Golf
{
    partial class SokTavling
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.tavlingsnamn_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ok_button = new System.Windows.Forms.Button();
            this.avbryt_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(15, 145);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(141, 20);
            this.dateTimePicker1.TabIndex = 65;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 57;
            this.label2.Text = "Datum";
            // 
            // tavlingsnamn_textBox
            // 
            this.tavlingsnamn_textBox.Location = new System.Drawing.Point(15, 91);
            this.tavlingsnamn_textBox.Name = "tavlingsnamn_textBox";
            this.tavlingsnamn_textBox.Size = new System.Drawing.Size(199, 20);
            this.tavlingsnamn_textBox.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 55;
            this.label1.Text = "Tävlingsnamn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 66;
            this.label5.Text = "Tävling-ID";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(51, 20);
            this.textBox1.TabIndex = 67;
            // 
            // ok_button
            // 
            this.ok_button.Location = new System.Drawing.Point(107, 221);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(75, 23);
            this.ok_button.TabIndex = 68;
            this.ok_button.Text = "OK";
            this.ok_button.UseVisualStyleBackColor = true;
            this.ok_button.Click += new System.EventHandler(this.ok_button_Click);
            // 
            // avbryt_button
            // 
            this.avbryt_button.Location = new System.Drawing.Point(188, 221);
            this.avbryt_button.Name = "avbryt_button";
            this.avbryt_button.Size = new System.Drawing.Size(75, 23);
            this.avbryt_button.TabIndex = 69;
            this.avbryt_button.Text = "Avbryt";
            this.avbryt_button.UseVisualStyleBackColor = true;
            this.avbryt_button.Click += new System.EventHandler(this.avbryt_button_Click);
            // 
            // soktavling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 254);
            this.Controls.Add(this.avbryt_button);
            this.Controls.Add(this.ok_button);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tavlingsnamn_textBox);
            this.Controls.Add(this.label1);
            this.Name = "soktavling";
            this.Text = "Sök tävling";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tavlingsnamn_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button ok_button;
        private System.Windows.Forms.Button avbryt_button;
    }
}