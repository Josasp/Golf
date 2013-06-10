namespace Golf
{
    partial class SeAlla
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
            this.ok_button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.betalt_textBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.medlemsstatus_comboBox = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.kon_comboBox = new System.Windows.Forms.ComboBox();
            this.handicap_textBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.postort_textBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.postnummer_textBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.adress_textBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.epost_textBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.telefonnummer_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.fornamn_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.efternamn_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.golfid_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ok_button
            // 
            this.ok_button.Location = new System.Drawing.Point(931, 359);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(75, 23);
            this.ok_button.TabIndex = 55;
            this.ok_button.Text = "Stäng";
            this.ok_button.UseVisualStyleBackColor = true;
            this.ok_button.Click += new System.EventHandler(this.ok_button_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 36);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(729, 316);
            this.dataGridView1.TabIndex = 57;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(644, 358);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 23);
            this.button1.TabIndex = 58;
            this.button1.Text = "Radera markerad";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // betalt_textBox
            // 
            this.betalt_textBox.Location = new System.Drawing.Point(63, 281);
            this.betalt_textBox.Name = "betalt_textBox";
            this.betalt_textBox.Size = new System.Drawing.Size(77, 22);
            this.betalt_textBox.TabIndex = 82;
            this.betalt_textBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.golfid_textBox_KeyUp);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 285);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 81;
            this.label9.Text = "Betalt år: ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(24, 133);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 13);
            this.label12.TabIndex = 80;
            this.label12.Text = "Status";
            // 
            // medlemsstatus_comboBox
            // 
            this.medlemsstatus_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.medlemsstatus_comboBox.FormattingEnabled = true;
            this.medlemsstatus_comboBox.Items.AddRange(new object[] {
            "Aktiv",
            "Vilande",
            "Greenfee",
            "Junior",
            "Ickemedlem"});
            this.medlemsstatus_comboBox.Location = new System.Drawing.Point(63, 128);
            this.medlemsstatus_comboBox.Name = "medlemsstatus_comboBox";
            this.medlemsstatus_comboBox.Size = new System.Drawing.Size(147, 21);
            this.medlemsstatus_comboBox.TabIndex = 75;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(35, 109);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 13);
            this.label11.TabIndex = 79;
            this.label11.Text = "Kön";
            // 
            // kon_comboBox
            // 
            this.kon_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kon_comboBox.FormattingEnabled = true;
            this.kon_comboBox.Items.AddRange(new object[] {
            "Man",
            "Kvinna"});
            this.kon_comboBox.Location = new System.Drawing.Point(63, 104);
            this.kon_comboBox.Name = "kon_comboBox";
            this.kon_comboBox.Size = new System.Drawing.Size(75, 21);
            this.kon_comboBox.TabIndex = 78;
            // 
            // handicap_textBox
            // 
            this.handicap_textBox.Location = new System.Drawing.Point(63, 32);
            this.handicap_textBox.Name = "handicap_textBox";
            this.handicap_textBox.Size = new System.Drawing.Size(57, 22);
            this.handicap_textBox.TabIndex = 77;
            this.handicap_textBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.golfid_textBox_KeyUp);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 76;
            this.label10.Text = "Handicap";
            // 
            // postort_textBox
            // 
            this.postort_textBox.Location = new System.Drawing.Point(63, 206);
            this.postort_textBox.Name = "postort_textBox";
            this.postort_textBox.Size = new System.Drawing.Size(108, 22);
            this.postort_textBox.TabIndex = 74;
            this.postort_textBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.golfid_textBox_KeyUp);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 73;
            this.label8.Text = "Stad";
            // 
            // postnummer_textBox
            // 
            this.postnummer_textBox.Location = new System.Drawing.Point(63, 180);
            this.postnummer_textBox.Name = "postnummer_textBox";
            this.postnummer_textBox.Size = new System.Drawing.Size(108, 22);
            this.postnummer_textBox.TabIndex = 72;
            this.postnummer_textBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.golfid_textBox_KeyUp);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 71;
            this.label7.Text = "Postnr";
            // 
            // adress_textBox
            // 
            this.adress_textBox.Location = new System.Drawing.Point(63, 155);
            this.adress_textBox.Name = "adress_textBox";
            this.adress_textBox.Size = new System.Drawing.Size(160, 22);
            this.adress_textBox.TabIndex = 70;
            this.adress_textBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.golfid_textBox_KeyUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 69;
            this.label6.Text = "Address";
            // 
            // epost_textBox
            // 
            this.epost_textBox.Location = new System.Drawing.Point(63, 256);
            this.epost_textBox.Name = "epost_textBox";
            this.epost_textBox.Size = new System.Drawing.Size(160, 22);
            this.epost_textBox.TabIndex = 68;
            this.epost_textBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.golfid_textBox_KeyUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 67;
            this.label5.Text = "E-post";
            // 
            // telefonnummer_textBox
            // 
            this.telefonnummer_textBox.Location = new System.Drawing.Point(63, 231);
            this.telefonnummer_textBox.Name = "telefonnummer_textBox";
            this.telefonnummer_textBox.Size = new System.Drawing.Size(160, 22);
            this.telefonnummer_textBox.TabIndex = 66;
            this.telefonnummer_textBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.golfid_textBox_KeyUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 65;
            this.label4.Text = "Telefonnr";
            // 
            // fornamn_textBox
            // 
            this.fornamn_textBox.Location = new System.Drawing.Point(63, 56);
            this.fornamn_textBox.Name = "fornamn_textBox";
            this.fornamn_textBox.Size = new System.Drawing.Size(147, 22);
            this.fornamn_textBox.TabIndex = 64;
            this.fornamn_textBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.golfid_textBox_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 63;
            this.label3.Text = "Efternamn";
            // 
            // efternamn_textBox
            // 
            this.efternamn_textBox.Location = new System.Drawing.Point(63, 80);
            this.efternamn_textBox.Name = "efternamn_textBox";
            this.efternamn_textBox.Size = new System.Drawing.Size(147, 22);
            this.efternamn_textBox.TabIndex = 62;
            this.efternamn_textBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.golfid_textBox_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 61;
            this.label2.Text = "Förnamn";
            // 
            // golfid_textBox
            // 
            this.golfid_textBox.Enabled = false;
            this.golfid_textBox.Location = new System.Drawing.Point(63, 9);
            this.golfid_textBox.Name = "golfid_textBox";
            this.golfid_textBox.Size = new System.Drawing.Size(147, 22);
            this.golfid_textBox.TabIndex = 60;
            this.golfid_textBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.golfid_textBox_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 59;
            this.label1.Text = "Golf-ID";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.betalt_textBox);
            this.groupBox1.Controls.Add(this.golfid_textBox);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.epost_textBox);
            this.groupBox1.Controls.Add(this.postort_textBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.medlemsstatus_comboBox);
            this.groupBox1.Controls.Add(this.telefonnummer_textBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.postnummer_textBox);
            this.groupBox1.Controls.Add(this.handicap_textBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.adress_textBox);
            this.groupBox1.Controls.Add(this.kon_comboBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.fornamn_textBox);
            this.groupBox1.Controls.Add(this.efternamn_textBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(758, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 316);
            this.groupBox1.TabIndex = 83;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ändra ";
            this.groupBox1.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(167, 285);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 84;
            this.button2.Text = "Spara";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 358);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(107, 23);
            this.button4.TabIndex = 85;
            this.button4.Text = "Lägg till ny spelare";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(162, 6);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 86;
            this.button5.Text = "Sök spelare";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(56, 8);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 87;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 12);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 13);
            this.label13.TabIndex = 85;
            this.label13.Text = "Golf-ID";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(285, 6);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(93, 23);
            this.button6.TabIndex = 88;
            this.button6.Text = "Visa alla spelare";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // SeAlla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 395);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ok_button);
            this.Name = "SeAlla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Se alla";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ok_button;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox betalt_textBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox medlemsstatus_comboBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox kon_comboBox;
        private System.Windows.Forms.TextBox handicap_textBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox postort_textBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox postnummer_textBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox adress_textBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox epost_textBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox telefonnummer_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fornamn_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox efternamn_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox golfid_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button6;
    }
}