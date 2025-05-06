
namespace CarRace
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.Exit = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.play = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.RoadEd = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ScoreEd = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.RedLine = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.RedLine)).BeginInit();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.Animated = true;
            this.Exit.AnimatedGIF = true;
            this.Exit.BackColor = System.Drawing.Color.Transparent;
            this.Exit.BorderColor = System.Drawing.Color.Maroon;
            this.Exit.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.Exit.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.CustomBorderColor = System.Drawing.Color.Maroon;
            this.Exit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Exit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Exit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Exit.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Exit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Exit.FillColor = System.Drawing.Color.DarkBlue;
            this.Exit.FillColor2 = System.Drawing.Color.Red;
            this.Exit.FocusedColor = System.Drawing.Color.Blue;
            this.Exit.Font = new System.Drawing.Font("Verdana", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Exit.ForeColor = System.Drawing.Color.NavajoWhite;
            this.Exit.Location = new System.Drawing.Point(300, 406);
            this.Exit.Name = "Exit";
            this.Exit.ShadowDecoration.BorderRadius = 20;
            this.Exit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Exit.Size = new System.Drawing.Size(130, 130);
            this.Exit.TabIndex = 5;
            this.Exit.Text = "HOME";
            this.Exit.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixel;
            this.Exit.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // play
            // 
            this.play.Animated = true;
            this.play.AnimatedGIF = true;
            this.play.BackColor = System.Drawing.Color.Transparent;
            this.play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.play.BorderColor = System.Drawing.Color.Maroon;
            this.play.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.play.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.play.CustomBorderColor = System.Drawing.Color.Maroon;
            this.play.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.play.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.play.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.play.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.play.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.play.FillColor = System.Drawing.Color.DarkBlue;
            this.play.FillColor2 = System.Drawing.Color.Red;
            this.play.FocusedColor = System.Drawing.Color.Blue;
            this.play.Font = new System.Drawing.Font("Verdana", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.play.ForeColor = System.Drawing.Color.NavajoWhite;
            this.play.Location = new System.Drawing.Point(153, 406);
            this.play.Name = "play";
            this.play.ShadowDecoration.BorderRadius = 20;
            this.play.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.play.Size = new System.Drawing.Size(130, 130);
            this.play.TabIndex = 4;
            this.play.Text = "play";
            this.play.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixel;
            this.play.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // RoadEd
            // 
            this.RoadEd.BackColor = System.Drawing.Color.Transparent;
            this.RoadEd.BackgroundImage = global::CarRace.Properties.Resources.Untitled_1;
            this.RoadEd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RoadEd.Enabled = false;
            this.RoadEd.Font = new System.Drawing.Font("Bahnschrift SemiBold", 25F, System.Drawing.FontStyle.Bold);
            this.RoadEd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(205)))), ((int)(((byte)(249)))));
            this.RoadEd.Location = new System.Drawing.Point(219, 38);
            this.RoadEd.Name = "RoadEd";
            this.RoadEd.Size = new System.Drawing.Size(159, 42);
            this.RoadEd.TabIndex = 6;
            this.RoadEd.Text = "Road : 0 m";
            this.RoadEd.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.RoadEd.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            // 
            // ScoreEd
            // 
            this.ScoreEd.BackColor = System.Drawing.Color.Transparent;
            this.ScoreEd.BackgroundImage = global::CarRace.Properties.Resources.Untitled_1;
            this.ScoreEd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ScoreEd.Enabled = false;
            this.ScoreEd.Font = new System.Drawing.Font("Bahnschrift SemiBold", 25.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ScoreEd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(205)))), ((int)(((byte)(249)))));
            this.ScoreEd.Location = new System.Drawing.Point(209, 86);
            this.ScoreEd.Name = "ScoreEd";
            this.ScoreEd.Size = new System.Drawing.Size(176, 43);
            this.ScoreEd.TabIndex = 6;
            this.ScoreEd.Text = "Score : 0 m";
            this.ScoreEd.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // RedLine
            // 
            this.RedLine.BackColor = System.Drawing.Color.Transparent;
            this.RedLine.Image = global::CarRace.Properties.Resources.Untitled_11;
            this.RedLine.Location = new System.Drawing.Point(12, 3);
            this.RedLine.Name = "RedLine";
            this.RedLine.Size = new System.Drawing.Size(100, 50);
            this.RedLine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.RedLine.TabIndex = 7;
            this.RedLine.TabStop = false;
            this.RedLine.Visible = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::CarRace.Properties.Resources._52b3dbcd36a0718eb07170d118f9d9a2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.RedLine);
            this.Controls.Add(this.ScoreEd);
            this.Controls.Add(this.RoadEd);
            this.Controls.Add(this.play);
            this.Controls.Add(this.Exit);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rawi Rush";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RedLine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2GradientCircleButton Exit;
        private Guna.UI2.WinForms.Guna2GradientCircleButton play;
        private Guna.UI2.WinForms.Guna2HtmlLabel RoadEd;
        private Guna.UI2.WinForms.Guna2HtmlLabel ScoreEd;
        private System.Windows.Forms.PictureBox RedLine;
    }
}