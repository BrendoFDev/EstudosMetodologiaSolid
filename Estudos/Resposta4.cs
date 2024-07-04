using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudos
{
 
    public class MultiFunctionPrinter : IPrintService, IDigitalizeService, ISendService
    {
        public void Print()
        {
            // Imprime o documento
        }

        public void Scan()
        {
            // Digitaliza o documento
        }

        public void SendByFax()
        {
            // Envia o documento por fax
        }
    }

    public class SimplePrinter : IPrintService
    {
        public void Print()
        {

        }
    }

    public interface IPrintService
    {
        void Print();
    }

    public interface IDigitalizeService
    {
        void Scan();
    }

    public interface ISendService
    {
        void SendByFax();
    }

}
