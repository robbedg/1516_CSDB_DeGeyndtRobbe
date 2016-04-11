using Backend;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Process
    {
        //Dictionary with connections
        private Dictionary<string, Connection> connections { get; set; }

        //DataSet
        public DataSet dataSet { get; set; }

        //Get names of available DBs
        public string[] availableDBs
        {
            get
            {
                return connections.Keys.ToArray();
            }
        }

        //DBkey used for getting data.
        public string activeDB { get; set; }

        //DBkey used for storing changes
        public string updateTo { get; set; }

        //constructor
        public Process()
        {
            connections = new Dictionary<string, Connection>();
            dataSet = new DataSet();
            ConnectionStringSettingsCollection cons = ConfigurationManager.ConnectionStrings;
            
            //Add all databases found in app.config   
            foreach (ConnectionStringSettings c in cons)
            {
                connections.Add(c.Name, new Connection(c.Name));
            }
        }

        //Get items via SProc
        public string[] Sproc()
        {
            Dictionary<int, int> input = connections[activeDB].Command("CALL bepaal_lijst_van_bij_te_bestellen_artikelen()");
            return ToSringArray(input);
        }
        
        //Get items via 2 statements and C#-code
        public string[] Classic()
        {
            Dictionary<int, int> items = connections[activeDB].Command("SELECT artikel_id, SUM(aantal) FROM items WHERE tijdstip IS NULL GROUP BY artikel_id");
            Dictionary<int, int> artikelen = connections[activeDB].Command("SELECT artikel_id, voorraad FROM artikelen");

            Dictionary<int, int> input = new Dictionary<int, int>();

            foreach (int key in items.Keys)
            {
                int voorraad;
                artikelen.TryGetValue(key, out voorraad);

                int aantal;
                items.TryGetValue(key, out aantal);

                int value = aantal - voorraad;

                if (value > 0)
                {
                    input.Add(key, value);
                }
            }

            return ToSringArray(input);
        }

        //Get 'artikelen' with DataAdapter
        public void GetData()
        {
            connections[activeDB].GetDataGrid("SELECT * FROM artikelen");
            this.dataSet = connections[activeDB].dataSet.Copy();
        }

        //Update 'artikelen' with DataAdapter
        public void UpdateData()
        {
            //If 'all' is selected update all available databases.
            if (updateTo.Equals("all"))
            {
                foreach (string c in connections.Keys)
                {
                    connections[c].GetDataGrid("SELECT * FROM artikelen");
                    connections[c].dataSet = this.dataSet.Copy();
                    connections[c].UpdateGrid();
                }
            }
            else
            {
                connections[updateTo].GetDataGrid("SELECT * FROM artikelen");
                connections[updateTo].dataSet = this.dataSet.Copy();
                connections[updateTo].UpdateGrid();
            }
        }

        //Convert Dictionary to stringarray
        private string[] ToSringArray(Dictionary<int, int> input)
        {
            string[] output = new string[input.Keys.Count];
            int[] keys = input.Keys.ToArray();
            int[] values = input.Values.ToArray();

            for (int i = 0; i < output.Length; i++)
            {
                output[i] = "artikelNr= " + keys[i] + "-> tekort= " + values[i];
            }

            return output;
        }
    }
}
