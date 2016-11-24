using Housame_Oueslati_SUN16_tenta.Models;
using Housame_Oueslati_SUN16_tenta.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static Housame_Oueslati_SUN16_tenta.Filters.TicketFilters;

namespace Housame_Oueslati_SUN16_tenta.Managers
{
    public delegate void PrintErrorMsg();
    class Manager : IManager
    {
        private static event PrintErrorMsg ErrorMsg;

        public void AddCustomer()
        {
            Console.Clear();
            Console.WriteLine("Add a new customer:");
            var newCustomer = CreateCustomer();
            ListManager.CustomerList.Add(newCustomer);
            Console.WriteLine("Done, press anywhere to move on");
            Console.ReadKey(true);
        }

        public void ShowCustomers()
        {
            Console.Clear();
            GUI.PrintCustomers();
            Console.ReadKey(true);
        }

        public void ShowTickets()
        {
            Console.Clear();
            GUI.PrintTickets();
            Console.ReadKey(true);
        }

        private Customer CreateCustomer()
        {
            Customer newCustomer = new Customer();
            newCustomer.Name = InputControllers.NameController();
            newCustomer.Age = InputControllers.AgeController();
            newCustomer.Email = InputControllers.EmailController();
            return newCustomer;
        }

        public void BuyTicket()//kunder som är under 18 år får ej boka biljetter en kund fins hårdkodad för att testa event
        {
            Console.Clear();
            GUI.PrintCustomers();
            var index = InputControllers.IndexController(ListManager.CustomerList.Count);
            CreateTicket(index); 
            Console.ReadKey(true);
        }

        private void CreateTicket(int index)//Här anropas event om den valda kund är under 18 år
        {
            if (ListManager.CustomerList[index].Age < 18)
            {
                ErrorMsg += new PrintErrorMsg(GUI.AgeError);
                ErrorMsg?.Invoke();
            }
            else
            {
                VIPTicket newTicket = new VIPTicket();
                newTicket.Buyer = ListManager.CustomerList[index];
                newTicket.Price = InputControllers.PriceController();
                GUI.ShowVIPlevels();
                int choice = InputControllers.VIPChoice();
                newTicket.VIPLevel = (VIPTicket.Level)choice;
                ListManager.TicketList.Add(newTicket);
            }

        }

        public void SearchByBuyer()
        {
            Console.Clear();
            Console.WriteLine("Name you want to search");
            var seekedName = InputControllers.NameController().ToUpper();
            var newTickets = ListManager.TicketList.FindAll(t => t.Buyer.Name.ToUpper().Equals(seekedName));
            if (newTickets.Count == 0)
            {
                Console.WriteLine("The name you search doesn't exist or have no tickets to show");
                Thread.Sleep(1500);
            }
            else
            {
                foreach (var ticket in newTickets)
                {
                    Console.WriteLine(ticket.PrintInfo());
                }
                Console.ReadKey(true);
            }
        }

        public void PrintWhere(TicketFilter filter)
        {
            foreach (var ticket in ListManager.TicketList)
            {
                if (filter(ticket))
                    Console.WriteLine(ticket.PrintInfo());
            }
        }

    }
}
