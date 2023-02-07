namespace snake_game_project
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gameArea = new snake_game_project.GameArea();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.scoreArea = new snake_game_project.FormRelated.ScoreArea();
            this.SuspendLayout();
            // 
            // gameArea
            // 
            this.gameArea.BackColor = System.Drawing.Color.Black;
            this.gameArea.Location = new System.Drawing.Point(0, 0);
            this.gameArea.Name = "gameArea";
            this.gameArea.Size = new System.Drawing.Size(800, 800);
            this.gameArea.TabIndex = 0;
            this.gameArea.Paint += new System.Windows.Forms.PaintEventHandler(this.gameArea_Paint);
            // 
            // scoreArea
            // 
            this.scoreArea.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.scoreArea.Location = new System.Drawing.Point(806, 0);
            this.scoreArea.Name = "scoreArea";
            this.scoreArea.Size = new System.Drawing.Size(200, 800);
            this.scoreArea.TabIndex = 11;
            this.scoreArea.Paint += new System.Windows.Forms.PaintEventHandler(this.scoreArea_Paint);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.scoreArea);
            this.Controls.Add(this.gameArea);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private GameArea gameArea;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private FormRelated.ScoreArea scoreArea;
    }
}