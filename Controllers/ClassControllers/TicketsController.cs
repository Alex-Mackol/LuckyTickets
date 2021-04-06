using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using TaskLuckyTickets.Models.ClassModels;
using TaskLuckyTickets.View.ClassView;

namespace TaskLuckyTickets.Controllers.ClassControllers
{
    class TicketsController
    {
        LuckyTicketMoscow ticketMoscow;
        LuckyTicketPiter ticketPiter;
        DisplayResult displayResult;
        TicketValidator validator;

        public TicketsController()
        {
            //ticketMoscow = new LuckyTicketMoscow();
            //ticketPiter = new LuckyTicketPiter();
            displayResult = new DisplayResult();
        }

        public void Startprogram(string startPosition, string lastPosition)
        {
            string methodToCountLuckyTickets = "";
            using (StreamReader sr = new StreamReader("text.txt"))
            {
                while (!sr.EndOfStream)
                    methodToCountLuckyTickets = sr.ReadLine();
            }
            validator = new TicketValidator(methodToCountLuckyTickets);

            if (validator.ChoosenToCountLuckyTickets() == "Moscow")
            {
                ticketMoscow = new LuckyTicketMoscow(int.Parse(startPosition), int.Parse(lastPosition));
                ticketMoscow.CountLuckyTicketsInInterval();
                displayResult.DisplayOnScrenInfo(startPosition, lastPosition,ticketMoscow.AmountOfLuckyTickets);
            }
            else
            {
                ticketPiter = new LuckyTicketPiter(int.Parse(startPosition), int.Parse(lastPosition));
                ticketPiter.CountLuckyTicketsInInterval();
                displayResult.DisplayOnScrenInfo(startPosition, lastPosition, ticketPiter.AmountOfLuckyTickets);
            }

        }

        
    }
}
