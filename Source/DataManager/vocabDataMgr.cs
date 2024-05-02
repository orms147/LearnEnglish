using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace LearnEnglish.Source.DataManager
{
    [Serializable]
    class vocabDataMgr
    {

        private static string mydataFilePath = "..\\vocabularyFile.dat";
        private List<vocabVolume> vocabData;
        
        public void initDummyData()
        {
            this.vocabData = new List<vocabVolume>();
        }

        public vocabLesson getLesson(int volumeIdx, int lessonIdx)
        {
            vocabLesson lesson = vocabData[volumeIdx].lessonList[lessonIdx];

            return lesson;
        }

        public string[] getVolumeList()
        {
            int volumeNum = vocabData.Count();
            string[] volumeList = new string[volumeNum];

            for (int i = 0; i < volumeNum; i++)
            {
                volumeList[i] = vocabData[i].VolumeName;
            }

            return volumeList;
        }

        public string[] getLessonList(int volumeIdx)
        {
            string[] lessonList;
            if (volumeIdx < vocabData.Count)
            {
                int lessonNum = vocabData[volumeIdx].lessonList.Count;
                lessonList = new string[lessonNum];

                for (int i = 0; i < lessonNum; i++)
                {
                    lessonList[i] = vocabData[volumeIdx].lessonList[i].LessonName;
                }

                return lessonList;
            }
            else
            {
                return null;
            }

        }

        public void saveVocabData()
        {

            BinaryFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(mydataFilePath, FileMode.Create, FileAccess.Write);

            formatter.Serialize(stream, _instance);
            stream.Close();
        }

        public static void loadVocabData()
        {
            if (File.Exists(mydataFilePath))
            {
                Stream stream = new FileStream(mydataFilePath, FileMode.Open, FileAccess.Read);
                IFormatter formatter = new BinaryFormatter();
                _instance = (vocabDataMgr)formatter.Deserialize(stream);
                stream.Close();

                /*foreach (vocabVolume volume in _instance.vocabData)
                    foreach(vocabLesson lesson in volume.lessonList)
                        foreach(vocabWord word in lesson.vocabList)
                        {
                            if (word.PronunUrl == "" || word.PronunUrl == null || word.EnglishWord.IndexOf(" ") != -1)
                            {
                                word.UpdatePronunciation();
                            }
                        }
                */
            }
            else
            {
                _instance.initDummyData();
            }
        }

        public bool AddNewVolume(string newVolumeName)
        {
            bool ret = true;
            vocabVolume volume = new vocabVolume(newVolumeName);
            this.vocabData.Add(volume);
            return ret;
        }

        public bool AddNewLesson(int volumeIndex, string newLessonName, string vocabListRaw)
        {
            if (volumeIndex >= vocabData.Count) { return false; }   // so sanh chi so tep

            bool ret = true;
            vocabLesson lesson = new vocabLesson(newLessonName);    // khởi tao bai moi
            if (vocabListRaw != "") // danh sach nhap vao khac rong
            {
                string[] stringSeparators = new string[] { "\r\n" };    // chia nho cac ki tu
                string[] listOfWords = vocabListRaw.Split(stringSeparators, StringSplitOptions.None);

                foreach (string wordRaw in listOfWords)
                {
                    vocabWord newWord = new vocabWord(wordRaw);

                    lesson.vocabList.Add(newWord);
                }
            }
            vocabData[volumeIndex].lessonList.Add(lesson);  // them bai`
            return ret;
        }

        public void UpdateAWord(int volumeIdx, int lessonIdx, int wordIndex, string eng, string pronunc, string mean, int level)
        {
            vocabWord word = vocabData[volumeIdx].lessonList[lessonIdx].vocabList[wordIndex];
            word.EnglishWord = eng;
            word.Pronunciation = pronunc;
            word.VietMeaning = mean;
            if (level != (int)LevelGroup.WORD_LEVEL.LEVEL_MAX)
            {
                word.LevelGroup = (LevelGroup.WORD_LEVEL)level;
            }
        }


        // Singleton implementation
        private static vocabDataMgr _instance;

        private vocabDataMgr() { }
        public static vocabDataMgr GetInstance()
        {
            if (_instance == null)
            {
                _instance = new vocabDataMgr();
                vocabDataMgr.loadVocabData();
            }

            return _instance;
        }
        // End of signleton implementation


        public void RemoveWords(int volumeIdx, int lessonIdx, int[] wordIdx)
        {
            for (int a = (wordIdx.Length - 1); a >= 0; a--)
            {
                vocabData[volumeIdx].lessonList[lessonIdx].vocabList.RemoveAt(wordIdx[a]);
            }
        }
        public bool AddNewWords(int volumeIndex, int lessonIndex, string vocabListRaw)
        {
            bool ret = true;
            if (vocabListRaw != "")
            {
                string[] stringSeparators = new string[] { "\r\n" };
                string[] listOfWords = vocabListRaw.Split(stringSeparators, StringSplitOptions.None);

                foreach (string wordRaw in listOfWords)
                {
                    vocabWord newWord = new vocabWord(wordRaw);

                    vocabData[volumeIndex].lessonList[lessonIndex].vocabList.Add(newWord);
                }
            }
            return ret;
        }
        public int[] statistics()
        {
            int[] WordListCount = new int[(int)LevelGroup.WORD_LEVEL.LEVEL_MAX];
            foreach (vocabVolume aVolume in vocabData)
            {
                foreach (vocabLesson aLesson in aVolume.lessonList)
                {
                    foreach (vocabWord aWord in aLesson.vocabList)
                    {
                        if (aWord.LevelGroup == LevelGroup.WORD_LEVEL.LEVEL_OK)
                        {
                            WordListCount[(int)LevelGroup.WORD_LEVEL.LEVEL_OK]++;
                        }
                        else if (aWord.LevelGroup == LevelGroup.WORD_LEVEL.LEVEL_REMEMBERED)
                        {
                            WordListCount[(int)LevelGroup.WORD_LEVEL.LEVEL_REMEMBERED]++;
                        }
                        else if (aWord.LevelGroup == LevelGroup.WORD_LEVEL.LEVEL_LEARNING)
                        {
                            WordListCount[(int)LevelGroup.WORD_LEVEL.LEVEL_LEARNING]++;
                        }
                        else if (aWord.LevelGroup == LevelGroup.WORD_LEVEL.LEVEL_WAIT)
                        {
                            WordListCount[(int)LevelGroup.WORD_LEVEL.LEVEL_WAIT]++;
                        }
                    }
                }
            }
            return WordListCount;
        }
        public string[] Search(string vocabSearch)
        {
            string[] searchWord = new string[2];
            bool ret = false;
            string a;
            foreach (vocabVolume aVolume in vocabData)
            {   
                foreach(vocabLesson aLesson in aVolume.lessonList)
                {
                    foreach (vocabWord aWord in aLesson.vocabList)
                    {
                        if (aWord.EnglishWord == vocabSearch)
                        {
                            searchWord[0] = aVolume.VolumeName;
                            searchWord[1] = aLesson.LessonName;
                            ret = true;
                            break;
                        }
                    }
                    if (ret)
                    {
                        break;
                    }
                }
                if (ret)
                {
                    break;
                }
            }
            return searchWord;
        }
    }
    



}
