namespace LearnEnglish.Source.SubWindows
{
    partial class AddNewVolume
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
            this.addNewVolume_OK_button = new System.Windows.Forms.Button();
            this.addNewVolume_Cancel_button = new System.Windows.Forms.Button();
            this.addNewVolume_label = new System.Windows.Forms.Label();
            this.addNewVolume_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addNewVolume_OK_button
            // 
            this.addNewVolume_OK_button.Enabled = false;
            this.addNewVolume_OK_button.Location = new System.Drawing.Point(41, 81);
            this.addNewVolume_OK_button.Name = "addNewVolume_OK_button";
            this.addNewVolume_OK_button.Size = new System.Drawing.Size(75, 23);
            this.addNewVolume_OK_button.TabIndex = 0;
            this.addNewVolume_OK_button.Text = "OK";
            this.addNewVolume_OK_button.UseVisualStyleBackColor = true;
            this.addNewVolume_OK_button.Click += new System.EventHandler(this.addNewVolume_OK_button_Click);
            // 
            // addNewVolume_Cancel_button
            // 
            this.addNewVolume_Cancel_button.Location = new System.Drawing.Point(175, 81);
            this.addNewVolume_Cancel_button.Name = "addNewVolume_Cancel_button";
            this.addNewVolume_Cancel_button.Size = new System.Drawing.Size(75, 23);
            this.addNewVolume_Cancel_button.TabIndex = 1;
            this.addNewVolume_Cancel_button.Text = "Cancel";
            this.addNewVolume_Cancel_button.UseVisualStyleBackColor = true;
            this.addNewVolume_Cancel_button.Click += new System.EventHandler(this.addNewVolume_Cancel_button_Click);
            // 
            // addNewVolume_label
            // 
            this.addNewVolume_label.AutoSize = true;
            this.addNewVolume_label.Location = new System.Drawing.Point(38, 34);
            this.addNewVolume_label.Name = "addNewVolume_label";
            this.addNewVolume_label.Size = new System.Drawing.Size(44, 13);
            this.addNewVolume_label.TabIndex = 2;
            this.addNewVolume_label.Text = "Tên tập";
            // 
            // addNewVolume_textBox
            // 
            this.addNewVolume_textBox.Location = new System.Drawing.Point(89, 31);
            this.addNewVolume_textBox.Name = "addNewVolume_textBox";
            this.addNewVolume_textBox.Size = new System.Drawing.Size(161, 20);
            this.addNewVolume_textBox.TabIndex = 3;
            this.addNewVolume_textBox.TextChanged += new System.EventHandler(this.addNewVolume_textBox_TextChanged);
            // 
            // AddNewVolume
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 120);
            this.ControlBox = false;
            this.Controls.Add(this.addNewVolume_textBox);
            this.Controls.Add(this.addNewVolume_label);
            this.Controls.Add(this.addNewVolume_Cancel_button);
            this.Controls.Add(this.addNewVolume_OK_button);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(313, 159);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(313, 159);
            this.Name = "AddNewVolume";
            this.Text = "Thêm tập mới";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addNewVolume_OK_button;
        private System.Windows.Forms.Button addNewVolume_Cancel_button;
        private System.Windows.Forms.Label addNewVolume_label;
        private System.Windows.Forms.TextBox addNewVolume_textBox;
    }
}