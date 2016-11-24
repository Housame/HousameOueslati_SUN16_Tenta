using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Housame_Oueslati_SUN16_tenta.Managers
{
    interface IManager
    {
        void AddCustomer();
        void ShowCustomers();
        void ShowTickets();
        void BuyTicket();
        void SearchByBuyer();
    }
}
