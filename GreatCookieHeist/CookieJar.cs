using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatCookieHeist
{
    public class CookieJar
    {
        public static int NumberOfCookies { get; set; }
        private static readonly object _lock = new object();
        public static void FillCookieJar(int numberOfCookies)
        {
            lock (_lock)
            {
                NumberOfCookies = numberOfCookies;
            }
        }

        public static async Task<bool> TakeCookie(Kid kid)
        {
            await Task.Delay(200);

            lock (_lock)
            {
                if (NumberOfCookies <= 0)
                {

                    Console.WriteLine($"Sorry {kid.Name}, the jar is empty. No more cookies :(");
                    return false;
                }
                else
                {
                    NumberOfCookies--;
                    kid.CookiesEaten++;
                    Console.WriteLine($"{kid.Name} took a cookie.");
                    return true;
                }
            }
           

        }
    }
}
