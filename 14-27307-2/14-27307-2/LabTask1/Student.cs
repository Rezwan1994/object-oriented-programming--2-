using System;


namespace LabTask1
{
    class Student
    {
        public string name;
        public string id;
        public string department;
        public float cgpa;

        public void input()
        {
            Console.WriteLine("Enter Your Name");
            name = System.Console.ReadLine();
            Console.WriteLine("Enter Your Id");
            id = System.Console.ReadLine();
            Console.WriteLine("Enter your department");
            department = System.Console.ReadLine();
            Console.WriteLine("Enter your cgpa");
            cgpa = Convert.ToSingle(Console.ReadLine());
        }
        public void ShowDetails()
        {
            Console.WriteLine("Name: " + name + "\nId: " + id+"\ndepartment:"+department+"\ncgpa:"+cgpa);
        }
    }
}
