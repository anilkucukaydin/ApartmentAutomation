using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentAutomation.BusinessLogic
{
    class GelirRepo
    {
        public List<Gelir> GelirGetir()
        {
            List<Gelir> list = new List<Gelir>();
            DataTable dt = Program.SqlHelper.GetTable("SELECT* FROM Gelirler");
            foreach (DataRow item in dt.Rows)
            {
                Gelir g = new Gelir();
                g.ID = (int)item["ID"];
                g.Tarih = (DateTime)item["Tarih"];
                g.Tutar = (decimal)item["Tutar"];
                g.DaireNo = (int)item["Daire No"];
                list.Add(g);
            }
            return list;
        }
        public void InsertGelir(Gelir newGelir)
        {
            SqlParameter p1 = new SqlParameter("daireNo", newGelir.DaireNo);
            SqlParameter p2 = new SqlParameter("tutar", newGelir.Tutar);
            SqlParameter p3 = new SqlParameter("tarih", newGelir.Tarih);
            Program.SqlHelper.ExecuteProc("InsertGelir", p1, p2, p3);
        }
    }
}
