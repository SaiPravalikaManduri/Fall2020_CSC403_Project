using Fall2020_CSC403_Project.code;
using Fall2020_CSC403_Project.Properties;
using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project {
  public partial class FrmBattle : Form {
    public static FrmBattle instance = null;
    private Enemy enemy;
    private static int dresscode;
    private static int weaponcode;
    private Player player;
    public SoundPlayer wSound;
    private static bool sheild;

        private FrmBattle() {
      InitializeComponent();
      player = Game.player;
    }

    public void Setup() {
            // update for this enemy
      playerdress();
      playerweapon();
      picEnemy.BackgroundImage = enemy.Img;
      picEnemy.Refresh();
      BackColor = enemy.Color;
      picBossBattle.Visible = false;

      // Observer pattern
      enemy.AttackEvent += PlayerDamage;
      player.AttackEvent += EnemyDamage;
            if (sheild == true) 
            { this.picPlayer.BackColor = System.Drawing.Color.Red; }
            // show health
            UpdateHealthBars();
    }

        private void playerweapon()
        {
            if (weaponcode == 1)
            {
                wSound = new SoundPlayer(Resources.boomeraud);
                
               
            }
            else if (weaponcode == 2)
            {
                wSound = new SoundPlayer(Resources.gunaud);
                
            }
            else if (weaponcode == 3)
            {
                wSound = new SoundPlayer(Resources.swordaud);
                
            }
        }

        private void playerdress()
     {
            if(dresscode == 1)
            {
                picPlayer.BackgroundImage = Properties.Resources.player;
            }
            else if (dresscode == 2)
            {
                picPlayer.BackgroundImage = Properties.Resources.char2;
            }
            else if (dresscode == 3)
            {
                picPlayer.BackgroundImage = Properties.Resources.LaraCroftInfobox;
            }
            
     }

        public void SetupForBossBattle() {
      picBossBattle.Location = Point.Empty;
      picBossBattle.Size = ClientSize;
      // picBossBattle.Visible = true;
     
      SoundPlayer simpleSound = new SoundPlayer(Resources.final_battle);
      simpleSound.Play();

      tmrFinalBattle.Enabled = true;
    }

    public static FrmBattle GetInstance(Enemy enemy, int code,int wcode,bool s) {
      dresscode = code;
      weaponcode = wcode;
       sheild= s ;
      if (instance == null) {
        instance = new FrmBattle();
        instance.enemy = enemy;
        instance.Setup();
      }
            
      
      return instance;
    }

    private void UpdateHealthBars() {
      float playerHealthPer = player.Health / (float)player.MaxHealth;
      float enemyHealthPer = enemy.Health / (float)enemy.MaxHealth;

      const int MAX_HEALTHBAR_WIDTH = 226;
      lblPlayerHealthFull.Width = (int)(MAX_HEALTHBAR_WIDTH * playerHealthPer);
      lblEnemyHealthFull.Width = (int)(MAX_HEALTHBAR_WIDTH * enemyHealthPer);

      lblPlayerHealthFull.Text = player.Health.ToString();
      lblEnemyHealthFull.Text = enemy.Health.ToString();
    }

    private void btnAttack_Click(object sender, EventArgs e) {
            
            if (weaponcode == 1)
            {
                player.OnAttack(-2);


            }
            else if (weaponcode == 2)
            {
                player.OnAttack(-6);

            }
            else if (weaponcode == 3)
            {
                player.OnAttack(-4);

            }
            else { player.OnAttack(-1); }
            
     
      if (enemy.Health > 0) {
        if (sheild == true)
                { enemy.OnAttack(-1); }
        else
                { enemy.OnAttack(-2); }
      }
      if (weaponcode > 0) 
      { wSound.Play(); }  
      
      UpdateHealthBars();
      if (player.Health <= 0 || enemy.Health <= 0) {
        instance = null;
        Close();
      }
    }

    private void EnemyDamage(int amount) {
      enemy.AlterHealth(amount);
    }

    private void PlayerDamage(int amount) {
      player.AlterHealth(amount);
    }

    private void tmrFinalBattle_Tick(object sender, EventArgs e) {
      picBossBattle.Visible = false;
      tmrFinalBattle.Enabled = false;
    }
  }
}
