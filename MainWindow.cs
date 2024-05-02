using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LearnEnglish.Source.DataManager;
using LearnEnglish.Source.SubWindows;

namespace LearnEnglish
{
    public partial class MainWindow : Form
    {
        private const int INVALID_INDEX = -1;
        private enum RANDOM_MODE
        {
            ENGLISH_TO_VIETNAMESE,
            VIETNAMESE_TO_ENGLISH
        };
        
        private enum DISPLAY_MODE
        {
            DISPLAY_ALL,
            DISPLAY_RANDOM
        };

        private string[] displayModeGroupText =
        {
            "Từ vựng trong bài",
            "Luyện tập với từ ngẫu nhiên"
        };

        private string[] displayModeBtnText =
        {
            "Luyện tập bài",
            "Hiển thị bài"
        };

        private int volumeIdx = INVALID_INDEX;
        private int lessonIdx = INVALID_INDEX;
        private int currLevel = INVALID_INDEX;
        private RANDOM_MODE currRandomMode = RANDOM_MODE.ENGLISH_TO_VIETNAMESE;
        private DISPLAY_MODE currDisplayMode = DISPLAY_MODE.DISPLAY_ALL;
        private Random random = new Random();

        //private vocabVolume selectedVolume;
        private vocabLesson selectedLesson;
        private vocabWord randomWord;

        private vocabDataMgr myDataMgr;

        private LearnEnglish.Source.SubWindows.Vocabulary_EditableListView vocab_listView;
        private LearnEnglish.Source.SubWindows.Vocabulary_SearchListView vocab_SearchlistView;

        public MainWindow()
        {
            InitializeComponent();
            this.vocab_listView = new LearnEnglish.Source.SubWindows.Vocabulary_EditableListView(this);
            initVocabListView();
            this.displayVocab_groupBox.Controls.Add(this.vocab_listView);
            this.vocab_SearchlistView = new LearnEnglish.Source.SubWindows.Vocabulary_SearchListView();
            this.displayVocab_groupBox.Controls.Add(this.vocab_SearchlistView);
            initVocabSearchListView();

            myDataMgr = vocabDataMgr.GetInstance();
            //vocabDataMgr.initDummyData();

            loadVolumeList();
            initLevelGroupList();
            displayLessonWords(currDisplayMode);
        }

        private void loadVolumeList()
        {
            string[] volumeList = myDataMgr.getVolumeList();
            int volumeCount = volumeList.Length;
            volume_comboBox.Items.Clear();

            for (int i = 0; i < volumeCount; i++)
            {
                volume_comboBox.Items.Add(volumeList[i]);
            }
        }

        private void initLevelGroupList()
        {
            for (int i = 0; i <= (int)LevelGroup.WORD_LEVEL.LEVEL_MAX; i++)
            {
                level_comboBox.Items.Add(LevelGroup.wordLevel[i]);
            }
        }

        private void loadLessonList()
        {
            if (volumeIdx != INVALID_INDEX)
            {
                string[] lessonList = myDataMgr.getLessonList(volumeIdx);
                if (lessonList == null)
                {
                    MessageBox.Show("Chưa có bài học nào trong tập này");
                }
                else
                {
                    int lessonCount = lessonList.Length;
                    lesson_comboBox.Items.Clear();
                    for (int i = 0; i < lessonCount; i++)
                    {
                        lesson_comboBox.Items.Add(lessonList[i]);
                    }
                }
            }
        }

        private void initVocabListView()
        {
            this.vocab_listView.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.vocab_listView.AutoArrange = false;
            this.vocab_listView.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.vocab_listView.CheckBoxes = true;
            this.vocab_listView.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vocab_listView.FullRowSelect = true;
            this.vocab_listView.GridLines = true;
            this.vocab_listView.HideSelection = false;
            this.vocab_listView.Location = new System.Drawing.Point(11, 63);
            this.vocab_listView.MaximumSize = new System.Drawing.Size(1085, 362);
            this.vocab_listView.MinimumSize = new System.Drawing.Size(1085, 362);
            this.vocab_listView.Name = "vocab_listView";
            this.vocab_listView.Size = new System.Drawing.Size(1085, 362);
            this.vocab_listView.TabIndex = 1;
            this.vocab_listView.UseCompatibleStateImageBehavior = false;
            this.vocab_listView.View = System.Windows.Forms.View.Details;
        }
        private void initVocabSearchListView()
        {
            this.vocab_SearchlistView.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.vocab_SearchlistView.AutoArrange = false;
            this.vocab_SearchlistView.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.vocab_SearchlistView.CheckBoxes = true;
            this.vocab_SearchlistView.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vocab_SearchlistView.FullRowSelect = true;
            this.vocab_SearchlistView.GridLines = true;
            this.vocab_SearchlistView.HideSelection = false;
            this.vocab_SearchlistView.MaximumSize = new System.Drawing.Size(1085, 362);
            this.vocab_SearchlistView.MinimumSize = new System.Drawing.Size(1085, 362);
            this.vocab_SearchlistView.Location = new System.Drawing.Point(11, 63);
            this.vocab_SearchlistView.Size = new System.Drawing.Size(1085, 362);
            this.vocab_SearchlistView.TabIndex = 1;
            this.vocab_SearchlistView.UseCompatibleStateImageBehavior = false;
            this.vocab_SearchlistView.View = System.Windows.Forms.View.Details;
        }


