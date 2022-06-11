using static System.Console;
namespace Operators
{
    class Program
    {
        public static void Main()
        {
            WriteLine("I am practicing and would achieve success soon");      
            int a = 3;
            int b = a++;
            
            //A should be 4
            //B should be 3
            
            WriteLine($"value of A is {a} and b is {b}");

            int c = 3;
            int d = ++c;

            //pre increment
            //C should be 4
            //D should be 4

            WriteLine($"Value of C is {c} and D is {d}");            

        }
    }
}