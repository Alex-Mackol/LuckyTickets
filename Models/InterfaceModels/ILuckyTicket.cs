using System;


namespace TaskLuckyTickets.Models.InterfaceModels
{
    interface ILuckyTicket
    {
        int StartNumber { get; }
        int LastNumber { get; }
        int AmountOfLuckyTickets { get; }
        int CountLuckyTicketsInInterval();
    }
}
