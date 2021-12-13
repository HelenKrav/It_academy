using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionRoman
{
    public enum RomanNumericEnum
    {
        I,
        V,
        X,
        L,
        C,
        D,
        M
    }
    public class Conversion
    {
        public int Conv(char[] romanArray)
        {
            
            string[] arabArray = new string[romanArray.Length];
            for (int i = 0; i < romanArray.Length; i++)
            {
                if (romanArray[i] == 'M')
                {
                    arabArray[i] = "1000";
                }
                else if (romanArray[i] == 'D')
                {
                    arabArray[i] = "500";
                }
                else if (romanArray[i] == 'C')
                {
                    arabArray[i] = "100";
                }
                else if (romanArray[i] == 'L')
                {
                    arabArray[i] = "50";
                }
                else if (romanArray[i] == 'X')
                {
                    arabArray[i] = "10";
                }
                else if (romanArray[i] == 'V')
                {
                    arabArray[i] = "5";
                }
                else if (romanArray[i]== 'I')
                {
                    arabArray[i] = "1";
                } 
            }
            int result = 0;
            for (int i = 0; i < arabArray.Length; i++)
            {
                if (i + 1 < arabArray.Length)
                {
                    if (Convert.ToInt32(arabArray[i]) < Convert.ToInt32(arabArray[i + 1]))
                    {
                        result -=Convert.ToInt32(arabArray[i]);
                    }
                    else
                    {
                        result += Convert.ToInt32(arabArray[i]);
                    }
                }
                else
                {
                    result += Convert.ToInt32(arabArray[i]);
                }
            }
            return result;
        }
    }
}
