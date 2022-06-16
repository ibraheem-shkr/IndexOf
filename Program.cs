using System;
using System.Collections.Generic;

namespace indexOf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            const string input = "aaaaaaaaaabaaaaand";

            // TEST
            string subtext = "h";
            Console.WriteLine(input + "/" + subtext + "\t\t" +IndexOf(input, subtext));

            subtext = "ma";
            Console.WriteLine(input + "/" + subtext + "\t\t" + IndexOf(input, subtext));

            subtext = "y";
            Console.WriteLine(input + "/" + subtext + "\t\t" + IndexOf(input, subtext));

            subtext = "aaab";
            Console.WriteLine(input + "/" + subtext + "\t\t" + IndexOf(input, subtext));

            subtext = "ahmad";
            Console.WriteLine(input + "/" + subtext + "\t\t" + IndexOf(input, subtext));

            subtext = null;
            Console.WriteLine(input + "/" + subtext + "\t\t" + IndexOf(input, subtext));

            subtext = "hmad";
            Console.WriteLine(input + "/" + subtext + "\t\t" + IndexOf(input, subtext));

            subtext = "d";
            Console.WriteLine(input + "/" + subtext + "\t\t" + IndexOf(input, subtext));


        }


        public static int IndexOf(string text, string subText)
        {
            if (text == null || subText == null) return -1;
            if (subText.Length > text.Length) return -1;
            if (subText.Length == 0 && text.Length == 0) return 0;
            if (text == subText) return 0;

            // if the textIndex reaches this point no need to continue, since the subText won't match anyway because there is no room for "subText" to exist within "text"
            int outOfBoundLimit = text.Length - subText.Length;
            int firstMatchIndex = -1;
            int subTextIndex = 0;
            for (int textIndex = 0; textIndex <= outOfBoundLimit; textIndex++)
            {
                if (text[textIndex] == subText[subTextIndex])
                {
                    if(firstMatchIndex == -1)
                        firstMatchIndex = textIndex;
                    subTextIndex++;
                }
                else
                {
                    subTextIndex = 0;
                    firstMatchIndex = -1;
                }
                if (subTextIndex == subText.Length)
                {
                    return firstMatchIndex;
                }
            }
            return -1;
        }
    }
}
