using System;
using Task1.Interface;

namespace Task1.Models
{
    public class Document : ISearchable
    {
        public string content;

        public Document(string content)
        {
            this.content = content;
        }

        public bool Search(string word)
        {
            return content.Contains(word);
        }
    }
}

