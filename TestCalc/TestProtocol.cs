using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalcWinForm;

namespace TestCalc
{
    [TestClass]
    public class TestProtocol
    {
        [DataTestMethod]
        [DataRow(1, 2, "p", 3)]
        [DataRow(1, 2, "*", 2)]
        [DataRow(1, 2, "-", -1)]
        [DataRow(2, 2, "/", 1)]

        public void MockRequest_Test(int a, int b, string op, int exp)
        {
            ILib lib = new Lib();
            int res = lib.RequestCalcResult(a, b, op);
            Assert.AreEqual(exp, res);
        }

        [DataTestMethod]
        [DataRow(1, 2, "p", 3)]
        [DataRow(1, 2, "*", 2)]
        [DataRow(1, 2, "-", -1)]
        [DataRow(2, 2, "/", 1)]

        public void MockClient_Test(int a, int b, string op, int exp)
        {
            ClientMock Client = new ClientMock(a, b, op);
            int res = Client.CalcResult(a, b, op);
            Assert.AreEqual(exp, res);
        }

        [DataTestMethod]
        [DataRow(1, 2, "p")]
        [DataRow(1, 2, "*")]
        [DataRow(1, 2, "-")]
        [DataRow(2, 2, "/")]

        public void MockServer_Test(int a, int b, string op)
        {
            ILib lib = new Lib();
            int res = lib.RequestCalcResult(a, b, op);
            Assert.AreEqual(10, res);
        }
    }
}
