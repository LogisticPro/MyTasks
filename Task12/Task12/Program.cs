using System;

namespace Task12
{
    class Program
    {
        static void Main(string[] args)
        {
            var provider = new NewsProvider();

            var client1 = new Client();
            var client2 = new Client();

            client1.Subscribe(provider, InfoType.Humor);
            client2.Subscribe(provider, InfoType.News);


            provider.SendNewsInfo(InfoType.Humor, "Я у мамки - хацкер");
            provider.SendNewsInfo(InfoType.News, "Some news");

            Console.WriteLine();

            client1.Unsubscribe(provider, InfoType.Humor);

            provider.SendNewsInfo(InfoType.Humor, "Я у мамки - хацкер");
            provider.SendNewsInfo(InfoType.News, "Some news");

            Console.ReadLine();
        }
    }
}
