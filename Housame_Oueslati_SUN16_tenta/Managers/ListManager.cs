using Housame_Oueslati_SUN16_tenta.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Housame_Oueslati_SUN16_tenta.Managers
{
    class ListManager
    {
        static List<VIPTicket> ticketList;
        public static List<VIPTicket> TicketList
        {
            get
            {
                if (ticketList == null)
                {
                    ticketList = new List<VIPTicket>()
                {
                    new VIPTicket {Buyer = CustomerList[0], Price = 999.99f ,VIPLevel = VIPTicket.Level.maxVIP},
                    new VIPTicket {Buyer = CustomerList[1], Price = 699.99f ,VIPLevel = VIPTicket.Level.miniVIP},
                    new VIPTicket {Buyer = CustomerList[2], Price = 799.99f ,VIPLevel = VIPTicket.Level.VIP},
                    new VIPTicket {Buyer = CustomerList[3], Price = 499.99f ,VIPLevel = VIPTicket.Level.NoVIP},
                    new VIPTicket {Buyer = CustomerList[4], Price = 599.99f ,VIPLevel = VIPTicket.Level.NoVIP}
                };
                }
                return ticketList;
            }
            set { ticketList = value; }
        }

        //Har lagt till en kund som är under 17 årför att event ska kunna testas
        static List<Customer> customerList;
        public static List<Customer> CustomerList
        {
            get
            {
                if (customerList == null)
                {
                    customerList = new List<Customer>()
                {
                    new Customer {Name = "Johan", Age = 35, Email = "johan@hotmail.com" },
                    new Customer {Name = "Marc", Age = 27, Email = "marc@hotmail.com" },
                    new Customer {Name = "Adrian", Age = 33, Email = "adrian@hotmail.com" },
                    new Customer {Name = "Sanna", Age = 26, Email = "Sanna@hotmail.com" },
                    new Customer {Name = "Amanda", Age = 29, Email = "amanda@hotmail.com" },
                    new Customer {Name = "Olle", Age = 17, Email = "oller@hotmail.com" }//Har lagt till den kund som är under 17 årför att event ska kunna testas
                };
                }
                return customerList;
            }
            set { customerList = value; }
        }

    }
}
