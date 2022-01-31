namespace AdditionalTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Title title = new Title(null);
            Body body = new Body("It's body content");
            Footer footer = new Footer("Footer");

            Document doc = new Document();
            doc.AddPart(title);
            doc.AddPart(body);
            doc.AddPart(footer);

            doc.Show();
        }
    }
}
