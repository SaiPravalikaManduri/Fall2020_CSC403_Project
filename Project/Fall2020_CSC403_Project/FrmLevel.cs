using Fall2020_CSC403_Project.code;
using Fall2020_CSC403_Project.Properties;
using MyGameLibrary;
using System;
using System.Drawing;
using System.Media;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Windows.Forms;
namespace Fall2020_CSC403_Project {
  public partial class FrmLevel : Form {
    private Player player;

    private Enemy enemyPoisonPacket;
    private Enemy bossKoolaid;
    private Enemy enemyCheeto;
    private Healths phealth;
    private Healths chealth;
    private Healths bhealth;
    private Healths mhealth;
    private Reward preward;
    private Character[] walls;

    private DateTime timeBegin;
    private FrmBattle frmBattle;
    private int switchimage=-1;
    private int flag = 1;
    private int poisionflag = -1;
    private int cheetoflag = -1;
    private int bossflag = -1;
    private int dresscode=1;
    private int weaponcode=0;
    private int score = 0;
    private int easylevel = 2;
    private int mediumlevel = 4;
    private int hardlevel = 8;
    private int leveltracker = 0;
    private int bosscounter;
    private bool sheild = false;
    private int NUM_WALLS = 16;
    private int PADDING = 7;
    private int wallcounter;
    private  SoundPlayer bSound;
    private SoundPlayer lSound;
    private SoundPlayer wiSound;
    private SoundPlayer wSound;
        bool bgplay = false;
    public FrmLevel() {
      InitializeComponent();
            
            
        }

    private void FrmLevel_Load(object sender, EventArgs e) {
      
      

      player = new Player(CreatePosition(picPlayer), CreateCollider(picPlayer, PADDING));
      bossKoolaid = new Enemy(CreatePosition(picBossKoolAid), CreateCollider(picBossKoolAid, PADDING));
      enemyPoisonPacket = new Enemy(CreatePosition(picEnemyPoisonPacket), CreateCollider(picEnemyPoisonPacket, PADDING));
      enemyCheeto = new Enemy(CreatePosition(picEnemyCheeto), CreateCollider(picEnemyCheeto, PADDING));
      phealth = new Healths(CreatePosition(picpoisonhealth), CreateCollider(picpoisonhealth, PADDING));
      chealth = new Healths(CreatePosition(piccheetohealth), CreateCollider(piccheetohealth, PADDING));
      bhealth = new Healths(CreatePosition(picbosshealth), CreateCollider(picbosshealth, PADDING));
      mhealth = new Healths(CreatePosition(picmysteryhealth), CreateCollider(picmysteryhealth, PADDING));
      preward = new Reward(CreatePosition(picrewards), CreateCollider(picrewards, PADDING));
      bossKoolaid.Img = picBossKoolAid.BackgroundImage;
      enemyPoisonPacket.Img = picEnemyPoisonPacket.BackgroundImage;
      enemyCheeto.Img = picEnemyCheeto.BackgroundImage;

      bossKoolaid.Color = Color.Red;
      enemyPoisonPacket.Color = Color.Green;
      enemyCheeto.Color = Color.FromArgb(255, 245, 161);

      walls = new Character[NUM_WALLS];

      for (int w = 0; w < NUM_WALLS; w++) {
        PictureBox pic = Controls.Find("picWall" + w.ToString(), true)[0] as PictureBox;
        walls[w] = new Character(CreatePosition(pic), CreateCollider(pic, PADDING));
      }
      wallcounter = walls.Length;
      Game.player = player;
      timeBegin = DateTime.Now;
           

        }

    private Vector2 CreatePosition(PictureBox pic) {
      return new Vector2(pic.Location.X, pic.Location.Y);
    }

    private Collider CreateCollider(PictureBox pic, int padding) {
      Rectangle rect = new Rectangle(pic.Location, new Size(pic.Size.Width - padding, pic.Size.Height - padding));
      return new Collider(rect);
    }

    private void FrmLevel_KeyUp(object sender, KeyEventArgs e) {
      player.ResetMoveSpeed();
    }

    private void tmrUpdateInGameTime_Tick(object sender, EventArgs e) {
      TimeSpan span = DateTime.Now - timeBegin;
      string time = span.ToString(@"hh\:mm\:ss");
      lblInGameTime.Text = "Time: " + time.ToString();
    }

