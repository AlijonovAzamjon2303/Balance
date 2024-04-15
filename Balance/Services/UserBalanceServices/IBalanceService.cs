//----------------------------------------
// Tarteeb School (c) All rights reserved
//----------------------------------------

namespace Balance.Services.UserBalanceServices
{
    internal interface IBalanceService
    {
        void Add(decimal amount);
        void Subtract(decimal amount);
        decimal Get(decimal amount);
    }
}
