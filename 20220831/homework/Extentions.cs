using System;
using System.Collections.Generic;
using System.Text;

namespace homework
{
    internal static class Extentions
    {

        public static int[] GetValueIndexes(this string str,char chr)
        {
            int[] indexes = new int[0];

            for (int i = 0; i < str.Length; i++)
            {
                if(str[i] == chr)
                {
                    Array.Resize(ref indexes, indexes.Length + 1);
                    indexes[indexes.Length - 1] = i;
                }
            }

            return indexes;
        }
    }
}
