﻿namespace Golf
{
    partial class LaggTillspelare
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
            this.label11 = new System.Windows.Forms.Label();
            this.kon_comboBox = new System.Windows.Forms.ComboBox();
            this.action_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.betalat_checkBox = new System.Windows.Forms.CheckBox();
            this.handicap_textBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.medlemsstatus_comboBox = new System.Windows.Forms.ComboBox();
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
            this.medlem_radioButton = new System.Windows.Forms.RadioButton();
            this.ickemedlem_radioButton = new System.Windows.Forms.RadioButton();
            this.medlem_groupBox = new System.Windows.Forms.GroupBox();
            this.medlem_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 208);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 13);
            this.label11.TabIndex = 49;
            this.label11.Text = "Kön";
            // 
            // kon_comboBox
            // 
            this.kon_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kon_comboBox.FormattingEnabled = true;
            this.kon_comboBox.Items.AddRange(new object[] {
            "Man",
            "Kvinna"});
            this.kon_comboBox.Location = new System.Drawing.Point(24, 224);
            this.kon_comboBox.Name = "kon_comboBox";
            this.kon_comboBox.Size = new System.Drawing.Size(75, 21);
            this.kon_comboBox.TabIndex = 48;
            // 
            // action_button
            // 
            this.action_button.Location = new System.Drawing.Point(259, 408);
            this.action_button.Name = "action_button";
            this.action_button.Size = new System.Drawing.Size(75, 23);
            this.action_button.TabIndex = 47;
            this.action_button.Text = "OK";
            this.action_button.UseVisualStyleBackColor = true;
            this.action_button.Click += new System.EventHandler(this.action_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(340, 408);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(75, 23);
            this.cancel_button.TabIndex = 46;
            this.cancel_button.Text = "Avbryt";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // betalat_checkBox
            // 
            this.betalat_checkBox.AutoSize = true;
            this.betalat_checkBox.Location = new System.Drawing.Point(11, 46);
            this.betalat_checkBox.Name = "betalat_checkBox";
            this.betalat_checkBox.Size = new System.Drawing.Size(126, 17);
            this.betalat_checkBox.TabIndex = 45;
            this.betalat_checkBox.Text = "Medlemsavgift betald";
            this.betalat_checkBox.UseVisualStyleBackColor = true;
            // 
            // handicap_textBox
            // 
            this.handicap_textBox.Location = new System.Drawing.Point(24, 78);
            this.handicap_textBox.Name = "handicap_textBox";
            this.handicap_textBox.Size = new System.Drawing.Size(57, 20);
            this.handicap_textBox.TabIndex = 44;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 43;
            this.label10.Text = "Handicap";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 42;
            // 
            // medlemsstatus_comboBox
            // 
            this.medlemsstatus_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.medlemsstatus_comboBox.FormattingEnabled = true;
            this.medlemsstatus_comboBox.Items.AddRange(new object[] {
            "Aktiv",
            "Vilande",
            "Greenfee",
            "Junior"});
            this.medlemsstatus_comboBox.Location = new System.Drawing.Point(11, 19);
            this.medlemsstatus_comboBox.Name = "medlemsstatus_comboBox";
            this.medlemsstatus_comboBox.Size = new System.Drawing.Size(147, 21);
            this.medlemsstatus_comboBox.TabIndex = 41;
            // 
            // postort_textBox
            // 
            this.postort_textBox.Location = new System.Drawing.Point(308, 78);
            this.postort_textBox.Name = "postort_textBox";
            this.postort_textBox.Size = new System.Drawing.Size(108, 20);
            this.postort_textBox.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(305, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 39;
            this.label8.Text = "Stad";
            // 
            // postnummer_textBox
            // 
            this.postnummer_textBox.Location = new System.Drawing.Point(209, 78);
            this.postnummer_textBox.Name = "postnummer_textBox";
            this.postnummer_textBox.Size = new System.Drawing.Size(93, 20);
            this.postnummer_textBox.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(206, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "Postnummer";
            // 
            // adress_textBox
            // 
            this.adress_textBox.Location = new System.Drawing.Point(209, 37);
            this.adress_textBox.Name = "adress_textBox";
            this.adress_textBox.Size = new System.Drawing.Size(207, 20);
            this.adress_textBox.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(206, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Address";
            // 
            // epost_textBox
            // 
            this.epost_textBox.Location = new System.Drawing.Point(209, 183);
            this.epost_textBox.Name = "epost_textBox";
            this.epost_textBox.Size = new System.Drawing.Size(207, 20);
            this.epost_textBox.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(206, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "E-post";
            // 
            // telefonnummer_textBox
            // 
            this.telefonnummer_textBox.Location = new System.Drawing.Point(209, 142);
            this.telefonnummer_textBox.Name = "telefonnummer_textBox";
            this.telefonnummer_textBox.Size = new System.Drawing.Size(207, 20);
            this.telefonnummer_textBox.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(206, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Telefonnummer";
            // 
            // fornamn_textBox
            // 
            this.fornamn_textBox.Location = new System.Drawing.Point(24, 142);
            this.fornamn_textBox.Name = "fornamn_textBox";
            this.fornamn_textBox.Size = new System.Drawing.Size(147, 20);
            this.fornamn_textBox.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Efternamn";
            // 
            // efternamn_textBox
            // 
            this.efternamn_textBox.Location = new System.Drawing.Point(24, 183);
            this.efternamn_textBox.Name = "efternamn_textBox";
            this.efternamn_textBox.Size = new System.Drawing.Size(147, 20);
            this.efternamn_textBox.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Förnamn";
            // 
            // golfid_textBox
            // 
            this.golfid_textBox.Location = new System.Drawing.Point(24, 37);
            this.golfid_textBox.Name = "golfid_textBox";
            this.golfid_textBox.Size = new System.Drawing.Size(147, 20);
            this.golfid_textBox.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Golf-ID";
            // 
            // medlem_radioButton
            // 
            this.medlem_radioButton.AutoSize = true;
            this.medlem_radioButton.Location = new System.Drawing.Point(24, 277);
            this.medlem_radioButton.Name = "medlem_radioButton";
            this.medlem_radioButton.Size = new System.Drawing.Size(62, 17);
            this.medlem_radioButton.TabIndex = 50;
            this.medlem_radioButton.TabStop = true;
            this.medlem_radioButton.Text = "Medlem";
            this.medlem_radioButton.UseVisualStyleBackColor = true;
            this.medlem_radioButton.CheckedChanged += new System.EventHandler(this.medlem_radioButton_CheckedChanged);
            // 
            // ickemedlem_radioButton
            // 
            this.ickemedlem_radioButton.AutoSize = true;
            this.ickemedlem_radioButton.Location = new System.Drawing.Point(102, 277);
            this.ickemedlem_radioButton.Name = "ickemedlem_radioButton";
            this.ickemedlem_radioButton.Size = new System.Drawing.Size(85, 17);
            this.ickemedlem_radioButton.TabIndex = 51;
            this.ickemedlem_radioButton.TabStop = true;
            this.ickemedlem_radioButton.Text = "Icke-medlem";
            this.ickemedlem_radioButton.UseVisualStyleBackColor = true;
            this.ickemedlem_radioButton.CheckedChanged += new System.EventHandler(this.ickemedlem_radioButton_CheckedChanged);
            // 
            // medlem_groupBox
            // 
            this.medlem_groupBox.Controls.Add(this.label9);
            this.medlem_groupBox.Controls.Add(this.medlemsstatus_comboBox);
            this.medlem_groupBox.Controls.Add(this.betalat_checkBox);
            this.medlem_groupBox.Location = new System.Drawing.Point(20, 306);
            this.medlem_groupBox.Name = "medlem_groupBox";
            this.medlem_groupBox.Size = new System.Drawing.Size(174, 93);
            this.medlem_groupBox.TabIndex = 52;
            this.medlem_groupBox.TabStop = false;
            this.medlem_groupBox.Text = "Medlemsstatus";
            this.medlem_groupBox.Visible = false;
            // 
            // laggtillspelare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 443);
            this.Controls.Add(this.medlem_groupBox);
            this.Controls.Add(this.ickemedlem_radioButton);
            this.Controls.Add(this.medlem_radioButton);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.kon_comboBox);
            this.Controls.Add(this.action_button);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.handicap_textBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.postort_textBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.postnummer_textBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.adress_textBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.epost_textBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.telefonnummer_textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fornamn_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.efternamn_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.golfid_textBox);
            this.Controls.Add(this.label1);
            this.Name = "laggtillspelare";
            this.Text = "Lägg till spelare";
            this.medlem_groupBox.ResumeLayout(false);
            this.medlem_groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox kon_comboBox;
        private System.Windows.Forms.Button action_button;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.CheckBox betalat_checkBox;
        private System.Windows.Forms.TextBox handicap_textBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox medlemsstatus_comboBox;
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
        private System.Windows.Forms.RadioButton medlem_radioButton;
        private System.Windows.Forms.RadioButton ickemedlem_radioButton;
        private System.Windows.Forms.GroupBox medlem_groupBox;

    }
}