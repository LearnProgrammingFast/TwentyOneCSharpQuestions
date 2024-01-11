using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirtyCSharpQuestions
{
    public static class AsyncAwaitPractice
    {

        public static async void TaskMethod()
        {
            Task<int> task = new Task<int>(AddNumbers);
            task.Start();
            Console.WriteLine("1. Other task executing");
            Console.WriteLine("2. Other task executing");
            Console.WriteLine("3. Other task executing");
            int total = await task;
            Console.WriteLine(" Sum of numbers till 1000: " + total);
            Console.WriteLine("1. After executing task");
            Console.WriteLine("2. After executing task");
        }
        //method to add numbers from 1 to 1000
        public static int AddNumbers()
        {
            int count = 0;
            Console.WriteLine("Adding numbers");
            for (int i = 0; i <= 1000; i++)
            {
                count += i;
            }
            return count;
        }

        public static async Task<string> GetTextAsync()
        {
           string filePath = "E://ESD//Heavy.pdf";
            // Main Thread
            using (var stream = System.IO.File.OpenRead(filePath))
            {
                System.Threading.Thread.Sleep(2000);
                // Main Thread
                using (var reader = new System.IO.StreamReader(stream))
                {
                    return await reader.ReadToEndAsync().ConfigureAwait(continueOnCapturedContext:false); // Background Thread;
                 }
            }
        }

    }
}
