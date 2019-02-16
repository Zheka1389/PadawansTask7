using System;

namespace PadawansTask7
{
    public class StringExtension
    {
        public static void OrderStringsByLength(string[] array)
        {
            string temp = "";
            for (int i = 0; i < array.Length; i++)
            {
                for (int y = i + 1; y < array.Length; y++)
                {
                    if (array[i].Length > array[y].Length)
                    {
                        temp = array[i];
                        array[i] = array[y];
                        array[y] = temp;
                    }
                }
            }
        }
    }
}
