using System.ComponentModel;

namespace Tic_tac_toe.Forms
{
    partial class StartingWindow
    {
        private IContainer components = null;

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
            this.B_StarGame = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SecondOpponent = new System.Windows.Forms.ComboBox();
            this.FirstOpponent = new System.Windows.Forms.ComboBox();
            this.UserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Label_CreateUser = new System.Windows.Forms.Label();
            this.B_CreateUser = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.B_History = new System.Windows.Forms.Button();
            this.create_Vip_Account = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // B_StarGame
            // 
            this.B_StarGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(100)))), ((int)(((byte)(163)))));
            this.B_StarGame.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F);
            this.B_StarGame.Location = new System.Drawing.Point(116, 223);
            this.B_StarGame.Margin = new System.Windows.Forms.Padding(2);
            this.B_StarGame.Name = "B_StarGame";
            this.B_StarGame.Size = new System.Drawing.Size(164, 65);
            this.B_StarGame.TabIndex = 0;
            this.B_StarGame.Text = "Start Game";
            this.B_StarGame.UseVisualStyleBackColor = false;
            this.B_StarGame.Click += new System.EventHandler(this.B_StarGame_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 24F);
            this.label1.Location = new System.Drawing.Point(68, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "VS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SecondOpponent
            // 
            this.SecondOpponent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SecondOpponent.FormattingEnabled = true;
            this.SecondOpponent.Location = new System.Drawing.Point(67, 139);
            this.SecondOpponent.Margin = new System.Windows.Forms.Padding(2);
            this.SecondOpponent.Name = "SecondOpponent";
            this.SecondOpponent.Size = new System.Drawing.Size(92, 25);
            this.SecondOpponent.TabIndex = 2;
            this.SecondOpponent.Click += new System.EventHandler(this.SecondOpponent_Click);
            // 
            // FirstOpponent
            // 
            this.FirstOpponent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FirstOpponent.FormattingEnabled = true;
            this.FirstOpponent.Location = new System.Drawing.Point(67, 53);
            this.FirstOpponent.Margin = new System.Windows.Forms.Padding(2);
            this.FirstOpponent.Name = "FirstOpponent";
            this.FirstOpponent.Size = new System.Drawing.Size(92, 24);
            this.FirstOpponent.TabIndex = 3;
            this.FirstOpponent.Click += new System.EventHandler(this.FirstOpponent_Click);
            // 
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(279, 89);
            this.UserName.Margin = new System.Windows.Forms.Padding(2);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(127, 20);
            this.UserName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F);
            this.label2.Location = new System.Drawing.Point(20, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Choose opponents";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Label_CreateUser
            // 
            this.Label_CreateUser.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F);
            this.Label_CreateUser.Location = new System.Drawing.Point(275, 25);
            this.Label_CreateUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label_CreateUser.Name = "Label_CreateUser";
            this.Label_CreateUser.Size = new System.Drawing.Size(184, 26);
            this.Label_CreateUser.TabIndex = 6;
            this.Label_CreateUser.Text = "Create user. Input name";
            this.Label_CreateUser.Click += new System.EventHandler(this.Label_CreateUser_Click);
            // 
            // B_CreateUser
            // 
            this.B_CreateUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(205)))), ((int)(((byte)(176)))));
            this.B_CreateUser.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F);
            this.B_CreateUser.Location = new System.Drawing.Point(279, 113);
            this.B_CreateUser.Margin = new System.Windows.Forms.Padding(2);
            this.B_CreateUser.Name = "B_CreateUser";
            this.B_CreateUser.Size = new System.Drawing.Size(127, 36);
            this.B_CreateUser.TabIndex = 7;
            this.B_CreateUser.Text = "Create Usual User";
            this.B_CreateUser.UseVisualStyleBackColor = false;
            this.B_CreateUser.Click += new System.EventHandler(this.B_CreateUser_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F);
            this.label3.Location = new System.Drawing.Point(9, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "X";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F);
            this.label4.Location = new System.Drawing.Point(9, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "O";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // B_History
            // 
            this.B_History.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(91)))), ((int)(((byte)(99)))));
            this.B_History.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F);
            this.B_History.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(232)))), ((int)(((byte)(238)))));
            this.B_History.Location = new System.Drawing.Point(285, 223);
            this.B_History.Name = "B_History";
            this.B_History.Size = new System.Drawing.Size(82, 65);
            this.B_History.TabIndex = 10;
            this.B_History.Text = "History";
            this.B_History.UseVisualStyleBackColor = false;
            this.B_History.Click += new System.EventHandler(this.B_History_Click);
            // 
            // create_Vip_Account
            // 
            this.create_Vip_Account.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(155)))), ((int)(((byte)(121)))));
            this.create_Vip_Account.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F);
            this.create_Vip_Account.Location = new System.Drawing.Point(279, 53);
            this.create_Vip_Account.Name = "create_Vip_Account";
            this.create_Vip_Account.Size = new System.Drawing.Size(127, 31);
            this.create_Vip_Account.TabIndex = 11;
            this.create_Vip_Account.Text = "Vip User";
            this.create_Vip_Account.UseVisualStyleBackColor = false;
            this.create_Vip_Account.Click += new System.EventHandler(this.create_Vip_Account_Click);
            // 
            // StartingWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(232)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(454, 313);
            this.Controls.Add(this.create_Vip_Account);
            this.Controls.Add(this.B_History);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.B_CreateUser);
            this.Controls.Add(this.Label_CreateUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.FirstOpponent);
            this.Controls.Add(this.SecondOpponent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.B_StarGame);
            this.Location = new System.Drawing.Point(15, 15);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "StartingWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button create_Vip_Account;

        private System.Windows.Forms.Button B_History;

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Button B_CreateUser;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Label_CreateUser;

        private System.Windows.Forms.TextBox UserName;

        private System.Windows.Forms.Button B_StarGame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox SecondOpponent;
        private System.Windows.Forms.ComboBox FirstOpponent;

        #endregion
    }
}