using System;
using System.IO;

namespace MyLibrary
{
    public class Class1
    {
        public static void Main()
        {
            try
            {
                Console.WriteLine("Enter a number: ");
                string s = Console.ReadLine();
                int a = Int32.Parse(s);
                Console.WriteLine(Subfactorial(a));
                Console.ReadKey();
            }
            catch (Exception) { }
        }

        public static int Subfactorial(int i)
        {
            if (i == 0) return 1;
            else if (i == 1) return 0;
            else
            {
                return (i - 1) * (Subfactorial(i - 1) + Subfactorial(i - 2));
            }
        }
    }
}
