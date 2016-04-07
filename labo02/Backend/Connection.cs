using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using MySql.Data.MySqlClient;

namespace Backend
{
    public class Connection
    {
        private DbProviderFactory factory { get; set; }
        private DbConnection connection { get; set; }
        private DbDataAdapter workAdapter { get; set; }

        public Connection()
        {
            factory = DbProviderFactories.GetFactory("MySql.Data.MySqlClient");
            connection = factory.CreateConnection();
            connection.ConnectionString = "SERVER=127.0.0.1; DATABASE=postorder; UID=root; PASSWORD=Azerty123";
        }

        public Dictionary<int, int> Command(String queryString)
        {
            Dictionary<int, int> result = new Dictionary<int, int>();

            DbCommand command = connection.CreateCommand();
            command.CommandText = queryString;
            command.CommandType = CommandType.Text;
            connection.Open();
            DbDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                result.Add(Int32.Parse(reader[0].ToString()), Int32.Parse(reader[1].ToString()));
            }
            connection.Close();
            return result;
        }

        public DataTable DataGrid()
        {
            DataTable targetTable = new DataTable();

            workAdapter = new MySqlDataAdapter("SELECT * FROM artikelen ORDER BY artikel_id", connection.ConnectionString);

            workAdapter.Fill(targetTable);

            return targetTable;
        }

        public void UpdateGrid(DataTable input)
        {
            workAdapter.Update(input);
        }
    }
}
