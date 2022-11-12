using Fall2020_CSC403_Project.code;
using Fall2020_CSC403_Project.Properties;
using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project {
  public partial class FrmLevel : Form {
    private Player player;

    private Enemy enemyPoisonPacket;
    private Enemy bossKoolaid;
    private Enemy enemyCheeto;
    private Character[] walls;

    private DateTime timeBegin;
    private FrmBattle frmBattle;
    private int switchimage=-1;
    private int flag = 1;
    private int poisionflag = -1;
    private int cheetoflag = -1;
    private int bossflag = -1;
    private int dresscode;
    private int score = 0;
        public FrmLevel() {
      InitializeComponent();
    }

    private void FrmLevel_Load(object sender, EventArgs e) {
      const int PADDING = 7;
      const int NUM_WALLS = 13;

      player = new Player(CreatePosition(picPlayer), CreateCollider(picPlayer, PADDING));
      bossKoolaid = new Enemy(CreatePosition(picBossKoolAid), CreateCollider(picBossKoolAid, PADDING));
      enemyPoisonPacket = new Enemy(CreatePosition(picEnemyPoisonPacket), CreateCollider(picEnemyPoisonPacket, PADDING));
      enemyCheeto = new Enemy(CreatePosition(picEnemyCheeto), CreateCollider(picEnemyCheeto, PADDING));

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
               // update player's picture box
               picPlayer.Location = new Point((int)player.Position.x, (int)player.Position.y);
           }
            enemycheck();
            
        }

        private void enemycheck()
        {
            if (enemyPoisonPacket.Health < 0 && poisionflag == -1)
            {
                score += 30;
                poisionflag *= -1;
                picEnemyPoisonPacket.Enabled = false;
                picEnemyPoisonPacket.Visible = false;
            }
            if (enemyCheeto.Health < 0 && cheetoflag == -1)
            {
                score += 40;
                cheetoflag *= -1;
                picEnemyCheeto.Enabled = false;
                picEnemyCheeto.Visible = false;
            }
            if (bossKoolaid.Health < 0 && bossflag == -1)
            {
                score += 80;
                picBossKoolAid.Size = new Size(picBossKoolAid.Width/2, picBossKoolAid.Height/2);
                bossflag *= -1;
                picBossKoolAid.Enabled = false;
                picBossKoolAid.Visible = false;
            }
        }

    private bool HitAWall(Character c) {
      bool hitAWall = false;
      for (int w = 0; w < walls.Length; w++) {
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

    private void HitHealthPack(Character you)
    {
         player.Health += 10; 
    }

   private void Fight(Enemy enemy) {
      player.ResetMoveSpeed();
      player.MoveBack();
      frmBattle = FrmBattle.GetInstance(enemy, dresscode);
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
            easylevel();
        }

        private void easylevel()
        {
            buttoncontrols();
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
            mediumlevel();
        }

        private void mediumlevel()
        {
            buttoncontrols();
        }

        private void hardbox_Click(object sender, EventArgs e)
        {
            flag = -1;
            hardlevel();
        }

        private void hardlevel()
        {
            buttoncontrols();
        }
    }
}
