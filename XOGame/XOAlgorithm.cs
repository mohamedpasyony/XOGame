using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XOGame
{
    internal class XOAlgorithm
    {
        private char[] board;
        private char currentPlayer;
        private List<Button> buttons;

        public XOAlgorithm(List<Button> buttons)
        {
            board = new char[9];
            currentPlayer = 'X'; // Start with player X
            this.buttons = buttons;
            InitializeBoard();
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
    }
}
