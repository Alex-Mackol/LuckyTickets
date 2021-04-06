using System;

using TaskLuckyTickets.Controllers.ClassControllers;

namespace TaskLuckyTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            TicketsController ticketsController = new TicketsController();
            ticketsController.Startprogram(args[0], args[1]);
            Console.ReadKey();
        }
    }
}
