//----------------------------------------
// Tarteeb School (c) All rights reserved
//----------------------------------------

using Balance.Brokers.Loggings;
using Balance.Models;
using Balance.Services.UserMessageServices;

namespace Balance.Services.UserBalanceServices
{
    internal class BalanceService : IBalanceService
    {
        User user;
        ILoggingBroker broker;
        IMessage message;
        public BalanceService()
        {
            this.user = new User() { Fund = 0};
            this.broker = new LoggingBroker();
        }
        public void Add(decimal amount)
        {
            this.user.Fund += amount;
        }

        public decimal Get()
        {
            return this.user.Fund;
        }

        public void Subtract(decimal amount)
        {
            if(this.user.Fund < amount) 
            {
                this.broker.LogError("Sizning hisobingizda mablag' yetarli emas!");
                return;
            }
            this.user.Fund -= amount;
            message = new EmailMessage();
            message.SendMassage(user, $"Sizning hisobingizdan {amount} miqdorida pul yechib olindi");
            if(this.user.Fund == 0)
            {
                message = new SMSMessage();
                message.SendMassage(user, "Sizning hisobingizda mablag' qolmadi. Iltimos hisobingizni to'ldiring!");
            }
        }
    }
}
