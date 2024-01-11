using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirtyCSharpQuestions
{
    public class RefVsOut
    {

        public  string GetNextName(ref int id)
        {
            string returnText = "Next-" + id.ToString();
            id += 1;
            return returnText;
        }
        
        public  string GetNextNameByOut(out int id)
        {
            id = 1;
            string returnText = "Next-" + id.ToString();
         
            return returnText;
        }
       
    }
}
