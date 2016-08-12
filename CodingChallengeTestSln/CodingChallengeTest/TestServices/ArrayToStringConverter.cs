using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallengeTest.TestServices
{
    public static class ArrayToStringConverter
    {
        public static string convert(int[] a)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("{");
            for(int i = 0; i < a.Length; i++)
            {
                sb.Append(" " + a[i] + " ");
                if(!(i + 1 == a.Length))
                {
                    sb.Append(",");
                }
            }
            sb.Append("}");
            return sb.ToString();
        }
    }
}
