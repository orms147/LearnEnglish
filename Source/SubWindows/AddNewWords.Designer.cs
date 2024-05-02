
namespace LearnEnglish.Source.SubWindows
{
    partial class AddNewWords
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
            this.addNewWords_Cancel_button = new System.Windows.Forms.Button();
            this.addNewWords_OK_button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addNewWords_vocabList_textBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addNewWords_Cancel_button
            // 
            this.addNewWords_Cancel_button.Location = new System.Drawing.Point(227, 257);
            this.addNewWords_Cancel_button.Name = "addNewWords_Cancel_button";
            this.addNewWords_Cancel_button.Size = new System.Drawing.Size(79, 23);
            this.addNewWords_Cancel_button.TabIndex = 0;
            this.addNewWords_Cancel_button.Text = "Cancel";
            this.addNewWords_Cancel_button.UseVisualStyleBackColor = true;
            this.addNewWords_Cancel_button.Click += new System.EventHandler(this.addNewWords_Cancel_button_Click);
            // 
            // addNewWords_OK_button
            // 
            this.addNewWords_OK_button.Location = new System.Drawing.Point(70, 257);
            this.addNewWords_OK_button.Name = "addNewWords_OK_button";
            this.addNewWords_OK_button.Size = new System.Drawing.Size(75, 23);
            this.addNewWords_OK_button.TabIndex = 1;
            this.addNewWords_OK_button.Text = "OK";
            this.addNewWords_OK_button.UseVisualStyleBackColor = true;
            this.addNewWords_OK_button.Click += new System.EventHandler(this.addNewWords_OK_button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addNewWords_vocabList_textBox);
            this.groupBox1.Location = new System.Drawing.Point(33, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 220);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập các từ mới";
            // 
            // addNewWords_vocabList_textBox
            // 
            this.addNewWords_vocabList_textBox.Location = new System.Drawing.Point(6, 19);
            this.addNewWords_vocabList_textBox.Multiline = true;
            this.addNewWords_vocabList_textBox.Name = "addNewWords_vocabList_textBox";
            this.addNewWords_vocabList_textBox.Size = new System.Drawing.Size(280, 195);
            this.addNewWords_vocabList_textBox.TabIndex = 0;
            this.addNewWords_vocabList_textBox.TextChanged += new System.EventHandler(this.addNewWords_vocabList_textBox_TextChanged);
            // 
            // AddNewWords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 292);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.addNewWords_OK_button);
            this.Controls.Add(this.addNewWords_Cancel_button);
            this.MaximumSize = new System.Drawing.Size(390, 331);
            this.MinimumSize = new System.Drawing.Size(390, 331);
            this.Name = "AddNewWords";
            this.Text = "Thêm từ mới";
            this.Load += new System.EventHandler(this.AddNewWords_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addNewWords_Cancel_button;
        private System.Windows.Forms.Button addNewWords_OK_button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox addNewWords_vocabList_textBox;
    }
}