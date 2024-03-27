namespace MegaApplication
{
    public class User
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public bool IsVerified { get; set; }
        public string? ResetCode { get; set; }

        public void SetAccountStatus(Verification st, string user_name)
        {
            UserName = user_name;
            Console.WriteLine("Username is {0} & account status is {1}.", user_name, st);
        }

        public enum Verification : byte
        {
            UNVERIFIED = 1,
            PENDING,
            VERIFIED
        }
    }
}
