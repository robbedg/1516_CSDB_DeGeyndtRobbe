using IBackend;
using LogicOLA;
using LogicPersonen;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class DBGet : IDBGet
    {
        //Connection
        private MySqlConnection conn = new MySqlConnection("Data Source=127.0.0.1;uid=root;pwd=Azerty123;database=db_labo01");

        public Docent[] GetDocenten()
        {
            //Stacks to store info
            Stack<string> personeelsnummer = new Stack<string>();
            Stack<string> naam = new Stack<string>();
            Stack<string> voornaam = new Stack<string>();

            //New DataSet
            DataSet dsDocenten = new DataSet();

            //New DataAdapter
            MySqlDataAdapter daDocenten = new MySqlDataAdapter("SELECT * FROM docenten ORDER BY naam DESC", conn);

            //Fill commands
            MySqlCommandBuilder cmdBldr = new MySqlCommandBuilder(daDocenten);

            //fill dataset
            daDocenten.Fill(dsDocenten, "Docenten");

            foreach (DataTable table in dsDocenten.Tables)
            {
                foreach (DataRow row in table.Rows)
                {
                    personeelsnummer.Push((string)row["personeelsnummer"]);
                    naam.Push((string)row["naam"]);
                    voornaam.Push((string)row["voornaam"]);
                }
            }

            //new objects
            int count = personeelsnummer.Count;
            Docent[] docenten = new Docent[count];
            
            for (int i = 0; i < count; i++)
            {
                docenten[i] = new Docent(naam.Pop(), voornaam.Pop(), personeelsnummer.Pop(), new List<OLA>());
            }

            return docenten;
        }

        public OLA[] GetOLAs(Docent docent)
        {
            //Stacks to store info;
            Stack<string> codes = new Stack<string>();
            Stack<string> naam = new Stack<string>();
            Stack<int> stp = new Stack<int>();

            //New DataSet
            DataSet dsOLAs = new DataSet();

            //Personeelsnummer
            string personeelsnummer = docent.ToString().Substring(1, 8);
            
            //Set command
            MySqlCommand cmd = new MySqlCommand("SELECT OLAs.* FROM OLAs" +
                " INNER JOIN docenten_has_OLAs" +
                " ON OLAs.code = docenten_has_OLAs.OLAs_code" +
                " INNER JOIN docenten" +
                " ON docenten_has_OLAs.personeelsnummer = docenten.personeelsnummer" +
                " WHERE docenten.personeelsnummer = @Personeelsnummer", conn);

            //Set parameters
            MySqlParameter param = new MySqlParameter("@Personeelsnummer", personeelsnummer);
            cmd.Parameters.Add(param);

            //New DataAdapter
            MySqlDataAdapter daOLAs = new MySqlDataAdapter(cmd);

            //Fill commands
            MySqlCommandBuilder cmdBldr = new MySqlCommandBuilder(daOLAs);

            //Fill dataset
            daOLAs.Fill(dsOLAs, "OLAs");

            //Fills stacks
            foreach (DataTable table in dsOLAs.Tables)
            {
                foreach (DataRow row in table.Rows)
                {
                    codes.Push((string)row["code"]);
                    naam.Push((string)row["naam"]);
                    stp.Push((int)row["stp"]);
                }
            }

            //new objects
            int count = codes.Count;
            OLA[] olas = new OLA[count];

            for (int i = 0; i < count; i++)
            {
                olas[i] = new OLA(codes.Pop(), naam.Pop(), stp.Pop());
            }

            return olas;
        }
    }
}
