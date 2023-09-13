namespace SchoolCsharpAssignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool success = false;
            while (!success)
            {
                try
                {
                    // task 1
                    /*
                    Console.Write("Please enter the length of the side: ");
                    double Side = double.Parse(Console.ReadLine());
                    Console.WriteLine("The P of the triangle is: " + Side*3);
                    success = true;
                    */

                    // task 2
                    /*
                    Console.Write("Please enter the length of the side: ");
                    Int64 Side = Int64.Parse(Console.ReadLine());
                    Console.WriteLine("The P is: " + Side * 6);
                    success = true;
                    */

                    // task 3
                    /*
                    Console.Write("Whats the price of the falafel? ");
                    Int64 FalafelPrice = Int64.Parse(Console.ReadLine());
                    Console.Write("Whats the price of the drink? ");
                    Int64 DrinkPrice = Int64.Parse(Console.ReadLine());
                    Int64 Total = FalafelPrice + DrinkPrice;
                    Console.WriteLine("The total is: " + Total + " shekels");
                    success = true;
                    */

                    // task 4
                    /*
                    Console.Write("Whats the price of the shirts? ");
                    Double ShirtPrice = Double.Parse(Console.ReadLine());
                    Console.Write("How many shirts did you buy? ");
                    Int64 NumShirts = Int64.Parse(Console.ReadLine());
                    Console.WriteLine("Reminder: prining a school badge costs 2ils/shirt");
                    double ShirtTotal = (ShirtPrice + 2) * NumShirts;
                    Console.WriteLine("The total is: " + ShirtTotal + " shekels");
                    success = true;
                    */

                    // task 6
                    /*
                    int a=1,b=2,c=3;

                    c = 0; // 1
                    Console.WriteLine("ONE");
                    Console.WriteLine(a);
                    Console.WriteLine(b);
                    Console.WriteLine(c);
                    a = (a + 5) * a; // 2
                    Console.WriteLine("TWO");
                    Console.WriteLine(a);
                    Console.WriteLine(b);
                    Console.WriteLine(c);
                    b = b + 2 * a; // 3
                    Console.WriteLine(a); // 4
                    Console.WriteLine(b);// 5
                    Console.WriteLine(c);// 6
                    success = true;
                    */

                    // task 7
                    /*
                    Console.Write("Enter A: ");
                    int a = int.Parse(Console.ReadLine());
                    Console.Write("Enter B: ");
                    int b = int.Parse(Console.ReadLine());
                    Console.Write("Enter C: ");
                    int c = int.Parse(Console.ReadLine());
                    int temp = a;
                    a = b;
                    b = c;
                    c = temp;
                    Console.WriteLine(a);
                    Console.WriteLine(b);
                    Console.WriteLine(c);
                    success = true;
                    */

                    // task 7D
                    /*
                    Console.Write("Enter A: ");
                    int a = int.Parse(Console.ReadLine());
                    Console.Write("Enter B: ");
                    int b = int.Parse(Console.ReadLine());
                    Console.Write("Enter C: ");
                    int c = int.Parse(Console.ReadLine());
                    Console.WriteLine(c + "\n" + a + "\n" + b);
                    success = true;
                    */
                }
                catch (FormatException)
                {
                    Console.WriteLine("\nplease enter a number!");
                }
            }
        }
    }
}