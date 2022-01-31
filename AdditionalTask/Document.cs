using System;
using System.Collections.Generic;

namespace AdditionalTask
{
    internal class Document
    {
        List<DocumentPart> docParts;

        public Document()
        {
            docParts = new List<DocumentPart>();
        }

        public void AddPart(DocumentPart part)
        {
            docParts.Add(part);
        }

        public void Show()
        {
            foreach (DocumentPart part in docParts)
                part.Show();
        }
    }
}