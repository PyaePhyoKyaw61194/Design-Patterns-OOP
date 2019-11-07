using System;
namespace TestPJ
{
    //Client Code
    //ReportFactory fac = new HTMLReportFactory();
    //ReportHeader header = fac.createHeader();
    //ReportBody body = fac.createBody();

    //header.generateHeader();
    //        body.generateBody();


    abstract class ReportHeader
    {
        public abstract void GenerateHeader();
    }
    abstract class ReportBody
    {
        public abstract void GenerateBody();
    }

    class HTMLReportHeader : ReportHeader
    {
        public override void GenerateHeader()
        {
            Console.WriteLine("HTML Report Header");
        }
    }
    class HTMLReportBody : ReportBody
    {
        public override void GenerateBody()
        {
            Console.WriteLine("HTML Report Body");
        }
    }

    class PDFReportHeader : ReportHeader
    {
        public override void GenerateHeader()
        {
            Console.WriteLine("PDF Report Header");
        }
    }
    class PDFReportBody : ReportBody
    {
        public override void GenerateBody()
        {
            Console.WriteLine("PDF Report Body");
        }
    }

    abstract class ReportFactory
    {
        public abstract ReportHeader createHeader();
        public abstract ReportBody createBody();
    }
    class HTMLReportFactory : ReportFactory
    {
        public override ReportHeader createHeader()
        {
            return new HTMLReportHeader();
        }
        public override ReportBody createBody()
        {
            return new HTMLReportBody();
        }
    }
    class PDFReportFactory : ReportFactory
    {
        public override ReportHeader createHeader()
        {
            return new PDFReportHeader();
        }
        public override ReportBody createBody()
        {
            return new PDFReportBody();
        }
    }
}