        private void displayLessonWords(DISPLAY_MODE displayMode)
        {
            displayVocab_groupBox.Text = displayModeGroupText[(int)displayMode];
            lessonPractise_button.Text = displayModeBtnText[(int)displayMode];
            switch (displayMode)
            {
                case DISPLAY_MODE.DISPLAY_ALL:
                    vocab_listView.Visible = true;
                    addWord_button.Visible = true;
                    removeWord_button.Visible = true;
                    randomWord_button.Visible = false;
                    randomWord_label.Visible = false;
                    pronounce_button.Visible = false;
                    pronounce_label.Visible = false;
                    meaning_button.Visible = false;
                    meaning_label.Visible = false;
                    levelGroup_label.Visible = false;

                    randomWord_label.Text = "";
                    pronounce_label.Text = "";
                    meaning_label.Text = "";
                    levelGroup_label.Text = "";

                    pronounce_button.Enabled = false;
                    meaning_button.Enabled = false;
                    break;

                case DISPLAY_MODE.DISPLAY_RANDOM:
                    vocab_listView.Visible = false;
                    randomWord_button.Visible = true;
                    randomWord_label.Visible = true;
                    pronounce_button.Visible = true;
                    pronounce_label.Visible = true;
                    meaning_button.Visible = true;
                    meaning_label.Visible = true;
                    levelGroup_label.Visible = true;

                    addWord_button.Visible = false;
                    removeWord_button.Visible = false;
                    break;

                default:
                    break;
            }
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            string vocabSearch = search_textBox.Text;
            string[] searchWord = myDataMgr.Search(vocabSearch);
            string search = "Từ cần tìm xuất hiện ở:\r\n";
            search += searchWord[0] + "\r\n";
            search += searchWord[1] + "\r\n";
            MessageBox.Show(search);
        }

        private void lessonPractise_button_Click(object sender, EventArgs e)
        {
            currDisplayMode = (DISPLAY_MODE)(DISPLAY_MODE.DISPLAY_RANDOM - currDisplayMode); 
            displayLessonWords(currDisplayMode);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng chưa sẵn sàng");
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            myDataMgr.saveVocabData();
            MessageBox.Show("Lưu xong!");
        }

        private void statistic_button_Click(object sender, EventArgs e)
        {
            int[] WordListCount = myDataMgr.statistics();
            string msg = "Loại OK:\t" + WordListCount[0] + " từ\r\n";
            msg += "Loại đã thuộc: " + WordListCount[1] + " từ\r\n";
            msg += "Loại cần nhớ:  " + WordListCount[2] + " từ\r\n";
            msg += "Loại chưa học: " + WordListCount[3] + " từ\r\n";
            MessageBox.Show(msg);
        }

        private void createLesson_button_Click(object sender, EventArgs e)
        {
            string[] volumeList = myDataMgr.getVolumeList();
            AddNewLesson addNewLesson = new AddNewLesson(this, volumeList);
            addNewLesson.ShowDialog();
        }

        private void createVolume_button_Click(object sender, EventArgs e)
        {
            AddNewVolume addNewVolume = new AddNewVolume(this);
            addNewVolume.ShowDialog();
        }

        private void volume_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            volumeIdx = volume_comboBox.SelectedIndex;
            lesson_comboBox.SelectedIndex = -1;
            loadLessonList();
        }

        private void lesson_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            lessonIdx = lesson_comboBox.SelectedIndex;

            if (lessonIdx == -1) return;

