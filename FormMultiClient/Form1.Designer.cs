namespace FormMultiClient
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
            this.Connect = new System.Windows.Forms.Button();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.UserNameTB = new System.Windows.Forms.TextBox();
            this.GameNameLabel = new System.Windows.Forms.Label();
            this.LogInBtn = new System.Windows.Forms.Button();
            this.logInPanal = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.CreateRoomBtn = new System.Windows.Forms.Button();
            this.WatchBtn = new System.Windows.Forms.Button();
            this.ChoicePanal = new System.Windows.Forms.Panel();
            this.PlayBtn = new System.Windows.Forms.Button();
            this.RoomsListLabel = new System.Windows.Forms.Label();
            this.RoomsListLB = new System.Windows.Forms.ListBox();
            this.RoomsPanel = new System.Windows.Forms.Panel();
            this.ConnectBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.CreateRoomPanel = new System.Windows.Forms.Panel();
            this.PlayersLB = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.WatchPanal = new System.Windows.Forms.Panel();
            this.StartWatchingBtn = new System.Windows.Forms.Button();
            this.StartWatchLB = new System.Windows.Forms.ListBox();
            this.chooseRoom = new System.Windows.Forms.Label();
            this.StartPlayPanel = new System.Windows.Forms.Panel();
            this.PlayRoomsLB = new System.Windows.Forms.ListBox();
            this.StartPlayingBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.logInPanal.SuspendLayout();
            this.ChoicePanal.SuspendLayout();
            this.RoomsPanel.SuspendLayout();
            this.CreateRoomPanel.SuspendLayout();
            this.WatchPanal.SuspendLayout();
            this.StartPlayPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Connect
            // 
            this.Connect.Font = new System.Drawing.Font("Tahoma", 12F);
            this.Connect.Location = new System.Drawing.Point(329, 192);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(142, 67);
            this.Connect.TabIndex = 0;
            this.Connect.Text = "CONNECT";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Font = new System.Drawing.Font("Tahoma", 16F);
            this.UserNameLabel.Location = new System.Drawing.Point(66, 142);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(135, 33);
            this.UserNameLabel.TabIndex = 1;
            this.UserNameLabel.Text = "Username";
            // 
            // UserNameTB
            // 
            this.UserNameTB.Font = new System.Drawing.Font("Tahoma", 14F);
            this.UserNameTB.Location = new System.Drawing.Point(238, 143);
            this.UserNameTB.Name = "UserNameTB";
            this.UserNameTB.Size = new System.Drawing.Size(243, 36);
            this.UserNameTB.TabIndex = 2;
            // 
            // GameNameLabel
            // 
            this.GameNameLabel.AutoSize = true;
            this.GameNameLabel.Font = new System.Drawing.Font("Tahoma", 18F);
            this.GameNameLabel.Location = new System.Drawing.Point(145, 57);
            this.GameNameLabel.Name = "GameNameLabel";
            this.GameNameLabel.Size = new System.Drawing.Size(266, 36);
            this.GameNameLabel.TabIndex = 3;
            this.GameNameLabel.Text = "GUESS THE WORD";
            // 
            // LogInBtn
            // 
            this.LogInBtn.Font = new System.Drawing.Font("Tahoma", 12F);
            this.LogInBtn.Location = new System.Drawing.Point(220, 226);
            this.LogInBtn.Name = "LogInBtn";
            this.LogInBtn.Size = new System.Drawing.Size(116, 48);
            this.LogInBtn.TabIndex = 4;
            this.LogInBtn.Text = "LogIn";
            this.LogInBtn.UseVisualStyleBackColor = true;
            this.LogInBtn.Click += new System.EventHandler(this.LogInBtn_Click);
            // 
            // logInPanal
            // 
            this.logInPanal.Controls.Add(this.LogInBtn);
            this.logInPanal.Controls.Add(this.GameNameLabel);
            this.logInPanal.Controls.Add(this.UserNameTB);
            this.logInPanal.Controls.Add(this.UserNameLabel);
            this.logInPanal.Location = new System.Drawing.Point(122, 70);
            this.logInPanal.Name = "logInPanal";
            this.logInPanal.Size = new System.Drawing.Size(557, 311);
            this.logInPanal.TabIndex = 1;
            this.logInPanal.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F);
            this.label1.Location = new System.Drawing.Point(145, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "GUESS THE WORD";
            // 
            // CreateRoomBtn
            // 
            this.CreateRoomBtn.Font = new System.Drawing.Font("Tahoma", 12F);
            this.CreateRoomBtn.Location = new System.Drawing.Point(19, 200);
            this.CreateRoomBtn.Name = "CreateRoomBtn";
            this.CreateRoomBtn.Size = new System.Drawing.Size(153, 48);
            this.CreateRoomBtn.TabIndex = 4;
            this.CreateRoomBtn.Text = "Create Room";
            this.CreateRoomBtn.UseVisualStyleBackColor = true;
            this.CreateRoomBtn.Click += new System.EventHandler(this.CreateRoomBtn_Click);
            // 
            // WatchBtn
            // 
            this.WatchBtn.Font = new System.Drawing.Font("Tahoma", 12F);
            this.WatchBtn.Location = new System.Drawing.Point(202, 200);
            this.WatchBtn.Name = "WatchBtn";
            this.WatchBtn.Size = new System.Drawing.Size(153, 48);
            this.WatchBtn.TabIndex = 5;
            this.WatchBtn.Text = "Watch";
            this.WatchBtn.UseVisualStyleBackColor = true;
            this.WatchBtn.Click += new System.EventHandler(this.WatchBtn_Click);
            // 
            // ChoicePanal
            // 
            this.ChoicePanal.Controls.Add(this.PlayBtn);
            this.ChoicePanal.Controls.Add(this.WatchBtn);
            this.ChoicePanal.Controls.Add(this.CreateRoomBtn);
            this.ChoicePanal.Controls.Add(this.label1);
            this.ChoicePanal.Location = new System.Drawing.Point(122, 70);
            this.ChoicePanal.Name = "ChoicePanal";
            this.ChoicePanal.Size = new System.Drawing.Size(557, 311);
            this.ChoicePanal.TabIndex = 5;
            this.ChoicePanal.Visible = false;
            // 
            // PlayBtn
            // 
            this.PlayBtn.Font = new System.Drawing.Font("Tahoma", 12F);
            this.PlayBtn.Location = new System.Drawing.Point(385, 200);
            this.PlayBtn.Name = "PlayBtn";
            this.PlayBtn.Size = new System.Drawing.Size(153, 48);
            this.PlayBtn.TabIndex = 5;
            this.PlayBtn.Text = "Play";
            this.PlayBtn.UseVisualStyleBackColor = true;
            this.PlayBtn.Click += new System.EventHandler(this.PlayBtn_Click);
            // 
            // RoomsListLabel
            // 
            this.RoomsListLabel.AutoSize = true;
            this.RoomsListLabel.Font = new System.Drawing.Font("Tahoma", 16F);
            this.RoomsListLabel.Location = new System.Drawing.Point(206, 24);
            this.RoomsListLabel.Name = "RoomsListLabel";
            this.RoomsListLabel.Size = new System.Drawing.Size(145, 33);
            this.RoomsListLabel.TabIndex = 0;
            this.RoomsListLabel.Text = "Rooms List";
            // 
            // RoomsListLB
            // 
            this.RoomsListLB.Font = new System.Drawing.Font("Tahoma", 12F);
            this.RoomsListLB.FormattingEnabled = true;
            this.RoomsListLB.ItemHeight = 24;
            this.RoomsListLB.Location = new System.Drawing.Point(19, 76);
            this.RoomsListLB.Name = "RoomsListLB";
            this.RoomsListLB.Size = new System.Drawing.Size(519, 172);
            this.RoomsListLB.TabIndex = 1;
            this.RoomsListLB.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.RoomsListLB_MouseDoubleClick);
            // 
            // RoomsPanel
            // 
            this.RoomsPanel.Controls.Add(this.ConnectBtn);
            this.RoomsPanel.Controls.Add(this.BackBtn);
            this.RoomsPanel.Controls.Add(this.RoomsListLB);
            this.RoomsPanel.Controls.Add(this.RoomsListLabel);
            this.RoomsPanel.Location = new System.Drawing.Point(122, 70);
            this.RoomsPanel.Name = "RoomsPanel";
            this.RoomsPanel.Size = new System.Drawing.Size(557, 352);
            this.RoomsPanel.TabIndex = 6;
            this.RoomsPanel.Visible = false;
            // 
            // ConnectBtn
            // 
            this.ConnectBtn.Font = new System.Drawing.Font("Tahoma", 12F);
            this.ConnectBtn.Location = new System.Drawing.Point(436, 281);
            this.ConnectBtn.Name = "ConnectBtn";
            this.ConnectBtn.Size = new System.Drawing.Size(102, 46);
            this.ConnectBtn.TabIndex = 3;
            this.ConnectBtn.Text = "Connect";
            this.ConnectBtn.UseVisualStyleBackColor = true;
            this.ConnectBtn.Visible = false;
            this.ConnectBtn.Click += new System.EventHandler(this.ConnectBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.Font = new System.Drawing.Font("Tahoma", 12F);
            this.BackBtn.Location = new System.Drawing.Point(19, 281);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(104, 46);
            this.BackBtn.TabIndex = 2;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Visible = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // CreateRoomPanel
            // 
            this.CreateRoomPanel.Controls.Add(this.PlayersLB);
            this.CreateRoomPanel.Controls.Add(this.label2);
            this.CreateRoomPanel.Location = new System.Drawing.Point(122, 70);
            this.CreateRoomPanel.Name = "CreateRoomPanel";
            this.CreateRoomPanel.Size = new System.Drawing.Size(557, 352);
            this.CreateRoomPanel.TabIndex = 7;
            this.CreateRoomPanel.Visible = false;
            // 
            // PlayersLB
            // 
            this.PlayersLB.Font = new System.Drawing.Font("Tahoma", 12F);
            this.PlayersLB.FormattingEnabled = true;
            this.PlayersLB.ItemHeight = 24;
            this.PlayersLB.Location = new System.Drawing.Point(47, 109);
            this.PlayersLB.Name = "PlayersLB";
            this.PlayersLB.Size = new System.Drawing.Size(463, 148);
            this.PlayersLB.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label2.Location = new System.Drawing.Point(170, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Waiting for a Player";
            // 
            // WatchPanal
            // 
            this.WatchPanal.Controls.Add(this.StartWatchingBtn);
            this.WatchPanal.Controls.Add(this.StartWatchLB);
            this.WatchPanal.Controls.Add(this.chooseRoom);
            this.WatchPanal.Location = new System.Drawing.Point(122, 73);
            this.WatchPanal.Name = "WatchPanal";
            this.WatchPanal.Size = new System.Drawing.Size(557, 349);
            this.WatchPanal.TabIndex = 8;
            this.WatchPanal.Visible = false;
            // 
            // StartWatchingBtn
            // 
            this.StartWatchingBtn.Font = new System.Drawing.Font("Tahoma", 12F);
            this.StartWatchingBtn.Location = new System.Drawing.Point(191, 278);
            this.StartWatchingBtn.Name = "StartWatchingBtn";
            this.StartWatchingBtn.Size = new System.Drawing.Size(174, 47);
            this.StartWatchingBtn.TabIndex = 2;
            this.StartWatchingBtn.Text = "Start Watching";
            this.StartWatchingBtn.UseVisualStyleBackColor = true;
            this.StartWatchingBtn.Visible = false;
            this.StartWatchingBtn.Click += new System.EventHandler(this.StartWatchingBtn_Click);
            // 
            // StartWatchLB
            // 
            this.StartWatchLB.Font = new System.Drawing.Font("Tahoma", 12F);
            this.StartWatchLB.FormattingEnabled = true;
            this.StartWatchLB.ItemHeight = 24;
            this.StartWatchLB.Location = new System.Drawing.Point(47, 74);
            this.StartWatchLB.Name = "StartWatchLB";
            this.StartWatchLB.Size = new System.Drawing.Size(463, 172);
            this.StartWatchLB.TabIndex = 1;
            this.StartWatchLB.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.StartWatchLB_MouseDoubleClick);
            // 
            // chooseRoom
            // 
            this.chooseRoom.AutoSize = true;
            this.chooseRoom.Font = new System.Drawing.Font("Tahoma", 14F);
            this.chooseRoom.Location = new System.Drawing.Point(188, 21);
            this.chooseRoom.Name = "chooseRoom";
            this.chooseRoom.Size = new System.Drawing.Size(180, 29);
            this.chooseRoom.TabIndex = 0;
            this.chooseRoom.Text = "Choose a Room";
            // 
            // StartPlayPanel
            // 
            this.StartPlayPanel.Controls.Add(this.PlayRoomsLB);
            this.StartPlayPanel.Controls.Add(this.StartPlayingBtn);
            this.StartPlayPanel.Controls.Add(this.label3);
            this.StartPlayPanel.Location = new System.Drawing.Point(125, 70);
            this.StartPlayPanel.Name = "StartPlayPanel";
            this.StartPlayPanel.Size = new System.Drawing.Size(551, 308);
            this.StartPlayPanel.TabIndex = 9;
            this.StartPlayPanel.Visible = false;
            // 
            // PlayRoomsLB
            // 
            this.PlayRoomsLB.Font = new System.Drawing.Font("Tahoma", 12F);
            this.PlayRoomsLB.FormattingEnabled = true;
            this.PlayRoomsLB.ItemHeight = 24;
            this.PlayRoomsLB.Location = new System.Drawing.Point(35, 77);
            this.PlayRoomsLB.Name = "PlayRoomsLB";
            this.PlayRoomsLB.Size = new System.Drawing.Size(480, 148);
            this.PlayRoomsLB.TabIndex = 6;
            // 
            // StartPlayingBtn
            // 
            this.StartPlayingBtn.Font = new System.Drawing.Font("Tahoma", 12F);
            this.StartPlayingBtn.Location = new System.Drawing.Point(182, 244);
            this.StartPlayingBtn.Name = "StartPlayingBtn";
            this.StartPlayingBtn.Size = new System.Drawing.Size(186, 48);
            this.StartPlayingBtn.TabIndex = 5;
            this.StartPlayingBtn.Text = "Start Playing";
            this.StartPlayingBtn.UseVisualStyleBackColor = true;
            this.StartPlayingBtn.Visible = false;
            this.StartPlayingBtn.Click += new System.EventHandler(this.StartPlayingBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label3.Location = new System.Drawing.Point(185, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Choose a Room";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Connect);
            this.Controls.Add(this.CreateRoomPanel);
            this.Controls.Add(this.RoomsPanel);
            this.Controls.Add(this.WatchPanal);
            this.Controls.Add(this.StartPlayPanel);
            this.Controls.Add(this.ChoicePanal);
            this.Controls.Add(this.logInPanal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.logInPanal.ResumeLayout(false);
            this.logInPanal.PerformLayout();
            this.ChoicePanal.ResumeLayout(false);
            this.ChoicePanal.PerformLayout();
            this.RoomsPanel.ResumeLayout(false);
            this.RoomsPanel.PerformLayout();
            this.CreateRoomPanel.ResumeLayout(false);
            this.CreateRoomPanel.PerformLayout();
            this.WatchPanal.ResumeLayout(false);
            this.WatchPanal.PerformLayout();
            this.StartPlayPanel.ResumeLayout(false);
            this.StartPlayPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.TextBox UserNameTB;
        private System.Windows.Forms.Label GameNameLabel;
        private System.Windows.Forms.Button LogInBtn;
        private System.Windows.Forms.Panel logInPanal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CreateRoomBtn;
        private System.Windows.Forms.Button WatchBtn;
        private System.Windows.Forms.Panel ChoicePanal;
        private System.Windows.Forms.Label RoomsListLabel;
        private System.Windows.Forms.ListBox RoomsListLB;
        private System.Windows.Forms.Panel RoomsPanel;
        private System.Windows.Forms.Button ConnectBtn;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Panel CreateRoomPanel;
        private System.Windows.Forms.ListBox PlayersLB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button PlayBtn;
        private System.Windows.Forms.Panel WatchPanal;
        private System.Windows.Forms.Button StartWatchingBtn;
        private System.Windows.Forms.ListBox StartWatchLB;
        private System.Windows.Forms.Label chooseRoom;
        private System.Windows.Forms.Panel StartPlayPanel;
        private System.Windows.Forms.ListBox PlayRoomsLB;
        private System.Windows.Forms.Button StartPlayingBtn;
        private System.Windows.Forms.Label label3;
    }
}

