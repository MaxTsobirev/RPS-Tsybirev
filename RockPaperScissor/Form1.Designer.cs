namespace RPS_Tsõbirev
{
    partial class Form1
    {

        private System.ComponentModel.IContainer components = null;

       
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


        private void InitializeComponent()
        {
            this.picPaper = new System.Windows.Forms.PictureBox();
            this.picScissor = new System.Windows.Forms.PictureBox();
            this.picRock = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblplayer = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblComputerResult = new System.Windows.Forms.Label();
            this.lblComputer = new System.Windows.Forms.Label();
            this.picComputer = new System.Windows.Forms.PictureBox();
            this.picPlayer = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPaper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picScissor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picComputer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // picPaper
            // 
            this.picPaper.Image = global::RPS_Tsõbirev.Properties.Resources.paper1;
            this.picPaper.Location = new System.Drawing.Point(28, 76);
            this.picPaper.Name = "picPaper";
            this.picPaper.Size = new System.Drawing.Size(132, 125);
            this.picPaper.TabIndex = 2;
            this.picPaper.TabStop = false;
            this.picPaper.Click += new System.EventHandler(this.player_click);
            // 
            // picScissor
            // 
            this.picScissor.Image = global::RPS_Tsõbirev.Properties.Resources.scissor;
            this.picScissor.Location = new System.Drawing.Point(248, 76);
            this.picScissor.Name = "picScissor";
            this.picScissor.Size = new System.Drawing.Size(132, 125);
            this.picScissor.TabIndex = 1;
            this.picScissor.TabStop = false;
            this.picScissor.Click += new System.EventHandler(this.player_click);
            // 
            // picRock
            // 
            this.picRock.Image = global::RPS_Tsõbirev.Properties.Resources.hands_and_gestures__1_;
            this.picRock.Location = new System.Drawing.Point(453, 76);
            this.picRock.Name = "picRock";
            this.picRock.Size = new System.Drawing.Size(132, 125);
            this.picRock.TabIndex = 0;
            this.picRock.TabStop = false;
            this.picRock.Click += new System.EventHandler(this.player_click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "Choose to play";
            // 
            // lblchel
            // 
            this.lblplayer.AutoSize = true;
            this.lblplayer.Location = new System.Drawing.Point(24, 440);
            this.lblplayer.Name = "lblplayer";
            this.lblplayer.Size = new System.Drawing.Size(91, 21);
            this.lblplayer.TabIndex = 5;
            this.lblplayer.Text = "Sinu tulemus";
            // 
            // lblRezultat
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(121, 440);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(28, 21);
            this.lblResult.TabIndex = 6;
            this.lblResult.Text = ": 0";
            // 
            // lblBOTrezultat
            // 
            this.lblComputerResult.AutoSize = true;
            this.lblComputerResult.Location = new System.Drawing.Point(570, 440);
            this.lblComputerResult.Name = "lblComputerResult";
            this.lblComputerResult.Size = new System.Drawing.Size(28, 21);
            this.lblComputerResult.TabIndex = 8;
            this.lblComputerResult.Text = ": 0";
            // 
            // lblBOT
            // 
            this.lblComputer.AutoSize = true;
            this.lblComputer.Location = new System.Drawing.Point(434, 440);
            this.lblComputer.Name = "lblComputer";
            this.lblComputer.Size = new System.Drawing.Size(130, 21);
            this.lblComputer.TabIndex = 7;
            this.lblComputer.Text = "Arvuti tulemus";
            // 
            // picComputer
            // 
            this.picComputer.InitialImage = null;
            this.picComputer.Location = new System.Drawing.Point(453, 282);
            this.picComputer.Name = "picComputer";
            this.picComputer.Size = new System.Drawing.Size(132, 125);
            this.picComputer.TabIndex = 9;
            this.picComputer.TabStop = false;
            // 
            // picPlayer
            // 
            this.picPlayer.InitialImage = global::RPS_Tsõbirev.Properties.Resources.rock;
            this.picPlayer.Location = new System.Drawing.Point(28, 282);
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.Size = new System.Drawing.Size(132, 125);
            this.picPlayer.TabIndex = 10;
            this.picPlayer.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 499);
            this.Controls.Add(this.picPlayer);
            this.Controls.Add(this.picComputer);
            this.Controls.Add(this.lblComputerResult);
            this.Controls.Add(this.lblComputer);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblplayer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picPaper);
            this.Controls.Add(this.picScissor);
            this.Controls.Add(this.picRock);
            this.Name = "Form1";
            this.Text = "Game";
            ((System.ComponentModel.ISupportInitialize)(this.picPaper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picScissor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picComputer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picRock;
        private System.Windows.Forms.PictureBox picScissor;
        private System.Windows.Forms.PictureBox picPaper;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblplayer;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblComputerResult;
        private System.Windows.Forms.Label lblComputer;
        private System.Windows.Forms.PictureBox picComputer;
        private System.Windows.Forms.PictureBox picPlayer;
    }
}