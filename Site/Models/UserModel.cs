namespace Site.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public int Role { get; set; }
        public string Token { get; set; }
    }

    public class UserView
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public int Role { get; set; }
    }

    public class UserInputModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
