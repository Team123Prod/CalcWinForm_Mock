using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcWinForm
{
    public class Lib: ILib
    {
        private HttpClient client;
        private string uri;

        public Lib()
        {
            client = new HttpClient();
            uri = @"http://localhost:8888/";
        }

        public int RequestCalcResult(int a, int b, string op)
        {
            string temp = uri + "?a=" + a + "&b=" + b + "&op=" + op;
            string response = client.GetStringAsync(temp).Result;
            return int.Parse(response);
        }
    }
}
