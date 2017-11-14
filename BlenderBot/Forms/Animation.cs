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
    public partial class Animation : Form
    {
        #region Fields
        public static bool noquit;
        bool slidingStart;
        bool slidingEnd;
        bool slidStart;
        bool slidEnd;
        int slidervalueStart;
        int slidervalueEnd;
        const int WM_NCLBUTTONDOWN = 0xA1;
        const int HT_CAPTION = 0x2;
        StartupForm _StartupForm = Application.OpenForms.Cast<StartupForm>().FirstOrDefault(c => c is StartupForm);
        #endregion

        public Animation()
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

        #region sliderStart

        private void SlideStart(object sender, MouseEventArgs e)
        {
            Cursor.Hide();
            slidingStart = true;
            Rectangle rect = new Rectangle(Start.PointToScreen(Point.Empty).X, Start.PointToScreen(Point.Empty).Y + (Start.Height / 2), Start.Width + 4, 1);
            Cursor.Clip = rect;
            Cursor.Position = new Point(Start.PointToScreen(Point.Empty).X + (Start.Width / 2), Cursor.Position.Y);
        }

        private void XSlideStart(object sender, MouseEventArgs e)
        {
            Cursor.Show();
            slidingStart = false;
            Cursor.Clip = new Rectangle();
            StartTextbox.Text = slidervalueStart.ToString();
            if (!slidStart)
            {
                StartTextbox.Visible = true;
                StartTextbox.Focus();
            }
            slidStart = false;
        }

        private void GetSlideStart(object sender, MouseEventArgs e)
        {
            int _CursorPositionX = Cursor.Position.X;
            int _ControlPositionX = Start.PointToScreen(Point.Empty).X + (Start.Width / 2);

            if (slidingStart == true && Math.Abs(_ControlPositionX - _CursorPositionX) > 20)
            {
                slidStart = true;
                Cursor.Position = new Point(_ControlPositionX, Cursor.Position.Y);
                if (slidervalueStart != 0)
                {
                    int change = (_ControlPositionX - _CursorPositionX) > 0 ? -1 : 1;
                    slidervalueStart = (slidervalueStart + change);
                    Start.Text = slidervalueStart.ToString();

                }
                else if ((_ControlPositionX - _CursorPositionX) < 20)
                {
                    slidervalueStart = 1;
                    Start.Text = slidervalueStart.ToString();
                }
            }
        }

        private void StartTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals(Convert.ToChar(Keys.Enter)))
            {
                slidervalueStart = Convert.ToInt32(StartTextbox.Text);
                Start.Text = slidervalueStart.ToString();
                StartTextbox.Hide();
            }
            if (e.KeyChar.Equals(Convert.ToChar(Keys.Escape)))
            {
                StartTextbox.Text = Start.Text;
                StartTextbox.Hide();
            }
            if (char.IsDigit(e.KeyChar)) return;
            if (char.IsControl(e.KeyChar)) return;
            e.Handled = true;
        }

        private void StartTextbox_Leave(object sender, EventArgs e)
        {
            slidervalueStart = Convert.ToInt32(StartTextbox.Text);
            Start.Text = slidervalueStart.ToString();
            StartTextbox.Hide();
        }

        private void _StartDecrement(object sender, EventArgs e)
        {
            slidervalueStart--;
            Start.Text = slidervalueStart.ToString();
        }

        private void _StartIncrement(object sender, EventArgs e)
        {
            slidervalueStart++;
            Start.Text = slidervalueStart.ToString();
        }

        #endregion

        #region sliderEnd

        private void Slide(object sender, MouseEventArgs e)
        {
            Cursor.Hide();
            slidingEnd = true;
            Rectangle rect = new Rectangle(End.PointToScreen(Point.Empty).X, End.PointToScreen(Point.Empty).Y + (End.Height / 2), End.Width + 4, 1);
            Cursor.Clip = rect;
            Cursor.Position = new Point(End.PointToScreen(Point.Empty).X + (End.Width / 2), Cursor.Position.Y);
        }

        private void XSlide(object sender, MouseEventArgs e)
        {
            Cursor.Show();
            slidingEnd = false;
            Cursor.Clip = new Rectangle();
            EndTextbox.Text = slidervalueEnd.ToString();
            if (!slidEnd)
            {
                EndTextbox.Visible = true;
                EndTextbox.Focus();
            }
            slidEnd = false;
        }

        private void GetSlide(object sender, MouseEventArgs e)
        {
            int _CursorPositionX = Cursor.Position.X;
            int _ControlPositionX = End.PointToScreen(Point.Empty).X + (End.Width / 2);

            if (slidingEnd == true && Math.Abs(_ControlPositionX - _CursorPositionX) > 20)
            {
                slidEnd = true;
                Cursor.Position = new Point(_ControlPositionX, Cursor.Position.Y);
                if (slidervalueEnd != 0)
                {
                    int change = (_ControlPositionX - _CursorPositionX) > 0 ? -1 : 1;
                    slidervalueEnd = (slidervalueEnd + change);
                    End.Text = slidervalueEnd.ToString();

                }
                else if ((_ControlPositionX - _CursorPositionX) < 20)
                {
                    slidervalueEnd = 1;
                    End.Text = slidervalueEnd.ToString();
                }
            }
        }

        private void FrameTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals(Convert.ToChar(Keys.Enter)))
            {
                slidervalueEnd = Convert.ToInt32(EndTextbox.Text);
                End.Text = slidervalueEnd.ToString();
                EndTextbox.Hide();
            }
            if (e.KeyChar.Equals(Convert.ToChar(Keys.Escape)))
            {
                EndTextbox.Text = End.Text;
                EndTextbox.Hide();
            }
            if (char.IsDigit(e.KeyChar)) return;
            if (char.IsControl(e.KeyChar)) return;
            e.Handled = true;
        }

        private void FrameTextbox_Leave(object sender, EventArgs e)
        {
            slidervalueEnd = Convert.ToInt32(EndTextbox.Text);
            End.Text = slidervalueEnd.ToString();
            EndTextbox.Hide();
        }

        private void Decrement(object sender, EventArgs e)
        {
            slidervalueEnd--;
            End.Text = slidervalueEnd.ToString();
        }

        private void Increment(object sender, EventArgs e)
        {
            slidervalueEnd++;
            End.Text = slidervalueEnd.ToString();
        }

        #endregion

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

        private void Back_Click(object sender, EventArgs e)
        {
            Hide();
            _StartupForm.Show();
        }

        private async void BeginRender_Click(object sender, EventArgs e)
        {
            object[] args = Scripts.Args.AppendAnimation(Scripts.Args.Get(), File.Text, Start.Text, End.Text);
            int Result = Scripts.Start.Animation(args[0]);
            Console.WriteLine("Finished!");
            string Dir = Scripts.Args.Preview(Scripts.Args.Get()[1] + $"\\{File.Text}\\", Scripts.Args.Get()[3], Start.Text, File.Text);
            await Scripts.Notify.MainAsync(args[2].ToString(), Dir, "", Convert.ToUInt64(args[1]), true, false, Preview.Checked, Result, args[0]);
            if (Shutdown.Checked)
            {
                Process.Start("CMD.exe", "/c shutdown /s /f /t 15");
            }
            Console.WriteLine(noquit);
            if (!noquit)
            {
                Environment.Exit(0);
            }
        }

        private void Open_Click(object sender, EventArgs e)
        {
            SelectBlend.InitialDirectory = Scripts.Args.Get()[1];
            SelectBlend.ShowDialog();
            File.Text = SelectBlend.SafeFileName.Split('.').First();
        }
    }
}
