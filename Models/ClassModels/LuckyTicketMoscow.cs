using System;

using TaskLuckyTickets.Models.InterfaceModels;

namespace TaskLuckyTickets.Models.ClassModels
{
    class LuckyTicketMoscow: ILuckyTicket
    {
        public int StartNumber { get; }

        public int LastNumber { get; }

        public int AmountOfLuckyTickets { get; set; }
        public LuckyTicketMoscow()
        {
            StartNumber = 000000;
            LastNumber = 999999;
        }
        public LuckyTicketMoscow(int startNumber, int lastNumber)
        {
            StartNumber = startNumber;
            LastNumber = lastNumber;
        }
        public int CountLuckyTicketsInInterval()
        {
            AmountOfLuckyTickets = 0;
            int a, b, c, d, f, g;
            for (int i = StartNumber; i <= LastNumber; i++)
            {
                a = i / 100000;
                b = (i % 100000) / 10000;
                c = (i % 10000) / 1000;
                d = (i % 1000) / 100;
                f = (i % 100) / 10;
                g = i % 10;

                if (a + b + c == d + f + g)
                    AmountOfLuckyTickets++;
            }
            return AmountOfLuckyTickets;
        }
    }
}
