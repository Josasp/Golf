namespace Golf
{
    partial class BusyForm
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
            this.unbook_button = new System.Windows.Forms.Button();
            this.book_button = new System.Windows.Forms.Button();
            this.note_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // unbook_button
            // 
            this.unbook_button.Location = new System.Drawing.Point(12, 70);
            this.unbook_button.Name = "unbook_button";
            this.unbook_button.Size = new System.Drawing.Size(75, 23);
            this.unbook_button.TabIndex = 0;
            this.unbook_button.Text = "Avboka";
            this.unbook_button.UseVisualStyleBackColor = true;
            // 
            // book_button
            // 
            this.book_button.Location = new System.Drawing.Point(93, 70);
            this.book_button.Name = "book_button";
            this.book_button.Size = new System.Drawing.Size(130, 23);
            this.book_button.TabIndex = 1;
            this.book_button.Text = "Boka";
            this.book_button.UseVisualStyleBackColor = true;
            this.book_button.Click += new System.EventHandler(this.book_button_Click);
            // 
            // note_textBox
            // 
            this.note_textBox.Location = new System.Drawing.Point(12, 25);
            this.note_textBox.Name = "note_textBox";
            this.note_textBox.Size = new System.Drawing.Size(211, 22);
            this.note_textBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Notering";
            // 
            // BusyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 105);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.note_textBox);
            this.Controls.Add(this.book_button);
            this.Controls.Add(this.unbook_button);
            this.Name = "BusyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Boka upptaget";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button unbook_button;
        private System.Windows.Forms.Button book_button;
        private System.Windows.Forms.TextBox note_textBox;
        private System.Windows.Forms.Label label1;
    }
}