// using System;

// namespace MyApp
// {
//     public class Program
//     {
//         public static void Main(string[] args)
//         {
//             Console.WriteLine("Hello, world!");
//         }
//     }
// }

using System;
using System.Collections;

class TCHLN
{
    static public void Main()
    {

        Stack my_stack = new Stack();

        my_stack.Push("Tech");
        my_stack.Push("Evolution");
        my_stack.Push("Techolution");
        my_stack.Push(null);
        my_stack.Push(1234);
        my_stack.Push(490.98);

        foreach (var elem in my_stack)
        {
            Console.WriteLine(elem);
            Console.ReadLine();
        }
    }
}