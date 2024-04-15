//----------------------------------------
// Tarteeb School (c) All rights reserved
//----------------------------------------

using Balance.Brokers.Loggings;
using Balance.Models;
using Balance.Services.UserBalanceServices;

namespace Balance.Services.UserMessageServices
{
    internal class SMSMessage : IMessage
    {
        ILoggingBroker broker;
        public SMSMessage()
        {
            this.broker = new LoggingBroker();
        }
        public void SendMassage(User user, string message)
        {
            this.broker.LogInforamation($"Hurmatli {user.Name} sizga quyidagi xabar SMS orqali jo'natildi");
            this.broker.LogInforamation(message);
        }
    }
}
