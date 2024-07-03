using Estudos;
using System;

public class Order
{
    public double CalculateTotal()
    {
        // Complex logic for calculating the total
        return 0.0;
    }
}


public class OrderProcessor
{
    private readonly IOrderRepository _OrderRepository;
    private readonly IEmailService _EmailService;

    public OrderProcessor(IOrderRepository orderRepository, IEmailService emailService)
    {
        _OrderRepository = orderRepository;
        _EmailService = emailService;
    }

    public void ProcessOrder(Order order)
    {
        double TotalValueFromOrder = order.CalculateTotal();
        _OrderRepository.Save(order);
        _EmailService.SendEmail($"Pedido Salvo Com Valor Total:{TotalValueFromOrder}");
    }
}
