namespace BlenderBot.Forms
{
    partial class Preferences
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
            this.BlenderExe = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Save = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.AnimationFormat = new System.Windows.Forms.ComboBox();
            this.RenderFormat = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ChannelID = new System.Windows.Forms.TextBox();
            this.ProjectsDir = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.OpenBlender = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BlenderExe
            // 
            this.BlenderExe.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BlenderExe.Location = new System.Drawing.Point(145, 7);
            this.BlenderExe.Name = "BlenderExe";
            this.BlenderExe.Size = new System.Drawing.Size(172, 23);
            this.BlenderExe.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.Save);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.AnimationFormat);
            this.panel1.Controls.Add(this.RenderFormat);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.ChannelID);
            this.panel1.Controls.Add(this.ProjectsDir);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.BlenderExe);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 187);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Dragging);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(7, 157);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(123, 23);
            this.Save.TabIndex = 10;
            this.Save.Text = "Save User Settings";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.SavePrefs);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(264, 157);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Close";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.ClosePrefs);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button2.BackgroundImage = global::BlenderBot.Properties.Resources.Open;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(317, 36);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(23, 23);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.SelectFolder);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.BackgroundImage = global::BlenderBot.Properties.Resources.Open;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(317, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 23);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.OpenBlenderDialog);
            // 
            // AnimationFormat
            // 
            this.AnimationFormat.BackColor = System.Drawing.SystemColors.ControlLight;
            this.AnimationFormat.FormattingEnabled = true;
            this.AnimationFormat.Items.AddRange(new object[] {
            "Use Blender Configuration",
            "AVIRAW",
            "AVIJPEG",
            "MPEG",
            "QUICKTIME",
            "PNG",
            "TIFF",
            "JPEG",
            "TGA",
            "RAWTGA",
            "IRIS",
            "IRIZ",
            "BMP",
            "HDR"});
            this.AnimationFormat.Location = new System.Drawing.Point(145, 123);
            this.AnimationFormat.Name = "AnimationFormat";
            this.AnimationFormat.Size = new System.Drawing.Size(172, 23);
            this.AnimationFormat.TabIndex = 6;
            this.AnimationFormat.Text = "Use Blender Configuration";
            // 
            // RenderFormat
            // 
            this.RenderFormat.BackColor = System.Drawing.SystemColors.ControlLight;
            this.RenderFormat.FormattingEnabled = true;
            this.RenderFormat.Items.AddRange(new object[] {
            "Use Blender Configuration",
            "PNG",
            "TIFF",
            "JPEG",
            "TGA",
            "RAWTGA",
            "IRIS",
            "IRIZ",
            "BMP",
            "HDR"});
            this.RenderFormat.Location = new System.Drawing.Point(145, 94);
            this.RenderFormat.Name = "RenderFormat";
            this.RenderFormat.Size = new System.Drawing.Size(172, 23);
            this.RenderFormat.TabIndex = 5;
            this.RenderFormat.Text = "Use Blender Configuration";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Render Format:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Animation Format:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Channel ID:";
            // 
            // ChannelID
            // 
            this.ChannelID.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ChannelID.Location = new System.Drawing.Point(145, 65);
            this.ChannelID.Name = "ChannelID";
            this.ChannelID.Size = new System.Drawing.Size(172, 23);
            this.ChannelID.TabIndex = 4;
            // 
            // ProjectsDir
            // 
            this.ProjectsDir.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ProjectsDir.Location = new System.Drawing.Point(145, 36);
            this.ProjectsDir.Name = "ProjectsDir";
            this.ProjectsDir.Size = new System.Drawing.Size(172, 23);
            this.ProjectsDir.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Projects Folder:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Blender Executable:";
            // 
            // OpenBlender
            // 
            this.OpenBlender.FileName = "blender.exe";
            this.OpenBlender.Filter = "Blender Executable | blender.exe";
            this.OpenBlender.Title = "Select Blender Executable";
            // 
            // Preferences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(356, 197);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Preferences";
            this.ShowIcon = false;
            this.Shown += new System.EventHandler(this.GetPrefs);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Dragging);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox BlenderExe;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox AnimationFormat;
        private System.Windows.Forms.ComboBox RenderFormat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ChannelID;
        private System.Windows.Forms.TextBox ProjectsDir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.OpenFileDialog OpenBlender;
    }
}