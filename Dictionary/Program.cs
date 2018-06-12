using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            var phoneBook = new Dictionary<string, Int64>();
            for (int i = 0; i < n; i++)
            {
                var readLine = Console.ReadLine();
                if (readLine != null)
                {
                    string[] Entry = readLine.Split(' ');
                    phoneBook.Add(Entry[0],Convert.ToInt64(Entry[1]));
                }
            }
            List<string> searchString = new List<string>();
            string tempRead;
            while((tempRead=Console.ReadLine())!=null)
            {
                searchString.Add(tempRead);
            }
            foreach (string s in searchString)
            {
                if (phoneBook.ContainsKey(s))
                {
                    Console.WriteLine(s + "=" + phoneBook[s]);
                }
                else
                {
                    Console.WriteLine("Not found");
                }
            }
            Console.ReadLine();
        }
    }
}
