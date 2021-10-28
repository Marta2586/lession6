using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Phone
    {
        public double Size { get; set; }

        public string Brand { get; set; }

        public string model { get; set; }

        public bool FunctionCall { get; set; }

        public bool FunctionSendSMS { get; set; }
        public bool Function { get; internal set; }
        public double Call { get; internal set; }
    }
}
