namespace BlenderBot
{
    partial class StartupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartupForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Exit = new System.Windows.Forms.Button();
            this.Animation = new System.Windows.Forms.Button();
            this.Render = new System.Windows.Forms.Button();
            this.Preferences = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Controls.Add(this.Exit, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.Animation, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.Render, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Preferences, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(145, 248);
            this.tableLayoutPanel1.TabIndex = 5;
            this.tableLayoutPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Dragging);
            // 
            // Exit
            // 
            this.Exit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Exit.AutoSize = true;
            this.Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.Image = global::BlenderBot.Properties.Resources.Exit;
            this.Exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Exit.Location = new System.Drawing.Point(22, 218);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(100, 27);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "Exit";
            this.Exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Animation
            // 
            this.Animation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Animation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Animation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Animation.Enabled = false;
            this.Animation.Image = ((System.Drawing.Image)(resources.GetObject("Animation.Image")));
            this.Animation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Animation.Location = new System.Drawing.Point(22, 152);
            this.Animation.Name = "Animation";
            this.Animation.Size = new System.Drawing.Size(100, 27);
            this.Animation.TabIndex = 1;
            this.Animation.Text = "Animation";
            this.Animation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Animation.UseVisualStyleBackColor = true;
            this.Animation.Click += new System.EventHandler(this.Animation_Click);
            // 
            // Render
            // 
            this.Render.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Render.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Render.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Render.Image = ((System.Drawing.Image)(resources.GetObject("Render.Image")));
            this.Render.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Render.Location = new System.Drawing.Point(22, 119);
            this.Render.Name = "Render";
            this.Render.Size = new System.Drawing.Size(100, 27);
            this.Render.TabIndex = 0;
            this.Render.Text = "Render";
            this.Render.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Render.UseVisualStyleBackColor = true;
            this.Render.Click += new System.EventHandler(this.Render_Click);
            // 
            // Preferences
            // 
            this.Preferences.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Preferences.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Preferences.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Preferences.Image = global::BlenderBot.Properties.Resources.Prefs;
            this.Preferences.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Preferences.Location = new System.Drawing.Point(22, 185);
            this.Preferences.Name = "Preferences";
            this.Preferences.Size = new System.Drawing.Size(100, 27);
            this.Preferences.TabIndex = 2;
            this.Preferences.Text = "Preferences";
            this.Preferences.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Preferences.UseVisualStyleBackColor = true;
            this.Preferences.Click += new System.EventHandler(this.Prefs_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Dragging);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(149, 252);
            this.panel1.TabIndex = 6;
            // 
            // StartupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(159, 262);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StartupForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Dragging);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button Animation;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Render;
        private System.Windows.Forms.Button Preferences;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
    }
}