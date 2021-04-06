using System;
using System.Collections.Generic;

using TaskLuckyTickets.Models.InterfaceModels;


namespace TaskLuckyTickets.Models.ClassModels
{
    class LuckyTicketPiter : ILuckyTicket
    {
        public int StartNumber { get; }

        public int LastNumber { get; }

        public int AmountOfLuckyTickets { get; set; }
        public LuckyTicketPiter()
        {
            StartNumber = 000000;
            LastNumber = 999999;
        }
        public LuckyTicketPiter(int startNumber, int lastNumber)
        {
            StartNumber = startNumber;
            LastNumber = lastNumber;
        }
        public int CountLuckyTicketsInInterval()
        {
            AmountOfLuckyTickets = 0;
            int sumOddPart = 0, sumEvenPart = 0, currentNum;

            for (int i = StartNumber; i <= LastNumber; i++)
            {
                sumOddPart = 0;
                sumEvenPart = 0;
                currentNum = i;
                for (int j = 0; j < 6; j++)
                {
                    if (currentNum % 10 % 2 == 0)
                    {
                        sumOddPart += currentNum % 10;
                    }
                    else
                    {
                        sumEvenPart += currentNum % 10;
                    }
                    currentNum /= 10;
                }
                if (sumEvenPart == sumOddPart)
                {
                    AmountOfLuckyTickets++;
                }
            }

            return AmountOfLuckyTickets;
        }
    }
}
