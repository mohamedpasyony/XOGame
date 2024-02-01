using Bl.Models;
using Bl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XOGame
{
    public partial class RegisterOneVsCom : Form
    {
        public RegisterOneVsCom()
        {
            InitializeComponent();
        }
        private Form ActiveForm = null;
        private void openChildForm(Form ChildForm)
        {
            if (ActiveForm != null)
                ActiveForm.Close();
            ActiveForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            Game_panel.Controls.Add(ChildForm);
            Game_panel.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();

        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StartGameVScom_btn_Click(object sender, EventArgs e)
        {
            if ( PName_txt.Text == string.Empty)
            {
                MessageBox.Show("Please Enter All Data !");
            }
            else
            {
                PlayersInfo players = new PlayersInfo();
                players.Player1Name = PName_txt.Text;
                players.Player2Name = "Computer";
                players.Player1Symbol = 'X';
                players.Player2Symbol = 'O';
                PlayersInfoServices.UpdateToCurrentPlayers(players);

                openChildForm(new GameFormVsComputer());

            }
        }
    }
}
