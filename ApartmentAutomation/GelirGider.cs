using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentAutomation
{
    enum MasrafTuru
    {
        Elektrik,
        Su,
        Temizlik,
        GenelMasraf
    }
    class GelirGider
    {
        public int ID { get; set; }
        public decimal Tutar { get; set; }
        public DateTime Tarih { get; set; }
    }
    class Gelir : GelirGider
    {
        public int DaireNo { get; set; }   
    }
    class Gider: GelirGider
    {
        public string MasrafTuru { get; set; }
    }
}
