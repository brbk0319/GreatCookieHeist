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

        public static void FillCookieJar(int numberOfCookies) 
        {
            NumberOfCookies = numberOfCookies;
        }


        public static async Task TakeCookie(Kid kid)
        {
            await Task.Delay(2000);
            if (NumberOfCookies == 0) 
            {
                
                Console.WriteLine($"Sorry {kid.Name}, the jar is empty. No more cookies :(");
            }
            else
            {
                NumberOfCookies--;
                kid.CookiesEaten++;
                Console.WriteLine($"{kid.Name} took a cookie.");
            }
        }
    }
}
