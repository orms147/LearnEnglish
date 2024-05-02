using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace LearnEnglish.Source.SubWindows
{
    public partial class PlayPronunciationButton : UserControl
    {
        private string mp3Url = "";
        private int myIndex = 0;
        public PlayPronunciationButton(int index, string url)
        {
            InitializeComponent();
            mp3Url = url;
            myIndex = index;
        }

        public int Index
        {
            get { return myIndex; }
        }

        private void playMp3Button_Click(object sender, EventArgs e)
        {
            string[] UrlList = mp3Url.Split(' ');        // nếu đây là một cụm từ vựng thì tách thành từng từ

            WindowsMediaPlayer player = new WindowsMediaPlayer();

            if (UrlList.Length == 1)
            {
                player.URL = UrlList[0];
                player.controls.play();
            }
            else if (UrlList.Length > 1)
            {
                WMPLib.IWMPPlaylist playlist = player.playlistCollection.newPlaylist("NewPlaylist");
                foreach (string url in UrlList)
                {
                    WMPLib.IWMPMedia fileMedia = player.newMedia(url);
                    playlist.appendItem(fileMedia);
                    player.currentPlaylist = playlist;
                    player.controls.play();
                }
            }
            else
            {
                // do nothing
            }
        }
    }
}
