using MySql.Data.MySqlClient;
namespace GestionConge.Data
{
    public class DBConnection
    {
        private string connectionString =

            "server=localhost;database=gestion_conge;uid=root;pwd=;";

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
 }