    private void tmrPlayerMove_Tick(object sender, EventArgs e) {
           if (flag == -1)
           {
               // move player
               player.Move();
           
               // check collision with walls
               if (HitAWall(player))
               {
                   player.MoveBack();
               }
               if (picrewards.Enabled == true)
               {
                   if (HitReward(player, preward))
                   {
                        score += 100;
                        picrewards.Visible = false;
                        picrewards.Enabled = false;
                   }
               }
               if (picpoisonhealth.Enabled == true)
               {
                   if (HitAhealthbox(player, phealth) && player.Health<player.MaxHealth)
                   {
                       healthmeter();
                       picpoisonhealth.Visible = false;
                       picpoisonhealth.Enabled = false;
                   }
               }

               if (piccheetohealth.Enabled == true)
               {
                   if (HitAhealthbox(player, chealth) && player.Health < player.MaxHealth)
                   {
                        healthmeter();
                        piccheetohealth.Visible = false;
                        piccheetohealth.Enabled = false;
                   }
               }
               if (picbosshealth.Enabled == true)
               {
                   if (HitAhealthbox(player, bhealth) && player.Health < player.MaxHealth)
                   {
                        healthmeter();
                        picbosshealth.Visible = false;
                        picbosshealth.Enabled = false;

                   }
               }
               if (picmysteryhealth.Enabled == true)
               {
                   if (HitAhealthbox(player, mhealth))
                   {
                       player.Health = player.MaxHealth;
                       picmysteryhealth.Visible = false;
                       picmysteryhealth.Enabled = false;
                       playersheild();
                   }
               }

                // check collision with enemies
               if (enemyPoisonPacket.Health >= 0)
               {
                   if (HitAChar(player, enemyPoisonPacket))
                   {
                        
                        Fight(enemyPoisonPacket);
                        
                        

                    }
                }
               if (enemyCheeto.Health >= 0)
               {
                   if (HitAChar(player, enemyCheeto))
                   {
                       Fight(enemyCheeto);
                   }
               }
               if (bossKoolaid.Health >= 0)
               {
                   if (HitAChar(player, bossKoolaid))
                   {
                       Fight(bossKoolaid);
                   }
           
               }
               
                if (player.Health <= 0)
                {
                    lSound = new SoundPlayer(Resources.losing);
                    lSound.Play();
                    flag = 1;
                    winlossbanner.Enabled = true;
                    winlossbanner.Visible = true;
                    this.winlossbanner.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.loose;
                }
                ScoreBaord();
                // update player's picture box
                picPlayer.Location = new Point((int)player.Position.x, (int)player.Position.y);
           }
            enemycheck();
            if (bossKoolaid.Health < 0 && enemyCheeto.Health < 0 && enemyPoisonPacket.Health < 0)
            {
                 wiSound = new SoundPlayer(Resources.You_Won);
                wiSound.Play();
                
                winlossbanner.Enabled = true;
                winlossbanner.Visible = true;
            }

        }

        private void ScoreBaord()
        {
            scoreboard.Text = "Your Score:-" + score;
        }

        private void playersheild()
        {
          this.picPlayer.BackColor = System.Drawing.Color.Red;
            sheild = true;
        }

        private bool HitAhealthbox(Character you, Character other)
        {
            return you.Collider.Intersects(other.Collider); ;
        }
        private bool HitReward(Character you, Character other)
        {
            return you.Collider.Intersects(other.Collider); ;
        }
        private void healthmeter()
        {
            player.Health += 5;
            if (player.Health > player.MaxHealth)
            {
                player.Health = player.MaxHealth;
            }
        }

        private void enemycheck()
        {
            if (enemyPoisonPacket.Health < 0 && poisionflag == -1)
            {
                score += 30;
                poisionflag *= -1;
                picEnemyPoisonPacket.Enabled = false;
                picEnemyPoisonPacket.Visible = false;
                if (leveltracker == 2 || leveltracker == 3)
                {
                    picpoisonhealth.Enabled = true;
                    picpoisonhealth.Visible = true;
                }
                
            }
            if (enemyCheeto.Health < 0 && cheetoflag == -1)
            {
                score += 40;
                cheetoflag *= -1;
                picEnemyCheeto.Enabled = false;
                picEnemyCheeto.Visible = false;
                if (leveltracker == 2 || leveltracker == 3)
                {
                    piccheetohealth.Enabled = true;
                    piccheetohealth.Visible = true;
                }

            }
            if (bossKoolaid.Health < 0 && bossflag == -1)
            {
                score += 80;
                picBossKoolAid.Size = new Size(picBossKoolAid.Width/2, picBossKoolAid.Height/2);
               
                if (bosscounter == 1)
                {
                    bossflag *= -1;
                    picBossKoolAid.Enabled = false;
                    picBossKoolAid.Visible = false;

                }
                else
                {
                    bossKoolaid.Health = 10;
                    bosscounter += 1;
                    picBossKoolAid.Enabled = true;
                    picBossKoolAid.Visible = true;
                    picrewards.Visible = true;
                    picrewards.Enabled = true;
                }
                if (leveltracker == 2)
                {
                    picbosshealth.Visible = true;
                    picbosshealth.Enabled = true;
                }
            }
           
        }

    private bool HitAWall(Character c) {
      bool hitAWall = false;
      for (int w = 0; w < wallcounter; w++) {
        if (c.Collider.Intersects(walls[w].Collider)) {
          hitAWall = true;
          break;
        }
      }
      return hitAWall;
    }

