using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apps
{
    class Program
    {
        static void Main(string[] args)
        {
             
            Linq ln = new Linq();

            string texts = "AB01-";
            char[] text = texts.ToArray();
            foreach (char item in text)
            {
                bool isNumber = char.IsNumber(item);
                var isLetter = char.IsLetter(item);
                if (isNumber)
                {
                    Console.WriteLine("num");
                }
                else if (isLetter)
                    Console.WriteLine("letter");
                else
                    Console.WriteLine(item.GetType());
            }
        }
    }
}
