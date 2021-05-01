using System.Collections.Generic;

namespace Week6.Tasks
{
    public static class StudentPrinter
    {
        public static void Print()
        {
            var students = new List<Student>
            {
                new Student{Id = 1, Name = "A",Address = "12",Number = "121"},
                new Student{Id = 2, Name = "A",Address = "12",Number = "121"},
                new Student{Id = 3, Name = "A",Address = "12",Number = "121"},
                new Student{Id = 4, Name = "A",Address = "12",Number = "121"},
                new Student{Id = 5, Name = "A",Address = "12",Number = "121"}
            };

            ConsoleDataFormatter.PrintSeparatorLine();
            ConsoleDataFormatter.PrintRow("Salam salam xalqi necesiz", "Name", "Address", "Number");
            ConsoleDataFormatter.PrintSeparatorLine();

            foreach (var item in students)
            {
                ConsoleDataFormatter.PrintRow(item.Id.ToString(), item.Name, item.Address, item.Number);
                //Console.WriteLine(item.Id.ToString(),item.Name,item.Address,item.Number);
            }
            ConsoleDataFormatter.PrintSeparatorLine();
        }

    }
}