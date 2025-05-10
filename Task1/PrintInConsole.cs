using System;
namespace Generic.domain
{
    public static class PrintInConsole
    {
       
        public static void Print<T>(T item)
        {
            Console.WriteLine(item);
        }

      
        public static void PrintCollection<T>(IEnumerable<T> collection)
        {
            foreach (T item in collection)
            {
                Print(item); 
            }
        }
    }
}
