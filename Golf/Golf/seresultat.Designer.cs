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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.singel_radioButton = new System.Windows.Forms.RadioButton();
            this.lag_radioButton = new System.Windows.Forms.RadioButton();
            this.action_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.res_textBox = new System.Windows.Forms.TextBox();
            this.save_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // singel_radioButton
            // 
            this.singel_radioButton.AutoSize = true;
            this.singel_radioButton.Location = new System.Drawing.Point(12, 25);
            this.singel_radioButton.Name = "singel_radioButton";
            this.singel_radioButton.Size = new System.Drawing.Size(57, 17);
            this.singel_radioButton.TabIndex = 70;
            this.singel_radioButton.Text = "Singel";
            this.singel_radioButton.UseVisualStyleBackColor = true;
            this.singel_radioButton.CheckedChanged += new System.EventHandler(this.singel_radioButton_CheckedChanged);
            // 
            // lag_radioButton
            // 
            this.lag_radioButton.AutoSize = true;
            this.lag_radioButton.Location = new System.Drawing.Point(75, 25);
            this.lag_radioButton.Name = "lag_radioButton";
            this.lag_radioButton.Size = new System.Drawing.Size(43, 17);
            this.lag_radioButton.TabIndex = 69;
            this.lag_radioButton.TabStop = true;
            this.lag_radioButton.Text = "Lag";
            this.lag_radioButton.UseVisualStyleBackColor = true;
            this.lag_radioButton.CheckedChanged += new System.EventHandler(this.singel_radioButton_CheckedChanged);
            // 
            // action_button
            // 
            this.action_button.Location = new System.Drawing.Point(241, 384);
            this.action_button.Name = "action_button";
            this.action_button.Size = new System.Drawing.Size(75, 23);
            this.action_button.TabIndex = 72;
            this.action_button.Text = "OK";
            this.action_button.UseVisualStyleBackColor = true;
            this.action_button.Click += new System.EventHandler(this.cancel_button_Click);
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
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.PaleGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.Location = new System.Drawing.Point(12, 48);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(385, 330);
            this.dataGridView.TabIndex = 73;
            this.dataGridView.SelectionChanged += new System.EventHandler(this.dataGridView_SelectionChanged);
            // 
            // res_textBox
            // 
            this.res_textBox.Location = new System.Drawing.Point(12, 384);
            this.res_textBox.Name = "res_textBox";
            this.res_textBox.Size = new System.Drawing.Size(100, 22);
            this.res_textBox.TabIndex = 74;
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(118, 384);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(75, 23);
            this.save_button.TabIndex = 75;
            this.save_button.Text = "Spara";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // SeResultat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 419);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.res_textBox);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.action_button);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.singel_radioButton);
            this.Controls.Add(this.lag_radioButton);
            this.Name = "SeResultat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Se resultat";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton singel_radioButton;
        private System.Windows.Forms.RadioButton lag_radioButton;
        private System.Windows.Forms.Button action_button;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox res_textBox;
        private System.Windows.Forms.Button save_button;
    }
}