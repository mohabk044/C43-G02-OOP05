namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Operators overloading - Relational
            Complex C1 = new Complex() { Real = 1, Imag = 2 };
            Complex C2 = new Complex() { Real = 2 , Imag = 4 };

            if (C1 > C2)
                Console.WriteLine("C1 > C2");
            else
                Console.WriteLine("C2 > C1");

            #endregion
        }
    }
}
