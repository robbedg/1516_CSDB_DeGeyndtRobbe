using LogicOLA;
using LogicPersonen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBackend
{
    public interface IDBGet
    {
        List<Docent> GetDocenten();
        List<OLA> GetOLAs(Docent docent);
    }
}
