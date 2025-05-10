using System;
using Task1.Interface;

namespace Task1.Models
{
	public class WebPage : ISearchable
	{
        public string htmlContent;

        public WebPage(string htmlContent)
        {
            this.htmlContent = htmlContent;
        }

        public bool Search(string word)
        {
            return htmlContent.Contains(word);
        }
    }
}

