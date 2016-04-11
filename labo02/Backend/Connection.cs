using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;

namespace Backend
{
    public class Connection
    {
        //Factory
        private DbProviderFactory factory { get; set; }
        //Connection
        private DbConnection connection { get; set; }
        //DataAdapter
        private DbDataAdapter workAdapter { get; set; }
        //Command buider
        private DbCommandBuilder builder { get; set; }
        //DataSet
        public DataSet dataSet { get; set; }

        //Constructor
        public Connection(string name)
        {
            //Get connection settings
            ConnectionStringSettings connectionStringSettings = ConfigurationManager.ConnectionStrings[name];
            //Get factory
            factory = DbProviderFactories.GetFactory(connectionStringSettings.ProviderName);
            //Create connection
            connection = factory.CreateConnection();
            //Set connection string
            connection.ConnectionString = connectionStringSettings.ConnectionString;
        }

        //Return results of given query (DataReader)
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

        //Return results of given query (DataAdapter)
        public void GetDataGrid(string queryString)
        {
            using(connection)
            {   
                DbCommand command = factory.CreateCommand();
                command.CommandText = queryString;
                command.Connection = connection;

                workAdapter = factory.CreateDataAdapter();
                workAdapter.SelectCommand = command;

                builder = factory.CreateCommandBuilder();
                builder.DataAdapter = workAdapter;

                dataSet = new DataSet();
                workAdapter.Fill(dataSet);
            }
        }

        //Update table with changes made
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
