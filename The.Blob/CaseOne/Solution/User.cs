using System;

namespace The.Blob.CaseOne.Solution
{
    public class User
    {
        public int Id { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public UserType Type { get; set; }

        public void ChangeUserPassword(string oldPassword, string newPassword)
        {
            var isValidPassword = CheckUserPassword(oldPassword);
            if (!isValidPassword)
                throw new InvalidOperationException("Incorrect old password");
            if (string.IsNullOrEmpty(newPassword))
                throw new InvalidOperationException("Password must not be empty");

            Password = newPassword;
        }
        public bool CheckUserPassword(string password) => Password == password;
    }

    public enum UserType
    {
        Standart,
        Vip
    }
}