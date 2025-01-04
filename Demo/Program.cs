using Demo.Abstraction;
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

            #region Abstraction
            //Shape shape = new Shape();  // invalid
            //shape.CalcArea();
            Rectangle rectangle = new Rectangle(10, 20);
            rectangle.Dim1 = 10;
            rectangle.Dim2 = 21;
            //Console.WriteLine(rectangle.CalcArea());
            //Console.WriteLine(rectangle.Premiter);

            Square square = new Square(3);
            //Console.WriteLine(square.Premiter);
            //Console.WriteLine(square.CalcArea());

            Circle circle = new Circle(4.57m);
            //Console.WriteLine(circle.CalcArea());
            //Console.WriteLine(circle.Premiter);
            #endregion

        }
    }
}
