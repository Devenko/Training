using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Net_module1_3_1_lab
{
    class CatchExceptionClass
    {
        public void CatchExceptionMethod(int[] arr1)
        {
            try
            {
                MyArray ma = new MyArray();

                // 3) replace second elevent of array by 0

                int[] arr = new int[4] { 1, 4, 8, 5 };
                ma.Assign(arr, 4);
                arr[1] = 0;
                
            }
           
                // 8) catch all other exceptions here
            catch (Exception q)
            {
                // 9) print System.Exception properties:
                // HelpLink, Message, Source, StackTrace, TargetSite
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"HelpLink: {q.HelpLink}");
                Console.WriteLine($"Message: {q.Message}");
                Console.WriteLine($"Source: {q.Source}");
                Console.WriteLine($"StackTrace: {q.StackTrace}");
                Console.WriteLine($"TargetSite: {q.TargetSite}");
            }

            // 10) add finally block, print some message
            // explain features of block finally
            finally
            {
                Console.WriteLine("CatchExceptionMethod finish");
                Console.ReadKey();
            }
        }
    }
}
