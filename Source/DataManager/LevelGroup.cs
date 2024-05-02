using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnEnglish.Source.DataManager
{
    [Serializable]
    class LevelGroup
    {
        public enum WORD_LEVEL
        {
            LEVEL_OK = 0,
            LEVEL_REMEMBERED,
            LEVEL_LEARNING,
            LEVEL_WAIT,
            LEVEL_MAX,
        };
        public static string[] wordLevel = { "OK", "Đã nhớ", "Đang học", "Chưa học", "Toàn bộ" };
    }
}
