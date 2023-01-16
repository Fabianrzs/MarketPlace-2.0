using DAL.Interface;
using Microsoft.Extensions.Configuration;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Reflection.Metadata;

namespace DAL.Base
{
    public class ConnectionManager : IConnectionManager
    {
        private readonly IConfiguration _configuration;

        private readonly SqlConnection _connection;

        public ConnectionManager(IConfiguration configuration)
        {
            _configuration = configuration;
            _connection = new SqlConnection();
            _connection.ConnectionString = _configuration.GetConnectionString("DefaultConnnetion");
        }

        public ConnectionManager(string cs)
        {
            _connection = new SqlConnection(cs);
        }

        public void Open()
        {
            _connection.Open();
        }

        public void Close() 
        { 
            _connection.Close();
        }

        public IDbConnection Connection { get {return _connection;} }

    }
}
