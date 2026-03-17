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

        public int CookiesEaten { get; set; }

        public Kid() { }
        public Kid(string name)
        {
            Name = name;
        }

        public async Task GrabCookie()
        {
            Random rndm = new Random();
            while (true)
            {
                await Task.Delay(rndm.Next(100, 700));
                bool moreCookies = await CookieJar.TakeCookie(this);
                if (!moreCookies) { break; }
            }
        }
    }
}
