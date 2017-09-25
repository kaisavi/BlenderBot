using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlenderBot.Forms
{
    public partial class Render : Form
    {
        #region Variables
        StartupForm _StartupForm = Application.OpenForms.Cast<StartupForm>().FirstOrDefault(c => c is StartupForm);
        public string[] prefs;
        int slidervalue;
        const int WM_NCLBUTTONDOWN = 0xA1;
        const int HT_CAPTION = 0x2;
        bool sliding;
        bool slid;
        #endregion

        public Render()
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

        private void Open_Click(object sender, EventArgs e)
        {
            SelectBlend.InitialDirectory = Scripts.Args.Get()[1];
            SelectBlend.ShowDialog();
            File.Text = SelectBlend.SafeFileName.Split('.').First();
        }

        #region slider

        private void Slide(object sender, MouseEventArgs e)
        {
            Cursor.Hide();
            sliding = true;
            Rectangle rect = new Rectangle(Frame.PointToScreen(Point.Empty).X, Frame.PointToScreen(Point.Empty).Y + (Frame.Height / 2), Frame.Width + 4, 1);
            Cursor.Clip = rect;
            Cursor.Position = new Point(Frame.PointToScreen(Point.Empty).X + (Frame.Width / 2), Cursor.Position.Y);
        }

        private void XSlide(object sender, MouseEventArgs e)
        {
            Cursor.Show();
            sliding = false;
            Cursor.Clip = new Rectangle();
            FrameTextbox.Text = slidervalue.ToString();
            if (!slid)
            {
                FrameTextbox.Visible = true;
                FrameTextbox.Focus();
            }
            slid = false;
        }

        private void GetSlide(object sender, MouseEventArgs e)
        {
            int _CursorPositionX = Cursor.Position.X;
            int _ControlPositionX = Frame.PointToScreen(Point.Empty).X + (Frame.Width / 2);

            if (sliding == true && Math.Abs(_ControlPositionX - _CursorPositionX) > 20)
            {
                slid = true;
                Cursor.Position = new Point(_ControlPositionX, Cursor.Position.Y);
                if (slidervalue != 0)
                {
                    int change = (_ControlPositionX - _CursorPositionX) > 0 ? -1 : 1;
                    slidervalue = (slidervalue + change);
                    Frame.Text = slidervalue.ToString();

                }
                else if ((_ControlPositionX - _CursorPositionX) < 20)
                {
                    slidervalue = 1;
                    Frame.Text = slidervalue.ToString();
                }
            }
        }

        private void FrameTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals(Convert.ToChar(Keys.Enter)))
            {
                slidervalue = Convert.ToInt32(FrameTextbox.Text);
                Frame.Text = slidervalue.ToString();
                FrameTextbox.Hide();
            }
            if (e.KeyChar.Equals(Convert.ToChar(Keys.Escape)))
            {
                FrameTextbox.Text = Frame.Text;
                FrameTextbox.Hide();
            }
            if (Char.IsDigit(e.KeyChar)) return;
            if (Char.IsControl(e.KeyChar)) return;
            e.Handled = true;
        }

        private void FrameTextbox_Leave(object sender, EventArgs e)
        {
            slidervalue = Convert.ToInt32(FrameTextbox.Text);
            Frame.Text = slidervalue.ToString();
            FrameTextbox.Hide();
        }

        private void Decrement(object sender, EventArgs e)
        {
            slidervalue--;
            Frame.Text = slidervalue.ToString();
        }

        private void Increment(object sender, EventArgs e)
        {
            slidervalue++;
            Frame.Text = slidervalue.ToString();
        }

        #endregion

        private void Shutdown_CheckedChanged(object sender, EventArgs e)
        {
            Shutdown.ForeColor = Shutdown.Checked ? Color.White : Color.Black;
        }

        private async void BeginRender_Click(object sender, EventArgs e)
        {
            object[] args = Scripts.Args.Append(Scripts.Args.Get(), File.Text, Frame.Text);
            Scripts.Start.Render(args[0]);
            Console.WriteLine("Finished!");
            await Scripts.Notify.MainAsync(args[2].ToString(), Convert.ToUInt64(args[1]));
            if (Shutdown.Checked)
            {
                Process.Start("CMD.exe", "shutdown /s");
            }

            Environment.Exit(0);
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Hide();
            _StartupForm.Show();
        }

        private void Exited(object sender, FormClosedEventArgs e)
        {
            if (_StartupForm != null)
            {
                _StartupForm.Show();
            }
            else
            {
                _StartupForm = new StartupForm();
                _StartupForm.Show();
            }
        }
    }
}
