using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using LearnEnglish.Source.DataManager;

namespace LearnEnglish.Source.SubWindows
{
	public class Vocabulary_EditableListView : ListView
	{
		private enum VOCABULARY_FIELDS
		{
			FIELD_SELECT = 0,
			FIELD_INDEX,
			FIELD_ENGWORD,
			FIELD_PRONUNC_ICON,
			FIELD_PRONUNC,
			FIELD_MEANING,
			FIELD_GROUP,
			FIELD_MAX
		}

		private string[] headerString =
		{
			"Chọn",
			"Thứ tự",
			"Từ vựng",
			"",
			"Phát âm",
			"Nghĩa",
			"Nhóm"
		};

		private int[] headerWidth = { 70, 80, 220, 40, 160, 400, 90 };

		private LearnEnglish.MainWindow myParent;

		private ListViewItem selectedItem;
		private int mousePosX = 0;
		private string subItemText;
		private int selectedSubItemIdx = 0;
		private const int LEVEL_MAX = 4;
		private int selectedLevel = LEVEL_MAX;

		private int headerRowHeight = 25;

		private System.Windows.Forms.TextBox editString_textBox = new System.Windows.Forms.TextBox();
		private System.Windows.Forms.ComboBox group_comboBox = new System.Windows.Forms.ComboBox();
		private List<PlayPronunciationButton> playButtonList = new List<PlayPronunciationButton>();

		private System.Windows.Forms.ColumnHeader[] columnHeaders = new ColumnHeader[(int)VOCABULARY_FIELDS.FIELD_MAX];

		public Vocabulary_EditableListView(LearnEnglish.MainWindow parent)
		{

			for (int i = 0; i <= (int)LevelGroup.WORD_LEVEL.LEVEL_MAX; i++)
			{
				group_comboBox.Items.Add(LevelGroup.wordLevel[i]);
			}
			group_comboBox.Size = new System.Drawing.Size(0, 0);
			group_comboBox.Location = new System.Drawing.Point(0, 0);
			this.Controls.AddRange(new System.Windows.Forms.Control[] { this.group_comboBox });
			group_comboBox.SelectedIndexChanged += new System.EventHandler(this.OnSelectedChangedComboBox);
			group_comboBox.LostFocus += new System.EventHandler(this.FocusOverComboBox);
			group_comboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnKeyPressComboBox);
			group_comboBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			group_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
			group_comboBox.Hide();


			editString_textBox.Size = new System.Drawing.Size(0, 0);
			editString_textBox.Location = new System.Drawing.Point(0, 0);
			this.Controls.AddRange(new System.Windows.Forms.Control[] { this.editString_textBox });
			editString_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EditOverTextBox);
			editString_textBox.LostFocus += new System.EventHandler(this.FocusOverTextBox);
			editString_textBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			editString_textBox.BorderStyle = BorderStyle.Fixed3D;
			editString_textBox.Hide();
			editString_textBox.Text = "";

			for (int i = 0; i < (int) VOCABULARY_FIELDS.FIELD_MAX; i++)
			{
				this.columnHeaders[i] = new System.Windows.Forms.ColumnHeader();
				this.columnHeaders[i].Text = headerString[i];
				this.columnHeaders[i].Width = headerWidth[i];
			}

