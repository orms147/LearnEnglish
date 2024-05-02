namespace LearnEnglish
{
    partial class MainWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.volume_comboBox = new System.Windows.Forms.ComboBox();
            this.lesson_comboBox = new System.Windows.Forms.ComboBox();
            this.ViEn_radioBtn = new System.Windows.Forms.RadioButton();
            this.EnVi_radioBtn = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.search_button = new System.Windows.Forms.Button();
            this.search_textBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.generalPractise_button = new System.Windows.Forms.Button();
            this.lessonPractise_button = new System.Windows.Forms.Button();
            this.level_comboBox = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.createVolume_button = new System.Windows.Forms.Button();
            this.createLesson_button = new System.Windows.Forms.Button();
            this.statistic_button = new System.Windows.Forms.Button();
            this.save_button = new System.Windows.Forms.Button();
            this.displayVocab_groupBox = new System.Windows.Forms.GroupBox();
            this.removeWord_button = new System.Windows.Forms.Button();
            this.addWord_button = new System.Windows.Forms.Button();
            this.levelGroup_label = new System.Windows.Forms.Label();
            this.meaning_label = new System.Windows.Forms.Label();
            this.pronounce_label = new System.Windows.Forms.Label();
            this.meaning_button = new System.Windows.Forms.Button();
            this.pronounce_button = new System.Windows.Forms.Button();
            this.randomWord_label = new System.Windows.Forms.Label();
            this.randomWord_button = new System.Windows.Forms.Button();
            this.lessonName_label = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.displayVocab_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(419, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Học từ vựng";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.volume_comboBox);
            this.groupBox1.Controls.Add(this.lesson_comboBox);
            this.groupBox1.Controls.Add(this.ViEn_radioBtn);
            this.groupBox1.Controls.Add(this.EnVi_radioBtn);
            this.groupBox1.Location = new System.Drawing.Point(33, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 99);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lựa chọn";
            // 
            // volume_comboBox
            // 
            this.volume_comboBox.FormattingEnabled = true;
            this.volume_comboBox.Location = new System.Drawing.Point(110, 20);
            this.volume_comboBox.Name = "volume_comboBox";
            this.volume_comboBox.Size = new System.Drawing.Size(115, 21);
            this.volume_comboBox.TabIndex = 3;
            this.volume_comboBox.Text = "Lựa chọn tập";
            this.volume_comboBox.SelectedIndexChanged += new System.EventHandler(this.volume_comboBox_SelectedIndexChanged);
            // 
            // lesson_comboBox
            // 
            this.lesson_comboBox.FormattingEnabled = true;
            this.lesson_comboBox.Location = new System.Drawing.Point(110, 62);
            this.lesson_comboBox.Name = "lesson_comboBox";
            this.lesson_comboBox.Size = new System.Drawing.Size(115, 21);
            this.lesson_comboBox.TabIndex = 2;
            this.lesson_comboBox.Text = "Lựa chọn bài";
            this.lesson_comboBox.SelectedIndexChanged += new System.EventHandler(this.lesson_comboBox_SelectedIndexChanged);
            // 
            // ViEn_radioBtn
            // 
            this.ViEn_radioBtn.AutoSize = true;
            this.ViEn_radioBtn.Location = new System.Drawing.Point(19, 66);
            this.ViEn_radioBtn.Name = "ViEn_radioBtn";
            this.ViEn_radioBtn.Size = new System.Drawing.Size(65, 17);
            this.ViEn_radioBtn.TabIndex = 1;
            this.ViEn_radioBtn.TabStop = true;
            this.ViEn_radioBtn.Text = "Việt-Anh";
            this.ViEn_radioBtn.UseVisualStyleBackColor = true;
            this.ViEn_radioBtn.CheckedChanged += new System.EventHandler(this.ViEn_radioBtn_CheckedChanged);
            // 
            // EnVi_radioBtn
            // 
            this.EnVi_radioBtn.AutoSize = true;
            this.EnVi_radioBtn.Location = new System.Drawing.Point(19, 24);
            this.EnVi_radioBtn.Name = "EnVi_radioBtn";
            this.EnVi_radioBtn.Size = new System.Drawing.Size(65, 17);
            this.EnVi_radioBtn.TabIndex = 0;
            this.EnVi_radioBtn.TabStop = true;
            this.EnVi_radioBtn.Text = "Anh-Việt";
            this.EnVi_radioBtn.UseVisualStyleBackColor = true;
            this.EnVi_radioBtn.CheckedChanged += new System.EventHandler(this.EnVi_radioBtn_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.search_button);
            this.groupBox2.Controls.Add(this.search_textBox);
            this.groupBox2.Location = new System.Drawing.Point(338, 92);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(193, 100);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm";
            // 
            // search_button
            // 
            this.search_button.Location = new System.Drawing.Point(57, 60);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(75, 23);
            this.search_button.TabIndex = 1;
            this.search_button.Text = "Tìm kiếm";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // search_textBox
            // 
            this.search_textBox.Location = new System.Drawing.Point(22, 23);
            this.search_textBox.Name = "search_textBox";
            this.search_textBox.Size = new System.Drawing.Size(145, 20);
            this.search_textBox.TabIndex = 0;
            this.search_textBox.TextChanged += new System.EventHandler(this.search_textBox_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.generalPractise_button);
            this.groupBox3.Controls.Add(this.lessonPractise_button);
            this.groupBox3.Controls.Add(this.level_comboBox);
            this.groupBox3.Location = new System.Drawing.Point(588, 92);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(202, 98);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Luyện tập";
            // 
            // generalPractise_button
            // 
            this.generalPractise_button.Location = new System.Drawing.Point(101, 60);
            this.generalPractise_button.Name = "generalPractise_button";
            this.generalPractise_button.Size = new System.Drawing.Size(95, 23);
            this.generalPractise_button.TabIndex = 2;
            this.generalPractise_button.Text = "Luyện tập chung";
            this.generalPractise_button.UseVisualStyleBackColor = true;
            this.generalPractise_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // lessonPractise_button
            // 
            this.lessonPractise_button.Location = new System.Drawing.Point(6, 60);
            this.lessonPractise_button.Name = "lessonPractise_button";
            this.lessonPractise_button.Size = new System.Drawing.Size(89, 23);
            this.lessonPractise_button.TabIndex = 1;
            this.lessonPractise_button.Text = "Luyện tập bài";
            this.lessonPractise_button.UseVisualStyleBackColor = true;
            this.lessonPractise_button.Click += new System.EventHandler(this.lessonPractise_button_Click);
            // 
            // level_comboBox
            // 
            this.level_comboBox.FormattingEnabled = true;
            this.level_comboBox.Location = new System.Drawing.Point(26, 23);
            this.level_comboBox.Name = "level_comboBox";
            this.level_comboBox.Size = new System.Drawing.Size(153, 21);
            this.level_comboBox.TabIndex = 0;
            this.level_comboBox.Text = "Lựa chọn nhóm từ vựng";
            this.level_comboBox.SelectedIndexChanged += new System.EventHandler(this.level_comboBox_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.createVolume_button);
            this.groupBox4.Controls.Add(this.createLesson_button);
            this.groupBox4.Controls.Add(this.statistic_button);
            this.groupBox4.Controls.Add(this.save_button);
            this.groupBox4.Location = new System.Drawing.Point(846, 92);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(288, 99);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chức năng";
            // 
            // createVolume_button
            // 
            this.createVolume_button.Location = new System.Drawing.Point(155, 60);
            this.createVolume_button.Name = "createVolume_button";
            this.createVolume_button.Size = new System.Drawing.Size(98, 23);
            this.createVolume_button.TabIndex = 3;
            this.createVolume_button.Text = "Thêm tập mới";
            this.createVolume_button.UseVisualStyleBackColor = true;
            this.createVolume_button.Click += new System.EventHandler(this.createVolume_button_Click);
            // 
            // createLesson_button
            // 
            this.createLesson_button.Location = new System.Drawing.Point(32, 60);
            this.createLesson_button.Name = "createLesson_button";
            this.createLesson_button.Size = new System.Drawing.Size(98, 23);
            this.createLesson_button.TabIndex = 2;
            this.createLesson_button.Text = "Thêm bài mới";
            this.createLesson_button.UseVisualStyleBackColor = true;
            this.createLesson_button.Click += new System.EventHandler(this.createLesson_button_Click);
            // 
            // statistic_button
            // 
            this.statistic_button.Location = new System.Drawing.Point(155, 24);
            this.statistic_button.Name = "statistic_button";
            this.statistic_button.Size = new System.Drawing.Size(98, 23);
            this.statistic_button.TabIndex = 1;
            this.statistic_button.Text = "Thống kê";
            this.statistic_button.UseVisualStyleBackColor = true;
            this.statistic_button.Click += new System.EventHandler(this.statistic_button_Click);
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(32, 24);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(98, 23);
            this.save_button.TabIndex = 0;
            this.save_button.Text = "Lưu từ vựng";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // displayVocab_groupBox
            // 
            this.displayVocab_groupBox.Controls.Add(this.removeWord_button);
            this.displayVocab_groupBox.Controls.Add(this.addWord_button);
            this.displayVocab_groupBox.Controls.Add(this.levelGroup_label);
            this.displayVocab_groupBox.Controls.Add(this.meaning_label);
            this.displayVocab_groupBox.Controls.Add(this.pronounce_label);
            this.displayVocab_groupBox.Controls.Add(this.meaning_button);
            this.displayVocab_groupBox.Controls.Add(this.pronounce_button);
            this.displayVocab_groupBox.Controls.Add(this.randomWord_label);
            this.displayVocab_groupBox.Controls.Add(this.randomWord_button);
            this.displayVocab_groupBox.Controls.Add(this.lessonName_label);
            this.displayVocab_groupBox.Location = new System.Drawing.Point(35, 206);
            this.displayVocab_groupBox.Name = "displayVocab_groupBox";
            this.displayVocab_groupBox.Size = new System.Drawing.Size(1102, 431);
            this.displayVocab_groupBox.TabIndex = 5;
            this.displayVocab_groupBox.TabStop = false;
            this.displayVocab_groupBox.Text = "Từ vựng trong bài";
            this.displayVocab_groupBox.Enter += new System.EventHandler(this.displayVocab_groupBox_Enter);
            // 
            // removeWord_button
            // 
            this.removeWord_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeWord_button.Location = new System.Drawing.Point(936, 21);
            this.removeWord_button.Name = "removeWord_button";
            this.removeWord_button.Size = new System.Drawing.Size(55, 28);
            this.removeWord_button.TabIndex = 11;
            this.removeWord_button.Text = "Xóa";
            this.removeWord_button.UseVisualStyleBackColor = true;
            this.removeWord_button.Click += new System.EventHandler(this.removeWord_button_Click);
            // 
            // addWord_button
            // 
            this.addWord_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addWord_button.Location = new System.Drawing.Point(843, 21);
            this.addWord_button.Name = "addWord_button";
            this.addWord_button.Size = new System.Drawing.Size(55, 28);
            this.addWord_button.TabIndex = 10;
            this.addWord_button.Text = "Thêm";
            this.addWord_button.UseVisualStyleBackColor = true;
            this.addWord_button.Click += new System.EventHandler(this.addWord_button_Click);
            // 
            // levelGroup_label
            // 
            this.levelGroup_label.AutoSize = true;
            this.levelGroup_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelGroup_label.Location = new System.Drawing.Point(594, 267);
            this.levelGroup_label.Name = "levelGroup_label";
            this.levelGroup_label.Size = new System.Drawing.Size(70, 25);
            this.levelGroup_label.TabIndex = 9;
            this.levelGroup_label.Text = "label2";
            this.levelGroup_label.Visible = false;
            // 
            // meaning_label
            // 
            this.meaning_label.AutoSize = true;
            this.meaning_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meaning_label.Location = new System.Drawing.Point(196, 322);
            this.meaning_label.Name = "meaning_label";
            this.meaning_label.Size = new System.Drawing.Size(70, 25);
            this.meaning_label.TabIndex = 8;
            this.meaning_label.Text = "label3";
            this.meaning_label.Visible = false;
            // 
            // pronounce_label
            // 
            this.pronounce_label.AutoSize = true;
            this.pronounce_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pronounce_label.Location = new System.Drawing.Point(591, 191);
            this.pronounce_label.Name = "pronounce_label";
            this.pronounce_label.Size = new System.Drawing.Size(70, 25);
            this.pronounce_label.TabIndex = 7;
            this.pronounce_label.Text = "label2";
            this.pronounce_label.Visible = false;
            // 
            // meaning_button
            // 
            this.meaning_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meaning_button.Location = new System.Drawing.Point(197, 267);
            this.meaning_button.Name = "meaning_button";
            this.meaning_button.Size = new System.Drawing.Size(155, 38);
            this.meaning_button.TabIndex = 5;
            this.meaning_button.Text = "Nghĩa";
            this.meaning_button.UseVisualStyleBackColor = true;
            this.meaning_button.Visible = false;
            this.meaning_button.Click += new System.EventHandler(this.meaning_button_Click);
            // 
            // pronounce_button
            // 
            this.pronounce_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pronounce_button.Location = new System.Drawing.Point(588, 134);
            this.pronounce_button.Name = "pronounce_button";
            this.pronounce_button.Size = new System.Drawing.Size(161, 37);
            this.pronounce_button.TabIndex = 4;
            this.pronounce_button.Text = "Phát âm";
            this.pronounce_button.UseVisualStyleBackColor = true;
            this.pronounce_button.Visible = false;
            this.pronounce_button.Click += new System.EventHandler(this.pronounce_button_Click);
            // 
            // randomWord_label
            // 
            this.randomWord_label.AutoSize = true;
            this.randomWord_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.randomWord_label.Location = new System.Drawing.Point(193, 194);
            this.randomWord_label.Name = "randomWord_label";
            this.randomWord_label.Size = new System.Drawing.Size(70, 25);
            this.randomWord_label.TabIndex = 3;
            this.randomWord_label.Text = "label2";
            this.randomWord_label.Visible = false;
            // 
            // randomWord_button
            // 
            this.randomWord_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.randomWord_button.Location = new System.Drawing.Point(195, 134);
            this.randomWord_button.Name = "randomWord_button";
            this.randomWord_button.Size = new System.Drawing.Size(158, 37);
            this.randomWord_button.TabIndex = 2;
            this.randomWord_button.Text = "Từ ngẫu nhiên";
            this.randomWord_button.UseVisualStyleBackColor = true;
            this.randomWord_button.Visible = false;
            this.randomWord_button.Click += new System.EventHandler(this.randomWord_button_Click);
            // 
            // lessonName_label
            // 
            this.lessonName_label.AutoSize = true;
            this.lessonName_label.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lessonName_label.Location = new System.Drawing.Point(440, 16);
            this.lessonName_label.Name = "lessonName_label";
            this.lessonName_label.Size = new System.Drawing.Size(206, 31);
            this.lessonName_label.TabIndex = 0;
            this.lessonName_label.Text = "Hãy chọn bài học";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(267, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 649);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.displayVocab_groupBox);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "MainWindow";
            this.Text = "Học từ vựng tiếng Anh";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.displayVocab_groupBox.ResumeLayout(false);
            this.displayVocab_groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox volume_comboBox;
        private System.Windows.Forms.ComboBox lesson_comboBox;
        private System.Windows.Forms.RadioButton ViEn_radioBtn;
        private System.Windows.Forms.RadioButton EnVi_radioBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.TextBox search_textBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button generalPractise_button;
        private System.Windows.Forms.Button lessonPractise_button;
        private System.Windows.Forms.ComboBox level_comboBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button createVolume_button;
        private System.Windows.Forms.Button createLesson_button;
        private System.Windows.Forms.Button statistic_button;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.GroupBox displayVocab_groupBox;
        private System.Windows.Forms.Label lessonName_label;
        private System.Windows.Forms.Label meaning_label;
        private System.Windows.Forms.Label pronounce_label;
        private System.Windows.Forms.Button meaning_button;
        private System.Windows.Forms.Button pronounce_button;
        private System.Windows.Forms.Label randomWord_label;
        private System.Windows.Forms.Button randomWord_button;
        private System.Windows.Forms.Label levelGroup_label;
        private System.Windows.Forms.Button removeWord_button;
        private System.Windows.Forms.Button addWord_button;
        private System.Windows.Forms.Button button1;
    }
}

