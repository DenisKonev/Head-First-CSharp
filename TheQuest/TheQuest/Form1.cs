using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheQuest
{
    public partial class Form1 : Form
    {
        private Game game;
        private Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender,EventArgs e)
        {
            game = new Game(new Rectangle(150, 125, 884, 385));
            game.NewLevel(random);
            UpdateCharacters();
        }

        private void UpdateCharacters()
        {
            playerSprite.Location = game.PlayerLocation;
            playerHitPoints.Text = game.PlayerHitPoints.ToString();
            bool showBat = false;
            bool showGhost = false;
            bool showGhoul = false;
            int enemiesShown = 0;
            // more code to go here...

            foreach (Enemy enemy in game.Enemies)
            {
                if (enemy is Bat)
                {
                    batSprite.Location = enemy.Location;
                    batHitPoints.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints > 0)
                    {
                        showBat = true;
                        enemiesShown++;
                    }
                }
                // etc...
                swordSprite.Visible = false;
                bowSprite.Visible = false;
                redPotionSprite.Visible = false;
                bluePotionSprite.Visible = false;
                maceSprite.Visible = false;
                Control weaponControl = null;
                switch (game.WeaponInRoom.Name)
                {
                    case "Sword":
                        weaponControl = swordSprite; 
                        break;
                }
                weaponControl.Location = game.WeaponInRoom.Location;
                if (game.WeaponInRoom.PickedUp)
                    weaponControl.Visible = false;
                else
                    weaponControl.Visible = true;
                if (game.PlayerHitPoints <= 0)
                {
                    MessageBox.Show("You died");
                    Application.Exit();
                }
                if (enemiesShown < 1)
                {
                    MessageBox.Show("You have defeated the enemies on this level");
                    game.NewLevel(random);
                    UpdateCharacters();
                }
            }
        }
        private void swordInv_Click(object sender, EventArgs e)
        {
            selectInventoryItem(swordInv, "Sword");
            uhideAttackButtons();
        }
        private void bowInv_Click(object sender, EventArgs e)
        {
            selectInventoryItem(bowInv, "Bow");
            uhideAttackButtons();
        }
        private void maceInv_Click(object sender, EventArgs e)
        {
            selectInventoryItem(maceInv, "Mace");
            uhideAttackButtons();
        }

        private void bluePotionInv_Click(object sender, EventArgs e)
        {
            selectInventoryItem(bluePotionInv, "Blue Potion");
            hideAttackButtons();
        }
        private void redPotionInv_Click(object sender, EventArgs e)
        {
            selectInventoryItem(redPotionInv, "Red Potion");
            hideAttackButtons();
        }
        private void selectInventoryItem(PictureBox pictureBox, string weaponName)
        {
            clearPictureBoxBorders();
            pictureBox.BorderStyle = BorderStyle.Fixed3D;
            if (game.CheckPlayerInventory(weaponName))
                game.Equip(weaponName);
        }

        private void clearPictureBoxBorders()
        {
            swordInv.BorderStyle = BorderStyle.None;
            bowInv.BorderStyle = BorderStyle.None;
            maceInv.BorderStyle = BorderStyle.None;
            bluePotionInv.BorderStyle = BorderStyle.None;
            redPotionInv.BorderStyle = BorderStyle.None;
        }
        private void hideAttackButtons()
        {
            //Hide Left, Right and Down attack buttons and change Up button to Drink
            attackLeftButton.Visible = false;
            attackRightButton.Visible = false;
            attackDownButton.Visible = false;
            attackUpButton.Text = "Drink";
        }
        private void uhideAttackButtons()
        {
            attackLeftButton.Visible = true;
            attackRightButton.Visible = true;
            attackDownButton.Visible = true;
            attackUpButton.Text = "Up";
        }
        private void moveUpButton_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Up, random);
            this.UpdateCharacters();
        }

        private void moveLeftButton_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Left, random);
            this.UpdateCharacters();
        }

        private void moveRightButton_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Right, random);
            this.UpdateCharacters();
        }

        private void moveDownButton_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Down, random);
            this.UpdateCharacters();
        }

        private void attackUpButton_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Up, random);
            this.UpdateCharacters();
        }

        private void attackLeftButton_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Left, random);
            this.UpdateCharacters();
        }

        private void attackRightButton_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Right, random);
            this.UpdateCharacters();
        }

        private void attackDownButton_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Down, random);
            this.UpdateCharacters();
        }
    }
}
