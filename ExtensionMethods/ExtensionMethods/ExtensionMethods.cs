using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using System.Linq;


namespace ExtensionMethods
{
    public static class ExtensionMethods
    {

        #region 1 Capital Letter
        // Write an extension method to check if astring starts with a capital letter or not.
        public static string StartWithCapitalLetter(this String str)
        {
            if (str.Length > 0)
            {
                if (str[0].ToString() == str[0].ToString().ToUpper())
                {
                    return $"It`s {true}, your string start with capital letter.";
                }
                else
                {
                    return $"It`s {false}, your string don`t start with capital letter.";
                }
            }
            else
            {
                return str;
            }


        }
        #endregion

        #region 2 Pluralize
        //Write an extension methodthat appends an ‘s’to astring. 
        //Ex:input : method
        //output:methods
        public static string Pluralize(this String str)
        {
            if (str.Length > 0)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(str);
                sb.Append('s');
                return sb.ToString();
            }
            else
            {
                return str;
            }

        }
        #endregion

        #region 3 Capitalize word
        //Write an extension methodthat will capitalize a word.
        //Input:mom
        //Output:Mom
        public static string CapitalizeWord(this String str)
        {
            if (str.Length > 0)
            {
                return char.ToUpper(str[0]) + str.Substring(1);
            }
            else
            {
                return str;
            }
        }
        #endregion

        #region 4 Capitalize and pluralize
        //Write aprogram that will capitalize astring , and pluralize the same string.
        //You cand write a new extension method or use what you already have.
        public static string CapitalizeAndPluralize(this String str)
        {
            return str.CapitalizeWord().Pluralize();
        }
        #endregion

        #region 5 Character count
        //Write an extension method what will count the number of characters in a string.
        public static string CharCounter(this String str)
        {
            return $"Your string has {str.Length} characters.";
        }
        #endregion

        #region 6 Apply VAT
        //Write an extension methodthat will apply a VAT of 24% on an input. 
        //This input can be a decimal value, or an integer 
        public static string ApplyVAT(this Decimal amount)
        {
            return $"Amount with VAT is: { amount * 1.24M}";
        }
        #endregion

    }
}
