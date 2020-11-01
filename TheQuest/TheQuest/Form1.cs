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
            game = new Game(new Rectangle(150, 120, 840, 350));
            game.NewLevel(random);
            UpdateCharacters();
        }
        private void UpdateCharacters()
        {
            player.Location = game.PlayerLocation;
            playerHitPoints.Text = game.PlayerHitPoints.ToString();
            int enemiesShown = 0;

            foreach (Enemy enemy in game.Enemies)
            {
                if (enemy is Bat)
                {
                    bat.Location = enemy.Location;
                    batHitPoints.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints > 0)
                    {
                        bat.Visible = true;
                        enemiesShown++;
                    }
                    else
                    {
                        bat.Visible = false;
                        batHitPoints.Text = "0";
                    }
                }
                if (enemy is Ghost)
                {
                    ghost.Location = enemy.Location;
                    ghostHitPoints.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints > 0)
                    {
                        ghost.Visible = true;
                        enemiesShown++;
                    }
                    else
                    {

                        ghost.Visible = false;
                        ghostHitPoints.Text = "0";
                    }

                }
                if (enemy is Gnoul)
                {
                    gnoul.Location = enemy.Location;
                    gnoulHitPoints.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints > 0)
                    {
                        gnoul.Visible = true;
                        enemiesShown++;
                    }
                    else
                    {
                        gnoul.Visible = false;
                        gnoulHitPoints.Text = "0";
                    }
                }
            }

            sword.Visible = false;
            bow.Visible = false;
            redPotion.Visible = false;
            bluePotion.Visible = false;
            mace.Visible = false;

            Control weaponControl = null;
            switch (game.WeaponInRoom.Name)
            {
                case "Sword":
                    weaponControl = sword;
                    break;
                case "Bow":
                    weaponControl = bow;
                    break;
                case "Red Potion":
                    weaponControl = redPotion;
                    break;
                case "Blue Potion":
                    weaponControl = bluePotion;
                    break;
                case "Mace":
                    weaponControl = mace;
                    break;
            }

            if (game.CheckPlayerInventory("Sword"))
                swordInv.Visible = true;
            if (game.CheckPlayerInventory("Bow"))
                bowInv.Visible = true;
            if (game.CheckPlayerInventory("RedPotion"))
            {
                if ((game.CheckPotionInventory("RedPotion")) == false)
                    redPotionInv.Visible = true;
                else
                    redPotionInv.Visible = false;
            }
            if (game.CheckPlayerInventory("BluePotion"))
            {
                if ((game.CheckPotionInventory("BluePotion")) == false)
                    bluePotionInv.Visible = true;
                else
                {
                    RemovePotionFromInventory("BluePotion");
                }
            }
            if (game.CheckPlayerInventory("Mace"))
                maceInv.Visible = true;
            if (weaponControl != null)
            {
                weaponControl.Location = game.WeaponInRoom.Location;
                if (game.WeaponInRoom.PickedUp)
                    weaponControl.Visible = false;
                else
                    weaponControl.Visible = true;
            }
            if (game.PlayerHitPoints <= 0)
            {
                MessageBox.Show("You died");
                DialogResult playAgain = MessageBox.Show("Would you like to Play again", "Play Again", MessageBoxButtons.YesNo);
                if (playAgain == DialogResult.Yes)
                    Application.Restart();
                else
                    Application.Exit();
            }
            if (enemiesShown < 1)
            {
                MessageBox.Show("You have defeated the enemies on this level");
                game.NewLevel(random);
                UpdateCharacters();
            }
            Application.DoEvents();
        }
        private void RemovePotionFromInventory(string PotionName)
        {
            if (PotionName == "BluePotion")
                bluePotionInv.Visible = false;
            if (PotionName == "RedPotion")
                redPotionInv.Visible = false;
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
            attackUpButton.Text = "↑";
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
