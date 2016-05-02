using Context;
using Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logic
{
    public class Manipulations
    {
        public List<Lecturer> lecturers
        {
            get
            {
                using (var context = new DatabaseContext())
                {
                    return context.lecturers.ToList<Lecturer>();
                }
            }
        }

        public List<OPO> opos
        {
            get
            {
                using (var context = new DatabaseContext())
                {
                    return context.OPOs.ToList<OPO>();
                }
            }
        }

        public List<OLA> olas
        {
            get
            {
                using (var context = new DatabaseContext())
                {
                    return context.OLAs.ToList<OLA>();
                }
            }
        }

        public Manipulations()
        {
            
        }

        public void NewLecturer(string number, string lastname, string firstname)
        {
            using ( var context = new DatabaseContext())
            {
                context.lecturers.Add(new Lecturer(number, firstname, lastname));
                context.SaveChanges();
            }
        }

        public List<ListViewItem> GetOLAs(Lecturer lecturer)
        {
            using (var context = new DatabaseContext())
            {
                var output = from ola in context.OLAs
                             where ola.lecturers.Contains(lecturer)
                             select ola;
                
                List<ListViewItem> listview = new List<ListViewItem>();

                foreach (var item in output)
                {
                    string[] olaStringArray = new string[] { item.code, item.name, item.opo.ToString(), item.stp.ToString() };
                    listview.Add(new ListViewItem(olaStringArray));
                }
                return listview;
            }
        }

        public void AddOPO(OPO opo)
        {
            using (var context = new DatabaseContext())
            {
                opo.coordinator = null;
                context.OPOs.Add(opo);
                context.SaveChanges();
            }
        }
        public void UpdateOLA(string code, OLA newola)
        {
            using (var context = new DatabaseContext())
            {
                var input = from ola in context.OLAs
                            where ola.code.Equals(code)
                            select ola;

                OLA selectedola = (OLA)(input.ToArray<OLA>().Last());

            }
        }
    }
}
