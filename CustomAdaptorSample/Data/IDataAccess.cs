using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CustomAdaptorSample.Data;

namespace CustomAdaptorSample.Data
{
    public interface IDataAccess
    {
        Task<List<Order>> GetAllRecords();
    }
}
