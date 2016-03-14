using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarCode
{
    public class CommCLR
    {
        public static IWebClient_clr webclient { get; set; }

        public static IScanning Iscan { get; set; }

        public CommCLR(IWebClient_clr wc,IScanning scan)
        {
            CommCLR.webclient = wc;
            CommCLR.Iscan = scan;
        }
    }
}
