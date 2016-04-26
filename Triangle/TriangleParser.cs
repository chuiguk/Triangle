using System;
using System.Linq;
using System.IO;
namespace Triangle
{
    static class TriangleParser
    {
        static public int[][] Parse(string path)
        {
            string[] rows;
            try
            {
                rows = File.ReadAllLines(path);
            }
            catch (FileNotFoundException)
            {
                return null;
            }

            int[][] array = new int[rows.Length][];
            for (var i = 0; i < rows.Length; i++)
            {
                var numbers = rows[i].Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
                array[i] = numbers;
            }
            return array;
        }
    }
}
