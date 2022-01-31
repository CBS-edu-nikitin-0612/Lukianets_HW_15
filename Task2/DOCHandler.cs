using System;

namespace Task2
{
    internal class DOCHandler : AbstractHandler
    {
        public override void Change()
        {
            Console.WriteLine("Change DOC");
        }

        public override void Create()
        {
            Console.WriteLine("Create DOC");
        }

        public override void Open()
        {
            Console.WriteLine("Open DOC");
        }

        public override void Save()
        {
            Console.WriteLine("Save DOC");
        }
    }
}
