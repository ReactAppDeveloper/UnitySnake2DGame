namespace Snake
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pbCanvas = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblGameOver = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lEVElToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fASTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mEDIUMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sLOWToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutDeveloperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pAUSEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resumeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbCanvas
            // 
            this.pbCanvas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbCanvas.BackColor = System.Drawing.Color.Red;
            this.pbCanvas.ErrorImage = null;
            this.pbCanvas.InitialImage = null;
            this.pbCanvas.Location = new System.Drawing.Point(5, 29);
            this.pbCanvas.Name = "pbCanvas";
            this.pbCanvas.Size = new System.Drawing.Size(580, 461);
            this.pbCanvas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbCanvas.TabIndex = 0;
            this.pbCanvas.TabStop = false;
            this.pbCanvas.Click += new System.EventHandler(this.pbCanvas_Click);
            this.pbCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.pbCanvas_Paint);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Font = new System.Drawing.Font("Sitka Banner", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(658, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = "Points";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Showcard Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.Chartreuse;
            this.lblScore.Location = new System.Drawing.Point(779, 261);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(0, 46);
            this.lblScore.TabIndex = 2;
            // 
            // lblGameOver
            // 
            this.lblGameOver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGameOver.AutoSize = true;
            this.lblGameOver.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblGameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameOver.ForeColor = System.Drawing.Color.Black;
            this.lblGameOver.Location = new System.Drawing.Point(626, 311);
            this.lblGameOver.Margin = new System.Windows.Forms.Padding(0);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(109, 39);
            this.lblGameOver.TabIndex = 3;
            this.lblGameOver.Text = "label2";
            this.lblGameOver.Visible = false;
            this.lblGameOver.Click += new System.EventHandler(this.lblGameOver_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(589, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "MYSELF";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(591, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "HIGHEST SCORE";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.pAUSEToolStripMenuItem,
            this.resumeToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.Crimson;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(43, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlText;
            this.newGameToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newGameToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newGameToolStripMenuItem.Text = "TRY AGAIN";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlText;
            this.exitToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "CLOSE";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutMeToolStripMenuItem,
            this.lEVElToolStripMenuItem});
            this.helpToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpToolStripMenuItem.ForeColor = System.Drawing.Color.Crimson;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(63, 22);
            this.helpToolStripMenuItem.Text = "Option";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // aboutMeToolStripMenuItem
            // 
            this.aboutMeToolStripMenuItem.BackColor = System.Drawing.SystemColors.HotTrack;
            this.aboutMeToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.aboutMeToolStripMenuItem.Name = "aboutMeToolStripMenuItem";
            this.aboutMeToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.aboutMeToolStripMenuItem.Text = "HIGEST SCORE";
            this.aboutMeToolStripMenuItem.Click += new System.EventHandler(this.aboutMeToolStripMenuItem_Click);
            // 
            // lEVElToolStripMenuItem
            // 
            this.lEVElToolStripMenuItem.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lEVElToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fASTToolStripMenuItem,
            this.mEDIUMToolStripMenuItem,
            this.sLOWToolStripMenuItem});
            this.lEVElToolStripMenuItem.Name = "lEVElToolStripMenuItem";
            this.lEVElToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.lEVElToolStripMenuItem.Text = "LEVEL";
            // 
            // fASTToolStripMenuItem
            // 
            this.fASTToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlText;
            this.fASTToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.fASTToolStripMenuItem.Name = "fASTToolStripMenuItem";
            this.fASTToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.fASTToolStripMenuItem.Text = "FAST";
            this.fASTToolStripMenuItem.Click += new System.EventHandler(this.fASTToolStripMenuItem_Click);
            // 
            // mEDIUMToolStripMenuItem
            // 
            this.mEDIUMToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlText;
            this.mEDIUMToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.mEDIUMToolStripMenuItem.Name = "mEDIUMToolStripMenuItem";
            this.mEDIUMToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.mEDIUMToolStripMenuItem.Text = "MEDIUM";
            this.mEDIUMToolStripMenuItem.Click += new System.EventHandler(this.mEDIUMToolStripMenuItem_Click);
            // 
            // sLOWToolStripMenuItem
            // 
            this.sLOWToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlText;
            this.sLOWToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.sLOWToolStripMenuItem.Name = "sLOWToolStripMenuItem";
            this.sLOWToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.sLOWToolStripMenuItem.Text = "SLOW";
            this.sLOWToolStripMenuItem.Click += new System.EventHandler(this.sLOWToolStripMenuItem_Click);
            // 
            // aboutDeveloperToolStripMenuItem
            // 
            this.aboutDeveloperToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.aboutDeveloperToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutDeveloperToolStripMenuItem.ForeColor = System.Drawing.Color.Crimson;
            this.aboutDeveloperToolStripMenuItem.Name = "aboutDeveloperToolStripMenuItem";
            this.aboutDeveloperToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.aboutDeveloperToolStripMenuItem.Text = "About developer";
            this.aboutDeveloperToolStripMenuItem.Click += new System.EventHandler(this.aboutDeveloperToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.aboutDeveloperToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(929, 26);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pAUSEToolStripMenuItem
            // 
            this.pAUSEToolStripMenuItem.Name = "pAUSEToolStripMenuItem";
            this.pAUSEToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pAUSEToolStripMenuItem.Text = "PAUSE";
            this.pAUSEToolStripMenuItem.Click += new System.EventHandler(this.pAUSEToolStripMenuItem_Click);
            // 
            // resumeToolStripMenuItem
            // 
            this.resumeToolStripMenuItem.Name = "resumeToolStripMenuItem";
            this.resumeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.resumeToolStripMenuItem.Text = "Resume";
            this.resumeToolStripMenuItem.Click += new System.EventHandler(this.resumeToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(929, 493);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblGameOver);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbCanvas);
            this.Controls.Add(this.menuStrip1);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snake Game";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCanvas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblGameOver;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutMeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lEVElToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fASTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mEDIUMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sLOWToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutDeveloperToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem pAUSEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resumeToolStripMenuItem;
    }
}

