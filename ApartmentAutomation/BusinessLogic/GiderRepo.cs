using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentAutomation.BusinessLogic
{
    class GiderRepo
    {
        public List<Gider> GiderGetir()
        {
            List<Gider> list = new List<Gider>();
            DataTable dt = Program.SqlHelper.GetTable("SELECT* FROM Giderler");
            foreach (DataRow item in dt.Rows)
            {
                Gider gid = new Gider();
                gid.ID = (int)item["ID"];
                gid.MasrafTuru = item["Masraf Türü"].ToString();
                gid.Tarih = (DateTime)item["Tarih"];
                gid.Tutar = (decimal)item["Tutar"];
                list.Add(gid);
            }
            return list;
        }
        public void InsertGider(Gider newGider)
        {
            SqlParameter p1 = new SqlParameter("MasrafTuru", newGider.MasrafTuru);
            SqlParameter p2 = new SqlParameter("tutar", newGider.Tutar);
            SqlParameter p3 = new SqlParameter("tarih", newGider.Tarih);
            Program.SqlHelper.ExecuteProc("InsertGider", p1, p2, p3);
            
        }
    }   
   
    
}
