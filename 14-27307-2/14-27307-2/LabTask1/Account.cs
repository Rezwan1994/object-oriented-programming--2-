using System;


namespace LabTask1
{
    class Account
    {
        public string accountName;
        public string accountId;
        public double balance;

        public void input()
        {
            Console.WriteLine("Enter Your Account Name: ");
            accountName = System.Console.ReadLine();
            Console.WriteLine("Enter Your Id");
            accountId = System.Console.ReadLine();
            Console.WriteLine("Enter your balance");
            
            balance = Convert.ToInt64(Console.ReadLine());
            

        }              public void Deposit()        {            Console.WriteLine("Enter diposit amount");
            double d = Convert.ToInt64(Console.ReadLine());
            if (d < 0)
            {
                Console.WriteLine("negative value cannot be accepted!!!");
            }
            else
            {
                balance = balance + d;
            }
                  }
        public void Withdraw()
        {
            Console.WriteLine("Enter diposit amount");
            double d = Convert.ToInt64(Console.ReadLine());
            if (d < 0)
            {
                Console.WriteLine("negative value cannot be accepted!!!");
            }
            else if (d < balance)
            {
                balance = balance - d;
            }
            else if(d> balance)
            {
                Console.WriteLine("Your balance is not sufficiant!!!!");
            }
        }
        public void ShowDetails()
        {
            Console.WriteLine("Account Name:"+this.accountName+"\nAccount Id:"+this.accountId+"\nBalance:"+this.balance);
        }    
    }
}
