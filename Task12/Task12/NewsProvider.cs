using System;
using System.Collections.Generic;
using System.Text;

namespace Task12
{
    public delegate void InfoSender(InfoType type, string message);
    public class NewsProvider
    {
        public event InfoSender Notify;
        public void SendNewsInfo(InfoType type, string message)
        {
            Notify?.Invoke(type, message);
        }      
    }
}
