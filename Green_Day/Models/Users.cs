namespace Green_Day.Models
{
    public class Users
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Email { get; set; }
        public UserType Type { get; set; }

        public enum UserType
        {
            Regular,
            Farmer,
            Employee
        }
        public string password { get; set; }
    }
}
