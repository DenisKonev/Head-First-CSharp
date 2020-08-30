namespace GoFish
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.textName = new System.Windows.Forms.TextBox();
            this.listHand = new System.Windows.Forms.ListBox();
            this.textProgress = new System.Windows.Forms.TextBox();
            this.textBooks = new System.Windows.Forms.TextBox();
            this.buttonAsk = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your name";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(293, 51);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(6);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(240, 38);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "Start the game!";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(24, 51);
            this.textName.Margin = new System.Windows.Forms.Padding(6);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(240, 31);
            this.textName.TabIndex = 2;
            // 
            // listHand
            // 
            this.listHand.FormattingEnabled = true;
            this.listHand.ItemHeight = 25;
            this.listHand.Location = new System.Drawing.Point(557, 51);
            this.listHand.Margin = new System.Windows.Forms.Padding(6);
            this.listHand.Name = "listHand";
            this.listHand.Size = new System.Drawing.Size(313, 679);
            this.listHand.TabIndex = 3;
            // 
            // textProgress
            // 
            this.textProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textProgress.Location = new System.Drawing.Point(24, 144);
            this.textProgress.Margin = new System.Windows.Forms.Padding(6);
            this.textProgress.Multiline = true;
            this.textProgress.Name = "textProgress";
            this.textProgress.ReadOnly = true;
            this.textProgress.Size = new System.Drawing.Size(509, 424);
            this.textProgress.TabIndex = 4;
            // 
            // textBooks
            // 
            this.textBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBooks.Location = new System.Drawing.Point(24, 605);
            this.textBooks.Margin = new System.Windows.Forms.Padding(6);
            this.textBooks.Multiline = true;
            this.textBooks.Name = "textBooks";
            this.textBooks.ReadOnly = true;
            this.textBooks.Size = new System.Drawing.Size(509, 201);
            this.textBooks.TabIndex = 5;
            // 
            // buttonAsk
            // 
            this.buttonAsk.Enabled = false;
            this.buttonAsk.Location = new System.Drawing.Point(557, 762);
            this.buttonAsk.Margin = new System.Windows.Forms.Padding(6);
            this.buttonAsk.Name = "buttonAsk";
            this.buttonAsk.Size = new System.Drawing.Size(313, 44);
            this.buttonAsk.TabIndex = 6;
            this.buttonAsk.Text = "Ask for a card";
            this.buttonAsk.UseVisualStyleBackColor = true;
            this.buttonAsk.Click += new System.EventHandler(this.buttonAsk_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 113);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Game progress";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 574);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Books";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(552, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Your hand";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 832);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonAsk);
            this.Controls.Add(this.textBooks);
            this.Controls.Add(this.textProgress);
            this.Controls.Add(this.listHand);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(911, 871);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(911, 871);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Go fish!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.ListBox listHand;
        private System.Windows.Forms.TextBox textProgress;
        private System.Windows.Forms.TextBox textBooks;
        private System.Windows.Forms.Button buttonAsk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

