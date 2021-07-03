using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintScannerProgram
{
    public class PrintScanner : IPrinter, IScanner
    {
        IPrinter _printerRef;
        IScanner _scannerRef;

        public void SetPrinter(IPrinter printerRef)
        {
            this._printerRef = printerRef;
        }
        public void SetScanner(IScanner scanRef)
        {

            this._scannerRef = scanRef;
        }
        public void Print()
        {
          
            this._printerRef.Print();
        }
        public void Scan()
        {
          
            this._scannerRef.Scan();
        }

    }
}
