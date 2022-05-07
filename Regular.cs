using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Lab1
{
    static class Regular

    {
       static public string Check(string text, string reg, char s1, char s2)
        {
            string result = "";
            
            string copy_word;

            int i;

            //Regex first = new Regex("(0|1)*0(0|1)(0|1)");

            Regex first = new Regex(reg);


            MatchCollection matches = first.Matches(text);
            if (matches.Count > 0)
            {
                foreach (Match match in matches)
                {
                    result += (match.Value) + " позиция - " + text.IndexOf(match.Value) + ", ";
                    copy_word = match.Value;
                    copy_word = copy_word.Replace(s1, '!');
                    copy_word = copy_word.Replace(s2, '!');
                    i = text.IndexOf(match.Value);
                    text = text.Remove(i, match.Value.Length).Insert(i, copy_word);

                }
            }
            else
            {
                result += ("Совпадений не найдено");
            }
                return result;
            
        }

    }
}