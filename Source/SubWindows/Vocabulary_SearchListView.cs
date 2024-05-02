using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearnEnglish.Source.SubWindows
{
    public partial class Vocabulary_SearchListView : ListView
    {
		private System.Windows.Forms.ColumnHeader[] columnHeaders = new ColumnHeader[(int)VOCABULARY_FIELDS.MAX];
		public Vocabulary_SearchListView()
        {
			//InitializeComponent();
			for (int i = 0; i <= (int)VOCABULARY_FIELDS.FIELD_MEANING; i++)
			{
				this.columnHeaders[i] = new System.Windows.Forms.ColumnHeader();
				this.columnHeaders[i].Text = headerString[i];
				this.columnHeaders[i].Width = headerWidth[i];
			}
			this.Columns.AddRange(columnHeaders);
		}

        public Vocabulary_SearchListView(IContainer container)
        {
            container.Add(this);

           // InitializeComponent();

        }
		private enum VOCABULARY_FIELDS
		{
			FIELD_SELECT = 0,
			FIELD_INDEX,
			FIELD_CLASS,
			FIELD_LESSON,
			FIELD_ENGWORD,
			FIELD_PRONUNC,
			FIELD_MEANING,
			MAX,
		}

		private string[] headerString =
		{
			"Chọn",
			"Thứ tự",
			"Lớp",
			"Bài",
			"Từ vựng",
			"Phát âm",
			"Nghĩa",
		};
		private int[] headerWidth = { 70, 80, 65, 65, 220, 160, 400 };
		private LearnEnglish.MainWindow myParent;

		ListViewItem selectedItem;
		private int mousePosX = 0;
		private string subItemText;
		private int selectedSubItemIdx = 0;

		private int headerRowHeight = 25;

	}

	
}
