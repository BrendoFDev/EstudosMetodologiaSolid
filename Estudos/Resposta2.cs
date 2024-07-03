using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Estudos
{

    public class Report
    {
        public string? Data { get; set; }
    }

    public class ReportServices
    {
        public IReportGenerator ReportGenerator { get; }
        public IReportPrinter ReportPrinter { get; }

        public ReportServices(IReportGenerator Generator, IReportPrinter Printer)
        {
            this.ReportGenerator = Generator;
            this.ReportPrinter = Printer;
        }
    }

    public class ReportGenerator : IReportGenerator
    {
        public Report Generate(string report) 
        { 
            Report _report = new Report();
            _report.Data = report;
            return _report;
        }
    }

    public class ReportPrinter : IReportPrinter
    {
        public void Print(Report report)
        {
            Console.Write(report.Data);
        }
    }

    public interface IReportPrinter
    {
         void Print(Report report);
    }

    public interface IReportGenerator
    {
        Report Generate(string ReportContent);
    }
 /*
    public class Program
    {
        public static void Main()
        {
           
            IReportGenerator Generator = new ReportGenerator();
            IReportPrinter Printer = new ReportPrinter();

            ReportServices _ReportServices = new ReportServices(Generator, Printer);

            Report report = _ReportServices.ReportGenerator.Generate("Teste de Metodologias Solid e CleanCode BY BRENDO");
            
            _ReportServices.ReportPrinter.Print(report);

            Thread.Sleep(1000);
        }
    }*/
}


