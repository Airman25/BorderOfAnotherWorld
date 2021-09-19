using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BorderOfAnotherWorld
{
    public partial class ABorderOfAnotherWorld : Form
    {
        public ABorderOfAnotherWorld()
        {
            InitializeComponent();
            StartSetUp();

        }
        bool ShowingScan = false;
        bool IHaveWon = false;
        bool firstBattleWon = false;
        int herohp = 1;
        int heromaxhp = 2;
        int heromp = 1;
        int enemy1hp = 1;
        int heropower = 1;
        int heroStep = 30;
        int gamelanguage = 0;
        string heroDirection = "Up";
        string SavedDataABOAW = "";
        int HeroxLocation = 845;
        int HeroyLocation = 550;
        int RoomUp = 0;
        int RoomLeft = 0;
        int BattleNumber = 0;
        int PortalSize = 50;
        int FirstTimeChecker = 1;
        string HeroHelathText, HeroManaText = "";
        
        private void StartSetUp()
        {
            BackToMenu.Enabled = false;
            BackToMenu.Hide();
            LanguageChoose.Hide();
            LanguageChoose.Enabled = false;
            Back.Hide();
            Back.Enabled = false;
            Hero.Hide();
            ChapterStart.Hide();
            ChapterStart.Enabled = false;
            Tutorial.Size = new Size(1940, 1100);
            Tutorial.Hide();
            Tutorial.Enabled = false;
            SaveTheGame.Hide();
            SaveTheGame.Enabled = false;
            BackToMenu.Hide();
            BackToMenu.Enabled = false;
            Continue.Hide();
            Continue.Enabled = false;
            ProgrammedBy.Hide();
            Airman25.Hide();
            Attack.Hide();
            Attack.Enabled = false;
            Strategy.Hide();
            Strategy.Enabled = false;
            Skills.Hide();
            Skills.Enabled = false;
            Items.Hide();
            Items.Enabled = false;
            EnemyBox1.Hide();
            Enemy1InBattle.Hide();
            HeroInBattle.Hide();
            Shield.Hide();
            Shield.Enabled = false;
            Scan.Hide();
            Scan.Enabled = false;
            RunAway.Hide();
            RunAway.Enabled = false;
            Portal.Hide();
            ChapterI.Hide();
            Stats1.Hide();
            StatsText1.Hide();
            HeroHealt.Hide();
            HeroMana.Hide();
            LoseScreen.Hide();
            XPget.Hide();
            MoneyGet.Hide();
            Cactus.Hide();
            Cactus2.Hide();
            GameSetup();
        }

        private void GameSetup()
        {

            if (gamelanguage == 0)
            {
                Exit.Text = "Exit";
                Settings.Text = "Settings";
                Medals.Text = "Medals";
                Play.Text = "Play";
                LanguageChoose.Text = "Language: English";
                Back.Text = "Back";
                Tutorial.Text = " Move - W A S D \n Interact - Space \n Pause - P \n Press on the screen to continue \n \n \n \n \n \n";
                SaveTheGame.Text = "Save the game";
                BackToMenu.Text = "Back to menu";
                Load.Text = "Load a save";
                Continue.Text = "Continue";
                Credits.Text = "Credits";
                ProgrammedBy.Text = "Programmed by:";
                Airman25.Text = "Airman25";
                Attack.Text = "Attack";
                Strategy.Text = "Strategy";
                Skills.Text = "Skills";
                Items.Text = "Items";
                Shield.Text = "";
                Scan.Text = "";
                RunAway.Text = "";
                ChapterStart.Text = "Press to continue";
                ChapterStart.Size = new Size(315, 56);
                ChapterI.Text = "Chapter I: The endless sand";
                HeroHelathText = "HP:";
                HeroManaText = "MP:";

            }
            if (gamelanguage == 1)
            {
                Exit.Text = "Выйти";
                Settings.Text = "Настройки";
                Medals.Text = "Медали";
                Play.Text = "Играть";
                LanguageChoose.Text = "Язык: Русский";
                Back.Text = "Назад";
                Tutorial.Text = " Двигаться - W A S D (ц ф ы в) \n Взаимодействовать - Пробел \n Пауза - P (з) \n Нажмите чтобы продолжить \n \n \n \n \n \n";
                SaveTheGame.Text = "Сохранить игру";
                BackToMenu.Text = "Обратно в меню";
                Load.Text = "Загрузить файл сохранения";
                Continue.Text = "Продолжить";
                Credits.Text = "Авторы";
                ProgrammedBy.Text = "Програмироавно:";
                Airman25.Text = "Airman25";
                Attack.Text = "Атака";
                Strategy.Text = "Стратегия";
                Skills.Text = "Скилы";
                Items.Text = "Предметы";
                Shield.Text = "";
                Scan.Text = "";
                RunAway.Text = "";
                ChapterStart.Text = "Нажмите чтобы продолжить";
                ChapterStart.Size = new Size(526, 56); 
                ChapterI.Text = "Глава 1: Бесконечный песок";
                HeroHelathText = "ХП:";
                HeroManaText = "МП:";


            }

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            AllOff();
            LanguageChoose.Show();
            LanguageChoose.Enabled = true;
            
        }

        private void Medals_Click(object sender, EventArgs e)
        {
            AllOff();

        }

        private void Play_Click(object sender, EventArgs e)
        {
            AllOff();
            Back.Enabled = false;
            Back.Hide();
            Tutorial.Show();
            Tutorial.Enabled = true;
        }

        private void AllOff()
        {
            Exit.Hide();
            Exit.Enabled = false;
            Play.Hide();
            Play.Enabled = false;
            Settings.Hide();
            Settings.Enabled = false;
            Medals.Hide();
            Medals.Enabled = false;
            Load.Hide();
            Load.Enabled = false;
            Credits.Hide();
            Credits.Enabled = false;
            Back.Show();
            Back.Enabled = true;
        }

        private void AllOn()
        {
            Exit.Show();
            Exit.Enabled = true;
            Play.Show();
            Play.Enabled = true;
            Settings.Show();
            Settings.Enabled = true;
            Medals.Show();
            Medals.Enabled = true;
            Load.Show();
            Load.Enabled = true;
            Credits.Show();
            Credits.Enabled = true;
        }

        private void LanguageChoose_Click(object sender, EventArgs e)
        {
            if (gamelanguage == 0)
            {
                gamelanguage = 1;
            }
            else
            {
                gamelanguage = 0;
            }
            GameSetup();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            LanguageChoose.Hide();
            LanguageChoose.Enabled = false;
            Back.Hide();
            Back.Enabled = false;
            ProgrammedBy.Hide();
            Airman25.Hide();
            AllOn();
        }

        private void ABorderOfAnotherWorld_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W | e.KeyCode == Keys.Up)
            {
                Hero.Top -= heroStep;
                if ( (EnemyBox1.Visible == true && Hero.Bounds.IntersectsWith(EnemyBox1.Bounds)) || (Cactus.Visible == true && Hero.Bounds.IntersectsWith(Cactus.Bounds)) || (Cactus2.Visible == true && Hero.Bounds.IntersectsWith(Cactus2.Bounds)))
                {
                    Hero.Top += heroStep;
                }
                heroDirection = "up";
                e.Handled = e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.S | e.KeyCode == Keys.Down)
            {
                Hero.Top += heroStep;
                if ((EnemyBox1.Visible == true && Hero.Bounds.IntersectsWith(EnemyBox1.Bounds)) || (Cactus.Visible == true && Hero.Bounds.IntersectsWith(Cactus.Bounds)) || (Cactus2.Visible == true && Hero.Bounds.IntersectsWith(Cactus2.Bounds)))
                {
                    Hero.Top -= heroStep;
                }
                heroDirection = "down";
                e.Handled = e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.A | e.KeyCode == Keys.Left)
            {
                Hero.Left -= heroStep;
                if ((EnemyBox1.Visible == true && Hero.Bounds.IntersectsWith(EnemyBox1.Bounds)) || (Cactus.Visible == true && Hero.Bounds.IntersectsWith(Cactus.Bounds)) || (Cactus2.Visible == true && Hero.Bounds.IntersectsWith(Cactus2.Bounds)))
                {
                    Hero.Left += heroStep;
                }
                heroDirection = "left";
                e.Handled = e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.D | e.KeyCode == Keys.Right)
            {
                Hero.Left += heroStep;
                if ((EnemyBox1.Visible == true && Hero.Bounds.IntersectsWith(EnemyBox1.Bounds)) || (Cactus.Visible == true && Hero.Bounds.IntersectsWith(Cactus.Bounds)) || (Cactus2.Visible == true && Hero.Bounds.IntersectsWith(Cactus2.Bounds)))
                {
                    Hero.Left -= heroStep;
                }
                heroDirection = "right";
                e.Handled = e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.P)
            {
                BackToMenu.Enabled = true;
                BackToMenu.Show();
                SaveTheGame.Enabled = true;
                SaveTheGame.Show();
                Continue.Enabled = true;
                Continue.Show();               
                Hero.Hide();
                e.Handled = e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.Space)
            {

                Hero.Top -= 20;
                Hero.Left -= 20;
                Hero.Size = new Size(Hero.Height + 40, Hero.Width+40);
                if (EnemyBox1.Visible == true && Hero.Bounds.IntersectsWith(EnemyBox1.Bounds))
                {
                    EnemyBox1.Hide();
                    Cactus.Hide();
                    BattleNumber = 1;
                    Battle();
                    
                }
                Hero.Top += 20;
                Hero.Left += 20;
                Hero.Size = new Size(Hero.Height - 40, Hero.Width - 40);
                e.Handled = e.SuppressKeyPress = true;
            }
            
            HeroBorderCollision();
        }

        private void HeroBorderCollision()
        {
            if (Hero.Top + Hero.Height < 0)
            {
                Hero.Top = ClientRectangle.Height;
                RoomUp += 1;
            }
            if (Hero.Top > ClientRectangle.Height)
            {
                Hero.Top = 0 - Hero.Height;
                RoomUp -= 1;
            }
            if (Hero.Left + Hero.Width < 0)
            {
                Hero.Left = ClientRectangle.Width;
                RoomLeft += 1;
                FirstTimeChecker = 1;
            }
            if (Hero.Left > ClientRectangle.Width)
            {
                Hero.Left = 0 - Hero.Width;
                RoomLeft -= 1;
                FirstTimeChecker = 1;
            }
            
        }

        private void Textures()
        {
            //this.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(heroImageName);
            //hero.Image = (Image)Properties.Resources.ResourceManager.GetObject(heroImageName);
        }

        private void Tutorial_Click(object sender, EventArgs e)
        {
            Tutorial.Enabled = false;
            Tutorial.Hide();
            Textures();
            Hero.Show();
            Hero.Location = new Point(HeroxLocation, HeroyLocation);
        }

        private void BackToMenu_Click(object sender, EventArgs e)
        {
            BackToMenu.Enabled = false;
            BackToMenu.Hide();
            SaveTheGame.Hide();
            SaveTheGame.Enabled = false;
            Continue.Hide();
            Continue.Enabled = false;
            AllOn();
        }

        private void SaveTheGame_Click(object sender, EventArgs e)
        {
            

            if (SavingABOAW.ShowDialog() == DialogResult.Cancel)
                return;
            // ура я нашел это (если что смотрел я тут https://metanit.com/sharp/windowsforms/4.20.php)
            string filename = SavingABOAW.FileName;
            System.IO.File.WriteAllText(filename, "Coordinates: ] " + Hero.Top + "] " + Hero.Left+ "] " + "\n Language: ]" + gamelanguage + "] ");
        }

        private void Load_Click(object sender, EventArgs e)
        {
            if (OpeningABOAW.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = OpeningABOAW.FileName;
            string fileText = System.IO.File.ReadAllText(filename);
            SavedDataABOAW = fileText;
            var xCor = SavedDataABOAW.Split(']').Skip(1).FirstOrDefault();
            var yCor = SavedDataABOAW.Split(']').Skip(2).FirstOrDefault();
            HeroxLocation = int.Parse(xCor);
            HeroyLocation = int.Parse(yCor);
            var LanguageChoose = SavedDataABOAW.Split(']').Skip(4).FirstOrDefault();
            gamelanguage = int.Parse(LanguageChoose);
            GameSetup();
        }

        private void Continue_Click(object sender, EventArgs e)
        {
            BackToMenu.Enabled = false;
            BackToMenu.Hide();
            SaveTheGame.Hide();
            SaveTheGame.Enabled = false;
            Continue.Hide();
            Continue.Enabled = false;
            Textures();
            Hero.Show();
        }

        private void Credits_Click(object sender, EventArgs e)
        {
            AllOff();
            ProgrammedBy.Show();
            Airman25.Show();
        }

        private void Airman25_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UChI6pEoYRanwgUVViQbnxrw");
        }

        private void Battle()
        {
            RoomLeft = 999;
            RoomUp = 999;
            herohp = heromaxhp;
            Hero.Hide();
            MyTurn();
            HeroHealt.Show();
            HeroMana.Show();
            if (BattleNumber==1)
            {
                HeroInBattle.Show();
                Enemy1InBattle.Show();
                enemy1hp = 1;
            }
        }

        private void Attack_Click(object sender, EventArgs e)
        {
            enemy1hp -= heropower;
            OtherTurn();
            EnemyTurn();

        }

        private void Strategy_Click(object sender, EventArgs e)
        {
            if (Shield.Enabled == true)
            {
                Shield.Hide();
                Shield.Enabled = false;
                Scan.Hide();
                Scan.Enabled = false;
                RunAway.Hide();
                RunAway.Enabled = false;
            } 
            else
            {
                Shield.Show();
                Shield.Enabled = true;
                Scan.Show();
                Scan.Enabled = true;
                RunAway.Show();
                RunAway.Enabled = true;
            }
            
        }

        private void Shield_MouseEnter(object sender, EventArgs e)
        {
            //Hero.Show();
        }

        private void Shield_MouseLeave(object sender, EventArgs e)
        {
            //Hero.Hide();
        }

        private void TheFirstPortalEnter()
        {
            Hero.Hide();
            Portal.Hide();
            this.BackColor = SystemColors.ActiveCaptionText;
            RoomChecker.Stop();
            ChapterStart.Show();
            ChapterStart.Enabled = true;
            ChapterI.Show();
            Hero.Top = 200;
            Hero.Left = 200;
            

        }

        private void TheSamePortal(int RoomLeftCheck, int RoomUpCheck)
        {
            if (RoomLeft == RoomLeftCheck && RoomUp == RoomUpCheck && PortalSize > 50)
            {
                if (FirstTimeChecker == 1)
                {
                    PortalSize = 50;
                    Portal.Top = 1100;
                    Portal.Left = 2240;
                    PortalSize += 1500;
                    Portal.Top -= 1500;
                    FirstTimeChecker = 0;
                }
                Portal.Size = new Size(PortalSize, PortalSize);
                PortalSize += 50;
                Portal.Left -= 20;
                if (Hero.Bounds.IntersectsWith(Portal.Bounds))
                {
                    TheFirstPortalEnter();

                }
            }
        }

        private void RoomChecker_Tick(object sender, EventArgs e)
        {
            TheSamePortal(0, 0);
            TheSamePortal(1, 0);
            TheSamePortal(2, 0);
            TheSamePortal(3, 0);
            TheSamePortal(4, 0);
            TheSamePortal(5, 0);
            TheSamePortal(6, 0);
            TheSamePortal(7, 0);
            TheSamePortal(8, 0);
            TheSamePortal(9, 0);
            if (RoomLeft == -1 && RoomUp == 0)
            {
                if (Hero.Bounds.IntersectsWith(Portal.Bounds))
                {
                    TheFirstPortalEnter();
                }
                if (PortalSize == 50)
                {
                    Portal.Show();
                    PortalSize += 1500;
                    Portal.Top -= 1500;
                }

                Portal.Size = new Size(PortalSize, PortalSize);
                PortalSize += 50;
                Portal.Left -= 20;
            }

            
        }

        private void ChapterStart_Click(object sender, EventArgs e)
        {
            FirstChapter();
        }

        private void ABorderOfAnotherWorld_MouseClick(object sender, MouseEventArgs e)
        {
            if (ChapterStart.Enabled == true)
            {
                FirstChapter();
            }
            if (herohp < 1)
            {
                Application.Restart();
            }
            if (IHaveWon==true)
            {
                XPget.Hide();
                MoneyGet.Hide();
                HeroInBattle.Hide();
                Hero.Show();
                if (BattleNumber == 1)
                {
                    Cactus.Show();
                }
                IHaveWon = false;
            }
        }

        private void FirstChapter()
        {
            ChapterStart.Hide();
            ChapterStart.Enabled = false;
            ChapterI.Hide();
            Hero.Show();
            this.BackColor = SystemColors.Info;
            RoomLeft = 0;
            RoomUp = 0;
            SandRoomChecker.Start();
            
        }

        private void Skills_Click(object sender, EventArgs e)
        {
            if (Shield.Enabled == true)
            {
                Shield.Hide();
                Shield.Enabled = false;
                Scan.Hide();
                Scan.Enabled = false;
                RunAway.Hide();
                RunAway.Enabled = false;
            }
        }

        private void Items_Click(object sender, EventArgs e)
        {
            if (Shield.Enabled == true)
            {
                Shield.Hide();
                Shield.Enabled = false;
                Scan.Hide();
                Scan.Enabled = false;
                RunAway.Hide();
                RunAway.Enabled = false;
            }
        }

        private void RunAway_Click(object sender, EventArgs e)
        {
            HeroInBattle.Hide();
            Hero.Show();
            OtherTurn();
            HeroHealt.Hide();
            HeroMana.Hide();
            if (BattleNumber==1)
            {
                Enemy1InBattle.Hide();
                EnemyBox1.Show();
                RoomLeft = 0;
                RoomUp = 0;
            }
        }

        private void Stats1_MouseEnter(object sender, EventArgs e)
        {
            StatsText1.Show();
        }

        private void Stats1_MouseLeave(object sender, EventArgs e)
        {
            StatsText1.Hide();
        }

        private void Scan_Click(object sender, EventArgs e)
        {
            ShowingScan = true;
            OtherTurn();
            EnemyTurn();
        }

        private void Win()
        {
            HeroHealt.Hide();
            HeroMana.Hide();
            if (BattleNumber ==1)
            {
                XPget.Text = "1";
                MoneyGet.Text = "1";
                firstBattleWon = true;
                RoomLeft = 0;
                RoomUp = 0;
            }
            XPget.Show();
            MoneyGet.Show();
        }

        private void MyTurn()
        {
            HeroHealt.Text = HeroHelathText + herohp;
            HeroMana.Text = HeroManaText + heromp;
            Attack.Show();
            Attack.Enabled = true;
            Strategy.Show();
            Strategy.Enabled = true;
            Skills.Show();
            Skills.Enabled = true;
            Items.Show();
            Items.Enabled = true;
            if (ShowingScan == true)
            {
                if (enemy1hp > 0)
                {
                    Stats1.Show();
                    StatsText1.Text = "" + enemy1hp;
                }
            }
        }

        private void EnemyTurn()
        {
            if (enemy1hp < 1)
            {
                Enemy1InBattle.Hide();
                Stats1.Hide();
                IHaveWon = true;
                Win();
            }
            if (BattleNumber == 1)
            {
                if (enemy1hp > 0)
                {
                    herohp -= 1;
                }
            }
            if (herohp < 1)
            {
                HeroInBattle.Hide();
                HeroHealt.Hide();
                HeroMana.Hide();
                if (BattleNumber == 1)
                {
                    Enemy1InBattle.Hide();
                }
                this.BackColor = SystemColors.ActiveCaptionText;
                LoseScreen.Show();
            }
            else if (IHaveWon == false)
            {
                MyTurn();
            }


        }

        private void SandRoomChecker_Tick(object sender, EventArgs e)
        {
            if (RoomLeft == 0 && RoomUp == 0)
            {
                if (!firstBattleWon)
                {
                    EnemyBox1.Show();
                }
                Cactus.Show();
                Cactus2.Show();
            }else
            {
                EnemyBox1.Hide();
                Cactus2.Hide();
            }
            if (RoomLeft == -1 && RoomUp == 0)
            {
                Cactus.Show();
            }
            if (RoomLeft == 999 && RoomUp == 999)
            {
                Cactus.Hide();
            }

        }

        private void OtherTurn()
        {
            Attack.Hide();
            Attack.Enabled = false;
            Strategy.Hide();
            Strategy.Enabled = false;
            Skills.Hide();
            Skills.Enabled = false;
            Items.Hide();
            Items.Enabled = false;
            Stats1.Hide();
            StatsText1.Hide();
            if (Shield.Enabled == true)
            {
                Shield.Hide();
                Shield.Enabled = false;
                Scan.Hide();
                Scan.Enabled = false;
                RunAway.Hide();
                RunAway.Enabled = false;
            }
            
        }






    }
}

