namespace LearnEnglish.Source.SubWindows
{
    partial class PlayPronunciationButton
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.playMp3Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // playMp3Button
            // 
            this.playMp3Button.BackgroundImage = global::LearnEnglish.Properties.Resources.audio;
            this.playMp3Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.playMp3Button.Location = new System.Drawing.Point(0, 0);
            this.playMp3Button.Margin = new System.Windows.Forms.Padding(0);
            this.playMp3Button.Name = "playMp3Button";
            this.playMp3Button.Size = new System.Drawing.Size(15, 15);
            this.playMp3Button.TabIndex = 0;
            this.playMp3Button.UseVisualStyleBackColor = true;
            this.playMp3Button.Click += new System.EventHandler(this.playMp3Button_Click);
            // 
            // PlayPronunciationButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.playMp3Button);
            this.Name = "PlayPronunciationButton";
            this.Size = new System.Drawing.Size(15, 15);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button playMp3Button;
    }
}
