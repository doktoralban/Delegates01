using System;

namespace Delegates01
{
    // Delegate Definition  
    public delegate int operation(int x, int y);

    class Program
    {
        // Method that is passes as an Argument  
        // It has same signature as Delegates   
        static int Addition(int a, int b)
        {
            return a + b;
        }

        static void Main(string[] args)
        {
            // Delegate instantiation  
            operation oper = new operation(Program.Addition);

            // output  
            Console.WriteLine("Addition is={0}", oper(15, 42));
            Console.ReadLine();
        }


    }
}