using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_Dischi
{
    public class Supporto_Musicale
    {
        public int id { get; set; }
        public String nome { get; set; }
        public String descrizione { get; set; }
        public decimal prezzo_unitario { get; set; }
        public ArrayList Brani { get; set; } = new ArrayList();

        public override string ToString()
        {
            return $"{id}, {nome}, {descrizione}, {prezzo_unitario}, {ListaBrani.Count}";
        }
        
        



        public List<Brano> ListaBrani { get; set; } = new List<Brano>();

    }
}












