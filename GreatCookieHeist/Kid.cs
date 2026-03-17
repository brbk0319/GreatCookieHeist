using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GreatCookieHeist
{
    public class Kid
    {
        public string Name { get; set; }

        public int Delay { get; set; }
        public int CookiesEaten { get; set; }

        public Kid() { }
        public Kid(string name, int delay)
        {
            Name = name;
            Delay = delay;
        }

        public async Task GrabCookie()
        {
            while (CookieJar.NumberOfCookies > 0)
            {
                await Task.Delay(Delay);
                await CookieJar.TakeCookie(this);
            }
        }
    }
}