			this.Columns.AddRange(columnHeaders);

			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDownListView);
			this.DoubleClick += new System.EventHandler(this.OnDoubleClickListView);
			this.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.OnMouseWheelListView);

			myParent = parent;
		}

		private void OnKeyPressComboBox(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Escape)
			{
				group_comboBox.Hide();
			}
		}

		private void OnSelectedChangedComboBox(object sender, System.EventArgs e)
		{
			selectedLevel = group_comboBox.SelectedIndex;
			if (selectedLevel >= 0)
			{
				selectedItem.SubItems[selectedSubItemIdx].Text = group_comboBox.Items[selectedLevel].ToString();
				notifyParent();
			}
		}

		private void FocusOverComboBox(object sender, System.EventArgs e)
		{
			group_comboBox.Hide();
		}

		private void EditOverTextBox(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)Keys.Enter)
			{
				if (selectedItem.SubItems[selectedSubItemIdx].Text != editString_textBox.Text)
				{
					selectedItem.SubItems[selectedSubItemIdx].Text = editString_textBox.Text;
					notifyParent();
				}
				editString_textBox.Hide();
			}

			if (e.KeyChar == (char)Keys.Escape)
				editString_textBox.Hide();
		}

		private void FocusOverTextBox(object sender, System.EventArgs e)
		{
			if (selectedItem.SubItems[selectedSubItemIdx].Text != editString_textBox.Text)
			{
				selectedItem.SubItems[selectedSubItemIdx].Text = editString_textBox.Text;
				notifyParent();
			}
			editString_textBox.Hide();
		}

		public void OnDoubleClickListView(object sender, System.EventArgs e)
		{
			selectedLevel = LEVEL_MAX;
			// Check the subitem clicked .
			int nStart = mousePosX;
			int spos = 0;
			int epos = 0;
			for (int i = 0; i < this.Columns.Count; i++)
			{
				epos += this.Columns[i].Width;
				if (nStart > spos && nStart < epos)
				{
					selectedSubItemIdx = i;
					break;
				}

				spos = epos;
			}

			subItemText = selectedItem.SubItems[selectedSubItemIdx].Text;

			if(selectedSubItemIdx == (int)VOCABULARY_FIELDS.FIELD_SELECT || selectedSubItemIdx == (int)VOCABULARY_FIELDS.FIELD_INDEX ||
				selectedSubItemIdx == (int)VOCABULARY_FIELDS.FIELD_PRONUNC_ICON)
			{
				// do nothing
			}
			else if (selectedSubItemIdx == (int) VOCABULARY_FIELDS.FIELD_GROUP)
			{
				Rectangle r = new Rectangle(spos, selectedItem.Bounds.Y, epos, selectedItem.Bounds.Bottom);
				group_comboBox.Size = new System.Drawing.Size(epos - spos, selectedItem.Bounds.Bottom - selectedItem.Bounds.Top);
				group_comboBox.Location = new System.Drawing.Point(spos, selectedItem.Bounds.Y);
				group_comboBox.Show();
				group_comboBox.Text = subItemText;
				group_comboBox.SelectAll();
				group_comboBox.Focus();
			}
			else
			{
				Rectangle r = new Rectangle(spos, selectedItem.Bounds.Y, epos, selectedItem.Bounds.Bottom);
				editString_textBox.Size = new System.Drawing.Size(epos - spos, selectedItem.Bounds.Bottom - selectedItem.Bounds.Top);
				editString_textBox.Location = new System.Drawing.Point(spos, selectedItem.Bounds.Y);
				editString_textBox.Show();
				editString_textBox.Text = subItemText;
				editString_textBox.SelectAll();
				editString_textBox.Focus();
			}
			selectedItem.Checked = false;
		}

		public void OnMouseDownListView(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			// Get selected item, based on the mouse down position
			selectedItem = this.GetItemAt(e.X, e.Y);
			// Remember mouse posX, later check which sub-item is selected
			mousePosX = e.X;
		}

		public void OnMouseWheelListView(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			/* Khi nguoi dung cuon chuot (scroll) tren listView, vi tri cua cac item se bi thay doi 
			 can phai cap nhat lai vi tri cua cac playButton */

			// Tim xem item nao dang o tren dau table
			selectedItem = this.GetItemAt(100, headerRowHeight); // posX không quan trọng, có thể thay 100 bằng giá trị khác
			if (selectedItem == null) return; // Nếu không lấy được item đầu tiên tức là không có từ nào đang hiển thị, không cần xử lý sự kiện cuộn chuột

			int firstIndex = Convert.ToInt32(selectedItem.SubItems[(int)VOCABULARY_FIELDS.FIELD_INDEX].Text) - 1;

			// tinh height cua moi hang
			int rowHeight = this.Items[firstIndex + 1].Bounds.Top - this.Items[firstIndex].Bounds.Top;

			// thay doi vi tri cua cac playButton
			foreach (PlayPronunciationButton playButton in playButtonList)
			{
				if (playButton != null)
				{
					int newPosX = playButton.Location.X; // no change
					int newPosY = headerRowHeight + (playButton.Index - firstIndex) * rowHeight;
					playButton.Location = new System.Drawing.Point(newPosX, newPosY);
				}
			}


		}

		private void notifyParent()
		{
			string eng = selectedItem.SubItems[(int)VOCABULARY_FIELDS.FIELD_ENGWORD].Text;
			string pronunc = selectedItem.SubItems[(int)VOCABULARY_FIELDS.FIELD_PRONUNC].Text;
			string meaning = selectedItem.SubItems[(int)VOCABULARY_FIELDS.FIELD_MEANING].Text;
			myParent.UpdateAWord(selectedItem.Index, eng, pronunc, meaning, selectedLevel);
		}

		public void AddPlayButton(int itemIdx, string url)
		{
			if (url != "")
			{
				PlayPronunciationButton playBtn = new PlayPronunciationButton(itemIdx - 1, url);
				editString_textBox.Size = new System.Drawing.Size(15, 15);
				playButtonList.Add(playBtn);
				this.Controls.Add(playBtn);
				int posX = headerWidth[(int)VOCABULARY_FIELDS.FIELD_SELECT] + headerWidth[(int)VOCABULARY_FIELDS.FIELD_INDEX] +
							headerWidth[(int)VOCABULARY_FIELDS.FIELD_ENGWORD] + headerWidth[(int)VOCABULARY_FIELDS.FIELD_PRONUNC_ICON];
				posX -= playBtn.Width;
				int posY = this.Items[itemIdx - 1].Bounds.Top;
				playBtn.Location = new System.Drawing.Point(posX, posY);
				playBtn.Show();
			}
		}

		public void ClearPlayButtons()
		{
			foreach(PlayPronunciationButton playButton in playButtonList)
			{
				this.Controls.Remove(playButton);
			}
			playButtonList.Clear();
		}

	}
}
