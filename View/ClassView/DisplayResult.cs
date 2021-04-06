using System;
using System.Collections.Generic;

using TaskLuckyTickets.View.InterfaceView;

namespace TaskLuckyTickets.View.ClassView
{
    class DisplayResult : IDisplay
    {
        int AmountOfLuckyTickets { get; }
        public DisplayResult(/*int amountLuckyTickets*/)
        {
            //AmountOfLuckyTickets = amountLuckyTickets;
        }

        public void DisplayOnScrenInfo(string start, string last, int result)
        {
            Console.WriteLine($"Amount of lucky tickets in interval [{start};{last}]:" + result.ToString());
        }
    }
}
