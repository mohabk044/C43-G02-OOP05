using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Partial
{
    internal partial class Employee
    {  //Auto Generated
        public int Id { get; set; }
        public int Age { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public partial void Hello();


        public void Print()
        {
            Console.WriteLine("Hello Mohab");
        }
        public partial void Hello()
        {
            Console.WriteLine("Hello");
        }
    }
}