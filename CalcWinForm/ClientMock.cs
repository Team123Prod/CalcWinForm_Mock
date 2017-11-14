using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcWinForm
{
    public class ClientMock
    {
        public int a;
        public int b;
        public string op;
        public int res;
        ILib lib;
        public ClientMock(int a, int b, string op)
        {
            this.a = a;
            this.b = b;
            this.op = op;
            lib = new Lib();
        }

        public int CalcResult(int a, int b, string op)
        {
            return lib.RequestCalcResult(a, b, op);
        }
    }
}
