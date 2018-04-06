using System;

namespace Intro
{
    class Ui
    {
        public static int AskForInt(string question)
        {
            bool parsed;
            int value;
            do
            {
                string answer = Ask(question);
                parsed = int.TryParse(answer, out value);
                if (!parsed)
                {
                    Console.WriteLine("Du får bara använda siffror i svaret");
                }

            } while (!parsed);
            return value;
        }

        public static string Ask(string question)
        {
            Console.Write(question + " ");
            return Console.ReadLine();
        }
    }
}