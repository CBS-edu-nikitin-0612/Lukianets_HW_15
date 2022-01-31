using System;

namespace AdditionalTask
{
    internal class Body : DocumentPart
    {
        public Body(string content) : base(content) { }

        public override void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(Content);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
