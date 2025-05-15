using System.Data.Entity;

namespace SecondProject_Auto
{
    class UserContext : DbContext
    {
        public UserContext() : base("SecondDBConnection") { }
        public DbSet<User> Users { get; set; }
    }
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
