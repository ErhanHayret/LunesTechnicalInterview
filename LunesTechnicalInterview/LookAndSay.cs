using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunesTechnicalInterview
{
    public class LookAndSay
    {
        public void Func(int step, string data)
        {
            string newStr = "";
            char ch = data[0];
            int count = 0;
            int i = 0;
            if (step != 0)
            {
                while (true)
                {
                    if (data[i] == ch)
                    {
                        count++;
                    }
                    else
                    {
                        newStr += count.ToString();
                        newStr += ch.ToString();
                        count = 0;
                        if (i != data.Length)
                        {
                            ch = data[i];
                            continue;
                        }

                    }
                    i++;
                    if (i == data.Length)
                    {
                        newStr += count.ToString();
                        newStr += ch.ToString();
                        count = 0;
                        break;
                    }
                }
                Console.WriteLine(newStr);
                step--;
                Func(step, newStr);
            }
        }
    }
}
