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
            int firstNumberPart, secondNumberPart;
            int sumFirstPart, sumSecondPart;

            for (int i = StartNumber; i <= LastNumber; i++)
            {
                sumFirstPart = 0; 
                sumSecondPart = 0;
                secondNumberPart = i % 1000;
                firstNumberPart = i / 1000;

                for (int j = firstNumberPart, k = 1; j > 0; j /= 10, k++)
                {
                    sumFirstPart += firstNumberPart % 10;
                    firstNumberPart /= 10;
                    sumSecondPart += secondNumberPart % 10;
                    secondNumberPart /= 10;
                }
                if (sumFirstPart == sumSecondPart)
                {
                    AmountOfLuckyTickets++;
                }
            }

            return AmountOfLuckyTickets;
        }
    }
}
