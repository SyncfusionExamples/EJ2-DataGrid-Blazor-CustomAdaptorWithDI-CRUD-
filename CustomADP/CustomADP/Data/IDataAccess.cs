using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CustomADP.Data;

namespace CustomADP.Data
{
    public interface IDataAccess
    {
        Task<List<Order>> GetAllRecords();
    }
}
