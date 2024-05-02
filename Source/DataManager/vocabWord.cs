using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace LearnEnglish.Source.DataManager
{
    [Serializable]
    class vocabWord
    {
        private string englishWord;
        private string pronunUrl;
        private string pronunciation;
        private string vietMeaning;
        private LevelGroup.WORD_LEVEL levelGroup;

        private const int PRONUNCE_MP3_URL  = 0;
        private const int PRONUNCE_TEXT     = 1;
        private const int PRONUNCE_MAX      = 2;
        private const string hostServerUrl = "https://www.oxfordlearnersdictionaries.com/definition/english/";
        private const string pronuncIndicator1 = "<span class=\"phon\">";
        private const string pronuncIndicator2 = "</span>";
        private const string pronuncUrlIndicator1 = "data-src-mp3=\"";
        private const string pronuncUrlIndicator2 = "\"";

        public vocabWord(string eng, string pronounce, string viet)
        {
            englishWord = eng;
            pronunUrl = "";
            pronunciation = pronounce;
            vietMeaning = viet;
            levelGroup = DataManager.LevelGroup.WORD_LEVEL.LEVEL_REMEMBERED;
        }

        public vocabWord(string eng)
        {
            englishWord = eng.ToLower();
            string[] pronunc = searchPronunciation(englishWord);
            pronunUrl = pronunc[PRONUNCE_MP3_URL];
            pronunciation = pronunc[PRONUNCE_TEXT];
            vietMeaning = "";
            levelGroup = DataManager.LevelGroup.WORD_LEVEL.LEVEL_REMEMBERED;
        }

        public string EnglishWord
        {
            get { return englishWord; }
            set { englishWord = value; }
        }

        public string PronunUrl
        {
            get { return pronunUrl; }
            set { pronunUrl = value; }
        }

        public string Pronunciation
        {
            get { return pronunciation; }
            set { pronunciation = value; }
        }

        public string VietMeaning
        {
            get { return vietMeaning; }
            set { vietMeaning = value; }
        }

        public LevelGroup.WORD_LEVEL LevelGroup
        {
            get { return levelGroup; }
            set { levelGroup = value; }
        }

        public void UpdatePronunciation()
        {
            string[] pronunc = searchPronunciation(englishWord);
            pronunUrl = pronunc[PRONUNCE_MP3_URL];
            pronunciation = pronunc[PRONUNCE_TEXT];
        }

        private string[] searchPronunciation(string engWord)
        {
            engWord = engWord.Replace("-", " ");            // nếu xuất hiện dấu gạch nối thì thay thế bằng dâu cách
            string[] pronounce = new string[PRONUNCE_MAX];  // 0: url to mp3, 1: pronunciation
            pronounce[PRONUNCE_MP3_URL] = "";
            pronounce[PRONUNCE_TEXT] = "";
            string[] wordUnits = engWord.Split(' ');        // nếu đây là một cụm từ vựng thì tách thành từng từ để search phát âm
            string lastWordUnit = "";

            // search phát âm của từng từ
            foreach (string wordUnit in wordUnits)
            {
                string strWordUnit = RemoveSpecialCharacters(wordUnit); // xóa những kí tự không phải là chữ cái, ví dụ dấu ngoặc '(', ')'
                string strResponse = GetHttpResponse(strWordUnit);           // tra từ điển trên mạng để lấy cách phát âm

                // Nếu url bị sai, thử lại với một url khác
                if (strResponse == null || strResponse == "")
                {
                    strResponse = GetHttpResponse(strWordUnit, true);
                }
                if (strResponse != null && strResponse != "")
                {
                    // Lấy chuỗi phiên âm
                    pronounce[PRONUNCE_TEXT] += GetStringFromResponse_Between(strResponse, pronuncIndicator1, pronuncIndicator2);
                    pronounce[PRONUNCE_TEXT] += " ";        // nếu đây là một cụm từ thì tách phát âm của từng từ bằng một dấu cách

                    // Lấy url của file mp3 phát âm mẫu, chỉ lấy của từ dài nhất
                    pronounce[PRONUNCE_MP3_URL] += GetStringFromResponse_Between(strResponse, pronuncUrlIndicator1, pronuncUrlIndicator2);
                    pronounce[PRONUNCE_MP3_URL] += " ";

                }
                lastWordUnit = wordUnit;
            }
            if (pronounce[PRONUNCE_TEXT].Length > 0)
            {
                pronounce[PRONUNCE_TEXT] = pronounce[PRONUNCE_TEXT].Substring(0, pronounce[PRONUNCE_TEXT].Length - 1); // bỏ dấu cách ở sau từ cuối cùng
                pronounce[PRONUNCE_MP3_URL] = pronounce[PRONUNCE_MP3_URL].Substring(0, pronounce[PRONUNCE_MP3_URL].Length - 1); // bỏ dấu cách ở sau từ cuối cùng
            }

            return pronounce;
        }

        // Hàm kiểm tra một kí tự có phải là chữ cái hay không
        private string RemoveSpecialCharacters(string str)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in str)
            {
                if (c >= 'a' && c <= 'z')
                {
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }

        private string GetHttpResponse(string strWordUnit, bool retry = false)
        {
            string strUri = hostServerUrl;
            if (!retry)
            {
                strUri += strWordUnit;
            }
            else
            {
                strUri += strWordUnit + "1_1? q = " + strWordUnit;
            }

            string strSesponse = "";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(strUri);
            request.AllowAutoRedirect = true;
            request.Timeout = 10000;
            request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
            HttpWebResponse response = null;
            try
            {
                response = (HttpWebResponse)request.GetResponse();
                Stream receiveStream = response.GetResponseStream();
                StreamReader readStream = new StreamReader(receiveStream);

                strSesponse = readStream.ReadToEnd();

                // Thử xem trong httpResponse có phần phát âm hay không
                int pronuncIdx = strSesponse.IndexOf(pronuncIndicator1);
                // Nếu không tìm thấy, coi như url bị sai
                if (pronuncIdx == -1)
                {
                    strSesponse = "";
                }
            }
            catch (WebException e)
            {
                if (e.Response == null)
                {
                    // do nothing
                }
            }
            if (response != null)
            {
                response.Close();
            }
            return strSesponse;
        }

        private string GetStringFromResponse_Between(string response, string indicator1, string indicator2)
        {
            string strRet = "";
            int index1 = 0;
            int index2 = 0;
            int startIndex = 0;
            int maxLength = 150;

            // Get start index
            index1 = response.IndexOf(indicator1, index1);
            startIndex = index1 + indicator1.Length;
            // Get end index
            index2 = response.IndexOf(indicator2, startIndex);

            if (index1 == -1 || index2 == -1 || index2 - startIndex > maxLength)
            {
                strRet += "";
            }
            else
            {
                strRet += response.Substring(startIndex, index2 - startIndex);
            }

            return strRet;
        }
    }
}
