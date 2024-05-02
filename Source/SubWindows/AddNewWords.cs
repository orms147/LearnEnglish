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
    public partial class AddNewWords : Form
    {
        public MainWindow myParent;
        public AddNewWords(MainWindow parent)
        {
            myParent = parent;
            InitializeComponent();
        }

        private void AddNewWords_Load(object sender, EventArgs e)
        {

        }

        private void addNewWords_Cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addNewWords_OK_button_Click(object sender, EventArgs e)
        {
            string vocabularyList = addNewWords_vocabList_textBox.Text;
            if (myParent.AddNewWords(vocabularyList))
            {
                MessageBox.Show("Đã thêm ");
            }
            else
            {
                MessageBox.Show("Đã xảy ra lỗi. Hãy thử lại!");
            }
            this.Close();

        }

        private void addNewWords_vocabList_textBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
