using Context;
using Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public string[] GetLecturers()
        {
            using (var context = new DatabaseContext())
            {
                var output = from lecturer in context.lecturers
                                             select new { lecturer.firstname, lecturer.lastname };
                var list = output.ToList();

                string[] outlist = new string[list.Count];
                for (int i = 0; i < list.Count; i++)
                {
                    outlist[i] = list[i].firstname + " " + list[i].lastname;
                }
                return outlist;
            }
        }

        public void GetOLAs(string nummer)
        {

        }
    }
}
