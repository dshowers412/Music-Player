using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] f, p;

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // Play song that is double clicked.
            axWindowsMediaPlayer1.URL = p[listView1.SelectedIndices[0]];
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                p = openFileDialog1.FileNames; // Array of full path names to selected files.
                for (int i = 0; i < p.Length; i++)
                {
                    // Get music file information.
                    TagLib.File ff = TagLib.File.Create(p[i]);
                    ListViewItem fileInfo = new ListViewItem(ff.Tag.Title);
                    fileInfo.SubItems.Add(ff.Tag.AlbumArtists[0]);
                    fileInfo.SubItems.Add(ff.Tag.Album);
                    fileInfo.SubItems.Add(ff.Tag.Genres[0]);

                    // Add song information to list.
                    listView1.Items.Add(fileInfo);
                }
            }
        }
    }
}
