using Bl.Models;
using DAL;
using System.Data;

namespace Bl
{
    public static class PlayersInfoServices
    {
        public static string connectionString = "Server=.;Database=XOGame;Trusted_Connection=True;TrustServerCertificate=True";
        public static int UpdateToCurrentPlayers(PlayersInfo players)
        {
            string UpdateCommand = $" insert into PlayersInfo (Player1Name,Player1Symbol,Player2Name,Player2Symbol) values('{players.Player1Name}','{players.Player1Symbol}','{players.Player2Name}','{players.Player2Symbol}')";

            int result = Context.ExecuteNonQuery(UpdateCommand, connectionString);
            return result;
        }

        public static PlayersInfo SelectPlayersInfo()
        {
            PlayersInfo players = new  PlayersInfo ();
            string selectCmd = "SELECT TOP 1 * FROM PlayersInfo ORDER BY Id DESC";
           var result = Context.Select(selectCmd, connectionString);
            players.Id = result.Id;
            players.Player1Name = result.Player1Name;
            players.Player2Name = result.Player2Name;
            players.Player1Symbol = result.Player1Symbol;
            players.Player2Symbol = result.Player2Symbol;
            return players;
        }
    }
}