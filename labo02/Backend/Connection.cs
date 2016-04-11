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
        private DbCommandBuilder builder { get; set; }

        public DataSet dataSet { get; set; }

        public Connection()
        {
            factory = DbProviderFactories.GetFactory("MySql.Data.MySqlClient");
            connection = factory.CreateConnection();
            connection.ConnectionString = "Database=acsm_f4ebbffefd9d617;Data Source=eu-cdbr-azure-west-d.cloudapp.net;User Id=be47445ebed6c5;Password=e3104c4f";
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

        public void GetDataGrid()
        {
            using(connection)
            {
                workAdapter = new MySqlDataAdapter();
                workAdapter.SelectCommand = new MySqlCommand("SELECT * FROM artikelen", (MySqlConnection)connection);
                builder = new MySqlCommandBuilder((MySqlDataAdapter)workAdapter);
                dataSet = new DataSet();
                workAdapter.Fill(dataSet);
            }
        }

        public void UpdateGrid()
        {
            using(connection)
            {
                builder.GetUpdateCommand();
                workAdapter.Update(dataSet);
            }
        }
    }
}
