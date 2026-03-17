using GreatCookieHeist;
using System.Diagnostics.CodeAnalysis;

class Program
{
    public static async Task Main()
    {
        CookieJar.FillCookieJar(15);

        List<Kid> kids = new List<Kid>
        {
            new Kid("Bob", 1200),
            new Kid("Alice", 1000),
            new Kid("Jeff", 900),
            new Kid("Mary", 1100),
        };
        

        Console.WriteLine("The kids found the cookies...");

        List<Task> cookieHeist = kids.Select(k => k.GrabCookie()).ToList();

        await Task.WhenAll(cookieHeist);
        Console.WriteLine($"aaaaaand they're gone.\nCookies left: {CookieJar.NumberOfCookies}");

        int maxCount = kids.Max(k => k.CookiesEaten);
        var bestThief = kids.Where(k => k.CookiesEaten == maxCount);

        foreach (var thief in bestThief)
        {
            Console.WriteLine($"{thief.Name} stole the most and had {thief.CookiesEaten} cookies >:)");
        }
    }
}