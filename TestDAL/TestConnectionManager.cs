
using DAL.Base;

namespace TestDAL
{

    public class TestConnectionManager
    {
        private string connectionString = "Server=DKP-FABIAN\\SQLEXPRESS;Database=MarketPlace;" +
            "Trusted_Connection = True; MultipleActiveResultSets = true; Encrypt=False";

        [SetUp]
        public void Setup()
        {
        }


        [Test]
        public void InstanceConnections()
        {
            var connectionManager = new ConnectionManager(connectionString);

            connectionManager.Open();
            connectionManager.Close();

            Assert.IsNotNull(connectionManager);
        }
    }
}