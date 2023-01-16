using DAL.Base;
using DAL.Interface;
using Entity;

namespace TestDAL
{
    public class TestUserRepository
    {

        private string connectionString = "Server=DKP-FABIAN\\SQLEXPRESS;" +
            "Database=MarketPlace;Trusted_Connection = True; MultipleActiveResultSets = true; Encrypt=False";

        private IUserRepository _repository;

        public TestUserRepository()
        {
            var connectionManager = new ConnectionManager(connectionString);
            _repository = new UserRepository(connectionManager);
            connectionManager.Open();
        }


        [Test]
        public void InstanceRepository()
        {
            Assert.IsNotNull(_repository);
        }

        [Test]
        public void InsertUsers()
        {
           var user = new User()
            {
                Password= "password123",
                UserName = "UserName",
            };

            user.Encript();

            var request = _repository.Register(user);

            Assert.AreEqual(request, 1);
        }

        [Test]
        public void ConsultUsersByUserName()
        {
            var userName = "UserName";

            var request = _repository.GetUser(userName);

            Assert.AreEqual(request.UserName, userName);
        }
    }
}