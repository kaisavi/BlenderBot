namespace BlenderBot.Forms
{
    partial class Render
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Render));
            this.Frame = new System.Windows.Forms.Button();
            this.SliderContainer = new System.Windows.Forms.Panel();
            this.FrameTextbox = new System.Windows.Forms.TextBox();
            this.Inc = new System.Windows.Forms.Button();
            this.Dec = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Open = new System.Windows.Forms.Button();
            this.File = new System.Windows.Forms.TextBox();
            this.Shutdown = new System.Windows.Forms.CheckBox();
            this.BeginRender = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.SelectBlend = new System.Windows.Forms.OpenFileDialog();
            this.Preview = new System.Windows.Forms.CheckBox();
            this.SliderContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Frame
            // 
            this.Frame.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Frame.FlatAppearance.BorderSize = 0;
            this.Frame.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.Frame.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Frame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Frame.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Frame.Location = new System.Drawing.Point(16, 0);
            this.Frame.Name = "Frame";
            this.Frame.Size = new System.Drawing.Size(75, 20);
            this.Frame.TabIndex = 3;
            this.Frame.Text = "0";
            this.Frame.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Frame.UseVisualStyleBackColor = false;
            this.Frame.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Slide);
            this.Frame.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GetSlide);
            this.Frame.MouseUp += new System.Windows.Forms.MouseEventHandler(this.XSlide);
            // 
            // SliderContainer
            // 
            this.SliderContainer.BackColor = System.Drawing.Color.Transparent;
            this.SliderContainer.Controls.Add(this.FrameTextbox);
            this.SliderContainer.Controls.Add(this.Frame);
            this.SliderContainer.Controls.Add(this.Inc);
            this.SliderContainer.Controls.Add(this.Dec);
            this.SliderContainer.Location = new System.Drawing.Point(60, 36);
            this.SliderContainer.Name = "SliderContainer";
            this.SliderContainer.Size = new System.Drawing.Size(109, 20);
            this.SliderContainer.TabIndex = 3;
            // 
            // FrameTextbox
            // 
            this.FrameTextbox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.FrameTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FrameTextbox.Location = new System.Drawing.Point(16, 4);
            this.FrameTextbox.Name = "FrameTextbox";
            this.FrameTextbox.Size = new System.Drawing.Size(75, 16);
            this.FrameTextbox.TabIndex = 3;
            this.FrameTextbox.Visible = false;
            this.FrameTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrameTextbox_KeyPress);
            this.FrameTextbox.Leave += new System.EventHandler(this.FrameTextbox_Leave);
            // 
            // Inc
            // 
            this.Inc.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Inc.BackgroundImage = global::BlenderBot.Properties.Resources.Inc;
            this.Inc.FlatAppearance.BorderSize = 0;
            this.Inc.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.Inc.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Inc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Inc.Location = new System.Drawing.Point(87, 0);
            this.Inc.Name = "Inc";
            this.Inc.Size = new System.Drawing.Size(20, 20);
            this.Inc.TabIndex = 4;
            this.Inc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Inc.UseVisualStyleBackColor = false;
            this.Inc.Click += new System.EventHandler(this.Increment);
            // 
            // Dec
            // 
            this.Dec.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Dec.BackgroundImage = global::BlenderBot.Properties.Resources.Dec;
            this.Dec.FlatAppearance.BorderSize = 0;
            this.Dec.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.Dec.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Dec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dec.Location = new System.Drawing.Point(0, 0);
            this.Dec.Name = "Dec";
            this.Dec.Size = new System.Drawing.Size(20, 20);
            this.Dec.TabIndex = 2;
            this.Dec.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Dec.UseVisualStyleBackColor = false;
            this.Dec.Click += new System.EventHandler(this.Decrement);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(5, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Frame:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.Preview);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Open);
            this.panel1.Controls.Add(this.File);
            this.panel1.Controls.Add(this.Shutdown);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BeginRender);
            this.panel1.Controls.Add(this.SliderContainer);
            this.panel1.Controls.Add(this.Back);
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(198, 131);
            this.panel1.TabIndex = 6;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Dragging);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(5, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "File:";
            // 
            // Open
            // 
            this.Open.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Open.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Open.BackgroundImage")));
            this.Open.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Open.FlatAppearance.BorderSize = 0;
            this.Open.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Open.Location = new System.Drawing.Point(147, 8);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(23, 23);
            this.Open.TabIndex = 1;
            this.Open.UseVisualStyleBackColor = false;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // File
            // 
            this.File.BackColor = System.Drawing.SystemColors.ControlLight;
            this.File.Location = new System.Drawing.Point(60, 8);
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(91, 23);
            this.File.TabIndex = 0;
            // 
            // Shutdown
            // 
            this.Shutdown.AutoSize = true;
            this.Shutdown.FlatAppearance.BorderSize = 0;
            this.Shutdown.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Shutdown.Location = new System.Drawing.Point(5, 70);
            this.Shutdown.Name = "Shutdown";
            this.Shutdown.Size = new System.Drawing.Size(80, 19);
            this.Shutdown.TabIndex = 5;
            this.Shutdown.Text = "Shutdown";
            this.Shutdown.UseVisualStyleBackColor = false;
            this.Shutdown.CheckedChanged += new System.EventHandler(this.Shutdown_CheckedChanged);
            // 
            // BeginRender
            // 
            this.BeginRender.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BeginRender.Image = global::BlenderBot.Properties.Resources.Render;
            this.BeginRender.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BeginRender.Location = new System.Drawing.Point(114, 95);
            this.BeginRender.Name = "BeginRender";
            this.BeginRender.Size = new System.Drawing.Size(75, 27);
            this.BeginRender.TabIndex = 7;
            this.BeginRender.Text = "Start";
            this.BeginRender.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BeginRender.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BeginRender.UseVisualStyleBackColor = true;
            this.BeginRender.Click += new System.EventHandler(this.BeginRender_Click);
            // 
            // Back
            // 
            this.Back.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Back.Image = global::BlenderBot.Properties.Resources.back;
            this.Back.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Back.Location = new System.Drawing.Point(5, 95);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 27);
            this.Back.TabIndex = 8;
            this.Back.Text = "Back";
            this.Back.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Back.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // SelectBlend
            // 
            this.SelectBlend.Filter = ".blend Files | *.blend";
            this.SelectBlend.Title = "Select a .blend File";
            // 
            // Preview
            // 
            this.Preview.AutoSize = true;
            this.Preview.FlatAppearance.BorderSize = 0;
            this.Preview.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Preview.Location = new System.Drawing.Point(122, 70);
            this.Preview.Name = "Preview";
            this.Preview.Size = new System.Drawing.Size(67, 19);
            this.Preview.TabIndex = 6;
            this.Preview.Text = "Preview";
            this.Preview.UseVisualStyleBackColor = false;
            // 
            // Render
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(208, 141);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Render";
            this.ShowIcon = false;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Exited);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Dragging);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GetSlide);
            this.SliderContainer.ResumeLayout(false);
            this.SliderContainer.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Frame;
        private System.Windows.Forms.Button Dec;
        private System.Windows.Forms.Button Inc;
        private System.Windows.Forms.Panel SliderContainer;
        private System.Windows.Forms.TextBox FrameTextbox;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BeginRender;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox Shutdown;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.TextBox File;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog SelectBlend;
        private System.Windows.Forms.CheckBox Preview;
    }
}