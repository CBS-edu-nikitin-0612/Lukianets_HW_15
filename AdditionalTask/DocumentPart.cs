using System;

namespace AdditionalTask
{
    abstract class DocumentPart
    {
        protected string Name { get; set; }
        protected string content;
        public DocumentPart(string content)
        {
            Name = this.GetType().Name;
            Content = content;
        }
        public string Content
        {
            get => content;
            set
            {
                if (value != null)
                    content = value;
                else
                    Console.WriteLine($"No {Name} in the doc.");
            }
        }

        public abstract void Show();
    }
}
