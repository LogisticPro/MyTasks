using System;
using System.Collections.Generic;
using System.Text;

namespace Task12
{
    public class Client
    {
        public List<InfoType> infoTypes = new List<InfoType>();

        public void Subscribe(NewsProvider provider, InfoType type)
        {
            infoTypes.Add(type);
            provider.Notify += WriteNews;
        }

        public void Unsubscribe(NewsProvider provider, InfoType type)
        {
            infoTypes.Remove(type);
            provider.Notify -= WriteNews;
        }

        void WriteNews(InfoType type, string text)
        {
            if (infoTypes.Contains(type))
                Console.WriteLine($" {type} - {text}");
        }
    }
}
