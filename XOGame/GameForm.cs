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
    public partial class GameForm : Form
    {
        private char[] board;
        private int XScore = 0;
        private int OScore = 0;
        private char currentPlayer;
        private List<Button> buttons = new List<Button>();
        private int PlayerId;

        public GameForm()
        {
            InitializeComponent();
            board = new char[9];
            currentPlayer = 'X'; // Start with player X
            Turn_Label.Text = "X Turn";
            AddBtnsToList();
            InitializeBoard();
        }


        private void AddBtnsToList()
        {
            buttons.Add(Square1);
            buttons.Add(Square2);
            buttons.Add(Square3);
            buttons.Add(square4);
            buttons.Add(Square5);
            buttons.Add(Square6);
            buttons.Add(Square7);
            buttons.Add(Square8);
            buttons.Add(Square9);
        }
        private void button2_Click(object sender, EventArgs e)
        {

            this.Close();
        }
        private void GameForm_Load(object sender, EventArgs e)
        {
            var players = PlayersInfoServices.SelectPlayersInfo();
            Player1Name.Text = players.Player1Name;
            Player2Name.Text = players.Player2Name;
            P1Sympol_label.Text = players.Player1Symbol.ToString();
            P2Sympol_label.Text = players.Player2Symbol.ToString();
            PlayerId = players.Id;
        }

        private void Square1_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            ButtonClick(clickedButton);
        }

        private void Square2_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            ButtonClick(clickedButton);
        }

        private void Square3_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            ButtonClick(clickedButton);
        }

        private void square4_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            ButtonClick(clickedButton);
        }

        private void Square5_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            ButtonClick(clickedButton);
        }

        private void Square6_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            ButtonClick(clickedButton);
        }

        private void Square7_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            ButtonClick(clickedButton);
        }

        private void Square8_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            ButtonClick(clickedButton);
        }

        private void Square9_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            ButtonClick(clickedButton);
        }

        private void InitializeBoard()
        {
            // Initialize the board with empty spaces
            for (int i = 0; i < 9; i++)
            {
                board[i] = ' ';
                buttons[i].Text = " ";
            }
        }

        public void ButtonClick(Button button)
        {
            int buttonIndex = int.Parse(button.Tag.ToString());

            // Check if the move is valid
            if (board[buttonIndex] == ' ')
            {

                // Make the move
                board[buttonIndex] = currentPlayer;


                // Update the button text
                button.Text = currentPlayer.ToString();

                // Check for a winner
                if (CheckForWinner())
                {
                    MessageBox.Show($"{currentPlayer} is the winner!");
                    if (currentPlayer.ToString() == P1Sympol_label.Text)
                    {
                        XScore += 1;
                        Player1Score.Text = XScore.ToString();
                    }
                    else
                    {
                        OScore += 1;
                        Player2Score.Text = OScore.ToString();
                    }
                    InitializeBoard(); // Restart the game
                }
                else
                {
                    // Check for a tie
                    if (CheckForTie())
                    {
                        MessageBox.Show("It's a tie!");
                        InitializeBoard(); // Restart the game

                    }
                    else
                    {
                        // Switch to the other player
                        currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
                        Turn_Label.Text = $"{currentPlayer} Turn";

                    }
                }
            }
        }

        private bool CheckForWinner()
        {
            // Check rows, columns, and diagonals for a winner
            for (int i = 0; i < 3; i++)
            {
                if (board[i * 3] != ' ' && board[i * 3] == board[i * 3 + 1] && board[i * 3 + 1] == board[i * 3 + 2])
                    return true; // Row

                if (board[i] != ' ' && board[i] == board[i + 3] && board[i + 3] == board[i + 6])
                    return true; // Column
            }

            if (board[0] != ' ' && board[0] == board[4] && board[4] == board[8])
                return true; // Diagonal from top-left to bottom-right

            if (board[2] != ' ' && board[2] == board[4] && board[4] == board[6])
                return true; // Diagonal from top-right to bottom-left

            return false; // No winner
        }

        private bool CheckForTie()
        {
            // Check if all cells are filled
            for (int i = 0; i < 9; i++)
            {
                if (board[i] == ' ')
                    return false; // Not a tie
            }
            return true; // It's a tie
        }

        private void StartGame_btn_Click(object sender, EventArgs e)
        {
            XScore = 0;
            OScore = 0;
            Player2Score.Text = "0";
            Player1Score.Text = "0";
            Turn_Label.Text = "X Turn";
            currentPlayer = 'X';
            InitializeBoard();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            currentPlayer = 'X';
            Turn_Label.Text = "X Turn";
            InitializeBoard();

        }

        private void SaveScore_btn_Click(object sender, EventArgs e)
        {
            Score score = new Score();
            score.Player1Score = int.Parse(Player1Score.Text);
            score.Player2Score = int.Parse(Player2Score.Text);
            if (score.Player1Score > score.Player2Score)
            {
                score.Winner = Player1Name.Text;
            }
            else if (score.Player2Score > score.Player1Score)
            {
                score.Winner = Player2Name.Text;
            }
            else
            {
                score.Winner = "Tie";
            }
            score.PlayerId = PlayerId;
            ScoresServices.SaveScore(score);
            MessageBox.Show("Score Saved");

        }
    }
}

