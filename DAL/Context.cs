using DAL.DBModels;
using Microsoft.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class Context
    {
        public static PlayersInfoDB Select(string cmdText, string connectionString)
        {
            PlayersInfoDB playerInfo = null;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand selectCmd = new SqlCommand(cmdText, connection))
                {
                    using (SqlDataReader reader = selectCmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            playerInfo = new PlayersInfoDB
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                Player1Name = reader["Player1Name"].ToString(),
                                Player1Symbol = Convert.ToChar(reader["Player1Symbol"]),
                                Player2Name = reader["Player2Name"].ToString(),
                                Player2Symbol = Convert.ToChar(reader["Player2Symbol"])
                            };
                        }
                    }
                }
            }

            return playerInfo;
        }
        public static DataTable SelectDt(string cmdText, string connectionString)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand selectCmd = new SqlCommand(cmdText, connection);

            SqlDataAdapter adapter = new SqlDataAdapter(selectCmd);

            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            return dataTable;
        }


        // NonQuery
        // insert , update , delete
        public static int ExecuteNonQuery(string cmdText, string connectionString)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(cmdText, connection);
            connection.Open();
            int result = command.ExecuteNonQuery();
            connection.Close();
            return result;
        }
    }
}