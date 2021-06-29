using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintScannerProgram
{
    public class PrintManager:Printer
    {
        public void Print(Printer message)
        {
            message.Print();

        }
    }
}
