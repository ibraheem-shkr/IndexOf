using System;

namespace indexOf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            const string input = "ahmad";

            string subtext = "h";
            Console.WriteLine(input + "/" + subtext + "\t\t" +IndexOf(input, subtext));

            subtext = "ma";
            Console.WriteLine(input + "/" + subtext + "\t\t" + IndexOf(input, subtext));

            subtext = "y";
            Console.WriteLine(input + "/" + subtext + "\t\t" + IndexOf(input, subtext));

            subtext = "ahmadi";
            Console.WriteLine(input + "/" + subtext + "\t\t" + IndexOf(input, subtext));

        }


        public static int IndexOf(string text, string subText)
        {
            if (subText.Length > text.Length) return -1;
            for (int i = 0; i < text.Length && i < (text.Length - subText.Length +1); i++)
            {
                for (var q = 0; q < subText.Length; q++)
                {
                    if (text[i + q] != subText[q])
                    {
                        break;
                    }
                    if (q == subText.Length - 1)
                    {
                        return i;
                    }
                }
            }
            return -1;
        }
    }
}
