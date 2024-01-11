using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirtyCSharpQuestions
{
    public static class Question18
    {
        public static string buffer;

        public static async Task<string> PrintHello()
        {
            buffer = "";
            await Task.Delay(6);
            buffer = "Hello LearnProgrammingFast!";
            return "Hello World";
        }


    }
}
