namespace BlenderBot.Forms
{
    partial class Animation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Animation));
            this.StartContainer = new System.Windows.Forms.Panel();
            this.StartTextbox = new System.Windows.Forms.TextBox();
            this.Start = new System.Windows.Forms.Button();
            this.StartIncrement = new System.Windows.Forms.Button();
            this.StartDecrement = new System.Windows.Forms.Button();
            this.EndContainer = new System.Windows.Forms.Panel();
            this.EndTextbox = new System.Windows.Forms.TextBox();
            this.End = new System.Windows.Forms.Button();
            this.EndIncrement = new System.Windows.Forms.Button();
            this.EndDecrement = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Preview = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BeginRender = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Open = new System.Windows.Forms.Button();
            this.Shutdown = new System.Windows.Forms.CheckBox();
            this.File = new System.Windows.Forms.TextBox();
            this.SelectBlend = new System.Windows.Forms.OpenFileDialog();
            this.StartContainer.SuspendLayout();
            this.EndContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartContainer
            // 
            this.StartContainer.BackColor = System.Drawing.Color.Transparent;
            this.StartContainer.Controls.Add(this.StartTextbox);
            this.StartContainer.Controls.Add(this.Start);
            this.StartContainer.Controls.Add(this.StartIncrement);
            this.StartContainer.Controls.Add(this.StartDecrement);
            this.StartContainer.Location = new System.Drawing.Point(57, 38);
            this.StartContainer.Name = "StartContainer";
            this.StartContainer.Size = new System.Drawing.Size(127, 23);
            this.StartContainer.TabIndex = 4;
            // 
            // StartTextbox
            // 
            this.StartTextbox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.StartTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StartTextbox.Location = new System.Drawing.Point(19, 5);
            this.StartTextbox.Name = "StartTextbox";
            this.StartTextbox.Size = new System.Drawing.Size(87, 16);
            this.StartTextbox.TabIndex = 3;
            this.StartTextbox.Visible = false;
            this.StartTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StartTextbox_KeyPress);
            this.StartTextbox.Leave += new System.EventHandler(this.StartTextbox_Leave);
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Start.FlatAppearance.BorderSize = 0;
            this.Start.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.Start.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Start.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Start.Location = new System.Drawing.Point(19, 0);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(87, 23);
            this.Start.TabIndex = 3;
            this.Start.Text = "0";
            this.Start.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Start.UseVisualStyleBackColor = false;
            this.Start.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SlideStart);
            this.Start.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GetSlideStart);
            this.Start.MouseUp += new System.Windows.Forms.MouseEventHandler(this.XSlideStart);
            // 
            // StartIncrement
            // 
            this.StartIncrement.BackColor = System.Drawing.SystemColors.ControlLight;
            this.StartIncrement.BackgroundImage = global::BlenderBot.Properties.Resources.Inc;
            this.StartIncrement.FlatAppearance.BorderSize = 0;
            this.StartIncrement.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.StartIncrement.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.StartIncrement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartIncrement.Location = new System.Drawing.Point(101, 0);
            this.StartIncrement.Name = "StartIncrement";
            this.StartIncrement.Size = new System.Drawing.Size(23, 23);
            this.StartIncrement.TabIndex = 4;
            this.StartIncrement.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.StartIncrement.UseVisualStyleBackColor = false;
            this.StartIncrement.Click += new System.EventHandler(this._StartIncrement);
            // 
            // StartDecrement
            // 
            this.StartDecrement.BackColor = System.Drawing.SystemColors.ControlLight;
            this.StartDecrement.BackgroundImage = global::BlenderBot.Properties.Resources.Dec;
            this.StartDecrement.FlatAppearance.BorderSize = 0;
            this.StartDecrement.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.StartDecrement.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.StartDecrement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartDecrement.Location = new System.Drawing.Point(0, 0);
            this.StartDecrement.Name = "StartDecrement";
            this.StartDecrement.Size = new System.Drawing.Size(23, 23);
            this.StartDecrement.TabIndex = 2;
            this.StartDecrement.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.StartDecrement.UseVisualStyleBackColor = false;
            this.StartDecrement.Click += new System.EventHandler(this._StartDecrement);
            // 
            // EndContainer
            // 
            this.EndContainer.BackColor = System.Drawing.Color.Transparent;
            this.EndContainer.Controls.Add(this.EndTextbox);
            this.EndContainer.Controls.Add(this.End);
            this.EndContainer.Controls.Add(this.EndIncrement);
            this.EndContainer.Controls.Add(this.EndDecrement);
            this.EndContainer.Location = new System.Drawing.Point(57, 67);
            this.EndContainer.Name = "EndContainer";
            this.EndContainer.Size = new System.Drawing.Size(127, 23);
            this.EndContainer.TabIndex = 5;
            // 
            // EndTextbox
            // 
            this.EndTextbox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.EndTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EndTextbox.Location = new System.Drawing.Point(19, 5);
            this.EndTextbox.Name = "EndTextbox";
            this.EndTextbox.Size = new System.Drawing.Size(87, 16);
            this.EndTextbox.TabIndex = 3;
            this.EndTextbox.Visible = false;
            this.EndTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrameTextbox_KeyPress);
            this.EndTextbox.Leave += new System.EventHandler(this.FrameTextbox_Leave);
            // 
            // End
            // 
            this.End.BackColor = System.Drawing.SystemColors.ControlLight;
            this.End.FlatAppearance.BorderSize = 0;
            this.End.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.End.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.End.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.End.ForeColor = System.Drawing.SystemColors.ControlText;
            this.End.Location = new System.Drawing.Point(19, 0);
            this.End.Name = "End";
            this.End.Size = new System.Drawing.Size(87, 23);
            this.End.TabIndex = 6;
            this.End.Text = "0";
            this.End.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.End.UseVisualStyleBackColor = false;
            this.End.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Slide);
            this.End.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GetSlide);
            this.End.MouseUp += new System.Windows.Forms.MouseEventHandler(this.XSlide);
            // 
            // EndIncrement
            // 
            this.EndIncrement.BackColor = System.Drawing.SystemColors.ControlLight;
            this.EndIncrement.BackgroundImage = global::BlenderBot.Properties.Resources.Inc;
            this.EndIncrement.FlatAppearance.BorderSize = 0;
            this.EndIncrement.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.EndIncrement.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.EndIncrement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EndIncrement.Location = new System.Drawing.Point(101, 0);
            this.EndIncrement.Name = "EndIncrement";
            this.EndIncrement.Size = new System.Drawing.Size(23, 23);
            this.EndIncrement.TabIndex = 7;
            this.EndIncrement.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EndIncrement.UseVisualStyleBackColor = false;
            this.EndIncrement.Click += new System.EventHandler(this.Increment);
            // 
            // EndDecrement
            // 
            this.EndDecrement.BackColor = System.Drawing.SystemColors.ControlLight;
            this.EndDecrement.BackgroundImage = global::BlenderBot.Properties.Resources.Dec;
            this.EndDecrement.FlatAppearance.BorderSize = 0;
            this.EndDecrement.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.EndDecrement.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.EndDecrement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EndDecrement.Location = new System.Drawing.Point(0, 0);
            this.EndDecrement.Name = "EndDecrement";
            this.EndDecrement.Size = new System.Drawing.Size(23, 23);
            this.EndDecrement.TabIndex = 5;
            this.EndDecrement.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EndDecrement.UseVisualStyleBackColor = false;
            this.EndDecrement.Click += new System.EventHandler(this.Decrement);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.Preview);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.BeginRender);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Back);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Open);
            this.panel1.Controls.Add(this.Shutdown);
            this.panel1.Controls.Add(this.File);
            this.panel1.Controls.Add(this.StartContainer);
            this.panel1.Controls.Add(this.EndContainer);
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 157);
            this.panel1.TabIndex = 6;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Dragging);
            // 
            // Preview
            // 
            this.Preview.AutoSize = true;
            this.Preview.Enabled = false;
            this.Preview.FlatAppearance.BorderSize = 0;
            this.Preview.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Preview.Location = new System.Drawing.Point(121, 96);
            this.Preview.Name = "Preview";
            this.Preview.Size = new System.Drawing.Size(67, 19);
            this.Preview.TabIndex = 15;
            this.Preview.Text = "Preview";
            this.Preview.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(7, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "End:";
            // 
            // BeginRender
            // 
            this.BeginRender.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BeginRender.Image = global::BlenderBot.Properties.Resources.Animation;
            this.BeginRender.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BeginRender.Location = new System.Drawing.Point(121, 121);
            this.BeginRender.Name = "BeginRender";
            this.BeginRender.Size = new System.Drawing.Size(75, 27);
            this.BeginRender.TabIndex = 9;
            this.BeginRender.Text = "Start";
            this.BeginRender.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BeginRender.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BeginRender.UseVisualStyleBackColor = true;
            this.BeginRender.Click += new System.EventHandler(this.BeginRender_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(7, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Start:";
            // 
            // Back
            // 
            this.Back.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Back.Image = global::BlenderBot.Properties.Resources.back;
            this.Back.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Back.Location = new System.Drawing.Point(5, 121);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 27);
            this.Back.TabIndex = 10;
            this.Back.Text = "Back";
            this.Back.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Back.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(7, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "File:";
            // 
            // Open
            // 
            this.Open.BackColor = System.Drawing.SystemColors.Control;
            this.Open.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Open.BackgroundImage")));
            this.Open.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Open.FlatAppearance.BorderSize = 0;
            this.Open.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Open.Location = new System.Drawing.Point(159, 9);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(23, 23);
            this.Open.TabIndex = 1;
            this.Open.UseVisualStyleBackColor = false;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // Shutdown
            // 
            this.Shutdown.AutoSize = true;
            this.Shutdown.FlatAppearance.BorderSize = 0;
            this.Shutdown.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Shutdown.Location = new System.Drawing.Point(10, 96);
            this.Shutdown.Name = "Shutdown";
            this.Shutdown.Size = new System.Drawing.Size(80, 19);
            this.Shutdown.TabIndex = 8;
            this.Shutdown.Text = "Shutdown";
            this.Shutdown.UseVisualStyleBackColor = false;
            // 
            // File
            // 
            this.File.BackColor = System.Drawing.SystemColors.ControlLight;
            this.File.Location = new System.Drawing.Point(57, 9);
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(105, 23);
            this.File.TabIndex = 0;
            // 
            // SelectBlend
            // 
            this.SelectBlend.Filter = ".blend Files | *.blend";
            this.SelectBlend.Title = "Select a .blend File";
            // 
            // Animation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(215, 167);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Animation";
            this.ShowIcon = false;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Exited);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Dragging);
            this.StartContainer.ResumeLayout(false);
            this.StartContainer.PerformLayout();
            this.EndContainer.ResumeLayout(false);
            this.EndContainer.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel StartContainer;
        private System.Windows.Forms.TextBox StartTextbox;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button StartIncrement;
        private System.Windows.Forms.Button StartDecrement;
        private System.Windows.Forms.Panel EndContainer;
        private System.Windows.Forms.TextBox EndTextbox;
        private System.Windows.Forms.Button End;
        private System.Windows.Forms.Button EndIncrement;
        private System.Windows.Forms.Button EndDecrement;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button BeginRender;
        private System.Windows.Forms.CheckBox Shutdown;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.TextBox File;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox Preview;
        private System.Windows.Forms.OpenFileDialog SelectBlend;
    }
}