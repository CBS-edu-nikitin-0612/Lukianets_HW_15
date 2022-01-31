using System;

namespace AdditionalTask
{
    internal class Footer : DocumentPart
    {
        public Footer(string content) : base(content) { }

        public override void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(Content);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
