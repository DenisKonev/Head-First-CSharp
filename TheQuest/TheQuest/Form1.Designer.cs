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
            this.playerSprite = new System.Windows.Forms.PictureBox();
            this.batSprite = new System.Windows.Forms.PictureBox();
            this.ghostSprite = new System.Windows.Forms.PictureBox();
            this.gnoulSprite = new System.Windows.Forms.PictureBox();
            this.bluePotionSprite = new System.Windows.Forms.PictureBox();
            this.redPotionSprite = new System.Windows.Forms.PictureBox();
            this.swordSprite = new System.Windows.Forms.PictureBox();
            this.bowSprite = new System.Windows.Forms.PictureBox();
            this.maceSprite = new System.Windows.Forms.PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.playerSprite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.batSprite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghostSprite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gnoulSprite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bluePotionSprite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redPotionSprite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.swordSprite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bowSprite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maceSprite)).BeginInit();
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
            // playerSprite
            // 
            this.playerSprite.BackColor = System.Drawing.Color.Transparent;
            this.playerSprite.BackgroundImage = global::TheQuest.Properties.Resources.player;
            this.playerSprite.Location = new System.Drawing.Point(154, 125);
            this.playerSprite.Name = "playerSprite";
            this.playerSprite.Size = new System.Drawing.Size(50, 50);
            this.playerSprite.TabIndex = 0;
            this.playerSprite.TabStop = false;
            this.playerSprite.Visible = false;
            // 
            // batSprite
            // 
            this.batSprite.BackColor = System.Drawing.Color.Transparent;
            this.batSprite.BackgroundImage = global::TheQuest.Properties.Resources.bat;
            this.batSprite.Location = new System.Drawing.Point(210, 125);
            this.batSprite.Name = "batSprite";
            this.batSprite.Size = new System.Drawing.Size(50, 50);
            this.batSprite.TabIndex = 1;
            this.batSprite.TabStop = false;
            this.batSprite.Visible = false;
            // 
            // ghostSprite
            // 
            this.ghostSprite.BackColor = System.Drawing.Color.Transparent;
            this.ghostSprite.BackgroundImage = global::TheQuest.Properties.Resources.ghost;
            this.ghostSprite.Location = new System.Drawing.Point(266, 125);
            this.ghostSprite.Name = "ghostSprite";
            this.ghostSprite.Size = new System.Drawing.Size(50, 50);
            this.ghostSprite.TabIndex = 2;
            this.ghostSprite.TabStop = false;
            this.ghostSprite.Visible = false;
            // 
            // gnoulSprite
            // 
            this.gnoulSprite.BackColor = System.Drawing.Color.Transparent;
            this.gnoulSprite.BackgroundImage = global::TheQuest.Properties.Resources.ghoul;
            this.gnoulSprite.Location = new System.Drawing.Point(322, 125);
            this.gnoulSprite.Name = "gnoulSprite";
            this.gnoulSprite.Size = new System.Drawing.Size(50, 50);
            this.gnoulSprite.TabIndex = 3;
            this.gnoulSprite.TabStop = false;
            this.gnoulSprite.Visible = false;
            // 
            // bluePotionSprite
            // 
            this.bluePotionSprite.BackColor = System.Drawing.Color.Transparent;
            this.bluePotionSprite.BackgroundImage = global::TheQuest.Properties.Resources.potion_blue;
            this.bluePotionSprite.Location = new System.Drawing.Point(378, 125);
            this.bluePotionSprite.Name = "bluePotionSprite";
            this.bluePotionSprite.Size = new System.Drawing.Size(50, 50);
            this.bluePotionSprite.TabIndex = 4;
            this.bluePotionSprite.TabStop = false;
            this.bluePotionSprite.Visible = false;
            // 
            // redPotionSprite
            // 
            this.redPotionSprite.BackColor = System.Drawing.Color.Transparent;
            this.redPotionSprite.BackgroundImage = global::TheQuest.Properties.Resources.potion_red;
            this.redPotionSprite.Location = new System.Drawing.Point(434, 125);
            this.redPotionSprite.Name = "redPotionSprite";
            this.redPotionSprite.Size = new System.Drawing.Size(50, 50);
            this.redPotionSprite.TabIndex = 5;
            this.redPotionSprite.TabStop = false;
            this.redPotionSprite.Visible = false;
            // 
            // swordSprite
            // 
            this.swordSprite.BackColor = System.Drawing.Color.Transparent;
            this.swordSprite.BackgroundImage = global::TheQuest.Properties.Resources.sword;
            this.swordSprite.Location = new System.Drawing.Point(490, 125);
            this.swordSprite.Name = "swordSprite";
            this.swordSprite.Size = new System.Drawing.Size(50, 50);
            this.swordSprite.TabIndex = 6;
            this.swordSprite.TabStop = false;
            this.swordSprite.Visible = false;
            // 
            // bowSprite
            // 
            this.bowSprite.BackColor = System.Drawing.Color.Transparent;
            this.bowSprite.BackgroundImage = global::TheQuest.Properties.Resources.bow;
            this.bowSprite.Location = new System.Drawing.Point(546, 125);
            this.bowSprite.Name = "bowSprite";
            this.bowSprite.Size = new System.Drawing.Size(50, 50);
            this.bowSprite.TabIndex = 7;
            this.bowSprite.TabStop = false;
            this.bowSprite.Visible = false;
            // 
            // maceSprite
            // 
            this.maceSprite.BackColor = System.Drawing.Color.Transparent;
            this.maceSprite.BackgroundImage = global::TheQuest.Properties.Resources.mace;
            this.maceSprite.Location = new System.Drawing.Point(602, 125);
            this.maceSprite.Name = "maceSprite";
            this.maceSprite.Size = new System.Drawing.Size(50, 50);
            this.maceSprite.TabIndex = 8;
            this.maceSprite.TabStop = false;
            this.maceSprite.Visible = false;
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
            this.gnoulHitPoints.Size = new System.Drawing.Size(91, 25);
            this.gnoulHitPoints.TabIndex = 7;
            this.gnoulHitPoints.Text = "gnoulHitPoints";
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
            this.ghostHitPoints.Size = new System.Drawing.Size(91, 25);
            this.ghostHitPoints.TabIndex = 5;
            this.ghostHitPoints.Text = "ghostHitPoints";
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
            this.batHitPoints.Size = new System.Drawing.Size(94, 25);
            this.batHitPoints.TabIndex = 3;
            this.batHitPoints.Text = "batHitPoints";
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
            this.playerHitPoints.Size = new System.Drawing.Size(91, 25);
            this.playerHitPoints.TabIndex = 1;
            this.playerHitPoints.Text = "playerHitPoints";
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
            this.Controls.Add(this.playerSprite);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.bluePotionInv);
            this.Controls.Add(this.redPotionInv);
            this.Controls.Add(this.maceInv);
            this.Controls.Add(this.bowInv);
            this.Controls.Add(this.swordInv);
            this.Controls.Add(this.maceSprite);
            this.Controls.Add(this.bowSprite);
            this.Controls.Add(this.swordSprite);
            this.Controls.Add(this.redPotionSprite);
            this.Controls.Add(this.bluePotionSprite);
            this.Controls.Add(this.gnoulSprite);
            this.Controls.Add(this.ghostSprite);
            this.Controls.Add(this.batSprite);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1200, 900);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1200, 900);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Quest";
            ((System.ComponentModel.ISupportInitialize)(this.playerSprite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.batSprite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghostSprite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gnoulSprite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bluePotionSprite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redPotionSprite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.swordSprite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bowSprite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maceSprite)).EndInit();
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

        private System.Windows.Forms.PictureBox playerSprite;
        private System.Windows.Forms.PictureBox batSprite;
        private System.Windows.Forms.PictureBox ghostSprite;
        private System.Windows.Forms.PictureBox gnoulSprite;
        private System.Windows.Forms.PictureBox bluePotionSprite;
        private System.Windows.Forms.PictureBox redPotionSprite;
        private System.Windows.Forms.PictureBox swordSprite;
        private System.Windows.Forms.PictureBox bowSprite;
        private System.Windows.Forms.PictureBox maceSprite;
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

