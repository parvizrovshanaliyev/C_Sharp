using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling.TryCatch
{
    public class CustomExceptions : Exception
    {
        public CustomExceptions()
        {
            Console.WriteLine("custom exception class");
        }
    }
}
