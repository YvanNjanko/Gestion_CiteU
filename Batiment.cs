using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontEnd_Gestion_CiteU
{
    class Batiment
    {
        public char Code { get; set; }
        public int NombreEtages { get; set; }
        public int ChambresParEtage { get; set; }
        public decimal PrixChambre { get; set; }
        public int NombreMaxLitsParChambre { get; set; }
    }
}
