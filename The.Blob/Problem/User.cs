namespace The.Blob.Problem
{
    public class User
    {
        public int Id { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public UserType Type { get; set; }
    }

    public enum UserType
    {
        Standart,
        Vip
    }
}