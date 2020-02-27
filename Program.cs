using System;

namespace genericsExample
{     
    public class Compare<T> 
    {
        public static bool AreEqual(T Value1, T Value2)
        {
            // Compare values
            return Value1.Equals(Value2);
        }
    }

    class Program
    {        
        static void Main(string[] args)
        {
            Console.WriteLine("This program compares two positive or negative integer values using generics\n");

            Console.WriteLine("Enter a value");
            int input1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter another value");

            // string compare
            // string input2 = Console.ReadLine();
            // bool Equal = Compare<string>.AreEqual(input1, input2);

            // integer compare
            int input2 = Convert.ToInt32(Console.ReadLine());            
            bool Equal = Compare<int>.AreEqual(input1, input2);

            if (Equal)
            {
                Console.WriteLine("\nEqual");
            }
            else 
            {

                Console.WriteLine("\nNot Equal");
            }

            Console.WriteLine("\nPress any key to exit");
            Console.ReadKey();
        }
    }
}
