using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_Dischi
{
    public class Cliente
    {
        public int codice_cliente { get; set; }
        public String nome { get; set; }
        public String cognome { get; set; }
        public String email { get; set; }
        public DateTime data_di_nascita { get; set; }
    }
}
