using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomADP.Data
{
    public class Ord
    {
        public static List<Ord> Ordersdataa { get; set; }
        public int OrderID { get; set; }
        public string CustomerID { get; set; }
        public double Freight { get; set; }

        public static List<Ord> GetRecords()
        {
            Ordersdataa = Enumerable.Range(1, 75).Select(x => new Ord()
            {
                OrderID = 1000 + x,
                CustomerID = (new string[] { "ALFKI", "ANANTR", "ANTON", "BLONP", "BOLID" })[new Random().Next(5)],
                Freight = 2.1 * x,
            }).ToList();
            return Ordersdataa;
        }
    }




}
