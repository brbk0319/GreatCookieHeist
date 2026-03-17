using GreatCookieHeist;
using System.Diagnostics.CodeAnalysis;

class Program
{
    public static async Task Main()
    {
        CookieJar.FillCookieJar(6);

        List<Kid> kids = new List<Kid>
        {
            new Kid("Bob"),
            new Kid("Alice"),
            new Kid("Jeff"),
            new Kid("Mary"),
        };
        

        Console.WriteLine("The kids found the cookies...");

        List<Task> cookieHeist = kids.Select(k => k.GrabCookie()).ToList();

        await Task.WhenAll(cookieHeist);
        Console.WriteLine($"aaaaaand they're gone.\nCookies left: {CookieJar.NumberOfCookies}");

        //int maxCount = kids.Max(k => k.CookiesEaten);
        //var bestThief = kids.Where(k => k.CookiesEaten == maxCount);

        foreach (var k in kids)
        {
            Console.WriteLine($"{k.Name} stole {k.CookiesEaten} cookies >:)");
        }
    }
}