using System;
using interfaceHomework.Interface;

namespace interfaceHomework.Models
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

