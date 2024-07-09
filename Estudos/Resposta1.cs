using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudos
{
    public interface IOrderRepository
    {
        void Save(Order order);
    }

    public class DatabaseOrderRepository : IOrderRepository
    {
        public void Save(Order order)
        {
            //código para salvar o repositório
        }
    }

    public interface IEmailService
    {
        void SendEmail(string Message);
    }

    public class EmailService: IEmailService
    {
        public void SendEmail(string Message)
        {
            // logica para enviar email
        }
    }

    public class Program
    {
        public static void Main()
        {
            IOrderRepository orderRepository = new DatabaseOrderRepository();
            IEmailService emailService = new EmailService();
        }
    }
}
