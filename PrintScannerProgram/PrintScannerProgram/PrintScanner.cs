using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintScannerProgram
{
    public class PrintScanner
    {
        IPrinter printer;
        IScanner scanner;

        public PrintScanner(Printer _printer)
        {
            this.printer = _printer;

        }

        public PrintScanner(Scanner _scanner)
        {
            this.scanner = _scanner;
        }

        public PrintScanner(Printer _printer, Scanner _scanner)
        {
            this.printer = _printer;
            this.scanner = _scanner;
        }

        public void PrintingOnly()
        {
            printer.Print();
        }

        public void ScanningOnly()
        {
            scanner.Scan();
        }

        public void PrintAndScan()
        {
            printer.Print();
            scanner.Scan();
        }




    }
}
