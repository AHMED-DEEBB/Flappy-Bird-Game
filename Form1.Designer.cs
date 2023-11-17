namespace FlappyBirdGame
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
            this.land = new System.Windows.Forms.PictureBox();
            this.buttomTube = new System.Windows.Forms.PictureBox();
            this.topTube = new System.Windows.Forms.PictureBox();
            this.flappy = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Start = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.land)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttomTube)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topTube)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappy)).BeginInit();
            this.SuspendLayout();
            // 
            // land
            // 
            this.land.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.land, "land");
            this.land.Name = "land";
            this.land.TabStop = false;
            // 
            // buttomTube
            // 
            this.buttomTube.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.buttomTube, "buttomTube");
            this.buttomTube.Name = "buttomTube";
            this.buttomTube.TabStop = false;
            // 
            // topTube
            // 
            this.topTube.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.topTube, "topTube");
            this.topTube.Name = "topTube";
            this.topTube.TabStop = false;
            // 
            // flappy
            // 
            this.flappy.BackColor = System.Drawing.Color.Transparent;
            this.flappy.Cursor = System.Windows.Forms.Cursors.PanNorth;
            resources.ApplyResources(this.flappy, "flappy");
            this.flappy.Name = "flappy";
            this.flappy.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Start
            // 
            resources.ApplyResources(this.Start, "Start");
            this.Start.BackColor = System.Drawing.Color.YellowGreen;
            this.Start.FlatAppearance.BorderColor = System.Drawing.Color.LawnGreen;
            this.Start.FlatAppearance.BorderSize = 5;
            this.Start.ForeColor = System.Drawing.Color.Green;
            this.Start.Name = "Start";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // lblScore
            // 
            resources.ApplyResources(this.lblScore, "lblScore");
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblScore.Name = "lblScore";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.land);
            this.Controls.Add(this.buttomTube);
            this.Controls.Add(this.topTube);
            this.Controls.Add(this.flappy);
            this.Cursor = System.Windows.Forms.Cursors.PanNorth;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.land)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttomTube)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topTube)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox flappy;
        private System.Windows.Forms.PictureBox land;
        private System.Windows.Forms.PictureBox topTube;
        private System.Windows.Forms.PictureBox buttomTube;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Label lblScore;
    }
}

