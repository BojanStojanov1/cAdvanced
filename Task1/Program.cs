using Task1.Interface;
using Task1.Models;

ISearchable doc = new Document("Hello world in a document.");
ISearchable web = new WebPage("<html>Hello web page!</html>");
Console.WriteLine(doc.Search("world"));
Console.WriteLine(web.Search("page"));

