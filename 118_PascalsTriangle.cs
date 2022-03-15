using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Questions
{
    class _118_PascalsTriangle
    {
        public static IList<IList<int>> Generate(int numRows)
        {
            var triangle = new List<IList<int>>();

            if (numRows == 0) return triangle;

            // Add First Row In 
            var firstRow = new List<int>() { 1 };
            triangle.Add(firstRow);

            for (int i = 1; i < numRows; i++)
            {
                IList<int> prevRow = triangle[i - 1];
                IList<int> row = new List<int>();

                row.Add(1);

                for(int j = 1; j < i; j++)
                {
                    row.Add(prevRow[j - 1] + prevRow[j]);
                }

                row.Add(1);
                triangle.Add(row);
            }

            foreach(List<int> row in triangle)
            {
                string strRow = string.Empty;
                foreach(int i in row)
                {
                    strRow += $"{i}";
                }

                Console.WriteLine(strRow);
            }


            return triangle;
           
        }
    }
}
