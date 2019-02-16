using System;

namespace PadawansTask7
{
    public class StringExtension
    {
        public static void OrderStringsByLength(string[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException();
            }
            else
            {
                string temp = "";
                for (int i = 0; i < array.Length; i++)
                {
                    for (int y = i + 1; y < array.Length; y++)
                    {
                        if (array[i] == null || array[y] == null)
                        {
                            throw new ArgumentNullException();
                        }
                        else if (array[i].Length > array[y].Length)
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
}

