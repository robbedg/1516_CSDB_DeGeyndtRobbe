using Backend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class GetInfo
    {
        Connection connection = new Connection();
        public string[] Sproc()
        {
            Dictionary<int, int> input = connection.Command("CALL bepaal_lijst_van_bij_te_bestellen_artikelen()");
            return ToSringArray(input);
        }
        
        public string[] Classic()
        {
            Dictionary<int, int> items = connection.Command("SELECT artikel_id, SUM(aantal) FROM items GROUP BY artikel_id");
            Dictionary<int, int> artikelen = connection.Command("SELECT artikel_id, voorraad FROM artikelen");

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
