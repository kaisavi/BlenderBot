using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlenderBot.Forms
{

    public partial class Preferences : Form
    {
        StartupForm _StartupForm = Application.OpenForms.Cast<StartupForm>().FirstOrDefault(c => c is StartupForm);
        public string[] prefs;
        const int WM_NCLBUTTONDOWN = 0xA1;
        const int HT_CAPTION = 0x2;

        public Preferences()
        {
            InitializeComponent();
        }

        #region Dragging
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Dragging(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        #endregion

        private void SavePrefs(object sender, EventArgs e)
        {
            string[] prefs = { BlenderExe.Text, ProjectsDir.Text, ChannelID.Text, RenderFormat.Text, AnimationFormat.Text };
            Scripts.Args.Set(prefs);
        }

        private void GetPrefs(object sender, EventArgs e)
        {
            string[] prefs = Scripts.Args.Get();
            BlenderExe.Text = prefs[0]; ProjectsDir.Text = prefs[1]; ChannelID.Text = prefs[2]; RenderFormat.Text = prefs[3]; AnimationFormat.Text = prefs[4];
        }


        private void OpenBlenderDialog(object sender, EventArgs e)
        {
            if (System.IO.Directory.Exists(BlenderExe.Text))
            {
                OpenBlender.InitialDirectory = BlenderExe.Text;
            }
            else
            {
                OpenBlender.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
            }

            OpenBlender.ShowDialog();
            BlenderExe.Text = OpenBlender.FileName;
        }

        private void ClosePrefs(object sender, EventArgs e)
        {
            Hide();
        }

        private void SelectFolder(object sender, EventArgs e)
        {
            FolderSelect.FolderSelectDialog _SelectFolder = new FolderSelect.FolderSelectDialog();
            _SelectFolder.Title = "Select Project Folder";
            _SelectFolder.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (_SelectFolder.ShowDialog(IntPtr.Zero))
            {
                if (_SelectFolder.FileName.EndsWith(@"\"))
                {
                    ProjectsDir.Text = _SelectFolder.FileName;
                }
                else
                {
                    ProjectsDir.Text = _SelectFolder.FileName + @"\";
                }
            }
        }
    }
}
