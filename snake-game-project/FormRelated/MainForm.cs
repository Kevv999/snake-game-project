namespace snake_game_project
{
    public partial class MainForm : Form
    {
        Engine GameEngine;
        Renderer GameRenderer;
        System.Windows.Forms.Timer Timer;

        Panel MenuPanel;
        Panel GameOverPanel;

        LinkedList<Label> ScoreLabels;

        public MainForm(int playerAmount, int gameSize)
        {
            InitializeComponent();

            GameEngine = new Engine(gameSize, playerAmount);
            GameRenderer = new Renderer(gameSize, gameSize);

            ScoreLabels = new LinkedList<Label>();

            Timer = new System.Windows.Forms.Timer();
            Timer.Interval = 50;
            Timer.Tick += Timer_Tick;
            Timer.Start();

            AddScoreLabel();

            MenuPanel = CreateMenuPanel("Continue", "Main Menu", ContinueGame, GoToMainMenu);
            MenuPanel.Visible = false;
            MenuPanel.Enabled = false;

            GameOverPanel = CreateMenuPanel("Play Again", "Main Menu", PlayAgain, GoToMainMenu);
            GameOverPanel.Visible = false;
            GameOverPanel.Enabled = false;

        }

        private void AddScoreLabel()
        {
            int i = 0;
            foreach (var player in GameEngine.PlayerList)
            {
                Label label = new Label();
                label.ForeColor = player.PColor;
                label.AutoSize = true;
                label.Font = new Font("Arial", 14);
                label.Text = "Score: 0";
                label.Location = new Point(0, label.Size.Height * i);
                scoreArea.Controls.Add(label);
                ScoreLabels.AddLast(label);
                i++;
            }
            
        }

        private Panel CreateMenuPanel(string button1Text, string button2Text, EventHandler button1Event, EventHandler button2Event)
        {
            Size buttonSize = new Size(100, 30);

            Panel panel = new Panel();
            Button Button1 = new Button();
            Button1.Text = button1Text;
            Button1.Click += new EventHandler(button1Event);

            Button1.Size = buttonSize;
            Button Button2 = new Button();
            Button2.Text = button2Text;
            Button2.Click += new EventHandler(button2Event);

            Button2.Size = buttonSize;
            Button2.Location = new Point(Button2.Location.X, Button2.Height);
            panel.Size = new Size(Button1.Width, Button1.Height + Button2.Height);
            panel.BackColor = Color.White;
            panel.Location = new Point(gameArea.Width/2 - panel.Width/2, gameArea.Height/2 - panel.Height/2);

            panel.Controls.Add(Button1);
            panel.Controls.Add(Button2);

            this.Controls.Add(panel);
            panel.BringToFront();

            return panel;
        }

        private void PlayAgain(object? sender, EventArgs e)
        {
            GameEngine = new Engine(GameEngine.Size, GameEngine.PlayerList.Count);
            GameOverPanel.Visible = !GameOverPanel.Visible;
            GameOverPanel.Enabled = !GameOverPanel.Enabled;
        }
        private void ContinueGame(object? sender, EventArgs e)
        {
            MenuPanel.Visible = !MenuPanel.Visible;
            MenuPanel.Enabled = !MenuPanel.Enabled;
            Timer.Enabled = !Timer.Enabled;
        }

        private void GoToMainMenu(object? sender, EventArgs e)
        {
            var mainMenu = new MainMenu();
            mainMenu.Show();
            this.Close();
        }


        private void Timer_Tick(object? sender, EventArgs e)
        {
            GameEngine.Tick();
            GameEngine.Draw(GameRenderer);

            gameArea.Refresh();
            scoreArea.Refresh();

            if (GameEngine.EndGameCheck())
            {
                GameOverPanel.Visible = true;
                GameOverPanel.Enabled = true;
            }
        }

        private void gameArea_Paint(object? sender, PaintEventArgs e)
        {
            GameRenderer.PaintGameArea(sender, e);
        }
        private void scoreArea_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < ScoreLabels.Count; i++)
            {
                GameRenderer.UpdateScore(ScoreLabels.ElementAt(i), GameEngine.PlayerList.ElementAt(i).Score);
            }
        }
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    GameEngine.PlayerList.ElementAt(0).AddInput(Player.Direction.Up);
                    break;
                case Keys.S:
                    GameEngine.PlayerList.ElementAt(0).AddInput(Player.Direction.Down);
                    break;
                case Keys.A:
                    GameEngine.PlayerList.ElementAt(0).AddInput(Player.Direction.Left);
                    break;
                case Keys.D:
                    GameEngine.PlayerList.ElementAt(0).AddInput(Player.Direction.Right);
                    break;
                case Keys.Escape:
                    MenuPanel.Visible = !MenuPanel.Visible;
                    MenuPanel.Enabled = !MenuPanel.Enabled;
                    Timer.Enabled = !Timer.Enabled;
                    break;
            }
            if (GameEngine.PlayerList.Count == 2 || GameEngine.PlayerList.Count == 3) //Utökning rad
            {
                switch (e.KeyCode)
                {
                    case Keys.I:
                        GameEngine.PlayerList.ElementAt(1).AddInput(Player.Direction.Up);
                        break;
                    case Keys.K:
                        GameEngine.PlayerList.ElementAt(1).AddInput(Player.Direction.Down);
                        break;
                    case Keys.J:
                        GameEngine.PlayerList.ElementAt(1).AddInput(Player.Direction.Left);
                        break;
                    case Keys.L:
                        GameEngine.PlayerList.ElementAt(1).AddInput(Player.Direction.Right);
                        break;
                }
            }
                if(GameEngine.PlayerList.Count == 3)//Utökning switch
            {
                    switch(e.KeyCode)
                    {
                        case Keys.T:
                            GameEngine.PlayerList.ElementAt(2).AddInput(Player.Direction.Up);
                            break;
                        case Keys.G:
                            GameEngine.PlayerList.ElementAt(2).AddInput(Player.Direction.Down);
                            break;
                        case Keys.F:
                            GameEngine.PlayerList.ElementAt(2).AddInput(Player.Direction.Left);
                            break;
                        case Keys.H:
                            GameEngine.PlayerList.ElementAt(2).AddInput(Player.Direction.Right);
                            break;
                    }
                }
                
            
        }


    }
}