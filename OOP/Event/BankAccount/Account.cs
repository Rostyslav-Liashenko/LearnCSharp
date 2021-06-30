namespace LearnEvent
{
    public class Account
    {
        public delegate void AccountHandler(string message);
        public event AccountHandler Notify;
        public int Sum { get; private set;}

        public Account(int sum)
        {
            Sum = sum;
           
        }

        public void Put(int sum)
        {
            Sum += sum;
            Notify?.Invoke($"The account received: {sum}");
            
        }

        public void Take(int sum)
        {
            if (Sum >= sum)
            {
                Sum -= sum;
                Notify?.Invoke($"From the account taken: {sum}");
            }
            else
            {
                Notify?.Invoke($"Not enough money from account. Current balance: {Sum}");
            }
        }
    }
}
