using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
    public class ConvertTo
    {
        public static int Int(string text)
        {
            string val = "";
            int output = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (Char.IsDigit(text[i]))
                {
                    val += text[i];
                }
            }
            if (val.Length > 0)
            {
                output = int.Parse(val);
            }

            return output;
        }
    }
}