            reloadVocabListView();
        }

        private void reloadVocabListView()
        {
            vocab_listView.Items.Clear();
            vocab_listView.ClearPlayButtons();
            selectedLesson = myDataMgr.getLesson(volumeIdx, lessonIdx);

            // Hien thi ten bai
            lessonName_label.Text = volume_comboBox.SelectedItem.ToString() + " - " + lesson_comboBox.SelectedItem.ToString();

            // Hien thi cac tu vung trong bai
            int vocabWordCount = selectedLesson.vocabList.Count;


            int wordIdx = 0;
            foreach (vocabWord word in selectedLesson.vocabList)
            {
                wordIdx++;
                ListViewItem wordItem = new ListViewItem();
                wordItem.Checked = false;
                wordItem.SubItems.Add(wordIdx.ToString());  // Thu tu
                wordItem.SubItems.Add(word.EnglishWord);    // tu vung
                wordItem.SubItems.Add("");                  // phat am icon
                wordItem.SubItems.Add(word.Pronunciation);  // phat am
                wordItem.SubItems.Add(word.VietMeaning);    // nghia cua tu
                wordItem.SubItems.Add(LevelGroup.wordLevel[(int)word.LevelGroup]);     // Nhom tu

                vocab_listView.Items.Add(wordItem);
                vocab_listView.AddPlayButton(wordIdx, word.PronunUrl);
            }
        }

        private void level_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            currLevel = level_comboBox.SelectedIndex;
        }

        private void EnVi_radioBtn_CheckedChanged(object sender, EventArgs e)
        {
            currRandomMode = RANDOM_MODE.ENGLISH_TO_VIETNAMESE;
        }

        private void ViEn_radioBtn_CheckedChanged(object sender, EventArgs e)
        {
            currRandomMode = RANDOM_MODE.VIETNAMESE_TO_ENGLISH;
        }

        private void randomWord_button_Click(object sender, EventArgs e)
        {
            if (currLevel == -1)
            {
                MessageBox.Show("Hãy chọn nhóm từ!");
                return;
            }
            if (lessonIdx == -1 || volumeIdx == -1)
            {
                MessageBox.Show("Hãy chọn tập và bài!");
                return;
            }

            int wordCount = selectedLesson.vocabList.Count;
            int randomIdx = random.Next(0, wordCount);

            randomWord = selectedLesson.vocabList[randomIdx];
            if (currRandomMode == RANDOM_MODE.ENGLISH_TO_VIETNAMESE)
            {
                randomWord_label.Text = randomWord.EnglishWord;
            }
            else
            {
                randomWord_label.Text = randomWord.VietMeaning;
            }

            pronounce_button.Enabled = true;
            meaning_button.Enabled = true;
            pronounce_label.Text = "";
            meaning_label.Text = "";

            levelGroup_label.Text = LevelGroup.wordLevel[(int)randomWord.LevelGroup];
        }

        private void pronounce_button_Click(object sender, EventArgs e)
        {
            pronounce_label.Text = randomWord.Pronunciation;
        }

        private void meaning_button_Click(object sender, EventArgs e)
        {
            if (currRandomMode == RANDOM_MODE.ENGLISH_TO_VIETNAMESE)
            {
                meaning_label.Text = randomWord.VietMeaning;
            }
            else
            {
                meaning_label.Text = randomWord.EnglishWord;
            }
        }

        private void addWord_button_Click(object sender, EventArgs e)
        {
            if (lessonIdx == -1 || volumeIdx == -1)
            {
                MessageBox.Show("Hãy chọn tập và bài!");
                
            }
            else
            {
                AddNewWords addNewWords = new AddNewWords(this);
                addNewWords.ShowDialog();
            } 
        }
        //some thing hể
        private void removeWord_button_Click(object sender, EventArgs e)
        {
            // Danh sách những từ được tick chọn nằm ở CheckedItems[] được cung cấp bởi thư viện ListView
            int checkedItemCount = vocab_listView.CheckedItems.Count; // Kiểm tra xem có bao nhiêu từ được tick chọn, lấy từ thuộc tính Count

            int[] checkedWordsIdx = new int[checkedItemCount]; // Khai báo một mảng, lưu vị trí index của các từ được tick. Mảng này sau đó sẽ được gửi sang dataMgr

            // Lấy index của từng từ, gán vào trong mảng
            for (int i = 0; i < checkedItemCount; i++)
            {
                checkedWordsIdx[i] = vocab_listView.CheckedItems[i].Index;
            }

            myDataMgr.RemoveWords(volumeIdx, lessonIdx, checkedWordsIdx); // Yêu cầu dataMgr thực hiện việc xóa các từ đã chọn trong tập và bài hiện tại

            reloadVocabListView(); // Refresh lại danh sách hiển thị trên cửa sổ
        }

        /*************************************************************************/
        /*                      Data update                                      */
        public bool AddNewVolume(string volumeName)
        {
            bool ret = myDataMgr.AddNewVolume(volumeName);
            loadVolumeList();
            return ret;
        }
        public bool AddNewLesson(int volumeIndex, string lessonName, string vocabList)
        {
            bool ret = myDataMgr.AddNewLesson(volumeIndex, lessonName, vocabList);
            loadLessonList();
            return ret;
        }

        public void UpdateAWord(int wordIndex, string eng, string pronunc, string mean, int level)
        {
            if (volumeIdx != INVALID_INDEX && lessonIdx != INVALID_INDEX)
            {
                myDataMgr.UpdateAWord(volumeIdx, lessonIdx, wordIndex, eng, pronunc, mean, level);
            }
        }

        public bool AddNewWords(string vocabList)
        {
            bool ret = myDataMgr.AddNewWords(volumeIdx, lessonIdx, vocabList);
            reloadVocabListView();
            return ret;
        }

        private void search_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            vocab_listView.Visible = false;
            vocab_SearchlistView.Visible = true;
        }

        private void displayVocab_groupBox_Enter(object sender, EventArgs e)
        {

        }
        /*************************************************************************/
    }
}
