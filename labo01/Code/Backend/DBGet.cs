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
        private MySqlConnection conn;

        //Constructor
        public DBGet()
        {
            //Connection with remote MySQL server (Odisee Campus Ghent Only)
            conn = new MySqlConnection("Data Source=31.220.20.207;uid=u226756641_adm01;pwd=Azerty123;database=u226756641_lab01");
            
            try
            {
                //Try connection with remote server
                conn.Open();
                conn.Close();
            }
            catch (Exception)
            {
                //If connection fails use local MySQL server
                conn = new MySqlConnection("Data Source=127.0.0.1;uid=root;pwd=Azerty123;database=db_labo01");
            }
        }


        public List<Docent> GetDocenten()
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
            List<Docent> docenten = new List<Docent>();

            //Store in list
            int count = personeelsnummer.Count;
            for (int i = 0; i < count; i++)
            {
                docenten.Add(new Docent(naam.Pop(), voornaam.Pop(), personeelsnummer.Pop(), new List<OLA>()));
            }

            //return List
            return docenten;
        }

        public List<OLA> GetOLAs(Docent docent)
        {
            //When already available don't use database.
            if (docent.olas.Count > 0)
            {
                return docent.olas;
            }

            //Stacks to store info;
            Stack<string> codes = new Stack<string>();
            Stack<string> naam = new Stack<string>();
            Stack<int> stp = new Stack<int>();

            //New DataSet
            DataSet dsOLAs = new DataSet();
            
            //Set command
            MySqlCommand cmd = new MySqlCommand("SELECT olas.* FROM olas" +
                " INNER JOIN docenten_has_olas" +
                " ON olas.code = docenten_has_olas.olas_code" +
                " INNER JOIN docenten" +
                " ON docenten_has_olas.personeelsnummer = docenten.personeelsnummer" +
                " WHERE docenten.personeelsnummer = @Personeelsnummer", conn);

            //Set parameters
            MySqlParameter param = new MySqlParameter("@Personeelsnummer", docent.personeelsnummer);
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
            List<OLA> olas = new List<OLA>();

            //Store in list
            int count = codes.Count;
            for (int i = 0; i < count; i++)
            {
                olas.Add(new OLA(codes.Pop(), naam.Pop(), stp.Pop()));
            }

            //Add olas to Docent object
            docent.VoegOLAsToe(olas);

            //Return list
            return olas;
        }
    }
}
