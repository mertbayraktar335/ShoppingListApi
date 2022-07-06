using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using TeleperformanceProject.ShoppingList.Application.DTOs;

namespace Consumer.RabbitMq
{
    public class ConsumerService : IConsumerService
    {
        public void Consume(string queueName, bool IsAcknowledgeAuto)
        {
            var connectionFactory = new ConnectionFactory()
            {
                HostName = "localhost",
                VirtualHost = "/",
                Port = 5672,
                UserName = "guest",
                Password = "guest"
            };

            //we wont use USING because this will listen all the time!
            var connection = connectionFactory.CreateConnection();
            var channel = connection.CreateModel();

            //Creating the listening queue
            channel.QueueDeclare(queue: queueName, durable: false, exclusive: false, autoDelete: true);

            //Triggering an event to consume the messages from the queue.
            var consumer = new EventingBasicConsumer(channel);

            consumer.Received += (sender, args) =>
            {
                var message = JsonSerializer.Deserialize<ShopListDto>(Encoding.UTF8.GetString(args.Body.ToArray()));
                foreach (PropertyInfo p in message.GetType().GetProperties())
                    Console.WriteLine(message);
                Console.WriteLine();
            };

            channel.BasicConsume(queue: queueName, autoAck: IsAcknowledgeAuto, consumer: consumer);
        }
    }
}
