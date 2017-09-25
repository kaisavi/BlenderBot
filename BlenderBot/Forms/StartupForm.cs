using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlenderBot
{
    public partial class StartupForm : Form
    {
        Forms.Render _Render;
        Forms.Animation _Animation;
        Forms.Preferences _Preferences;
        public static string docs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;



        public StartupForm()
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
        
        private void Render_Click(object sender, EventArgs e)
        {
            if (_Render != null && !_Render.IsDisposed)
            {
                _Render.Show();
            }

            else
            {
                _Render = new Forms.Render();
                _Render.Show();
            }
            Hide();
        }

        private void Animation_Click(object sender, EventArgs e)
        {
            if (_Animation != null && !_Animation.IsDisposed)
            {
                _Animation.Show();
            }
            else
            {
                _Animation = new Forms.Animation();
                _Animation.Show();
            }
            Hide();
        }

        private void Prefs_Click(object sender, EventArgs e)
        {
            if (_Preferences != null && !_Preferences.IsDisposed)
            {
                _Preferences.ShowDialog();
            }
            else
            {
                _Preferences = new Forms.Preferences();
                
                _Preferences.ShowDialog();
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
