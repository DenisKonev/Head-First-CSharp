﻿namespace Chapter_3_Exercise_2
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
            this.joesCashLabel = new System.Windows.Forms.Label();
            this.bobsCashLabel = new System.Windows.Forms.Label();
            this.bankCashLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.saveJoeButton = new System.Windows.Forms.Button();
            this.loadJoeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // joesCashLabel
            // 
            this.joesCashLabel.AutoSize = true;
            this.joesCashLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.joesCashLabel.Location = new System.Drawing.Point(197, 45);
            this.joesCashLabel.Name = "joesCashLabel";
            this.joesCashLabel.Size = new System.Drawing.Size(174, 29);
            this.joesCashLabel.TabIndex = 0;
            this.joesCashLabel.Text = "joesCashLabel";
            // 
            // bobsCashLabel
            // 
            this.bobsCashLabel.AutoSize = true;
            this.bobsCashLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bobsCashLabel.Location = new System.Drawing.Point(197, 101);
            this.bobsCashLabel.Name = "bobsCashLabel";
            this.bobsCashLabel.Size = new System.Drawing.Size(182, 29);
            this.bobsCashLabel.TabIndex = 1;
            this.bobsCashLabel.Text = "bobsCashLabel";
            // 
            // bankCashLabel
            // 
            this.bankCashLabel.AutoSize = true;
            this.bankCashLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bankCashLabel.Location = new System.Drawing.Point(197, 155);
            this.bankCashLabel.Name = "bankCashLabel";
            this.bankCashLabel.Size = new System.Drawing.Size(180, 29);
            this.bankCashLabel.TabIndex = 2;
            this.bankCashLabel.Text = "bankCashLabel";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(66, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 82);
            this.button1.TabIndex = 3;
            this.button1.Text = "Give $10 to Joe";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(345, 243);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(184, 82);
            this.button2.TabIndex = 4;
            this.button2.Text = "Receive $5 from Bob";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(66, 369);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(184, 82);
            this.button3.TabIndex = 5;
            this.button3.Text = "Joe gives $10 to Bob";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(345, 369);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(184, 82);
            this.button4.TabIndex = 6;
            this.button4.Text = "Bob gives $5 to Joe";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // saveJoeButton
            // 
            this.saveJoeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveJoeButton.Location = new System.Drawing.Point(66, 524);
            this.saveJoeButton.Name = "saveJoeButton";
            this.saveJoeButton.Size = new System.Drawing.Size(184, 41);
            this.saveJoeButton.TabIndex = 7;
            this.saveJoeButton.Text = "Save Joe";
            this.saveJoeButton.UseVisualStyleBackColor = true;
            this.saveJoeButton.Click += new System.EventHandler(this.saveJoeButton_Click);
            // 
            // loadJoeButton
            // 
            this.loadJoeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loadJoeButton.Location = new System.Drawing.Point(345, 524);
            this.loadJoeButton.Name = "loadJoeButton";
            this.loadJoeButton.Size = new System.Drawing.Size(184, 41);
            this.loadJoeButton.TabIndex = 8;
            this.loadJoeButton.Text = "Load Joe";
            this.loadJoeButton.UseVisualStyleBackColor = true;
            this.loadJoeButton.Click += new System.EventHandler(this.loadJoeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 629);
            this.Controls.Add(this.loadJoeButton);
            this.Controls.Add(this.saveJoeButton);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bankCashLabel);
            this.Controls.Add(this.bobsCashLabel);
            this.Controls.Add(this.joesCashLabel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(647, 668);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(647, 668);
            this.Name = "Form1";
            this.Text = "Fun with Joe and Bob";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label joesCashLabel;
        private System.Windows.Forms.Label bobsCashLabel;
        private System.Windows.Forms.Label bankCashLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button saveJoeButton;
        private System.Windows.Forms.Button loadJoeButton;
    }
}

