using Bl.Models;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl
{
    public static class ScoresServices
    {
        public static string connectionString = "Server=.;Database=XOGame;Trusted_Connection=True;TrustServerCertificate=True";
        public static int SaveScore(Score score)
        {
            string SaveCommand = $" insert into Scores (Player1Score,Player2Score,Winner,Players_Info_Id) values({score.Player1Score},{score.Player2Score},'{score.Winner}',{score.PlayerId})";

            int result = Context.ExecuteNonQuery(SaveCommand, connectionString);
            return result;
        }
        public static DataTable GetScores()
        {
            string selectCmd = "SELECT Player1Name , Player2Name , Player1Score , Player2Score , Winner  FROM PlayersInfo join Scores on PlayersInfo.Id = Scores.Players_Info_Id";
            var result = Context.SelectDt(selectCmd, connectionString);
            return result;
        }

    }
}
