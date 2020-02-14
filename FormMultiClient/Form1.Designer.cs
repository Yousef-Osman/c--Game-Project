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
            this.WatchPanal = new System.Windows.Forms.Panel();
            this.BackBtn = new System.Windows.Forms.Button();
            this.StartWatchingBtn = new System.Windows.Forms.Button();
            this.StartWatchLB = new System.Windows.Forms.ListBox();
            this.chooseRoom = new System.Windows.Forms.Label();
            this.StartPlayPanel = new System.Windows.Forms.Panel();
            this.StartPlayingLB = new System.Windows.Forms.ListBox();
            this.BackPlay = new System.Windows.Forms.Button();
            this.StartPlayingBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PlayersLB = new System.Windows.Forms.ListBox();
            this.CreateRoomPanel = new System.Windows.Forms.Panel();
            this.GamePanel = new System.Windows.Forms.Panel();
            this.GameWordTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button20 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BufferPanel = new System.Windows.Forms.Panel();
            this.BufferLabel = new System.Windows.Forms.Label();
            this.logInPanal.SuspendLayout();
            this.ChoicePanal.SuspendLayout();
            this.WatchPanal.SuspendLayout();
            this.StartPlayPanel.SuspendLayout();
            this.CreateRoomPanel.SuspendLayout();
            this.GamePanel.SuspendLayout();
            this.BufferPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Connect
            // 
            this.Connect.Font = new System.Drawing.Font("Tahoma", 12F);
            this.Connect.Location = new System.Drawing.Point(420, 243);
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
            this.UserNameLabel.Location = new System.Drawing.Point(163, 190);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(135, 33);
            this.UserNameLabel.TabIndex = 1;
            this.UserNameLabel.Text = "Username";
            // 
            // UserNameTB
            // 
            this.UserNameTB.Font = new System.Drawing.Font("Tahoma", 14F);
            this.UserNameTB.Location = new System.Drawing.Point(341, 190);
            this.UserNameTB.Name = "UserNameTB";
            this.UserNameTB.Size = new System.Drawing.Size(243, 36);
            this.UserNameTB.TabIndex = 2;
            // 
            // GameNameLabel
            // 
            this.GameNameLabel.AutoSize = true;
            this.GameNameLabel.Font = new System.Drawing.Font("Tahoma", 18F);
            this.GameNameLabel.Location = new System.Drawing.Point(245, 88);
            this.GameNameLabel.Name = "GameNameLabel";
            this.GameNameLabel.Size = new System.Drawing.Size(266, 36);
            this.GameNameLabel.TabIndex = 3;
            this.GameNameLabel.Text = "GUESS THE WORD";
            // 
            // LogInBtn
            // 
            this.LogInBtn.Font = new System.Drawing.Font("Tahoma", 12F);
            this.LogInBtn.Location = new System.Drawing.Point(322, 286);
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
            this.logInPanal.Location = new System.Drawing.Point(118, 50);
            this.logInPanal.Name = "logInPanal";
            this.logInPanal.Size = new System.Drawing.Size(747, 434);
            this.logInPanal.TabIndex = 1;
            this.logInPanal.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F);
            this.label1.Location = new System.Drawing.Point(240, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "GUESS THE WORD";
            // 
            // CreateRoomBtn
            // 
            this.CreateRoomBtn.Font = new System.Drawing.Font("Tahoma", 12F);
            this.CreateRoomBtn.Location = new System.Drawing.Point(56, 246);
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
            this.WatchBtn.Location = new System.Drawing.Point(297, 246);
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
            this.ChoicePanal.Location = new System.Drawing.Point(118, 66);
            this.ChoicePanal.Name = "ChoicePanal";
            this.ChoicePanal.Size = new System.Drawing.Size(747, 421);
            this.ChoicePanal.TabIndex = 5;
            this.ChoicePanal.Visible = false;
            // 
            // PlayBtn
            // 
            this.PlayBtn.Font = new System.Drawing.Font("Tahoma", 12F);
            this.PlayBtn.Location = new System.Drawing.Point(538, 246);
            this.PlayBtn.Name = "PlayBtn";
            this.PlayBtn.Size = new System.Drawing.Size(153, 48);
            this.PlayBtn.TabIndex = 5;
            this.PlayBtn.Text = "Play";
            this.PlayBtn.UseVisualStyleBackColor = true;
            this.PlayBtn.Click += new System.EventHandler(this.PlayBtn_Click);
            // 
            // WatchPanal
            // 
            this.WatchPanal.Controls.Add(this.BackBtn);
            this.WatchPanal.Controls.Add(this.StartWatchingBtn);
            this.WatchPanal.Controls.Add(this.StartWatchLB);
            this.WatchPanal.Controls.Add(this.chooseRoom);
            this.WatchPanal.Location = new System.Drawing.Point(129, 50);
            this.WatchPanal.Name = "WatchPanal";
            this.WatchPanal.Size = new System.Drawing.Size(724, 418);
            this.WatchPanal.TabIndex = 8;
            this.WatchPanal.Visible = false;
            // 
            // BackBtn
            // 
            this.BackBtn.Font = new System.Drawing.Font("Tahoma", 12F);
            this.BackBtn.Location = new System.Drawing.Point(56, 346);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(174, 47);
            this.BackBtn.TabIndex = 2;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Visible = false;
            this.BackBtn.Click += new System.EventHandler(this.RoomNumber);
            // 
            // StartWatchingBtn
            // 
            this.StartWatchingBtn.Font = new System.Drawing.Font("Tahoma", 12F);
            this.StartWatchingBtn.Location = new System.Drawing.Point(486, 346);
            this.StartWatchingBtn.Name = "StartWatchingBtn";
            this.StartWatchingBtn.Size = new System.Drawing.Size(174, 47);
            this.StartWatchingBtn.TabIndex = 2;
            this.StartWatchingBtn.Text = "Start Watching";
            this.StartWatchingBtn.UseVisualStyleBackColor = true;
            this.StartWatchingBtn.Visible = false;
            this.StartWatchingBtn.Click += new System.EventHandler(this.RoomNumber);
            // 
            // StartWatchLB
            // 
            this.StartWatchLB.Font = new System.Drawing.Font("Tahoma", 12F);
            this.StartWatchLB.FormattingEnabled = true;
            this.StartWatchLB.ItemHeight = 24;
            this.StartWatchLB.Location = new System.Drawing.Point(56, 89);
            this.StartWatchLB.Name = "StartWatchLB";
            this.StartWatchLB.Size = new System.Drawing.Size(613, 172);
            this.StartWatchLB.TabIndex = 1;
            this.StartWatchLB.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.StartWatchLB_MouseDoubleClick);
            // 
            // chooseRoom
            // 
            this.chooseRoom.AutoSize = true;
            this.chooseRoom.Font = new System.Drawing.Font("Tahoma", 14F);
            this.chooseRoom.Location = new System.Drawing.Point(272, 21);
            this.chooseRoom.Name = "chooseRoom";
            this.chooseRoom.Size = new System.Drawing.Size(180, 29);
            this.chooseRoom.TabIndex = 0;
            this.chooseRoom.Text = "Choose a Room";
            // 
            // StartPlayPanel
            // 
            this.StartPlayPanel.Controls.Add(this.StartPlayingLB);
            this.StartPlayPanel.Controls.Add(this.BackPlay);
            this.StartPlayPanel.Controls.Add(this.StartPlayingBtn);
            this.StartPlayPanel.Controls.Add(this.label3);
            this.StartPlayPanel.Location = new System.Drawing.Point(119, 66);
            this.StartPlayPanel.Name = "StartPlayPanel";
            this.StartPlayPanel.Size = new System.Drawing.Size(744, 434);
            this.StartPlayPanel.TabIndex = 9;
            this.StartPlayPanel.Visible = false;
            this.StartPlayPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.StartPlayPanel_Paint);
            // 
            // StartPlayingLB
            // 
            this.StartPlayingLB.Font = new System.Drawing.Font("Tahoma", 12F);
            this.StartPlayingLB.FormattingEnabled = true;
            this.StartPlayingLB.ItemHeight = 24;
            this.StartPlayingLB.Location = new System.Drawing.Point(45, 87);
            this.StartPlayingLB.Name = "StartPlayingLB";
            this.StartPlayingLB.Size = new System.Drawing.Size(655, 220);
            this.StartPlayingLB.TabIndex = 6;
            // 
            // BackPlay
            // 
            this.BackPlay.Font = new System.Drawing.Font("Tahoma", 12F);
            this.BackPlay.Location = new System.Drawing.Point(45, 356);
            this.BackPlay.Name = "BackPlay";
            this.BackPlay.Size = new System.Drawing.Size(186, 48);
            this.BackPlay.TabIndex = 5;
            this.BackPlay.Text = "Back";
            this.BackPlay.UseVisualStyleBackColor = true;
            this.BackPlay.Visible = false;
            this.BackPlay.Click += new System.EventHandler(this.RoomNumber);
            // 
            // StartPlayingBtn
            // 
            this.StartPlayingBtn.Font = new System.Drawing.Font("Tahoma", 12F);
            this.StartPlayingBtn.Location = new System.Drawing.Point(513, 356);
            this.StartPlayingBtn.Name = "StartPlayingBtn";
            this.StartPlayingBtn.Size = new System.Drawing.Size(186, 48);
            this.StartPlayingBtn.TabIndex = 5;
            this.StartPlayingBtn.Text = "Start Playing";
            this.StartPlayingBtn.UseVisualStyleBackColor = true;
            this.StartPlayingBtn.Visible = false;
            this.StartPlayingBtn.Click += new System.EventHandler(this.RoomNumber);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label3.Location = new System.Drawing.Point(282, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Choose a Room";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label2.Location = new System.Drawing.Point(261, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Waiting for a Player";
            // 
            // PlayersLB
            // 
            this.PlayersLB.Font = new System.Drawing.Font("Tahoma", 12F);
            this.PlayersLB.FormattingEnabled = true;
            this.PlayersLB.ItemHeight = 24;
            this.PlayersLB.Location = new System.Drawing.Point(84, 127);
            this.PlayersLB.Name = "PlayersLB";
            this.PlayersLB.Size = new System.Drawing.Size(579, 196);
            this.PlayersLB.TabIndex = 1;
            // 
            // CreateRoomPanel
            // 
            this.CreateRoomPanel.Controls.Add(this.PlayersLB);
            this.CreateRoomPanel.Controls.Add(this.label2);
            this.CreateRoomPanel.Location = new System.Drawing.Point(118, 50);
            this.CreateRoomPanel.Name = "CreateRoomPanel";
            this.CreateRoomPanel.Size = new System.Drawing.Size(747, 437);
            this.CreateRoomPanel.TabIndex = 7;
            this.CreateRoomPanel.Visible = false;
            // 
            // GamePanel
            // 
            this.GamePanel.BackColor = System.Drawing.Color.DodgerBlue;
            this.GamePanel.Controls.Add(this.GameWordTB);
            this.GamePanel.Controls.Add(this.label4);
            this.GamePanel.Controls.Add(this.button20);
            this.GamePanel.Controls.Add(this.button18);
            this.GamePanel.Controls.Add(this.button16);
            this.GamePanel.Controls.Add(this.button25);
            this.GamePanel.Controls.Add(this.button14);
            this.GamePanel.Controls.Add(this.button24);
            this.GamePanel.Controls.Add(this.button12);
            this.GamePanel.Controls.Add(this.button23);
            this.GamePanel.Controls.Add(this.button10);
            this.GamePanel.Controls.Add(this.button22);
            this.GamePanel.Controls.Add(this.button8);
            this.GamePanel.Controls.Add(this.button21);
            this.GamePanel.Controls.Add(this.button6);
            this.GamePanel.Controls.Add(this.button4);
            this.GamePanel.Controls.Add(this.button2);
            this.GamePanel.Controls.Add(this.button19);
            this.GamePanel.Controls.Add(this.button17);
            this.GamePanel.Controls.Add(this.button15);
            this.GamePanel.Controls.Add(this.button13);
            this.GamePanel.Controls.Add(this.button11);
            this.GamePanel.Controls.Add(this.button9);
            this.GamePanel.Controls.Add(this.button7);
            this.GamePanel.Controls.Add(this.button26);
            this.GamePanel.Controls.Add(this.button5);
            this.GamePanel.Controls.Add(this.button3);
            this.GamePanel.Controls.Add(this.button1);
            this.GamePanel.Location = new System.Drawing.Point(22, 12);
            this.GamePanel.Name = "GamePanel";
            this.GamePanel.Size = new System.Drawing.Size(939, 528);
            this.GamePanel.TabIndex = 10;
            this.GamePanel.Visible = false;
            // 
            // GameWordTB
            // 
            this.GameWordTB.BackColor = System.Drawing.Color.DodgerBlue;
            this.GameWordTB.Font = new System.Drawing.Font("Tahoma", 18F);
            this.GameWordTB.ForeColor = System.Drawing.SystemColors.Window;
            this.GameWordTB.Location = new System.Drawing.Point(374, 178);
            this.GameWordTB.Name = "GameWordTB";
            this.GameWordTB.Size = new System.Drawing.Size(199, 44);
            this.GameWordTB.TabIndex = 31;
            this.GameWordTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 30F);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(248, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(443, 60);
            this.label4.TabIndex = 30;
            this.label4.Text = "GUESS THE WORD";
            // 
            // button20
            // 
            this.button20.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button20.Location = new System.Drawing.Point(262, 406);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(50, 50);
            this.button20.TabIndex = 28;
            this.button20.Text = "u";
            this.button20.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            this.button18.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button18.Location = new System.Drawing.Point(773, 339);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(50, 50);
            this.button18.TabIndex = 27;
            this.button18.Text = "t";
            this.button18.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            this.button16.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.Location = new System.Drawing.Point(700, 339);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(50, 50);
            this.button16.TabIndex = 26;
            this.button16.Text = "s";
            this.button16.UseVisualStyleBackColor = true;
            // 
            // button25
            // 
            this.button25.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button25.Location = new System.Drawing.Point(627, 406);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(50, 50);
            this.button25.TabIndex = 25;
            this.button25.Text = "z";
            this.button25.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.Location = new System.Drawing.Point(627, 339);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(50, 50);
            this.button14.TabIndex = 24;
            this.button14.Text = "r";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // button24
            // 
            this.button24.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button24.Location = new System.Drawing.Point(554, 406);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(50, 50);
            this.button24.TabIndex = 23;
            this.button24.Text = "y";
            this.button24.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.Location = new System.Drawing.Point(554, 339);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(50, 50);
            this.button12.TabIndex = 22;
            this.button12.Text = "q";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button23
            // 
            this.button23.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button23.Location = new System.Drawing.Point(481, 406);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(50, 50);
            this.button23.TabIndex = 21;
            this.button23.Text = "x";
            this.button23.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(481, 339);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(50, 50);
            this.button10.TabIndex = 20;
            this.button10.Text = "p";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button22
            // 
            this.button22.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button22.Location = new System.Drawing.Point(408, 406);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(50, 50);
            this.button22.TabIndex = 19;
            this.button22.Text = "w";
            this.button22.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(408, 339);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(50, 50);
            this.button8.TabIndex = 18;
            this.button8.Text = "o";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button21
            // 
            this.button21.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button21.Location = new System.Drawing.Point(335, 406);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(50, 50);
            this.button21.TabIndex = 4;
            this.button21.Text = "v";
            this.button21.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(335, 339);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(50, 50);
            this.button6.TabIndex = 16;
            this.button6.Text = "n";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(262, 339);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(50, 50);
            this.button4.TabIndex = 15;
            this.button4.Text = "m";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(189, 339);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 50);
            this.button2.TabIndex = 14;
            this.button2.Text = "l";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button19
            // 
            this.button19.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button19.Location = new System.Drawing.Point(116, 339);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(50, 50);
            this.button19.TabIndex = 13;
            this.button19.Text = "k";
            this.button19.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            this.button17.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button17.Location = new System.Drawing.Point(773, 268);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(50, 50);
            this.button17.TabIndex = 12;
            this.button17.Text = "j";
            this.button17.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.Location = new System.Drawing.Point(700, 268);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(50, 50);
            this.button15.TabIndex = 11;
            this.button15.Text = "i";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.Location = new System.Drawing.Point(627, 268);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(50, 50);
            this.button13.TabIndex = 10;
            this.button13.Text = "h";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(554, 268);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(50, 50);
            this.button11.TabIndex = 9;
            this.button11.Text = "g";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(481, 268);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(50, 50);
            this.button9.TabIndex = 8;
            this.button9.Text = "f";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(408, 268);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(50, 50);
            this.button7.TabIndex = 7;
            this.button7.Text = "e";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button26
            // 
            this.button26.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button26.Location = new System.Drawing.Point(335, 268);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(50, 50);
            this.button26.TabIndex = 6;
            this.button26.Text = "d";
            this.button26.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(262, 268);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(50, 50);
            this.button5.TabIndex = 5;
            this.button5.Text = "c";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(189, 268);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 50);
            this.button3.TabIndex = 29;
            this.button3.Text = "b";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(116, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 17;
            this.button1.Text = "a";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // BufferPanel
            // 
            this.BufferPanel.Controls.Add(this.BufferLabel);
            this.BufferPanel.Location = new System.Drawing.Point(119, 66);
            this.BufferPanel.Name = "BufferPanel";
            this.BufferPanel.Size = new System.Drawing.Size(746, 434);
            this.BufferPanel.TabIndex = 11;
            this.BufferPanel.Visible = false;
            // 
            // BufferLabel
            // 
            this.BufferLabel.AutoSize = true;
            this.BufferLabel.Font = new System.Drawing.Font("Tahoma", 18F);
            this.BufferLabel.Location = new System.Drawing.Point(105, 199);
            this.BufferLabel.Name = "BufferLabel";
            this.BufferLabel.Size = new System.Drawing.Size(537, 36);
            this.BufferLabel.TabIndex = 0;
            this.BufferLabel.Text = "Please Wait for another Player to join...";
            this.BufferLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.GamePanel);
            this.Controls.Add(this.BufferPanel);
            this.Controls.Add(this.ChoicePanal);
            this.Controls.Add(this.logInPanal);
            this.Controls.Add(this.Connect);
            this.Controls.Add(this.CreateRoomPanel);
            this.Controls.Add(this.WatchPanal);
            this.Controls.Add(this.StartPlayPanel);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.logInPanal.ResumeLayout(false);
            this.logInPanal.PerformLayout();
            this.ChoicePanal.ResumeLayout(false);
            this.ChoicePanal.PerformLayout();
            this.WatchPanal.ResumeLayout(false);
            this.WatchPanal.PerformLayout();
            this.StartPlayPanel.ResumeLayout(false);
            this.StartPlayPanel.PerformLayout();
            this.CreateRoomPanel.ResumeLayout(false);
            this.CreateRoomPanel.PerformLayout();
            this.GamePanel.ResumeLayout(false);
            this.GamePanel.PerformLayout();
            this.BufferPanel.ResumeLayout(false);
            this.BufferPanel.PerformLayout();
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
        private System.Windows.Forms.Button PlayBtn;
        private System.Windows.Forms.Panel WatchPanal;
        private System.Windows.Forms.Button StartWatchingBtn;
        private System.Windows.Forms.ListBox StartWatchLB;
        private System.Windows.Forms.Label chooseRoom;
        private System.Windows.Forms.Panel StartPlayPanel;
        private System.Windows.Forms.ListBox StartPlayingLB;
        private System.Windows.Forms.Button StartPlayingBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox PlayersLB;
        private System.Windows.Forms.Panel CreateRoomPanel;
        private System.Windows.Forms.Panel GamePanel;
        private System.Windows.Forms.TextBox GameWordTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button BackPlay;
        private System.Windows.Forms.Panel BufferPanel;
        private System.Windows.Forms.Label BufferLabel;
    }
}

