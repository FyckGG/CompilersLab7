using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    static class NotSymbpl
    {
        static public string Not_symbol(string text)
        {
            {
                string result = "";

                string good_string = "";

                string copy_text = text;

                int lost_lenght = 0;

                int pos = 0;

                while (pos < text.Length)
                {
                    char c = text[pos];
                    if (c != '&')
                    {
                        good_string += c;
                      
                    }
                    

                    else {

                        if (good_string != "")

                        {
                            result += good_string + " позиция - " + (copy_text.IndexOf(good_string) + lost_lenght)+ ", ";
                            lost_lenght += good_string.Length;
                            copy_text = copy_text.Substring(good_string.Length);
                            good_string = "";
                        }
                    }

                    pos++;
                }

               if (good_string != "")
                    result += good_string + " позиция - " + (copy_text.IndexOf(good_string) + lost_lenght) + ", ";
               if (result == "")
                    result += ("Совпадений не найдено");
                return result;

            }




        }
    }
}
