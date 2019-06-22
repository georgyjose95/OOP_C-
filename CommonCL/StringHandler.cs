using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonCL
{
    public static class StringHandler
    {
        /// <summary>
        /// Insert a single space if the there is a capital letter in a single string. . 
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>

        public static string InsertSpace(this string source)
        {
            string result = string.Empty;
            if (!string.IsNullOrWhiteSpace(source))
            {
                foreach(char letter in source)
                {
                    if (char.IsUpper(letter))
                    {
                        result = result.Trim();
                        result += " ";
                    }
                    result += letter;
                }
            }
            result = result.Trim();
            return result;
        }
    }
}
