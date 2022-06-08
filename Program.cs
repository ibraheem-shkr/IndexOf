using System;

namespace indexOf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            const string input = "ahmad";

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
            try
            {
                if (subText.Length > text.Length) return -1;
                if (text == subText) return 0;
            }
            catch (NullReferenceException exception)
            {
                Console.WriteLine(exception.Message);
                return -1;
            }

            // if the textIndex reaches this point no need to continue, since the subText won't match anyway because there is no room for "subText" to exist within "text"
            int outOfBoundLimit = text.Length - subText.Length;
            for (int textIndex = 0; textIndex <= outOfBoundLimit; textIndex++)
            {
                for (var subTextIndex = 0; subTextIndex < subText.Length; subTextIndex++)
                {
                    if (text[textIndex + subTextIndex] != subText[subTextIndex])
                    {
                        break;
                    }
                    if (subTextIndex == subText.Length - 1)
                    {
                        return textIndex;
                    }
                }
            }
            return -1;
        }
    }
}
