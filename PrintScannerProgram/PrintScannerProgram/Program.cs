using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintScannerProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer print = new Printer();
            print.Print();

            Scanner scan = new Scanner();
            scan.Scan();

            PrintManager printManager = new PrintManager();
            printManager.Print(print);

            ScanManager _scanManager = new ScanManager();
            _scanManager.Scan(scan);

            PrintScanner printonly = new PrintScanner(new PrintManager());
            printonly.PrintingOnly();

            PrintScanner scanOnly = new PrintScanner(new ScanManager());
            scanOnly.ScanningOnly();

            PrintScanner printAndScan = new PrintScanner(new PrintManager(), new ScanManager());
            printAndScan.PrintAndScan();

         }
    }
}
