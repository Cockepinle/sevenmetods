using System;
using System.Data.SqlTypes;
using System.Linq;
using System.Text.RegularExpressions;

namespace TDDStringPracticals
{
    public class TddStringPracticals
    {
        public static int ContSymbolinString(string stroka)
        {
            string[] words = stroka.Split(new char[] { ' ', '-', '.', ',', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            int a = 0;

            foreach (var word in words)
            {
                if (int.TryParse(word, out int num))
                {
                    a++; 
                }
            }

            return a;
        }

        public static int CountCombinationAMTheKey(string stroka)
        {
            string em = "ме";
            int count = 0;
            int ind = 0;

            while ((ind = stroka.IndexOf(em, ind)) != -1)
            {
                count++;
                ind += em.Length;
            }
            return count;
        }

        public static int CountStringWord(string stroka)
        {
            string[] words = stroka.Split(new char[] { ' ', '-', '.', ',', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            return words.Length; 
        }

        public static int LagestCountConsistently(string stroka)
        {
            var mach = Regex.Matches(stroka, @"\d+");
            int max = 0;
            foreach (Match match in mach)
            {
                if(match.Length > max)
                {
                    max = match.Length;
                }
            }
            return max;
        }

        public static char NineSymbolString(string stroka)
        {
            if (stroka.Length >= 9)
            {
                return stroka[8];
            }
            else
            {
                return '\0';
            }
        }

        public static string StringShortWord(string stroka)
        {
            string[] words = stroka.Split(new char[] { ' ', '-', '.', ',', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            string shortestWord = null;


            foreach (var word in words)
            {
                if (shortestWord == null || word.Length < shortestWord.Length)
                {
                    shortestWord = word;
                }
            }

            return shortestWord;
        }

        public static int SymbolString(string stroka)
        {
            return stroka.Length;
        }
    }
}