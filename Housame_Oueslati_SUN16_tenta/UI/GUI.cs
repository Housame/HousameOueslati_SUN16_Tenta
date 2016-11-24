using Housame_Oueslati_SUN16_tenta.Filters;
using Housame_Oueslati_SUN16_tenta.Managers;
using Housame_Oueslati_SUN16_tenta.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static Housame_Oueslati_SUN16_tenta.Filters.TicketFilters;

namespace Housame_Oueslati_SUN16_tenta.UI
{
    class GUI
    {
        Manager mgr = new Manager();
        public void MainMenu()
        {
            Console.Clear();
            PrintMenu();
            var input = Console.ReadKey(true).Key;
            switch (input)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    mgr.ShowCustomers();
                    break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    mgr.ShowTickets();
                    break;
                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    mgr.AddCustomer();
                    break;
                case ConsoleKey.D4:
                case ConsoleKey.NumPad4:
                    mgr.BuyTicket();
                    break;
                case ConsoleKey.D5:
                case ConsoleKey.NumPad5:
                    mgr.SearchByBuyer();
                    break;
                case ConsoleKey.D6:
                case ConsoleKey.NumPad6:
                    ShowBy();
                    break;
                case ConsoleKey.D7:
                case ConsoleKey.NumPad7:
                    Environment.Exit(0);
                    break;
            }
        }

        private void ShowBy()
        {
            PrintShowBy();
            var input = Console.ReadKey(true).Key;
            switch (input)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    TicketFilter isMoreThanFiveHundred = TicketFilters.IsMoreThanFiveHundred;
                    mgr.PrintWhere(isMoreThanFiveHundred);
                    Console.ReadKey();
                    break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    TicketFilter normalVIPAndMaxVIP = TicketFilters.NormalVIPAndMaxVIP;
                    mgr.PrintWhere(normalVIPAndMaxVIP);
                    Console.ReadKey();
                    break;
                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    MainMenu();
                    break;
            }
        }

        internal static void AgeError()
        {
            InputControllers.ClearOneLine();
            Console.WriteLine("Too young! People under 18 years old cannot buy tickets to this event");
            Thread.Sleep(1500);
        }

        private void PrintShowBy()
        {
            Console.Clear();
            Console.WriteLine("********************************");
            Console.WriteLine("*          Show By:            *");
            Console.WriteLine("* ---------------------------- *");
            Console.WriteLine("*                              *");
            Console.WriteLine("*     1. Tickets over 500 SEK  *");
            Console.WriteLine("*     2. VIP and maxVIP       *");
            Console.WriteLine("*     3. Back to main menu     *");
            Console.WriteLine("*                              *");
            Console.WriteLine("* ---------------------------- *");
            Console.WriteLine("********************************");
        }

        internal static void PrintTickets()
        {
            int index = 0;
            Console.WriteLine("********************");
            Console.WriteLine("****** Tickets  ****");
            Console.WriteLine("********************");
            foreach (var ticket in ListManager.TicketList)
            {
                index++;
                Console.WriteLine("{0}. {1}",index, ticket.PrintInfo());
            }
        }

        internal static void ShowVIPlevels()
        {
            foreach (var genre in Enum.GetValues(typeof(VIPTicket.Level)))
            {
                Console.WriteLine("{0}, {1}", (int)genre, genre);
            }
        }

        internal static void PrintCustomers()
        {
            int index = 0;
            Console.WriteLine("********************");
            Console.WriteLine("***** Customers ****");
            Console.WriteLine("********************");
            foreach (var customer in ListManager.CustomerList)
            {
                index++;
                Console.WriteLine("{3}. Name: {0}, Age: {1}, Email: {2}", customer.Name, customer.Age, customer.Email,index);
            }
        }

        public void PrintMenu()
        {
            Console.Clear();
            Console.WriteLine("********************************");
            Console.WriteLine("*        Start Menu            *");
            Console.WriteLine("* ---------------------------- *");
            Console.WriteLine("*                              *");
            Console.WriteLine("*       1. Show Customers      *");
            Console.WriteLine("*       2. Show Tickets        *");
            Console.WriteLine("*       3. Add a new customer  *");
            Console.WriteLine("*       4. Buy a ticket        *");
            Console.WriteLine("*       5. Search a customer   *");
            Console.WriteLine("*       6. Show by             *");
            Console.WriteLine("*       7. Exit                *");
            Console.WriteLine("*                              *");
            Console.WriteLine("* ---------------------------- *");
            Console.WriteLine("********************************");
        }
    }
}
