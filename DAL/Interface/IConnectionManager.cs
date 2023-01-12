using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface
{
    public interface IConnectionManager
    {
        void Open();
        void Close();
        IDbConnection Connection { get; }
    }
}
