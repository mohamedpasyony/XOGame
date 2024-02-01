using Bl;
using Bl.Models;
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
    public partial class RegisterOneVsone : Form
    {
        public RegisterOneVsone()
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StartGame_btn_Click(object sender, EventArgs e)
        {
            if ((P1RadioX.Checked == false && P1RadioO.Checked == false) || (P2RadioX.Checked == false && P2RadioO.Checked == false) || (P1Name_txt.Text == string.Empty || P2Name_txt.Text == string.Empty))
            {
                MessageBox.Show("Please Enter All Data !");
            }
            else
            {
                PlayersInfo players = new PlayersInfo();
                players.Player1Name = P1Name_txt.Text;
                players.Player2Name = P2Name_txt.Text;
                if (P1RadioX.Checked)
                {
                    players.Player1Symbol = Convert.ToChar(P1RadioX.Text);
                }
                else
                {
                    players.Player1Symbol = Convert.ToChar(P1RadioO.Text);
                }

                if (P2RadioX.Checked)
                {
                    players.Player2Symbol = Convert.ToChar(P2RadioX.Text);
                }
                else
                {
                    players.Player2Symbol = Convert.ToChar(P2RadioO.Text);
                }
                PlayersInfoServices.UpdateToCurrentPlayers(players);

                openChildForm(new GameForm());

            }
        }


        private void P1RadioX_CheckedChanged(object sender, EventArgs e)
        {
            if (P1RadioX.Checked)
            {
                if (P2RadioX.Checked)
                {
                    P2RadioX.Checked = false;
                    P2RadioO.Checked = true;
                }
            }
        }

        private void P2RadioX_CheckedChanged(object sender, EventArgs e)
        {
            if (P2RadioX.Checked)
            {
                if (P1RadioX.Checked)
                {
                    P1RadioX.Checked = false;
                    P1RadioO.Checked = true;
                }
            }
        }

        private void P1RadioO_CheckedChanged(object sender, EventArgs e)
        {
            if (P1RadioO.Checked)
            {
                if (P2RadioO.Checked)
                {
                    P2RadioO.Checked = false;
                    P2RadioX.Checked = true;
                }
            }
        }

        private void P2RadioO_CheckedChanged(object sender, EventArgs e)
        {
            if (P2RadioO.Checked)
            {
                if (P1RadioO.Checked)
                {
                    P1RadioO.Checked = false;
                    P1RadioX.Checked = true;
                }
            }
        }
    }
}
