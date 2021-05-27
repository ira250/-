using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using pr1;

namespace pr1
{
    class lib1
    {
        public static string strpow(string str, int count)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                sb.Append(str);
            }

            return sb.ToString();

            //или, но неэффективно
            string output = "";
            for (int i = 0; i < count; i++)
            {
                output += str;
            }

            return output;
        }

        public static string rev(string str)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = str.Length - 1; i >= 0; i--)
            {
                sb.Append(str[i]);
            }

            return sb.ToString();
        }

        //доделать
        public static string remove(string str, string subStr)
        {

            return "";
        }

        public int leng(string str)
        {
            str += '\0';
            int i = 0;
            while (str[i] != '\0') i++;
            return i;
            //или
            return str.Length;
        }
    }

    class lib2
    {
        public static int findF(string str)
        {
            int result = -2;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'f')
                    result++;

                if (result == 0)
                    return i;
            }

            return result;
        }

        public static string translit(string str)
        {
            string[] rus =
            {
                " ", "а", "б", "в", "г", "д", "е",
                "ё", "ж", "з", "и", "й", "к",
                "л", "м", "н", "о", "п", "р",
                "с", "т", "у", "ф", "х", "ц",
                "ч", "ш", "щ", "ъ", "ы", "ь",
                "э", "ю", "я"
            };
            string[] translit =
            {
                " ", "a", "b", "v", "g", "d", "e",
                "yo", "zh", "z", "i", "j", "k",
                "l", "m", "n", "o", "p", "r",
                "s", "t", "u", "f", "h", "c",
                "ch", "sh", "shch", "``", "y", "`",
                "e", "yu", "ya"
            };
            StringBuilder sb = new StringBuilder();
            for (int j = 0; j < str.Length; j++)
            {
                for (int i = 0; i < rus.Length; i++)
                {
                    if (str.Substring(j, 1) == rus[i])
                        sb.Append(translit[i]);
                }
            }

            return sb.ToString();
        }

        public static string toUpperCase(string str)
        {
            char chr;
            StringBuilder sb = new StringBuilder();
            for (int i = 1; i < str.Length - 1; i++)
            {
                chr = str[i];
                if (chr == 'h')
                {
                    chr = 'H';
                }

                sb.Append(chr);
            }

            return sb.ToString();
        }
    }

    class lib3
    {
        public static int minAbs(int[] array)
        {
            int minIndex = 0;
            int minElement = Math.Abs(array[0]);
            for (int i = 0; i < array.Length; i++)
            {
                if (Math.Abs(array[i]) < minElement)
                {
                    minElement = array[i];
                    minIndex = i;
                }
            }

            return minIndex;
        }

        //доделать
        public static void oneInArray(int[] array)
        {
            if (array.Length == 1)
            {
                Console.WriteLine(array[0]);
                return;
            }

            Array.Sort(array);
            ////for (int i = 1; i < array.Length; i++)
            {
            }
        }

        public static void randomArray()
        {
            Random rand = new Random();
            int[] array = new int[10];
            int counter = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(-5, 15);
                if (array[i] > 0) counter++;
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();
            int[] newArray = new int[counter];

            for (int i = 0, j = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    newArray[j] = array[i];
                    Console.Write(array[j] + " ");
                    j++;
                }
            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {

    }
}
