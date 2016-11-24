using Housame_Oueslati_SUN16_tenta.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Housame_Oueslati_SUN16_tenta.Filters
{
    class TicketFilters
    {
        public delegate bool TicketFilter(VIPTicket ticket);

        public static bool IsMoreThanFiveHundred(VIPTicket ticket)
        {
            return ticket.Price > 500;
        }

        public static bool NormalVIPAndMaxVIP(VIPTicket ticket)//Visar två nivåer av VIPLevel ( VIP och maxVIP)
        {
            return (ticket.VIPLevel == VIPTicket.Level.maxVIP) || (ticket.VIPLevel == VIPTicket.Level.VIP);
        }
    }
}
