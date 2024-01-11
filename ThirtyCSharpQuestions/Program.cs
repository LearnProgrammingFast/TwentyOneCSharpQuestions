using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThirtyCSharpQuestions
{
    internal class Program
    {
   
        static void Main(string[] args)
        {

            //int i = 0;
            //Console.WriteLine("Previous value of integer i by out:" + i.ToString());
            //string test = new RefVsOut().GetNextNameByOut(out i);
            //Console.WriteLine("Current value of integer i by out:" + i.ToString());

            //i = 1;
            //Console.WriteLine("Previous value of integer i:" + i.ToString());
            //test = new RefVsOut().GetNextName(ref i);
            //Console.WriteLine("Current value of integer i:" + i.ToString());

            //Console.Read();

            //int x = 0;
            //try
            //{
            //    x = 1;

            //}
            //catch (Exception)
            //{

            //    Console.WriteLine("Exception occured");

            //}
            //finally
            //{
            //    Console.WriteLine("Checking finally");
            //}

            //Console.Read();


            //SealedWithPrivateConstructor c = new SealedWithPrivateConstructor();


            //AsyncAwaitPractice.TaskMethod();
            //Console.Read();

            //var res = AsyncAwaitPractice.GetTextAsync();

            // Console.ReadLine();

            //int result = 0;
            //void Work1() { result = 1; }
            //void Work2() { result = 2; }
            //void Work3() { result = 3; }

            //Thread worker1 = new Thread(Work1);
            //Thread worker2 = new Thread(Work2);
            //Thread worker3 = new Thread(Work3);

            //worker1.Start();
            //worker2.Start();
            //worker3.Start();
            //Thread.Sleep(100);

            //Console.WriteLine(result);
            //Console.Read();


            //VoteMachine vm1 = VoteMachine.Instance;
            //VoteMachine vm2 = VoteMachine.Instance;
            //VoteMachine vm3 = VoteMachine.Instance;

            //vm1.RegisterVote();
            //vm2.RegisterVote();
            //vm3.RegisterVote();

            //Console.WriteLine(vm1.TotalVotes);

            //Console.Read();


            _ = Question18.PrintHello();
            Console.WriteLine(Question18.buffer);
            Console.Read();




        }


    }
}
