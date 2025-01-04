using Demo.CastingOperatorOverloading;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Operators overloading - Relational
            Complex C1 = new Complex() { Real = 1, Imag = 2 };
            Complex C2 = new Complex() { Real = 2, Imag = 4 };

            if (C1 > C2)
                Console.WriteLine("C1 > C2");
            else
                Console.WriteLine("C2 > C1");

            #endregion

            #region Casting Operator Overloading
            object obj = 4;
            int y = (int)obj;

            Complex c1 = new Complex() { Real = 10, Imag = 20 };
            int x = (int)c1;

            //string S = c1;

            string S = (string)c1;
            Console.WriteLine(S);

            #endregion

            #region Casting Operators overloading - mapping
            User user = new User()
            {
                FullName = "Mariam Shindy",
                Email = "Mariam@gmail.com",
                Password = "password",
                SecuirtyStamp = Guid.NewGuid(),
                Id = 10

            };

            Console.WriteLine(user.SecuirtyStamp);
            UserViewModel userViewModel = (UserViewModel)user;
            Console.WriteLine(userViewModel.FirstName);
            Console.WriteLine(userViewModel.LastName);
            Console.WriteLine(userViewModel.Email);

            object obj2 = new UserViewModel();
            userViewModel = (UserViewModel)obj;

            #endregion
        }
    }
}
