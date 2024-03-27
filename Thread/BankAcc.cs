namespace MegaApplication
{
    class BankAcc
    {
        private readonly Object accLock = new object();
        double Balance { get; set; }
        double Name { get; set; }

        public BankAcc(double bal)
        {
            Balance = bal;
        }

        public double WithDraw(double amt)
        {
            if ((Balance - amt) < 0)
            {
                Console.WriteLine("Insufficient funds. Current balance is MWK{0}.", Balance);
                return Balance;
            }

            lock (accLock)
            {
                if (Balance >= amt)
                {
                    Console.WriteLine("Withdrew MWK{0} from account. MWK{1} left in account.", amt, Balance);
                    Balance -= amt;
                }
                return Balance;
            }
        }

        public void IssueWithdraw()
        {
            WithDraw(1);
        }
    }
}
