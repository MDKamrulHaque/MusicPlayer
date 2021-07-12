using AxWMPLib;
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
    public partial class MusicPlayer : Form
    {
        public MusicPlayer()
        {
            InitializeComponent();
        }

        //Create Global variables of string type array to save the titles or name the of the songs and the path (location) of the songs 
        string[] paths, files;

        private void btnSelectSongs_Click(object sender, EventArgs e)
        {
            // code for selecting songs 
            OpenFileDialog ofd = new OpenFileDialog();

            // code for selecting multiple tracks 
            ofd.Multiselect = true;
            ofd.Filter = "All Supported Audio | *.mp3; *.wma | MP3s | *.mp3 | WMAs | *.wma";

            if (ofd.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.SafeFileNames; // this is to save name of the songs in the files array
                paths = ofd.FileNames; // this is to save the paths/location of the songs in the path array

                // after that we display the music titles in the listbox
                for (int i = 0; i <files.Length; i++)
                {

                    listBoxSongs.Items.Add(files[i]); // this displays the songs in the list box
                }
            }
        }

        private void listBoxSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            string
                        // code for playing the sellected music 
                        AxWindowsMediaPlayer = paths[listBoxSongs.SelectedIndex];
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // code for closing the app 
            this.Close();

        }
    }
}
