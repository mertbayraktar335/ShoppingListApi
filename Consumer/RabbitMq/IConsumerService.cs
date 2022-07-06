using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consumer.RabbitMq
{
    public interface IConsumerService
    {
        void Consume(string queueName, bool IsAcknowledgeAuto);
    }
}
