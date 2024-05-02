namespace LearnEnglish.Source.SubWindows
{
    partial class AddNewLesson
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
            this.addNewLesson_volume_comboBox = new System.Windows.Forms.ComboBox();
            this.addNewLesson_volume_label = new System.Windows.Forms.Label();
            this.addNewLesson_lesson_label = new System.Windows.Forms.Label();
            this.addNewLesson_lessonName_textBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addNewLesson_vocabList_textBox = new System.Windows.Forms.TextBox();
            this.addNewLesson_OK_button = new System.Windows.Forms.Button();
            this.addNewLesson_Cancel_button = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addNewLesson_volume_comboBox
            // 
            this.addNewLesson_volume_comboBox.FormattingEnabled = true;
            this.addNewLesson_volume_comboBox.Location = new System.Drawing.Point(117, 19);
            this.addNewLesson_volume_comboBox.Name = "addNewLesson_volume_comboBox";
            this.addNewLesson_volume_comboBox.Size = new System.Drawing.Size(160, 21);
            this.addNewLesson_volume_comboBox.TabIndex = 0;
            this.addNewLesson_volume_comboBox.SelectedIndexChanged += new System.EventHandler(this.addNewLesson_volume_comboBox_SelectedIndexChanged);
            // 
            // addNewLesson_volume_label
            // 
            this.addNewLesson_volume_label.AutoSize = true;
            this.addNewLesson_volume_label.Location = new System.Drawing.Point(31, 22);
            this.addNewLesson_volume_label.Name = "addNewLesson_volume_label";
            this.addNewLesson_volume_label.Size = new System.Drawing.Size(50, 13);
            this.addNewLesson_volume_label.TabIndex = 1;
            this.addNewLesson_volume_label.Text = "Chọn tập";
            // 
            // addNewLesson_lesson_label
            // 
            this.addNewLesson_lesson_label.AutoSize = true;
            this.addNewLesson_lesson_label.Location = new System.Drawing.Point(31, 59);
            this.addNewLesson_lesson_label.Name = "addNewLesson_lesson_label";
            this.addNewLesson_lesson_label.Size = new System.Drawing.Size(68, 13);
            this.addNewLesson_lesson_label.TabIndex = 2;
            this.addNewLesson_lesson_label.Text = "Nhập tên bài";
            // 
            // addNewLesson_lessonName_textBox
            // 
            this.addNewLesson_lessonName_textBox.Location = new System.Drawing.Point(117, 56);
            this.addNewLesson_lessonName_textBox.Name = "addNewLesson_lessonName_textBox";
            this.addNewLesson_lessonName_textBox.Size = new System.Drawing.Size(160, 20);
            this.addNewLesson_lessonName_textBox.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addNewLesson_vocabList_textBox);
            this.groupBox1.Location = new System.Drawing.Point(18, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 257);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập các từ mới";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // addNewLesson_vocabList_textBox
            // 
            this.addNewLesson_vocabList_textBox.Location = new System.Drawing.Point(6, 20);
            this.addNewLesson_vocabList_textBox.Multiline = true;
            this.addNewLesson_vocabList_textBox.Name = "addNewLesson_vocabList_textBox";
            this.addNewLesson_vocabList_textBox.Size = new System.Drawing.Size(265, 231);
            this.addNewLesson_vocabList_textBox.TabIndex = 0;
            this.addNewLesson_vocabList_textBox.TextChanged += new System.EventHandler(this.addNewLesson_vocabList_textBox_TextChanged);
            // 
            // addNewLesson_OK_button
            // 
            this.addNewLesson_OK_button.Location = new System.Drawing.Point(34, 371);
            this.addNewLesson_OK_button.Name = "addNewLesson_OK_button";
            this.addNewLesson_OK_button.Size = new System.Drawing.Size(75, 23);
            this.addNewLesson_OK_button.TabIndex = 5;
            this.addNewLesson_OK_button.Text = "OK";
            this.addNewLesson_OK_button.UseVisualStyleBackColor = true;
            this.addNewLesson_OK_button.Click += new System.EventHandler(this.addNewLesson_OK_button_Click);
            // 
            // addNewLesson_Cancel_button
            // 
            this.addNewLesson_Cancel_button.Location = new System.Drawing.Point(201, 371);
            this.addNewLesson_Cancel_button.Name = "addNewLesson_Cancel_button";
            this.addNewLesson_Cancel_button.Size = new System.Drawing.Size(75, 23);
            this.addNewLesson_Cancel_button.TabIndex = 6;
            this.addNewLesson_Cancel_button.Text = "Cancel";
            this.addNewLesson_Cancel_button.UseVisualStyleBackColor = true;
            this.addNewLesson_Cancel_button.Click += new System.EventHandler(this.addNewLesson_Cancel_button_Click);
            // 
            // AddNewLesson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 406);
            this.Controls.Add(this.addNewLesson_Cancel_button);
            this.Controls.Add(this.addNewLesson_OK_button);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.addNewLesson_lessonName_textBox);
            this.Controls.Add(this.addNewLesson_lesson_label);
            this.Controls.Add(this.addNewLesson_volume_label);
            this.Controls.Add(this.addNewLesson_volume_comboBox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(330, 445);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(330, 445);
            this.Name = "AddNewLesson";
            this.Text = "Tạo thêm bài mới";
            this.Load += new System.EventHandler(this.AddNewLesson_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox addNewLesson_volume_comboBox;
        private System.Windows.Forms.Label addNewLesson_volume_label;
        private System.Windows.Forms.Label addNewLesson_lesson_label;
        private System.Windows.Forms.TextBox addNewLesson_lessonName_textBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox addNewLesson_vocabList_textBox;
        private System.Windows.Forms.Button addNewLesson_OK_button;
        private System.Windows.Forms.Button addNewLesson_Cancel_button;
    }
}