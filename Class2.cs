using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace C_class2
{
    public class Class2
    {   
        public static async Task Demo()
        {
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            var task1 = Master();
            await task1;
            var task2 = Slave1();
            var task3 = Slave2();
            Task.WaitAll(task1, task2, task3);
            watch.Stop();
            Console.WriteLine($"Execution time: {watch.ElapsedMilliseconds} ms");
        }

        public static async Task Master()
        {
            await Task.Run(() => {
                Thread.Sleep(8000);
                Console.WriteLine("Master Running");
            });
            
        }

        public static async Task Slave1()
        {
            await Task.Run(() => {
                Thread.Sleep(3000);
                Console.WriteLine("Slave1 Running");
            });
        }

        public static async Task Slave2()
        {
            await Task.Run(() => {
                Thread.Sleep(2000);
                Console.WriteLine("Slave2 Running");
            });
        }
        //static void Main(string[] args)
        //{
        //    Demo();
        //    Console.ReadLine();
        //}
    }
}
