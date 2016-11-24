using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Housame_Oueslati_SUN16_tenta.UI
{

    class InputControllers
    {


        public static string NameController()
        {

            do
            {
                Console.Write("Name: ");
                string input = Console.ReadLine();
                if (input.Length >= 2)
                {

                    return input;
                }
                else
                {
                    ClearOneLine();
                    Console.WriteLine("Please put a right  name, at least 2 characters!");
                    Thread.Sleep(1000);
                    ClearOneLine();
                }
            } while (true);
        }

        public static int IndexController(int listCount)
        {
            int input = 0;
            do
            {
                Console.Write("Choose a user: ");
                try
                {
                    input = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    ClearOneLine();
                    Console.WriteLine("Make sure that you put in a number between 1 and {0}!!", listCount);
                    Thread.Sleep(1000);

                };

                if (input >= 1 && input <= listCount)
                {
                    return input - 1;
                }

                else
                {
                    ClearOneLine();
                }
            } while (true);
        }

        public static int AgeController()
        {
            int input = 0;
            do
            {
                Console.Write("Age: ");
                try
                {
                    input = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    ClearOneLine();
                    Console.WriteLine("Make sure that you put in a age");
                    Thread.Sleep(1000);

                };

                if (input >= 10 && input < 100)
                {
                    return input;
                }

                else
                {
                    ClearOneLine();
                }
            } while (true);
        }

        internal static int VIPChoice()
        {

            int input = 0;
            do
            {
                Console.Write("Choose a VIP level: ");
                try
                {
                    input = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    ClearOneLine();
                    Console.WriteLine("Make sure that you put in a number between 1-4");
                    Thread.Sleep(1000);

                };

                if (input >= 1 && input <= 4)
                {
                    return input;
                }

                else
                {
                    ClearOneLine();
                }
            } while (true);
        }

        internal static float PriceController()
        {
            do
            {
                float input = 0.0f;
                Console.Write("Price(SEK): ");
                try
                {
                    input = float.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    ClearOneLine();
                    Console.WriteLine("Make sure that the price is reasonable");
                    Thread.Sleep(1000);

                };

                if (input >= 99.99 && input < 9999.99)
                {
                    return input;
                }

                else
                {
                    ClearOneLine();
                    Console.WriteLine("Make sure that the price is reasonable");
                    Thread.Sleep(1000);
                    ClearOneLine();
                }
            } while (true);



        }

        public static string EmailController()
        {

            do
            {
                Console.Write("Email: ");
                string input = Console.ReadLine();
                if (input.Length >= 6)
                {
                    if (IsValidEmail(input))
                        return input;
                }
                else
                {
                    ClearOneLine();
                    Console.WriteLine("Please put a right  name, at least 2 characters!");
                    Thread.Sleep(1000);
                    ClearOneLine();
                }
            } while (true);
        }

        static bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        public static void ClearOneLine()// en metod som ska användas för att kunna ta bort ett antal Line "för grafisk förbättring"
        {
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, Console.CursorTop - 1);
        }


    }
}
