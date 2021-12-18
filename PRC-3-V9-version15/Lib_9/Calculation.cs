using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoubleArrayLibrary;

namespace Lib_9
{
    public static class Calculation
    {
        public static string LastLineNumber(this DoubleArrayLibrary.Array array) // номер последней строки
        {
            int[,] elements = new int[array.RowLength, array.ColumnLength];
            int number, repeat1 = 1, repeat2 = 1, maxi = -1;
            for (int i = 0; i < array.ColumnLength; i++)
            {
                for (int j = 0; j < array.RowLength - 1; j++)
                {
                    number = j + 1;
                    while (number < array.RowLength) // сравниваем элемент с последующим в строке и + счетчик
                    {
                        if (elements[i, j] == elements[i, number])
                        {
                            repeat1++;
                        }
                        number++;
                    }
                }
                if (repeat1 > repeat2) // если в первой строке больше чем в предыдущей запомнить индекс строки 
                {
                    repeat2 = repeat1;
                    maxi = i;
                }
                repeat1 = 1;
            }
            return maxi.ToString();
        }
    }
}
