using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcWinForm
{
    public interface ILib
    {
        int RequestCalcResult(int a, int b, string op);
    }
}
