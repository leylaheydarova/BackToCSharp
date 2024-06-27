using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_25
{
    public delegate double OperationHandler(int a);
    internal class Number
    {
        public static void ShowRes(OperationHandler handler, int a)
        {
            var res = handler(a);
            Console.WriteLine(res);
        }
    }
}