    private bool HitAChar(Character you, Character other) {
      return you.Collider.Intersects(other.Collider);
    }

    
   private void Fight(Enemy enemy) {
      player.ResetMoveSpeed();
      player.MoveBack();
      frmBattle = FrmBattle.GetInstance(enemy, dresscode,weaponcode,sheild);
      frmBattle.Show();
          
      if (enemy == bossKoolaid) {
        frmBattle.SetupForBossBattle();
      }
            
   }

    private void FrmLevel_KeyDown(object sender, KeyEventArgs e) {
      switch (e.KeyCode) {
        
        case Keys.Left:
          
          player.GoLeft();
          break;

        case Keys.Right:
         
          player.GoRight();
          break;

        case Keys.Up:
          player.GoUp();
          break;

        case Keys.Down:
          player.GoDown();
          break;

        default:
          player.ResetMoveSpeed();
          break;
      }
           
    }

    private void lblInGameTime_Click(object sender, EventArgs e) {

    }

    private void pictureBox1_Click(object sender, EventArgs e)
    {
            switchimage *= -1;
            if (switchimage == 1)
            {
                score += 2;
                run.BackgroundImage = Resources.run_50x50_stop;
                player.GO_INC = 8;
            }
            else { 
                run.BackgroundImage = Resources.run_50x50;
                player.GO_INC = 3;
            }
             
            
    }

        private void restart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void playpause_Click(object sender, EventArgs e)
        {
            flag *= -1;
            if (flag == 1) {
                playpause.Image = Resources.play;
            } 
            if(flag == -1)
            {
                playpause.Image = Resources.pause;
            }
        }

        private void char1_Click(object sender, EventArgs e)
        {
            picPlayer.BackgroundImage = Resources.player;
            dresscode = 1;
        }

        private void char2_Click(object sender, EventArgs e)
        {
            picPlayer.BackgroundImage = Resources.char2;
            dresscode = 2;
        }

        private void char3_Click(object sender, EventArgs e)
        {
            picPlayer.BackgroundImage = Resources.LaraCroftInfobox;
            dresscode = 3;
        }
       
        private void easy_Click(object sender, EventArgs e)
        {
            flag = -1;
            leveltracker = 1;
            easylevels();
            picmysteryhealth.Enabled = false;
            picmysteryhealth.Visible=false;

        }

        private void easylevels()
        {
            buttoncontrols();
            picpoisonhealth.Enabled = true;
            picpoisonhealth.Visible = true;
            piccheetohealth.Enabled = true;
            piccheetohealth.Visible= true;
            picbosshealth.Visible = true;
            picbosshealth.Enabled = true;
        }

        private void buttoncontrols()
        {
            difficultypanel.Enabled = false;
            difficultypanel.Visible = false;
            hammerhit.Enabled = true;
            hammerhit.Visible = true;
            run.Visible = true;
            run.Enabled = true;
            restart.Enabled = true;
            restart.Visible = true;
            playpause.Visible = true;
            playpause.Enabled = true;
        }
        private void medium_Click(object sender, EventArgs e)
        {
            flag = -1;
            leveltracker = 2;
            mediumlevels();
            picmysteryhealth.Visible = false;
            picmysteryhealth.Enabled=false;
        }

        private void mediumlevels()
        {
            buttoncontrols();
        }

        private void hardbox_Click(object sender, EventArgs e)
        {
            flag = -1;
            leveltracker = 3;
            hardlevels();
        }

        private void hardlevels()
        {
            buttoncontrols();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            weaponcode = 1;
            this.picboomer.BackColor = System.Drawing.Color.IndianRed;
            this.picgun.BackColor = System.Drawing.Color.Transparent;
            this.picsword.BackColor = System.Drawing.Color.Transparent;
        }

        private void picgun_Click(object sender, EventArgs e)
        {
            weaponcode = 2;
            this.picboomer.BackColor = System.Drawing.Color.Transparent;
            this.picgun.BackColor = System.Drawing.Color.IndianRed;
            this.picsword.BackColor = System.Drawing.Color.Transparent;
        }

        private void picsword_Click(object sender, EventArgs e)
        {
            weaponcode = 3;
            this.picboomer.BackColor = System.Drawing.Color.Transparent;
            this.picgun.BackColor = System.Drawing.Color.Transparent;
            this.picsword.BackColor = System.Drawing.Color.IndianRed;
        }

        private void hammerhit_Click(object sender, EventArgs e)
        {
            if(picPlayer.Location.Y <= 151 && picPlayer.Location.Y >= 78 && picPlayer.Location.X == 587)
            {

                wSound = new SoundPlayer(Resources.hammeraud);
                walldisable();
               
                wSound.Play();
               
                
                hammerhit.Visible=false;
                hammerhit.Enabled=false;
            }

        }
        private void walldisable()
        {

            picWall12.Enabled = false;
            picWall12.Visible = false;
            picWall13.Enabled = false;
            picWall13.Visible = false;
            picWall14.Enabled = false;
            picWall14.Visible = false;
            picWall15.Enabled = false;
            picWall15.Visible = false;
            wallcounter = 12;
            

        }
    }
}
