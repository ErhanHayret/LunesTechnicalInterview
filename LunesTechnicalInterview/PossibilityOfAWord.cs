using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunesTechnicalInterview
{
    public class PossibilityOfAWord
    {
        public void Func(string s, string q)
        {
            int trueCount = 0;
            int falseCount = 0;
            for (int i = 0; i < q.Length; i++)
            {
                for (int j = 0; j < s.Length; j++)
                {
                    if (q[i] == s[j])
                    {
                        trueCount++;
                        break;
                    }
                    else
                    {
                        falseCount++;
                    }
                }
                if (falseCount == s.Length)
                {
                    break;
                }
                else
                {
                    falseCount = 0;
                }
            }
            if (trueCount == q.Length)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
