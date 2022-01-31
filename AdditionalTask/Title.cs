using System;

namespace AdditionalTask
{
    internal class Title : DocumentPart
    {
        public Title(string content) : base(content) { }

        public override void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(Content);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
