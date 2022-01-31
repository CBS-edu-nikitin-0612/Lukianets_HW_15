using System;
using System.Collections.Generic;

namespace Task2
{
    internal class Program
    {
        public static void HandlerWork(AbstractHandler handler)
        {
            handler.Create();
            handler.Open();
            handler.Change();
            handler.Save();
        }
        static void Main(string[] args)
        {
            string line = new string('-', Console.WindowWidth);

            TXTHandler txtHandler1 = new TXTHandler();
            // HandlerWork(txtHandler1);

            AbstractHandler docHandler1 = new DOCHandler();
            // HandlerWork(docHandler1);

            XMLHandler xmlHandler1 = new XMLHandler();

            List<AbstractHandler> handlers = new List<AbstractHandler>();
            handlers.Add(txtHandler1);
            handlers.Add(docHandler1);
            handlers.Add(xmlHandler1);
            foreach (AbstractHandler handler in handlers)
            {
                HandlerWork(handler);
                Console.WriteLine(line);
            }
        }
    }
}
