
//     //     // while (true)
//     //     // {
           
//     //     //     double a = Convert.ToDouble(Console.ReadLine());

//     //     //     double b = Convert.ToDouble(Console.ReadLine());


//     //     //     char Bilol = Convert.ToChar(Console.ReadLine());

//     //     //     Calculator calc = new Calculator(a, b);

//     //     //     switch (Bilol)
//     //     //     {
//     //     //         case '+':
//     //     //             System.Console.WriteLine(calc.Sum());
//     //     //             break;

//     //     //         case '-':
//     //     //             System.Console.WriteLine(calc.Subtract());
//     //     //             break;

//     //     //         case '*':
//     //     //             System.Console.WriteLine(calc.Multiplication());
//     //     //             break;

//     //     //         case '/':
//     //     //             if (b != 0)
//     //     //             {
//     //     //                 System.Console.WriteLine(calc.Division());
//     //     //             }
                 
//     //     //             break;

//     //     //         default:
//     //     //             System.Console.WriteLine("намеша э бача");
//     //     //             break;
//     //     //     }

//     //     //     System.Console.WriteLine();
//     //     // }





//     // static void Main()
//     // {
//     //     Book book = new Book("Harry Potter", "J.K. Rowling", 2015);

//     //     Console.WriteLine(book.GetInfo());
//     //     Console.WriteLine(book.IsPublishedRecently());
//     // }



// class Program
// {
//     static void Main()
//     {
//         Console.Write("Enter the radius: ");
//         double radius = Convert.ToDouble(Console.ReadLine());

//         Circle circle = new Circle(radius);

//         Console.WriteLine("Radius: " + circle.GetRadius());
//         Console.WriteLine("Area: " + circle.GetArea());
//         Console.WriteLine("Diameter: " + circle.GetDiameter());
//         Console.WriteLine("Circumference: " + circle.GetCircumference());
//     }
// }




// class Program
// {
//     static void Main()
//     {
//         Date date = new Date(5, 3, 2025);

//         Console.WriteLine("Date: " + date.ToString());

//         date.SetDate(9, 11, 2026);

//         Console.WriteLine("New date: " + date.ToString());
//         Console.WriteLine("Day: " + date.GetDay());
//         Console.WriteLine("Month: " + date.GetMonth());
//         Console.WriteLine("Year: " + date.GetYear());
//     }
// }




// class Program
// {
//     static void Main()
//     {
//         BankAccount account = new BankAccount(101, "John", 1000m);

//         account.ShowInfo();

//         Console.WriteLine();

//         account.Deposit(500m);
//         account.Withdraw(200m);

//         Console.WriteLine("Balance: " + account.GetBalance());

//         Console.WriteLine();

//         account.FreezeAccount();
//         account.Withdraw(100m);

//         Console.WriteLine();

//         account.UnfreezeAccount();
//         account.Withdraw(100m);

//         Console.WriteLine();

//         account.ShowInfo();
//     }
// }


































































