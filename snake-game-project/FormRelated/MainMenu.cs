using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace snake_game_project
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();

            OnePlayer.Checked = true;
            Map1.Checked = true;
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            var playerRadioButtons = panel1.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            var mapRadioButtons = panel2.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);

            var playerAmount = 1;
            var gameSize = 20;

            if (playerRadioButtons!.Equals(OnePlayer))
            {
                playerAmount = 1;
            }
            else if (playerRadioButtons!.Equals(TwoPlayer))
            {
                playerAmount = 2;
            }
            else if(playerRadioButtons!.Equals(ThreePlayer))//Utökning
            {
                playerAmount = 3;
            }

            if (mapRadioButtons!.Equals(Map1))
            {
                gameSize = 20;
            }
            else if (mapRadioButtons.Equals(Map2))
            {
                gameSize = 25;
            }
            else if (mapRadioButtons.Equals(Map3))
            {
                gameSize = 40;
            }

            MainForm mainForm = new MainForm(playerAmount, gameSize);

            mainForm.Show();
            this.Hide();
        }

        private void QuitGame_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
