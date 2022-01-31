using System;

namespace Task2
{
    internal class TXTHandler : AbstractHandler
    {
        public override void Change()
        {
            Console.WriteLine("Change TXT");
        }

        public override void Create()
        {
            Console.WriteLine("Create TXT");
        }

        public override void Open()
        {
            Console.WriteLine("Open TXT");
        }

        public override void Save()
        {
            Console.WriteLine("Save TXT");
        }
    }
}