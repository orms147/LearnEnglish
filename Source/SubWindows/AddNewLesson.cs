using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearnEnglish.Source.SubWindows
{
    public partial class AddNewLesson : Form
    {
        private MainWindow myParent;
        public AddNewLesson(MainWindow parent, string[] volumeList)
        {
            myParent = parent;
            InitializeComponent();

            int volumeCount = volumeList.Length;

            for (int i = 0; i < volumeCount; i++)
            {
                string volumeName = volumeList[i];
                addNewLesson_volume_comboBox.Items.Add(volumeName);
            }
        }

        private void addNewLesson_Cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addNewLesson_OK_button_Click(object sender, EventArgs e)
        {
            int volumeIndex = addNewLesson_volume_comboBox.SelectedIndex;
            string newLessonName = addNewLesson_lessonName_textBox.Text;
            string vocabularyList = addNewLesson_vocabList_textBox.Text;
            if (myParent.AddNewLesson(volumeIndex, newLessonName, vocabularyList))
            {
                MessageBox.Show("Đã thêm " + newLessonName);
            }
            else
            {
                MessageBox.Show("Đã xảy ra lỗi. Hãy thử lại!");
            }
            this.Close();
        }

        private void AddNewLesson_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void addNewLesson_vocabList_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void addNewLesson_volume_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
