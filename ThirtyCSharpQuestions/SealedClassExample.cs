using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirtyCSharpQuestions
{
    sealed class SealedClassExample
    {
        private int x;
        private int y;
    }

    class SealedWithPrivateConstructor
    {
        private int x;
        private int y;

        private SealedWithPrivateConstructor() { }
        public SealedWithPrivateConstructor(int x) { }
    }

    //public class ChildClass:SealedClassExample
    //public class ChildClassWithConsturctor : SealedWithPrivateConstructor { }
}
