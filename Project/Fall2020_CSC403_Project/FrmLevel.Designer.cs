namespace Fall2020_CSC403_Project {
  partial class FrmLevel {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLevel));
            this.lblInGameTime = new System.Windows.Forms.Label();
            this.tmrUpdateInGameTime = new System.Windows.Forms.Timer(this.components);
            this.tmrPlayerMove = new System.Windows.Forms.Timer(this.components);
            this.difficultypanel = new System.Windows.Forms.FlowLayoutPanel();
            this.scoreboard = new System.Windows.Forms.Label();
            this.poisonhealthpack = new System.Windows.Forms.PictureBox();
            this.easybox = new System.Windows.Forms.PictureBox();
            this.mediumbox = new System.Windows.Forms.PictureBox();
            this.hardbox = new System.Windows.Forms.PictureBox();
            this.char3 = new System.Windows.Forms.PictureBox();
            this.char2 = new System.Windows.Forms.PictureBox();
            this.char1 = new System.Windows.Forms.PictureBox();
            this.playpause = new System.Windows.Forms.PictureBox();
            this.restart = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picWall11 = new System.Windows.Forms.PictureBox();
            this.picWall2 = new System.Windows.Forms.PictureBox();
            this.picWall8 = new System.Windows.Forms.PictureBox();
            this.picWall7 = new System.Windows.Forms.PictureBox();
            this.picWall1 = new System.Windows.Forms.PictureBox();
            this.picWall0 = new System.Windows.Forms.PictureBox();
            this.picWall10 = new System.Windows.Forms.PictureBox();
            this.picWall9 = new System.Windows.Forms.PictureBox();
            this.picWall6 = new System.Windows.Forms.PictureBox();
            this.picWall12 = new System.Windows.Forms.PictureBox();
            this.picWall4 = new System.Windows.Forms.PictureBox();
            this.picWall5 = new System.Windows.Forms.PictureBox();
            this.picEnemyCheeto = new System.Windows.Forms.PictureBox();
            this.picEnemyPoisonPacket = new System.Windows.Forms.PictureBox();
            this.picWall3 = new System.Windows.Forms.PictureBox();
            this.picBossKoolAid = new System.Windows.Forms.PictureBox();
            this.picPlayer = new System.Windows.Forms.PictureBox();
            this.bosshealthpack = new System.Windows.Forms.PictureBox();
            this.cheetohidden = new System.Windows.Forms.PictureBox();
            this.difficultypanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.poisonhealthpack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.easybox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediumbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hardbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.char3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.char2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.char1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playpause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemyCheeto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemyPoisonPacket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBossKoolAid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosshealthpack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheetohidden)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInGameTime
            // 
            this.lblInGameTime.AutoSize = true;
            this.lblInGameTime.BackColor = System.Drawing.Color.Black;
            this.lblInGameTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInGameTime.ForeColor = System.Drawing.Color.White;
            this.lblInGameTime.Location = new System.Drawing.Point(12, 9);
            this.lblInGameTime.Name = "lblInGameTime";
            this.lblInGameTime.Size = new System.Drawing.Size(46, 18);
            this.lblInGameTime.TabIndex = 2;
            this.lblInGameTime.Text = "label1";
            this.lblInGameTime.Click += new System.EventHandler(this.lblInGameTime_Click);
            // 
            // tmrUpdateInGameTime
            // 
            this.tmrUpdateInGameTime.Enabled = true;
            this.tmrUpdateInGameTime.Tick += new System.EventHandler(this.tmrUpdateInGameTime_Tick);
            // 
            // tmrPlayerMove
            // 
            this.tmrPlayerMove.Enabled = true;
            this.tmrPlayerMove.Interval = 10;
            this.tmrPlayerMove.Tick += new System.EventHandler(this.tmrPlayerMove_Tick);
            // 
            // difficultypanel
            // 
            this.difficultypanel.Controls.Add(this.easybox);
            this.difficultypanel.Controls.Add(this.mediumbox);
            this.difficultypanel.Controls.Add(this.hardbox);
            this.difficultypanel.Location = new System.Drawing.Point(366, 316);
            this.difficultypanel.Name = "difficultypanel";
            this.difficultypanel.Size = new System.Drawing.Size(518, 128);
            this.difficultypanel.TabIndex = 24;
            // 
            // scoreboard
            // 
            this.scoreboard.AutoSize = true;
            this.scoreboard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.scoreboard.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.scoreboard.Location = new System.Drawing.Point(644, 15);
            this.scoreboard.Name = "scoreboard";
            this.scoreboard.Size = new System.Drawing.Size(37, 15);
            this.scoreboard.TabIndex = 25;
            this.scoreboard.Text = "label1";
            // 
            // poisonhealthpack
            // 
            this.poisonhealthpack.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.healthpack;
            this.poisonhealthpack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.poisonhealthpack.Location = new System.Drawing.Point(304, 89);
            this.poisonhealthpack.Name = "poisonhealthpack";
            this.poisonhealthpack.Size = new System.Drawing.Size(102, 59);
            this.poisonhealthpack.TabIndex = 26;
            this.poisonhealthpack.TabStop = false;
            // 
            // easybox
            // 
            this.easybox.BackColor = System.Drawing.Color.Transparent;
            this.easybox.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.easy1;
            this.easybox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.easybox.Location = new System.Drawing.Point(3, 3);
            this.easybox.Name = "easybox";
            this.easybox.Size = new System.Drawing.Size(176, 119);
            this.easybox.TabIndex = 0;
            this.easybox.TabStop = false;
            this.easybox.Click += new System.EventHandler(this.easy_Click);
            // 
            // mediumbox
            // 
            this.mediumbox.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.normal;
            this.mediumbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mediumbox.Location = new System.Drawing.Point(185, 3);
            this.mediumbox.Name = "mediumbox";
            this.mediumbox.Size = new System.Drawing.Size(157, 119);
            this.mediumbox.TabIndex = 1;
            this.mediumbox.TabStop = false;
            this.mediumbox.Click += new System.EventHandler(this.medium_Click);
            // 
            // hardbox
            // 
            this.hardbox.BackColor = System.Drawing.Color.Transparent;
            this.hardbox.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.hard;
            this.hardbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hardbox.Location = new System.Drawing.Point(348, 3);
            this.hardbox.Name = "hardbox";
            this.hardbox.Size = new System.Drawing.Size(167, 119);
            this.hardbox.TabIndex = 2;
            this.hardbox.TabStop = false;
            this.hardbox.Click += new System.EventHandler(this.hardbox_Click);
            // 
            // char3
            // 
            this.char3.BackColor = System.Drawing.Color.Transparent;
            this.char3.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.LaraCroftInfoboxicon;
            this.char3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.char3.Location = new System.Drawing.Point(517, 9);
            this.char3.Name = "char3";
            this.char3.Size = new System.Drawing.Size(50, 50);
            this.char3.TabIndex = 23;
            this.char3.TabStop = false;
            this.char3.Click += new System.EventHandler(this.char3_Click);
            // 
            // char2
            // 
            this.char2.BackColor = System.Drawing.Color.Transparent;
            this.char2.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.char2icon;
            this.char2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.char2.Location = new System.Drawing.Point(446, 9);
            this.char2.Name = "char2";
            this.char2.Size = new System.Drawing.Size(50, 50);
            this.char2.TabIndex = 22;
            this.char2.TabStop = false;
            this.char2.Click += new System.EventHandler(this.char2_Click);
            // 
            // char1
            // 
            this.char1.BackColor = System.Drawing.Color.Transparent;
            this.char1.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.playericon;
            this.char1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.char1.Location = new System.Drawing.Point(380, 9);
            this.char1.Name = "char1";
            this.char1.Size = new System.Drawing.Size(50, 50);
            this.char1.TabIndex = 21;
            this.char1.TabStop = false;
            this.char1.Click += new System.EventHandler(this.char1_Click);
            // 
            // playpause
            // 
            this.playpause.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.pause;
            this.playpause.Location = new System.Drawing.Point(607, 664);
            this.playpause.Name = "playpause";
            this.playpause.Size = new System.Drawing.Size(51, 51);
            this.playpause.TabIndex = 20;
            this.playpause.TabStop = false;
            this.playpause.Click += new System.EventHandler(this.playpause_Click);
            // 
            // restart
            // 
            this.restart.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.replay;
            this.restart.Location = new System.Drawing.Point(664, 663);
            this.restart.Name = "restart";
            this.restart.Size = new System.Drawing.Size(51, 51);
            this.restart.TabIndex = 19;
            this.restart.TabStop = false;
            this.restart.Click += new System.EventHandler(this.restart_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.run_50x50;
            this.pictureBox1.Location = new System.Drawing.Point(551, 664);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // picWall11
            // 
            this.picWall11.BackColor = System.Drawing.Color.Transparent;
            this.picWall11.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall11.Location = new System.Drawing.Point(551, 425);
            this.picWall11.Name = "picWall11";
            this.picWall11.Size = new System.Drawing.Size(177, 232);
            this.picWall11.TabIndex = 17;
            this.picWall11.TabStop = false;
            // 
            // picWall2
            // 
            this.picWall2.BackColor = System.Drawing.Color.Transparent;
            this.picWall2.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall2.Location = new System.Drawing.Point(551, 1);
            this.picWall2.Name = "picWall2";
            this.picWall2.Size = new System.Drawing.Size(469, 67);
            this.picWall2.TabIndex = 16;
            this.picWall2.TabStop = false;
            // 
            // picWall8
            // 
            this.picWall8.BackColor = System.Drawing.Color.Transparent;
            this.picWall8.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall8.Location = new System.Drawing.Point(1093, 274);
            this.picWall8.Name = "picWall8";
            this.picWall8.Size = new System.Drawing.Size(82, 449);
            this.picWall8.TabIndex = 15;
            this.picWall8.TabStop = false;
            // 
            // picWall7
            // 
            this.picWall7.BackColor = System.Drawing.Color.Transparent;
            this.picWall7.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall7.Location = new System.Drawing.Point(721, 656);
            this.picWall7.Name = "picWall7";
            this.picWall7.Size = new System.Drawing.Size(373, 67);
            this.picWall7.TabIndex = 14;
            this.picWall7.TabStop = false;
            // 
            // picWall1
            // 
            this.picWall1.BackColor = System.Drawing.Color.Transparent;
            this.picWall1.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall1.Location = new System.Drawing.Point(83, 1);
            this.picWall1.Name = "picWall1";
            this.picWall1.Size = new System.Drawing.Size(469, 67);
            this.picWall1.TabIndex = 13;
            this.picWall1.TabStop = false;
            // 
            // picWall0
            // 
            this.picWall0.BackColor = System.Drawing.Color.Transparent;
            this.picWall0.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall0.Location = new System.Drawing.Point(2, 1);
            this.picWall0.Name = "picWall0";
            this.picWall0.Size = new System.Drawing.Size(82, 388);
            this.picWall0.TabIndex = 12;
            this.picWall0.TabStop = false;
            // 
            // picWall10
            // 
            this.picWall10.BackColor = System.Drawing.Color.Transparent;
            this.picWall10.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall10.Location = new System.Drawing.Point(653, 89);
            this.picWall10.Name = "picWall10";
            this.picWall10.Size = new System.Drawing.Size(228, 162);
            this.picWall10.TabIndex = 11;
            this.picWall10.TabStop = false;
            // 
            // picWall9
            // 
            this.picWall9.BackColor = System.Drawing.Color.Transparent;
            this.picWall9.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall9.Location = new System.Drawing.Point(266, 154);
            this.picWall9.Name = "picWall9";
            this.picWall9.Size = new System.Drawing.Size(197, 118);
            this.picWall9.TabIndex = 10;
            this.picWall9.TabStop = false;
            // 
            // picWall6
            // 
            this.picWall6.BackColor = System.Drawing.Color.Transparent;
            this.picWall6.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall6.Location = new System.Drawing.Point(357, 656);
            this.picWall6.Name = "picWall6";
            this.picWall6.Size = new System.Drawing.Size(195, 67);
            this.picWall6.TabIndex = 9;
            this.picWall6.TabStop = false;
            // 
            // picWall12
            // 
            this.picWall12.BackColor = System.Drawing.Color.Transparent;
            this.picWall12.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall12.Location = new System.Drawing.Point(890, 397);
            this.picWall12.Name = "picWall12";
            this.picWall12.Size = new System.Drawing.Size(203, 113);
            this.picWall12.TabIndex = 8;
            this.picWall12.TabStop = false;
            // 
            // picWall4
            // 
            this.picWall4.BackColor = System.Drawing.Color.Transparent;
            this.picWall4.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall4.Location = new System.Drawing.Point(2, 454);
            this.picWall4.Name = "picWall4";
            this.picWall4.Size = new System.Drawing.Size(82, 203);
            this.picWall4.TabIndex = 7;
            this.picWall4.TabStop = false;
            // 
            // picWall5
            // 
            this.picWall5.BackColor = System.Drawing.Color.Transparent;
            this.picWall5.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall5.Location = new System.Drawing.Point(2, 656);
            this.picWall5.Name = "picWall5";
            this.picWall5.Size = new System.Drawing.Size(358, 67);
            this.picWall5.TabIndex = 6;
            this.picWall5.TabStop = false;
            // 
            // picEnemyCheeto
            // 
            this.picEnemyCheeto.BackColor = System.Drawing.Color.Transparent;
            this.picEnemyCheeto.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.enemy_cheetos;
            this.picEnemyCheeto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picEnemyCheeto.Location = new System.Drawing.Point(838, 540);
            this.picEnemyCheeto.Name = "picEnemyCheeto";
            this.picEnemyCheeto.Size = new System.Drawing.Size(64, 107);
            this.picEnemyCheeto.TabIndex = 5;
            this.picEnemyCheeto.TabStop = false;
            // 
            // picEnemyPoisonPacket
            // 
            this.picEnemyPoisonPacket.BackColor = System.Drawing.Color.Transparent;
            this.picEnemyPoisonPacket.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.enemy_poisonpacket;
            this.picEnemyPoisonPacket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picEnemyPoisonPacket.Location = new System.Drawing.Point(110, 98);
            this.picEnemyPoisonPacket.Name = "picEnemyPoisonPacket";
            this.picEnemyPoisonPacket.Size = new System.Drawing.Size(63, 96);
            this.picEnemyPoisonPacket.TabIndex = 4;
            this.picEnemyPoisonPacket.TabStop = false;
            // 
            // picWall3
            // 
            this.picWall3.BackColor = System.Drawing.Color.Transparent;
            this.picWall3.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall3.Location = new System.Drawing.Point(2, 388);
            this.picWall3.Name = "picWall3";
            this.picWall3.Size = new System.Drawing.Size(358, 67);
            this.picWall3.TabIndex = 3;
            this.picWall3.TabStop = false;
            // 
            // picBossKoolAid
            // 
            this.picBossKoolAid.BackColor = System.Drawing.Color.Transparent;
            this.picBossKoolAid.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBossKoolAid.BackgroundImage")));
            this.picBossKoolAid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBossKoolAid.Location = new System.Drawing.Point(971, 74);
            this.picBossKoolAid.Name = "picBossKoolAid";
            this.picBossKoolAid.Size = new System.Drawing.Size(193, 194);
            this.picBossKoolAid.TabIndex = 1;
            this.picBossKoolAid.TabStop = false;
            // 
            // picPlayer
            // 
            this.picPlayer.BackColor = System.Drawing.Color.Transparent;
            this.picPlayer.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.player;
            this.picPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPlayer.Location = new System.Drawing.Point(119, 510);
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.Size = new System.Drawing.Size(71, 106);
            this.picPlayer.TabIndex = 0;
            this.picPlayer.TabStop = false;
            // 
            // bosshealthpack
            // 
            this.bosshealthpack.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.healthpack;
            this.bosshealthpack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bosshealthpack.Location = new System.Drawing.Point(985, 296);
            this.bosshealthpack.Name = "bosshealthpack";
            this.bosshealthpack.Size = new System.Drawing.Size(102, 59);
            this.bosshealthpack.TabIndex = 27;
            this.bosshealthpack.TabStop = false;
            // 
            // cheetohidden
            // 
            this.cheetohidden.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.healthpack;
            this.cheetohidden.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cheetohidden.Location = new System.Drawing.Point(985, 588);
            this.cheetohidden.Name = "cheetohidden";
            this.cheetohidden.Size = new System.Drawing.Size(102, 59);
            this.cheetohidden.TabIndex = 28;
            this.cheetohidden.TabStop = false;
            // 
            // FrmLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1176, 726);
            this.Controls.Add(this.cheetohidden);
            this.Controls.Add(this.bosshealthpack);
            this.Controls.Add(this.poisonhealthpack);
            this.Controls.Add(this.scoreboard);
            this.Controls.Add(this.difficultypanel);
            this.Controls.Add(this.char3);
            this.Controls.Add(this.char2);
            this.Controls.Add(this.char1);
            this.Controls.Add(this.playpause);
            this.Controls.Add(this.restart);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.picWall11);
            this.Controls.Add(this.picWall2);
            this.Controls.Add(this.picWall8);
            this.Controls.Add(this.picWall7);
            this.Controls.Add(this.picWall1);
            this.Controls.Add(this.picWall0);
            this.Controls.Add(this.picWall10);
            this.Controls.Add(this.picWall9);
            this.Controls.Add(this.picWall6);
            this.Controls.Add(this.picWall12);
            this.Controls.Add(this.picWall4);
            this.Controls.Add(this.picWall5);
            this.Controls.Add(this.picEnemyCheeto);
            this.Controls.Add(this.picEnemyPoisonPacket);
            this.Controls.Add(this.picWall3);
            this.Controls.Add(this.picBossKoolAid);
            this.Controls.Add(this.picPlayer);
            this.Controls.Add(this.lblInGameTime);
            this.DoubleBuffered = true;
            this.Name = "FrmLevel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Explore";
            this.Load += new System.EventHandler(this.FrmLevel_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmLevel_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmLevel_KeyUp);
            this.difficultypanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.poisonhealthpack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.easybox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediumbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hardbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.char3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.char2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.char1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playpause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemyCheeto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemyPoisonPacket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBossKoolAid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosshealthpack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheetohidden)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.PictureBox picPlayer;
    private System.Windows.Forms.PictureBox picBossKoolAid;
    private System.Windows.Forms.Label lblInGameTime;
    private System.Windows.Forms.Timer tmrUpdateInGameTime;
    private System.Windows.Forms.Timer tmrPlayerMove;
    private System.Windows.Forms.PictureBox picWall3;
    private System.Windows.Forms.PictureBox picEnemyPoisonPacket;
    private System.Windows.Forms.PictureBox picEnemyCheeto;
    private System.Windows.Forms.PictureBox picWall5;
    private System.Windows.Forms.PictureBox picWall4;
    private System.Windows.Forms.PictureBox picWall12;
    private System.Windows.Forms.PictureBox picWall6;
    private System.Windows.Forms.PictureBox picWall9;
    private System.Windows.Forms.PictureBox picWall10;
    private System.Windows.Forms.PictureBox picWall0;
    private System.Windows.Forms.PictureBox picWall7;
    private System.Windows.Forms.PictureBox picWall8;
    private System.Windows.Forms.PictureBox picWall1;
    private System.Windows.Forms.PictureBox picWall2;
    private System.Windows.Forms.PictureBox picWall11;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox restart;
        private System.Windows.Forms.PictureBox playpause;
        private System.Windows.Forms.PictureBox char1;
        private System.Windows.Forms.PictureBox char2;
        private System.Windows.Forms.PictureBox char3;
        private System.Windows.Forms.FlowLayoutPanel difficultypanel;
        private System.Windows.Forms.PictureBox easybox;
        private System.Windows.Forms.PictureBox mediumbox;
        private System.Windows.Forms.PictureBox hardbox;
        private System.Windows.Forms.Label scoreboard;
        private System.Windows.Forms.PictureBox poisonhealthpack;
        private System.Windows.Forms.PictureBox bosshealthpack;
        private System.Windows.Forms.PictureBox cheetohidden;
    }
}

