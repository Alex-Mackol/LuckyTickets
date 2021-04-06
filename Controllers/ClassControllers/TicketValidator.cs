using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskLuckyTickets.Controllers.ClassControllers
{
    class TicketValidator
    {
        public string MethodToCount { get; }
        public TicketValidator(string methodToCount)
        {
            MethodToCount = methodToCount;
        }

        public string ChoosenToCountLuckyTickets()
        {
            if (MethodToCount.Equals("Moscow", StringComparison.InvariantCultureIgnoreCase))
            {
                return "Moscow";
            }
            else if (MethodToCount.Equals("Piter", StringComparison.InvariantCultureIgnoreCase))
            {
                return "Piter";
            }
            else
            {
                return "Moscow";
            }
        }

    }
}
