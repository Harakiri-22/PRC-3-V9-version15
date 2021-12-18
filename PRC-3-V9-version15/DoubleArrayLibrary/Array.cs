using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace DoubleArrayLibrary
{
    public class Array
    {
        public Array(int row, int column)
        {
            _array = new int[row, column];
        }

        private readonly Random _random = new Random();
        private readonly int[,] _array;
        public int RowLength => _array.GetLength(0);
        public int ColumnLength => _array.GetLength(1);

        public void Fill(int minimum = 1, int maximum = 5)
        {
            for (int i = 0; i < RowLength; i++)
            {
                for (int j = 0; j < ColumnLength; j++)
                {
                    _array[i, j] = _random.Next(minimum, maximum);
                }
            }
        }

        public void Conservation(string path)
        {
            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.WriteLine(RowLength);
                writer.WriteLine(ColumnLength);

                for (int i = 0; i < RowLength; i++)
                {
                    for (int j = 0; j < ColumnLength; j++)
                    {
                        writer.WriteLine(_array[i, j]);
                    }
                }
            }
        }

        public void Opening(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                int rowlength = int.Parse(reader.ReadLine());
                int columnlength = int.Parse(reader.ReadLine());

                for (int i = 0; i < rowlength; i++)
                {
                    for (int j = 0; j < columnlength; j++)
                    {
                        _array[i, j] = int.Parse(reader.ReadLine());
                    }
                }
            }
        }

        public DataTable ToTableData()
        {
            var result = new DataTable();
            for (int i = 0; i < RowLength; i++)
            {
                result.Columns.Add("Col" + (i + 1));
            }

            for (int i = 0; i < ColumnLength; i++)
            {
                var row = result.NewRow();

                for (int j = 0; j < ColumnLength; j++)
                {
                    row[j] = _array[i, j];
                }

                result.Rows.Add(row);
            }

            return result;
        }

        public int this[int firstindex, int secondindex]
        {
            get => _array[firstindex, secondindex];
            set => _array[firstindex, secondindex] = value;
        }
        public void Clear()
        {
            Fill(0, 0);
        }
    }
}
