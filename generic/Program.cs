using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generic
{
    class Program
    {
        static void Main(string[] args)
        {
            Datasample<string> dss = new Datasample<string>("Forty-two");
            Datasample<int> dsi = new Datasample<int>(42);
            string s = dss.GetData();
            int i = dsi.GetData();
            Console.WriteLine(string.Format("s={0}, i={1}", s, i));
            String[] words = { "C++,", "MacOS", "C#", "Android", "Python" };
            String middle = Datasample<string>.getMiddleElement(words);
            ListOfObjects<string> list = new ListOfObjects<string>();
            list.AddObject("Forty-Two");
            Console.WriteLine(middle);
            Console.WriteLine(list.GetObject(0));
            Console.ReadKey();
            
        }
    }
}
