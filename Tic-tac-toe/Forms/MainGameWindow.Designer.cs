using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Tic_tac_toe.Forms
{
    partial class MainGameWindow
    {

        private System.ComponentModel.IContainer components = null;


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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainGameWindow));
            this.ButtonB1 = new System.Windows.Forms.Button();
            this.ButtonA1 = new System.Windows.Forms.Button();
            this.ButtonC1 = new System.Windows.Forms.Button();
            this.ButtonC2 = new System.Windows.Forms.Button();
            this.ButtonA2 = new System.Windows.Forms.Button();
            this.ButtonB2 = new System.Windows.Forms.Button();
            this.ButtonC3 = new System.Windows.Forms.Button();
            this.ButtonA3 = new System.Windows.Forms.Button();
            this.ButtonB3 = new System.Windows.Forms.Button();
            this.PlayerX = new System.Windows.Forms.Label();
            this.PlayerO = new System.Windows.Forms.Label();
            this.exitGame = new System.Windows.Forms.Button();
            this.resetGame = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.FirstGames = new System.Windows.Forms.Label();
            this.SecondGames = new System.Windows.Forms.Label();
            this.SecondWins = new System.Windows.Forms.Label();
            this.FirstWins = new System.Windows.Forms.Label();
            this.SecondName = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.B_startTraining = new System.Windows.Forms.Button();
            this.SecondScore = new System.Windows.Forms.Label();
            this.FirstScore = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.B_BackToStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonB1
            // 
            this.ButtonB1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.ButtonB1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonB1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.ButtonB1.Location = new System.Drawing.Point(363, 106);
            this.ButtonB1.Name = "ButtonB1";
            this.ButtonB1.Size = new System.Drawing.Size(75, 67);
            this.ButtonB1.TabIndex = 1;
            this.ButtonB1.Tag = "play";
            this.ButtonB1.Text = "\r\n";
            this.ButtonB1.UseVisualStyleBackColor = false;
            this.ButtonB1.Click += new System.EventHandler(this.gameButton4_Click);
            // 
            // ButtonA1
            // 
            this.ButtonA1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.ButtonA1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonA1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.ButtonA1.Location = new System.Drawing.Point(363, 33);
            this.ButtonA1.Name = "ButtonA1";
            this.ButtonA1.Size = new System.Drawing.Size(75, 67);
            this.ButtonA1.TabIndex = 2;
            this.ButtonA1.Tag = "play";
            this.ButtonA1.Text = "\r\n";
            this.ButtonA1.UseVisualStyleBackColor = false;
            this.ButtonA1.Click += new System.EventHandler(this.gameButton1_Click);
            // 
            // ButtonC1
            // 
            this.ButtonC1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.ButtonC1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonC1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.ButtonC1.Location = new System.Drawing.Point(363, 179);
            this.ButtonC1.Name = "ButtonC1";
            this.ButtonC1.Size = new System.Drawing.Size(75, 67);
            this.ButtonC1.TabIndex = 3;
            this.ButtonC1.Tag = "play";
            this.ButtonC1.UseVisualStyleBackColor = false;
            this.ButtonC1.Click += new System.EventHandler(this.gameButton7_Click);
            // 
            // ButtonC2
            // 
            this.ButtonC2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.ButtonC2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonC2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.ButtonC2.Location = new System.Drawing.Point(444, 179);
            this.ButtonC2.Name = "ButtonC2";
            this.ButtonC2.Size = new System.Drawing.Size(75, 67);
            this.ButtonC2.TabIndex = 6;
            this.ButtonC2.Tag = "play";
            this.ButtonC2.UseVisualStyleBackColor = false;
            this.ButtonC2.Click += new System.EventHandler(this.gameButton8_Click);
            // 
            // ButtonA2
            // 
            this.ButtonA2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.ButtonA2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonA2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.ButtonA2.Location = new System.Drawing.Point(444, 33);
            this.ButtonA2.Name = "ButtonA2";
            this.ButtonA2.Size = new System.Drawing.Size(75, 67);
            this.ButtonA2.TabIndex = 5;
            this.ButtonA2.Tag = "play";
            this.ButtonA2.UseVisualStyleBackColor = false;
            this.ButtonA2.Click += new System.EventHandler(this.gameButton2_Click);
            // 
            // ButtonB2
            // 
            this.ButtonB2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.ButtonB2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonB2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.ButtonB2.Location = new System.Drawing.Point(444, 106);
            this.ButtonB2.Name = "ButtonB2";
            this.ButtonB2.Size = new System.Drawing.Size(75, 67);
            this.ButtonB2.TabIndex = 4;
            this.ButtonB2.Tag = "play";
            this.ButtonB2.UseVisualStyleBackColor = false;
            this.ButtonB2.Click += new System.EventHandler(this.gameButton5_Click);
            // 
            // ButtonC3
            // 
            this.ButtonC3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.ButtonC3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonC3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.ButtonC3.Location = new System.Drawing.Point(525, 179);
            this.ButtonC3.Name = "ButtonC3";
            this.ButtonC3.Size = new System.Drawing.Size(75, 67);
            this.ButtonC3.TabIndex = 9;
            this.ButtonC3.Tag = "play";
            this.ButtonC3.UseVisualStyleBackColor = false;
            this.ButtonC3.Click += new System.EventHandler(this.gameButton9_Click);
            // 
            // ButtonA3
            // 
            this.ButtonA3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.ButtonA3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonA3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.ButtonA3.Location = new System.Drawing.Point(525, 33);
            this.ButtonA3.Name = "ButtonA3";
            this.ButtonA3.Size = new System.Drawing.Size(75, 67);
            this.ButtonA3.TabIndex = 8;
            this.ButtonA3.Tag = "play";
            this.ButtonA3.UseVisualStyleBackColor = false;
            this.ButtonA3.Click += new System.EventHandler(this.gameButton3_Click);
            // 
            // ButtonB3
            // 
            this.ButtonB3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.ButtonB3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonB3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.ButtonB3.Location = new System.Drawing.Point(525, 106);
            this.ButtonB3.Name = "ButtonB3";
            this.ButtonB3.Size = new System.Drawing.Size(75, 67);
            this.ButtonB3.TabIndex = 7;
            this.ButtonB3.Tag = "play";
            this.ButtonB3.UseVisualStyleBackColor = false;
            this.ButtonB3.Click += new System.EventHandler(this.gameButton6_Click);
            // 
            // PlayerX
            // 
            this.PlayerX.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.PlayerX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(99)))), ((int)(((byte)(153)))));
            this.PlayerX.Location = new System.Drawing.Point(85, 50);
            this.PlayerX.Name = "PlayerX";
            this.PlayerX.Size = new System.Drawing.Size(120, 39);
            this.PlayerX.TabIndex = 10;
            this.PlayerX.Text = "Player (X)";
            this.PlayerX.Click += new System.EventHandler(this.label1_Click);
            // 
            // PlayerO
            // 
            this.PlayerO.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.PlayerO.ForeColor = System.Drawing.Color.DodgerBlue;
            this.PlayerO.Location = new System.Drawing.Point(211, 44);
            this.PlayerO.Name = "PlayerO";
            this.PlayerO.Size = new System.Drawing.Size(135, 39);
            this.PlayerO.TabIndex = 11;
            this.PlayerO.Text = "Player (O)";
            this.PlayerO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exitGame
            // 
            this.exitGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.exitGame.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.exitGame.FlatAppearance.BorderSize = 4;
            this.exitGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitGame.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.exitGame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.exitGame.Location = new System.Drawing.Point(34, 308);
            this.exitGame.Name = "exitGame";
            this.exitGame.Size = new System.Drawing.Size(145, 64);
            this.exitGame.TabIndex = 12;
            this.exitGame.Text = "Exit";
            this.exitGame.UseVisualStyleBackColor = false;
            this.exitGame.Click += new System.EventHandler(this.exitGame_Click);
            // 
            // resetGame
            // 
            this.resetGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(159)))), ((int)(((byte)(171)))));
            this.resetGame.FlatAppearance.BorderSize = 2;
            this.resetGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetGame.Font = new System.Drawing.Font("Comic Sans MS", 12.25F, System.Drawing.FontStyle.Bold);
            this.resetGame.Location = new System.Drawing.Point(227, 296);
            this.resetGame.Name = "resetGame";
            this.resetGame.Size = new System.Drawing.Size(177, 41);
            this.resetGame.TabIndex = 13;
            this.resetGame.Text = "Start Usual";
            this.resetGame.UseVisualStyleBackColor = false;
            this.resetGame.Click += new System.EventHandler(this.resetGame_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(12, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 23);
            this.label3.TabIndex = 16;
            this.label3.Text = "Wins:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(12, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 23);
            this.label4.TabIndex = 21;
            this.label4.Text = "All Games:";
            // 
            // FirstGames
            // 
            this.FirstGames.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.FirstGames.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FirstGames.Location = new System.Drawing.Point(128, 139);
            this.FirstGames.Name = "FirstGames";
            this.FirstGames.Size = new System.Drawing.Size(51, 34);
            this.FirstGames.TabIndex = 22;
            this.FirstGames.Text = "[]";
            this.FirstGames.Click += new System.EventHandler(this.FirstGames_Click);
            // 
            // SecondGames
            // 
            this.SecondGames.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.SecondGames.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SecondGames.Location = new System.Drawing.Point(262, 139);
            this.SecondGames.Name = "SecondGames";
            this.SecondGames.Size = new System.Drawing.Size(63, 34);
            this.SecondGames.TabIndex = 23;
            this.SecondGames.Text = "[]";
            this.SecondGames.Click += new System.EventHandler(this.SecondGames_Click);
            // 
            // SecondWins
            // 
            this.SecondWins.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.SecondWins.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SecondWins.Location = new System.Drawing.Point(262, 176);
            this.SecondWins.Name = "SecondWins";
            this.SecondWins.Size = new System.Drawing.Size(63, 38);
            this.SecondWins.TabIndex = 25;
            this.SecondWins.Text = "[]";
            this.SecondWins.Click += new System.EventHandler(this.SecondWins_Click);
            // 
            // FirstWins
            // 
            this.FirstWins.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.FirstWins.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FirstWins.Location = new System.Drawing.Point(128, 176);
            this.FirstWins.Name = "FirstWins";
            this.FirstWins.Size = new System.Drawing.Size(51, 38);
            this.FirstWins.TabIndex = 24;
            this.FirstWins.Text = "[]";
            this.FirstWins.Click += new System.EventHandler(this.FirstWins_Click);
            // 
            // SecondName
            // 
            this.SecondName.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.SecondName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SecondName.Location = new System.Drawing.Point(262, 99);
            this.SecondName.Name = "SecondName";
            this.SecondName.Size = new System.Drawing.Size(84, 40);
            this.SecondName.TabIndex = 28;
            this.SecondName.Text = "[]";
            this.SecondName.Click += new System.EventHandler(this.SecondName_Click);
            // 
            // firstName
            // 
            this.firstName.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.firstName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.firstName.Location = new System.Drawing.Point(128, 99);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(91, 40);
            this.firstName.TabIndex = 27;
            this.firstName.Text = "[]";
            this.firstName.Click += new System.EventHandler(this.firstName_Click);
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(12, 99);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 23);
            this.label11.TabIndex = 26;
            this.label11.Text = "Name:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // B_startTraining
            // 
            this.B_startTraining.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(177)))), ((int)(((byte)(143)))));
            this.B_startTraining.FlatAppearance.BorderSize = 2;
            this.B_startTraining.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_startTraining.Font = new System.Drawing.Font("Comic Sans MS", 12.25F, System.Drawing.FontStyle.Bold);
            this.B_startTraining.Location = new System.Drawing.Point(227, 343);
            this.B_startTraining.Name = "B_startTraining";
            this.B_startTraining.Size = new System.Drawing.Size(177, 41);
            this.B_startTraining.TabIndex = 29;
            this.B_startTraining.Text = "Training game";
            this.B_startTraining.UseVisualStyleBackColor = false;
            this.B_startTraining.Click += new System.EventHandler(this.B_startTraining_Click);
            // 
            // SecondScore
            // 
            this.SecondScore.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.SecondScore.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SecondScore.Location = new System.Drawing.Point(262, 214);
            this.SecondScore.Name = "SecondScore";
            this.SecondScore.Size = new System.Drawing.Size(63, 32);
            this.SecondScore.TabIndex = 32;
            this.SecondScore.Text = "[]";
            this.SecondScore.Click += new System.EventHandler(this.SecondScore_Click);
            // 
            // FirstScore
            // 
            this.FirstScore.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.FirstScore.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FirstScore.Location = new System.Drawing.Point(128, 214);
            this.FirstScore.Name = "FirstScore";
            this.FirstScore.Size = new System.Drawing.Size(51, 32);
            this.FirstScore.TabIndex = 31;
            this.FirstScore.Text = "[]";
            this.FirstScore.Click += new System.EventHandler(this.FirstScore_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(12, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 23);
            this.label5.TabIndex = 30;
            this.label5.Text = "Score:";
            // 
            // B_BackToStart
            // 
            this.B_BackToStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.B_BackToStart.FlatAppearance.BorderSize = 2;
            this.B_BackToStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_BackToStart.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.B_BackToStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.B_BackToStart.Location = new System.Drawing.Point(478, 316);
            this.B_BackToStart.Margin = new System.Windows.Forms.Padding(2);
            this.B_BackToStart.Name = "B_BackToStart";
            this.B_BackToStart.Size = new System.Drawing.Size(76, 49);
            this.B_BackToStart.TabIndex = 33;
            this.B_BackToStart.Text = "Back";
            this.B_BackToStart.UseVisualStyleBackColor = false;
            this.B_BackToStart.Click += new System.EventHandler(this.B_BackToStart_Click);
            // 
            // MainGameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(612, 414);
            this.Controls.Add(this.B_BackToStart);
            this.Controls.Add(this.SecondScore);
            this.Controls.Add(this.FirstScore);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.B_startTraining);
            this.Controls.Add(this.SecondName);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.SecondWins);
            this.Controls.Add(this.FirstWins);
            this.Controls.Add(this.SecondGames);
            this.Controls.Add(this.FirstGames);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.resetGame);
            this.Controls.Add(this.exitGame);
            this.Controls.Add(this.PlayerO);
            this.Controls.Add(this.PlayerX);
            this.Controls.Add(this.ButtonC3);
            this.Controls.Add(this.ButtonA3);
            this.Controls.Add(this.ButtonB3);
            this.Controls.Add(this.ButtonC2);
            this.Controls.Add(this.ButtonA2);
            this.Controls.Add(this.ButtonB2);
            this.Controls.Add(this.ButtonC1);
            this.Controls.Add(this.ButtonA1);
            this.Controls.Add(this.ButtonB1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainGameWindow";
            this.Text = "Game";
            this.Load += new System.EventHandler(this.MainGameWindow_Load);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button B_BackToStart;

        private System.Windows.Forms.Label SecondScore;
        private System.Windows.Forms.Label FirstScore;
        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.Button B_startTraining;

        private System.Windows.Forms.Label FirstGames;
        private System.Windows.Forms.Label SecondGames;
        private System.Windows.Forms.Label SecondWins;
        private System.Windows.Forms.Label FirstWins;
        private System.Windows.Forms.Label SecondName;
        private System.Windows.Forms.Label firstName;
        private System.Windows.Forms.Label label11;

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Label PlayerO;
        private System.Windows.Forms.Button exitGame;
        private System.Windows.Forms.Button resetGame;

        private System.Windows.Forms.Button ButtonA1;
        private System.Windows.Forms.Button ButtonB1;
        private System.Windows.Forms.Button ButtonC1;
        private System.Windows.Forms.Button ButtonC2;
        private System.Windows.Forms.Button ButtonA2;
        private System.Windows.Forms.Button ButtonB2;
        private System.Windows.Forms.Button ButtonC3;
        private System.Windows.Forms.Button ButtonA3;
        private System.Windows.Forms.Button ButtonB3;
        private System.Windows.Forms.Label PlayerX;

        #endregion
    }
}