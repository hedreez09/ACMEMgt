using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACME.Common1
{
    public static class StringHandler
    {
        /// <summary>
        /// Inserts spaces before each capital in a string  
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static string InsertSpaces(this string source)// this is static so as to avoid instantiating it alway sinceits a utility class
        {
            string result = string.Empty;
            if (!String.IsNullOrEmpty(source))
            {
                foreach (char letter in source)
                {
                    if (char.IsUpper(letter))
                    {
                        //Trim any other space 
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
