namespace snake_game_project
{
    partial class MainMenu
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
            this.OnePlayer = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TwoPlayer = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Map3 = new System.Windows.Forms.RadioButton();
            this.Map2 = new System.Windows.Forms.RadioButton();
            this.Map1 = new System.Windows.Forms.RadioButton();
            this.PlayButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.QuitGame = new System.Windows.Forms.Button();
            this.ThreePlayer = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // OnePlayer
            // 
            this.OnePlayer.AutoSize = true;
            this.OnePlayer.Location = new System.Drawing.Point(3, 3);
            this.OnePlayer.Name = "OnePlayer";
            this.OnePlayer.Size = new System.Drawing.Size(66, 19);
            this.OnePlayer.TabIndex = 0;
            this.OnePlayer.TabStop = true;
            this.OnePlayer.Text = "1 Player";
            this.OnePlayer.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ThreePlayer);
            this.panel1.Controls.Add(this.TwoPlayer);
            this.panel1.Controls.Add(this.OnePlayer);
            this.panel1.Location = new System.Drawing.Point(296, 214);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(75, 100);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // TwoPlayer
            // 
            this.TwoPlayer.AutoSize = true;
            this.TwoPlayer.Location = new System.Drawing.Point(3, 28);
            this.TwoPlayer.Name = "TwoPlayer";
            this.TwoPlayer.Size = new System.Drawing.Size(66, 19);
            this.TwoPlayer.TabIndex = 1;
            this.TwoPlayer.TabStop = true;
            this.TwoPlayer.Text = "2 Player";
            this.TwoPlayer.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Map3);
            this.panel2.Controls.Add(this.Map2);
            this.panel2.Controls.Add(this.Map1);
            this.panel2.Location = new System.Drawing.Point(411, 214);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(69, 100);
            this.panel2.TabIndex = 3;
            // 
            // Map3
            // 
            this.Map3.AutoSize = true;
            this.Map3.Location = new System.Drawing.Point(3, 53);
            this.Map3.Name = "Map3";
            this.Map3.Size = new System.Drawing.Size(55, 19);
            this.Map3.TabIndex = 2;
            this.Map3.TabStop = true;
            this.Map3.Text = "40x40";
            this.Map3.UseVisualStyleBackColor = true;
            // 
            // Map2
            // 
            this.Map2.AutoSize = true;
            this.Map2.Location = new System.Drawing.Point(3, 28);
            this.Map2.Name = "Map2";
            this.Map2.Size = new System.Drawing.Size(55, 19);
            this.Map2.TabIndex = 1;
            this.Map2.TabStop = true;
            this.Map2.Text = "25x25";
            this.Map2.UseVisualStyleBackColor = true;
            // 
            // Map1
            // 
            this.Map1.AutoSize = true;
            this.Map1.Location = new System.Drawing.Point(3, 3);
            this.Map1.Name = "Map1";
            this.Map1.Size = new System.Drawing.Size(55, 19);
            this.Map1.TabIndex = 0;
            this.Map1.TabStop = true;
            this.Map1.Text = "20x20";
            this.Map1.UseVisualStyleBackColor = true;
            // 
            // PlayButton
            // 
            this.PlayButton.Location = new System.Drawing.Point(329, 320);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(118, 51);
            this.PlayButton.TabIndex = 4;
            this.PlayButton.Text = "Start";
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(294, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 75);
            this.label1.TabIndex = 5;
            this.label1.Text = "Snake";
            // 
            // QuitGame
            // 
            this.QuitGame.Location = new System.Drawing.Point(329, 377);
            this.QuitGame.Name = "QuitGame";
            this.QuitGame.Size = new System.Drawing.Size(118, 51);
            this.QuitGame.TabIndex = 6;
            this.QuitGame.Text = "Quit Game";
            this.QuitGame.UseVisualStyleBackColor = true;
            this.QuitGame.Click += new System.EventHandler(this.QuitGame_Click);
            // 
            // ThreePlayer
            // 
            this.ThreePlayer.AutoSize = true;
            this.ThreePlayer.Location = new System.Drawing.Point(3, 53);
            this.ThreePlayer.Name = "ThreePlayer";
            this.ThreePlayer.Size = new System.Drawing.Size(66, 19);
            this.ThreePlayer.TabIndex = 2;
            this.ThreePlayer.TabStop = true;
            this.ThreePlayer.Text = "3 Player";
            this.ThreePlayer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ThreePlayer.UseVisualStyleBackColor = true;
            this.ThreePlayer.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.QuitGame);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MainMenu";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RadioButton OnePlayer;
        private Panel panel1;
        private Panel panel2;
        private RadioButton Map1;
        private RadioButton TwoPlayer;
        private RadioButton Map3;
        private RadioButton Map2;
        private Button PlayButton;
        private Label label1;
        private Button QuitGame;
        private RadioButton ThreePlayer;
    }
}