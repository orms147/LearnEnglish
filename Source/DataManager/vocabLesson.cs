using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnEnglish.Source.DataManager
{
    [Serializable]
    class vocabLesson
    {
        private string lessonName;
        public List<vocabWord> vocabList;

        public vocabLesson (string name)
        {
            lessonName = name;
            vocabList = new List<vocabWord>();
        }

        public string LessonName
        {
            get { return lessonName; }
            set { lessonName = value; }
        }
    }
}
