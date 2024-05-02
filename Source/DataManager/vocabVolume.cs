using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnEnglish.Source.DataManager
{
    [Serializable]
    class vocabVolume
    {
        private string volumeName;
        public List<vocabLesson> lessonList;

        public vocabVolume(string name)
        {
            volumeName = name;
            lessonList = new List<vocabLesson>();
        }

        public string VolumeName
        {
            get { return volumeName; }
            set { volumeName = value; }
        }
    }
}
