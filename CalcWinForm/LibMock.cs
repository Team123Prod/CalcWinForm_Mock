using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcWinForm
{
    class LibMock : ILib
    {
        public int RequestCalcResult(int a, int b, string op)
        {
            int res = 0;
            int n1 = Convert.ToInt32(a);
            int n2 = Convert.ToInt32(b);
            switch (op)
            {
                case "-": res = n1 - n2; break;
                case "+": res = n1 + n2; break;
                case "*": res = n1 * n2; break;
                case "/": res = n1 / n2; break;
            }
            return res;
        }
    }
}
