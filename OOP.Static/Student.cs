using System;

namespace OOP.Static
{
    public class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }


        public void Test1()
        {
            Console.WriteLine("Instance alindiqdan sonra isleyir");
        }

        public static void Test2()
        {
            Console.WriteLine("Instance alinmadan isleyir");
        }
    }
}
