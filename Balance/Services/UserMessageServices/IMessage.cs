//----------------------------------------
// Tarteeb School (c) All rights reserved
//----------------------------------------

using Balance.Models;

namespace Balance.Services.UserBalanceServices
{
    internal interface IMessage
    {
        void SendMassage(User user, string message);
    }
}
