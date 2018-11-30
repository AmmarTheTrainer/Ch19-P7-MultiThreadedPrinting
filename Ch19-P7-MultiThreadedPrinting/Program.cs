using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ch19_P7_MultiThreadedPrinting
{
    class Program
    {
        private static readonly object locker = new object();
        public static void Method1()
        {
            Console.WriteLine(" Long running task in progress ");
            Thread.Sleep(3000);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("*****Synchronizing Threads *****\n");
            Printer p = new Printer();
            // Make 10 threads that are all pointing to the same
            // method on the same object.
            Thread[] threads = new Thread[10];

            for (int i = 0; i < 10; i++)
            {
                threads[i] = new Thread(new ThreadStart(p.PrintNumbers))
                {
                    Name = $"Worker thread #{i}"
                };
            }
            // Now start each one.
            foreach (Thread t in threads)
                t.Start();


            #region lock keyword in C#



            #endregion

            Console.ReadLine();
        }
    }
}
