using System;


namespace LabTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu = new Student();
            stu.input();

            stu.ShowDetails();
            Triangle tr = new Triangle();
            tr.input();
            tr.ShowDetails();
            tr.TestTriangle();

            Account ac = new Account();
            ac.input();
            Console.WriteLine("Enter 1 for diposit or 2 for widhdraw");
            int x = Convert.ToInt32(Console.ReadLine());

            if (x == 1)
            {
                ac.Deposit();
            }
            else if (x == 2)
            {
                ac.Withdraw();
            }
            ac.ShowDetails();

        }
    }
}
