using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_2Delegate_Operation_T
{
    delegate T Operation<T>(T a, T b);
    internal class program
    {
        static T Add<T>(T a, T b) => (dynamic)a + b;
        static T Subtract<T>(T a, T b) => (dynamic)a - b;
        static T Multiply<T>(T a, T b) => (dynamic)a * b;
        static T Divide<T>(T a, T b)
        {
            if (b.Equals(default(T)))
            {
                Console.WriteLine("Cannot divide by zero.");
                return default(T);
            }
            return (dynamic)a / b;
        }
        static void Main(string[] args)
        {
        
            Operation<int> addDelegate = Add;
            Operation<double> subtractDelegate = Subtract;
            Operation<int> multiplyDelegate = Multiply;
            Operation<double> divideDelegate = Divide;

             
            Console.Write("Enter the first value: ");
            string input1 = Console.ReadLine();

            Console.Write("Enter the second value: ");
            string input2 = Console.ReadLine();

             
            Console.WriteLine("Choose an operation:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");

              
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine($"Result: {addDelegate(Convert.ToInt32(input1), Convert.ToInt32(input2))}");
                    break;
                case 2:
                    Console.WriteLine($"Result: {subtractDelegate(Convert.ToDouble(input1), Convert.ToDouble(input2))}");
                    break;
                case 3:
                    Console.WriteLine($"Result: {multiplyDelegate(Convert.ToInt32(input1), Convert.ToInt32(input2))}");
                    break;
                case 4:
                    Console.WriteLine($"Result: {divideDelegate(Convert.ToDouble(input1), Convert.ToDouble(input2))}");
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
            Console.ReadKey();
        }
    }
}
    


    



 




    

      

