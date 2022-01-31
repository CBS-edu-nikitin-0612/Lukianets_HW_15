using System;

namespace Task2
{
    internal class XMLHandler : AbstractHandler
    {
        public override void Change()
        {
            Console.WriteLine("Change XML");
        }

        public override void Create()
        {
            Console.WriteLine("Create XML");
        }

        public override void Open()
        {
            Console.WriteLine("Open XML");
        }

        public override void Save()
        {
            Console.WriteLine("Save XML");
        }
    }
}
