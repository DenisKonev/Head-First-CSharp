namespace TheQuest
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
            this.player = new System.Windows.Forms.PictureBox();
            this.bat = new System.Windows.Forms.PictureBox();
            this.ghost = new System.Windows.Forms.PictureBox();
            this.gnoul = new System.Windows.Forms.PictureBox();
            this.bluePotion = new System.Windows.Forms.PictureBox();
            this.redPotion = new System.Windows.Forms.PictureBox();
            this.sword = new System.Windows.Forms.PictureBox();
            this.bow = new System.Windows.Forms.PictureBox();
            this.mace = new System.Windows.Forms.PictureBox();
            this.swordInv = new System.Windows.Forms.PictureBox();
            this.bowInv = new System.Windows.Forms.PictureBox();
            this.maceInv = new System.Windows.Forms.PictureBox();
            this.redPotionInv = new System.Windows.Forms.PictureBox();
            this.bluePotionInv = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gnoulHitPoints = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ghostHitPoints = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.batHitPoints = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.playerHitPoints = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.moveDownButton = new System.Windows.Forms.Button();
            this.moveRightButton = new System.Windows.Forms.Button();
            this.moveUpButton = new System.Windows.Forms.Button();
            this.moveLeftButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.attackDownButton = new System.Windows.Forms.Button();
            this.attackRightButton = new System.Windows.Forms.Button();
            this.attackUpButton = new System.Windows.Forms.Button();
            this.attackLeftButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gnoul)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bluePotion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redPotion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.swordInv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bowInv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maceInv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redPotionInv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bluePotionInv)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.BackgroundImage = global::TheQuest.Properties.Resources.player;
            this.player.Location = new System.Drawing.Point(154, 125);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(50, 50);
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // bat
            // 
            this.bat.BackColor = System.Drawing.Color.Transparent;
            this.bat.BackgroundImage = global::TheQuest.Properties.Resources.bat;
            this.bat.Location = new System.Drawing.Point(210, 125);
            this.bat.Name = "bat";
            this.bat.Size = new System.Drawing.Size(50, 50);
            this.bat.TabIndex = 1;
            this.bat.TabStop = false;
            this.bat.Visible = false;
            // 
            // ghost
            // 
            this.ghost.BackColor = System.Drawing.Color.Transparent;
            this.ghost.BackgroundImage = global::TheQuest.Properties.Resources.ghost;
            this.ghost.Location = new System.Drawing.Point(266, 125);
            this.ghost.Name = "ghost";
            this.ghost.Size = new System.Drawing.Size(50, 50);
            this.ghost.TabIndex = 2;
            this.ghost.TabStop = false;
            this.ghost.Visible = false;
            // 
            // gnoul
            // 
            this.gnoul.BackColor = System.Drawing.Color.Transparent;
            this.gnoul.BackgroundImage = global::TheQuest.Properties.Resources.ghoul;
            this.gnoul.Location = new System.Drawing.Point(322, 125);
            this.gnoul.Name = "gnoul";
            this.gnoul.Size = new System.Drawing.Size(50, 50);
            this.gnoul.TabIndex = 3;
            this.gnoul.TabStop = false;
            this.gnoul.Visible = false;
            // 
            // bluePotion
            // 
            this.bluePotion.BackColor = System.Drawing.Color.Transparent;
            this.bluePotion.BackgroundImage = global::TheQuest.Properties.Resources.potion_blue;
            this.bluePotion.Location = new System.Drawing.Point(378, 125);
            this.bluePotion.Name = "bluePotion";
            this.bluePotion.Size = new System.Drawing.Size(50, 50);
            this.bluePotion.TabIndex = 4;
            this.bluePotion.TabStop = false;
            this.bluePotion.Visible = false;
            // 
            // redPotion
            // 
            this.redPotion.BackColor = System.Drawing.Color.Transparent;
            this.redPotion.BackgroundImage = global::TheQuest.Properties.Resources.potion_red;
            this.redPotion.Location = new System.Drawing.Point(434, 125);
            this.redPotion.Name = "redPotion";
            this.redPotion.Size = new System.Drawing.Size(50, 50);
            this.redPotion.TabIndex = 5;
            this.redPotion.TabStop = false;
            this.redPotion.Visible = false;
            // 
            // sword
            // 
            this.sword.BackColor = System.Drawing.Color.Transparent;
            this.sword.BackgroundImage = global::TheQuest.Properties.Resources.sword;
            this.sword.Location = new System.Drawing.Point(490, 125);
            this.sword.Name = "sword";
            this.sword.Size = new System.Drawing.Size(50, 50);
            this.sword.TabIndex = 6;
            this.sword.TabStop = false;
            this.sword.Visible = false;
            // 
            // bow
            // 
            this.bow.BackColor = System.Drawing.Color.Transparent;
            this.bow.BackgroundImage = global::TheQuest.Properties.Resources.bow;
            this.bow.Location = new System.Drawing.Point(546, 125);
            this.bow.Name = "bow";
            this.bow.Size = new System.Drawing.Size(50, 50);
            this.bow.TabIndex = 7;
            this.bow.TabStop = false;
            this.bow.Visible = false;
            // 
            // mace
            // 
            this.mace.BackColor = System.Drawing.Color.Transparent;
            this.mace.BackgroundImage = global::TheQuest.Properties.Resources.mace;
            this.mace.Location = new System.Drawing.Point(602, 125);
            this.mace.Name = "mace";
            this.mace.Size = new System.Drawing.Size(50, 50);
            this.mace.TabIndex = 8;
            this.mace.TabStop = false;
            this.mace.Visible = false;
            // 
            // swordInv
            // 
            this.swordInv.BackColor = System.Drawing.Color.Transparent;
            this.swordInv.BackgroundImage = global::TheQuest.Properties.Resources.sword;
            this.swordInv.Location = new System.Drawing.Point(170, 707);
            this.swordInv.Name = "swordInv";
            this.swordInv.Size = new System.Drawing.Size(50, 50);
            this.swordInv.TabIndex = 9;
            this.swordInv.TabStop = false;
            this.swordInv.Visible = false;
            this.swordInv.Click += new System.EventHandler(this.swordInv_Click);
            // 
            // bowInv
            // 
            this.bowInv.BackColor = System.Drawing.Color.Transparent;
            this.bowInv.BackgroundImage = global::TheQuest.Properties.Resources.bow;
            this.bowInv.Location = new System.Drawing.Point(250, 707);
            this.bowInv.Name = "bowInv";
            this.bowInv.Size = new System.Drawing.Size(50, 50);
            this.bowInv.TabIndex = 10;
            this.bowInv.TabStop = false;
            this.bowInv.Visible = false;
            this.bowInv.Click += new System.EventHandler(this.bowInv_Click);
            // 
            // maceInv
            // 
            this.maceInv.BackColor = System.Drawing.Color.Transparent;
            this.maceInv.BackgroundImage = global::TheQuest.Properties.Resources.mace;
            this.maceInv.Location = new System.Drawing.Point(330, 707);
            this.maceInv.Name = "maceInv";
            this.maceInv.Size = new System.Drawing.Size(50, 50);
            this.maceInv.TabIndex = 11;
            this.maceInv.TabStop = false;
            this.maceInv.Visible = false;
            this.maceInv.Click += new System.EventHandler(this.maceInv_Click);
            // 
            // redPotionInv
            // 
            this.redPotionInv.BackColor = System.Drawing.Color.Transparent;
            this.redPotionInv.BackgroundImage = global::TheQuest.Properties.Resources.potion_red;
            this.redPotionInv.Location = new System.Drawing.Point(490, 707);
            this.redPotionInv.Name = "redPotionInv";
            this.redPotionInv.Size = new System.Drawing.Size(50, 50);
            this.redPotionInv.TabIndex = 12;
            this.redPotionInv.TabStop = false;
            this.redPotionInv.Visible = false;
            this.redPotionInv.Click += new System.EventHandler(this.redPotionInv_Click);
            // 
            // bluePotionInv
            // 
            this.bluePotionInv.BackColor = System.Drawing.Color.Transparent;
            this.bluePotionInv.BackgroundImage = global::TheQuest.Properties.Resources.potion_blue;
            this.bluePotionInv.Location = new System.Drawing.Point(410, 707);
            this.bluePotionInv.Name = "bluePotionInv";
            this.bluePotionInv.Size = new System.Drawing.Size(50, 50);
            this.bluePotionInv.TabIndex = 13;
            this.bluePotionInv.TabStop = false;
            this.bluePotionInv.Visible = false;
            this.bluePotionInv.Click += new System.EventHandler(this.bluePotionInv_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.gnoulHitPoints, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.ghostHitPoints, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.batHitPoints, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.playerHitPoints, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(715, 532);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // gnoulHitPoints
            // 
            this.gnoulHitPoints.AutoSize = true;
            this.gnoulHitPoints.Location = new System.Drawing.Point(103, 75);
            this.gnoulHitPoints.Name = "gnoulHitPoints";
            this.gnoulHitPoints.Size = new System.Drawing.Size(0, 25);
            this.gnoulHitPoints.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Gnoul";
            // 
            // ghostHitPoints
            // 
            this.ghostHitPoints.AutoSize = true;
            this.ghostHitPoints.Location = new System.Drawing.Point(103, 50);
            this.ghostHitPoints.Name = "ghostHitPoints";
            this.ghostHitPoints.Size = new System.Drawing.Size(0, 25);
            this.ghostHitPoints.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ghost";
            // 
            // batHitPoints
            // 
            this.batHitPoints.AutoSize = true;
            this.batHitPoints.Location = new System.Drawing.Point(103, 25);
            this.batHitPoints.Name = "batHitPoints";
            this.batHitPoints.Size = new System.Drawing.Size(0, 25);
            this.batHitPoints.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bat";
            // 
            // playerHitPoints
            // 
            this.playerHitPoints.AutoSize = true;
            this.playerHitPoints.Location = new System.Drawing.Point(103, 0);
            this.playerHitPoints.Name = "playerHitPoints";
            this.playerHitPoints.Size = new System.Drawing.Size(0, 25);
            this.playerHitPoints.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.moveDownButton);
            this.groupBox1.Controls.Add(this.moveRightButton);
            this.groupBox1.Controls.Add(this.moveUpButton);
            this.groupBox1.Controls.Add(this.moveLeftButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(584, 688);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 125);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Move";
            // 
            // moveDownButton
            // 
            this.moveDownButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.moveDownButton.Location = new System.Drawing.Point(109, 79);
            this.moveDownButton.Name = "moveDownButton";
            this.moveDownButton.Size = new System.Drawing.Size(40, 40);
            this.moveDownButton.TabIndex = 3;
            this.moveDownButton.Text = "↓";
            this.moveDownButton.UseVisualStyleBackColor = true;
            this.moveDownButton.Click += new System.EventHandler(this.moveDownButton_Click);
            // 
            // moveRightButton
            // 
            this.moveRightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.moveRightButton.Location = new System.Drawing.Point(153, 48);
            this.moveRightButton.Name = "moveRightButton";
            this.moveRightButton.Size = new System.Drawing.Size(40, 40);
            this.moveRightButton.TabIndex = 2;
            this.moveRightButton.Text = "→";
            this.moveRightButton.UseVisualStyleBackColor = true;
            this.moveRightButton.Click += new System.EventHandler(this.moveRightButton_Click);
            // 
            // moveUpButton
            // 
            this.moveUpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.moveUpButton.Location = new System.Drawing.Point(109, 19);
            this.moveUpButton.Name = "moveUpButton";
            this.moveUpButton.Size = new System.Drawing.Size(40, 40);
            this.moveUpButton.TabIndex = 1;
            this.moveUpButton.Text = "↑";
            this.moveUpButton.UseVisualStyleBackColor = true;
            this.moveUpButton.Click += new System.EventHandler(this.moveUpButton_Click);
            // 
            // moveLeftButton
            // 
            this.moveLeftButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.moveLeftButton.Location = new System.Drawing.Point(63, 48);
            this.moveLeftButton.Name = "moveLeftButton";
            this.moveLeftButton.Size = new System.Drawing.Size(40, 40);
            this.moveLeftButton.TabIndex = 0;
            this.moveLeftButton.Text = "←";
            this.moveLeftButton.UseVisualStyleBackColor = true;
            this.moveLeftButton.Click += new System.EventHandler(this.moveLeftButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.attackDownButton);
            this.groupBox2.Controls.Add(this.attackRightButton);
            this.groupBox2.Controls.Add(this.attackUpButton);
            this.groupBox2.Controls.Add(this.attackLeftButton);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(840, 688);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 125);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Attack";
            // 
            // attackDownButton
            // 
            this.attackDownButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.attackDownButton.Location = new System.Drawing.Point(102, 79);
            this.attackDownButton.Name = "attackDownButton";
            this.attackDownButton.Size = new System.Drawing.Size(40, 40);
            this.attackDownButton.TabIndex = 7;
            this.attackDownButton.Text = "↓";
            this.attackDownButton.UseVisualStyleBackColor = true;
            this.attackDownButton.Click += new System.EventHandler(this.attackDownButton_Click);
            // 
            // attackRightButton
            // 
            this.attackRightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.attackRightButton.Location = new System.Drawing.Point(146, 48);
            this.attackRightButton.Name = "attackRightButton";
            this.attackRightButton.Size = new System.Drawing.Size(40, 40);
            this.attackRightButton.TabIndex = 6;
            this.attackRightButton.Text = "→";
            this.attackRightButton.UseVisualStyleBackColor = true;
            this.attackRightButton.Click += new System.EventHandler(this.attackRightButton_Click);
            // 
            // attackUpButton
            // 
            this.attackUpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.attackUpButton.Location = new System.Drawing.Point(102, 19);
            this.attackUpButton.Name = "attackUpButton";
            this.attackUpButton.Size = new System.Drawing.Size(40, 40);
            this.attackUpButton.TabIndex = 5;
            this.attackUpButton.Text = "↑";
            this.attackUpButton.UseVisualStyleBackColor = true;
            this.attackUpButton.Click += new System.EventHandler(this.attackUpButton_Click);
            // 
            // attackLeftButton
            // 
            this.attackLeftButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.attackLeftButton.Location = new System.Drawing.Point(56, 48);
            this.attackLeftButton.Name = "attackLeftButton";
            this.attackLeftButton.Size = new System.Drawing.Size(40, 40);
            this.attackLeftButton.TabIndex = 4;
            this.attackLeftButton.Text = "←";
            this.attackLeftButton.UseVisualStyleBackColor = true;
            this.attackLeftButton.Click += new System.EventHandler(this.attackLeftButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::TheQuest.Properties.Resources.dungeon600x400;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 861);
            this.Controls.Add(this.player);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.bluePotionInv);
            this.Controls.Add(this.redPotionInv);
            this.Controls.Add(this.maceInv);
            this.Controls.Add(this.bowInv);
            this.Controls.Add(this.swordInv);
            this.Controls.Add(this.mace);
            this.Controls.Add(this.bow);
            this.Controls.Add(this.sword);
            this.Controls.Add(this.redPotion);
            this.Controls.Add(this.bluePotion);
            this.Controls.Add(this.gnoul);
            this.Controls.Add(this.ghost);
            this.Controls.Add(this.bat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1200, 900);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1200, 900);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Quest";
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gnoul)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bluePotion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redPotion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.swordInv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bowInv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maceInv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redPotionInv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bluePotionInv)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox bat;
        private System.Windows.Forms.PictureBox ghost;
        private System.Windows.Forms.PictureBox gnoul;
        private System.Windows.Forms.PictureBox bluePotion;
        private System.Windows.Forms.PictureBox redPotion;
        private System.Windows.Forms.PictureBox sword;
        private System.Windows.Forms.PictureBox bow;
        private System.Windows.Forms.PictureBox mace;
        private System.Windows.Forms.PictureBox swordInv;
        private System.Windows.Forms.PictureBox bowInv;
        private System.Windows.Forms.PictureBox maceInv;
        private System.Windows.Forms.PictureBox redPotionInv;
        private System.Windows.Forms.PictureBox bluePotionInv;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button moveLeftButton;
        private System.Windows.Forms.Button moveDownButton;
        private System.Windows.Forms.Button moveRightButton;
        private System.Windows.Forms.Button moveUpButton;
        private System.Windows.Forms.Button attackDownButton;
        private System.Windows.Forms.Button attackRightButton;
        private System.Windows.Forms.Button attackUpButton;
        private System.Windows.Forms.Button attackLeftButton;
        private System.Windows.Forms.Label gnoulHitPoints;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label ghostHitPoints;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label batHitPoints;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label playerHitPoints;
        private System.Windows.Forms.Label label1;
    }
}

