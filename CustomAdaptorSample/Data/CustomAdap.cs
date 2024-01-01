using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomAdaptorSample.Data;
using Microsoft.AspNetCore.Components;
using Syncfusion.Blazor;
using Syncfusion.Blazor.Data;

namespace CustomAdaptorSample.Data
{
    public class DummyInterface 
    {       
        public void InterfaceMethod() 
        {
            Console.WriteLine("1"); 
        }
    }
    public class CustomAdaptor : DataAdaptor
    {
        public DummyInterface dummyProperty;
        public CustomAdaptor(DummyInterface prop)
        {
            this.dummyProperty = prop;
            dummyProperty.InterfaceMethod();
        }

        public static List<Ord> Orders { get; set; } = Ord.GetRecords();
        public override object Read(DataManagerRequest dm, string key = null)
        {
            dummyProperty.InterfaceMethod();
            IEnumerable<Ord> DataSource = Orders;


            if (dm.Search != null && dm.Search.Count > 0)
            {
                // Searching
                DataSource = DataOperations.PerformSearching(DataSource, dm.Search);
            }
            if (dm.Sorted != null && dm.Sorted.Count > 0)
            {
                // Sorting
                DataSource = DataOperations.PerformSorting(DataSource, dm.Sorted);
            }
            if (dm.Where != null && dm.Where.Count > 0)
            {
                // Filtering
                DataSource = DataOperations.PerformFiltering(DataSource, dm.Where, dm.Where[0].Operator);
            }
            int count = DataSource.Cast<Ord>().Count();
            if (dm.Skip != 0)
            {
                //Paging
                DataSource = DataOperations.PerformSkip(DataSource, dm.Skip);
            }
            if (dm.Take != 0)
            {
                DataSource = DataOperations.PerformTake(DataSource, dm.Take);
            }
            return dm.RequiresCounts ? new DataResult() { Result = DataSource, Count = count } : (object)DataSource;
        }

        // Performs Insert operation
        public override object Insert(DataManager dm, object value, string key)
        {
            Orders.Insert(0, value as Ord);
            return value;
        }

        // Performs Remove operation
        public override object Remove(DataManager dm, object value, string keyField, string key)
        {
            Orders.Remove(Orders.Where(or => or.OrderID == int.Parse(value.ToString())).FirstOrDefault());
            return value;
        }

        // Performs Update operation
        public override object Update(DataManager dm, object value, string keyField, string key)
        {
            var data = Orders.Where(or => or.OrderID == (value as Ord).OrderID).FirstOrDefault();
            if (data != null)
            {
                data.OrderID = (value as Ord).OrderID;
                data.CustomerID = (value as Ord).CustomerID;
                data.Freight = (value as Ord).Freight;
            }
            return value;
        }

       // Performs BatchUpdate operation
        public override object BatchUpdate(DataManager dm, object Changed, object Added, object Deleted, string KeyField, string Key, int? dropIndex)
        {
            if (Changed != null)
            {
                foreach (var rec in (IEnumerable<Ord>)Changed)
                {
                    Ord val = Orders.Where(or => or.OrderID == rec.OrderID).FirstOrDefault();
                    val.OrderID = rec.OrderID;
                    val.CustomerID = rec.CustomerID;
                    val.Freight = rec.Freight;
                }

            }
            if (Added != null)
            {
                foreach (var rec in (IEnumerable<Ord>)Added)
                {
                    Orders.Add(rec);
                }

            }
            if (Deleted != null)
            {
                foreach (var rec in (IEnumerable<Ord>)Deleted)
                {
                    Orders.Remove(Orders.Where(or => or.OrderID == rec.OrderID).FirstOrDefault());
                }

            }
            return Orders;
        }
    }
}
