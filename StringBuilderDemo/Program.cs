using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilderDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("Hello");
            sb.AppendLine("");
            sb.AppendLine("This is the 2nd line");
            sb.Append(".");

            Console.WriteLine(sb.ToString());


         

        }
    }
}
