using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleperformanceProject.ShoppingList.Application.DTOs;
using TeleperformanceProject.ShoppingList.Domain.Entities;

namespace TeleperformanceProject.ShoppingList.Application.Repositories.RabbitMq
{
    public interface IPublisherService
    {
        void Publish(ShopListDto dto, string queueName, string routingKey);
    }
}
