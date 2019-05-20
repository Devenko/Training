using System;
using System.IO;

namespace CSharp_Net_module1_3_1_lab
{
    class Program
    {
        static void Main(string[] args)
        {
            CatchExceptionClass cec = new CatchExceptionClass();
            //cec.CatchExceptionMethod();

            // 11) Make some unhandled exception and study Visual Studio debugger report – 
            // read description and find the reason of exception
            int[] arr1 = new[] {1, 0, 8, 5};
            cec.CatchExceptionMethod(arr1);

            int[] arr2 = new int[3];
            cec.CatchExceptionMethod(arr2);
            Console.ReadKey();
        }
    }
}
