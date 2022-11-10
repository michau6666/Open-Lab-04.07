using System;

namespace Open_Lab_04._07
{
    public class StringTools
    {
        public string Reverse(string original)
        {
            char[] had = original.ToCharArray();
            Array.Reverse(had);
            string reverse = new string(had);
            return reverse;
        }
    }
}
