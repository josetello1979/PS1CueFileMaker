/*

autor:  Jose Tello
date 2022-03-26_103607
eduardo_tello@hotmail.com
eduardo.tello@gmail.com

Create .cue files for .bin files of PS1 roms
 

*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace PS1CueFileMaker
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void btnCreateCueFiles_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            this.txtError.Text = String.Empty;

            try
            {
                string path = this.txtInputDirectory.Text;


                SearchOption searchOption = SearchOption.AllDirectories;

                if(this.chkRecursive.Checked == false) 
                {
                    searchOption = SearchOption.TopDirectoryOnly;
                }

                foreach (string file in Directory.EnumerateFiles(path, "*.bin", searchOption))
                {
                    FileInfo fileInfo = new FileInfo(file);
                    string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(fileInfo.FullName);
                    string filePath =  Path.Combine(fileInfo.DirectoryName,fileNameWithoutExtension + ".cue");
                    string template = "FILE \"{0}\" BINARY " + Environment.NewLine + "TRACK 01 MODE2/2352" + Environment.NewLine + "INDEX 01 00:00:00";
                    string fileData = String.Format(template, fileInfo.Name);

                    System.IO.File.WriteAllText(filePath, fileData);
                    
                    //if (!System.IO.File.Exists(filePath))
                    //{
                    //    System.IO.File.WriteAllText(filePath, fileData);

                    //}

                }

                MessageBox.Show("Done...");
            }
            catch (Exception ex) 
            {
                string error = ex.ToString();
                this.txtError.Text = error;
                this.tabMainControl.SelectTab("tabError");
            }
            finally 
            {
                Cursor.Current = Cursors.Default;
                
            }
        }
    }
}
