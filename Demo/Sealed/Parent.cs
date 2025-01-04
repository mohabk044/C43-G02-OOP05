using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Sealed
{
    internal class Parent
    {
        public virtual void print()
        {
            Console.WriteLine("Hello Parent");
        }
    }
    class Child : Parent
    {
        public sealed override void print()
        {
            Console.WriteLine("Hello Child");
        }
    }

    sealed class GrandChild : Child
    {
        public new void print()
        {
            Console.WriteLine("Hello GrandChild");
        }
    }

    //class Test : GrandChild
    //{

    //}
}