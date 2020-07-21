using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concepts
{
    class LambdaExpressions
    {
        public Func<int, int, int> Add = (a, b) => a + b;

        public Action Signature = () => Console.WriteLine("Output: ");

        public Action<int> Print = (a) => Console.WriteLine(a);

    }
}
