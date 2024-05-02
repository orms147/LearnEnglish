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
    public partial class AddNewVolume : Form
    {
        public MainWindow myParent;
        public AddNewVolume(MainWindow parent)
        {
            InitializeComponent();
            myParent = parent;
        }

        private void addNewVolume_OK_button_Click(object sender, EventArgs e)
        {
            string newVolumeName = addNewVolume_textBox.Text;
            if(myParent.AddNewVolume(newVolumeName))
            {
                MessageBox.Show("Đã thêm " + newVolumeName);
            }
            else
            {
                MessageBox.Show("Đã xảy ra lỗi. Hãy thử lại!");
            }
            this.Close();
        }

        private void addNewVolume_Cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addNewVolume_textBox_TextChanged(object sender, EventArgs e)
        {
            addNewVolume_OK_button.Enabled = (addNewVolume_textBox.Text == "") ? false : true;
        }
    }
}
