namespace Golf
{
    partial class BookingWindow
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.book_button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gender_comboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.players_comboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // monthCalendar
            // 
            this.monthCalendar.BackColor = System.Drawing.SystemColors.Window;
            this.monthCalendar.CalendarDimensions = new System.Drawing.Size(1, 3);
            this.monthCalendar.Location = new System.Drawing.Point(629, 91);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.ShowWeekNumbers = true;
            this.monthCalendar.TabIndex = 0;
            this.monthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_DateChanged);
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.PaleGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.Location = new System.Drawing.Point(12, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(605, 539);
            this.dataGridView.TabIndex = 1;
            this.dataGridView.SelectionChanged += new System.EventHandler(this.dataGridView_SelectionChanged);
            // 
            // book_button
            // 
            this.book_button.Location = new System.Drawing.Point(12, 557);
            this.book_button.Name = "book_button";
            this.book_button.Size = new System.Drawing.Size(75, 23);
            this.book_button.TabIndex = 3;
            this.book_button.Text = "Boka tid";
            this.book_button.UseVisualStyleBackColor = true;
            this.book_button.Click += new System.EventHandler(this.book_button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.players_comboBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.gender_comboBox);
            this.groupBox1.Location = new System.Drawing.Point(629, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 67);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kalenderfilter";
            // 
            // gender_comboBox
            // 
            this.gender_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gender_comboBox.Enabled = false;
            this.gender_comboBox.FormattingEnabled = true;
            this.gender_comboBox.Items.AddRange(new object[] {
            "Båda",
            "Man",
            "Kvinna"});
            this.gender_comboBox.Location = new System.Drawing.Point(125, 34);
            this.gender_comboBox.Name = "gender_comboBox";
            this.gender_comboBox.Size = new System.Drawing.Size(118, 21);
            this.gender_comboBox.TabIndex = 0;
            this.gender_comboBox.SelectedIndexChanged += new System.EventHandler(this.players_comboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kön";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Spelare";
            // 
            // players_comboBox
            // 
            this.players_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.players_comboBox.FormattingEnabled = true;
            this.players_comboBox.Items.AddRange(new object[] {
            "1 spelare",
            "2 spelare",
            "3 spelare",
            "4 spelare"});
            this.players_comboBox.Location = new System.Drawing.Point(9, 34);
            this.players_comboBox.Name = "players_comboBox";
            this.players_comboBox.Size = new System.Drawing.Size(110, 21);
            this.players_comboBox.TabIndex = 2;
            this.players_comboBox.SelectedIndexChanged += new System.EventHandler(this.players_comboBox_SelectedIndexChanged);
            // 
            // BookingWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 593);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.book_button);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.monthCalendar);
            this.Name = "BookingWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Bokningslista";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button book_button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox players_comboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox gender_comboBox;
    }
}