namespace FlappyBird
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
            this.scoreLabel = new System.Windows.Forms.Label();
            this.scoreText = new System.Windows.Forms.Label();
            this.ground = new System.Windows.Forms.PictureBox();
            this.birdPlayer = new System.Windows.Forms.PictureBox();
            this.obstacleBottom = new System.Windows.Forms.PictureBox();
            this.obstacleTop = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.birdPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacleBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacleTop)).BeginInit();
            this.SuspendLayout();
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Ravie", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.Location = new System.Drawing.Point(12, 9);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(97, 26);
            this.scoreLabel.TabIndex = 0;
            this.scoreLabel.Text = "Score:";
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.Font = new System.Drawing.Font("Old English Text MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreText.Location = new System.Drawing.Point(114, 4);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(29, 32);
            this.scoreText.TabIndex = 1;
            this.scoreText.Text = "0";
            // 
            // ground
            // 
            this.ground.BackgroundImage = global::FlappyBird.Properties.Resources.ground;
            this.ground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ground.Location = new System.Drawing.Point(-4, 498);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(942, 196);
            this.ground.TabIndex = 5;
            this.ground.TabStop = false;
            // 
            // birdPlayer
            // 
            this.birdPlayer.BackColor = System.Drawing.Color.Transparent;
            this.birdPlayer.BackgroundImage = global::FlappyBird.Properties.Resources.bird;
            this.birdPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.birdPlayer.Location = new System.Drawing.Point(76, 233);
            this.birdPlayer.Name = "birdPlayer";
            this.birdPlayer.Size = new System.Drawing.Size(67, 62);
            this.birdPlayer.TabIndex = 4;
            this.birdPlayer.TabStop = false;
            // 
            // obstacleBottom
            // 
            this.obstacleBottom.BackgroundImage = global::FlappyBird.Properties.Resources.pipebottom;
            this.obstacleBottom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.obstacleBottom.Location = new System.Drawing.Point(592, 349);
            this.obstacleBottom.Name = "obstacleBottom";
            this.obstacleBottom.Size = new System.Drawing.Size(98, 155);
            this.obstacleBottom.TabIndex = 3;
            this.obstacleBottom.TabStop = false;
            // 
            // obstacleTop
            // 
            this.obstacleTop.BackgroundImage = global::FlappyBird.Properties.Resources.pipetop;
            this.obstacleTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.obstacleTop.Location = new System.Drawing.Point(398, -1);
            this.obstacleTop.Name = "obstacleTop";
            this.obstacleTop.Size = new System.Drawing.Size(98, 155);
            this.obstacleTop.TabIndex = 2;
            this.obstacleTop.TabStop = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 50;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.birdPlayer);
            this.Controls.Add(this.obstacleBottom);
            this.Controls.Add(this.obstacleTop);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.scoreLabel);
            this.Name = "Form1";
            this.Text = "FlappyBird";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.birdPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacleBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacleTop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.PictureBox obstacleTop;
        private System.Windows.Forms.PictureBox obstacleBottom;
        private System.Windows.Forms.PictureBox birdPlayer;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.Timer gameTimer;
    }
}

