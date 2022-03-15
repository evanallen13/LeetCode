using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Questions
{
    class _119_PascalsTriangle2
    {
        public IList<int> GetRow(int rowIndex)
        {
            List<int> lastRow = new List<int>();

            var triangle = new List<List<int>>();

            var firstRow = new List<int>() { 1 };

            triangle.Add(firstRow);
            lastRow = firstRow;

            for(int i = 1; i < rowIndex; i++)
            {
                var prevRow = triangle[i - 1];
                var row = new List<int>();
                row.Add(1);

                for(int j = 1; j < i; j++)
                {
                    row.Add(prevRow[j -1] + prevRow[j]);
                }

                row.Add(1);
                triangle.Add(row);
                lastRow = row;
            }

            return lastRow;
        }
    }
}
