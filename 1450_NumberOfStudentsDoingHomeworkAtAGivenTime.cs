using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class _1450_NumberOfStudentsDoingHomeworkAtAGivenTime
    {
        public static int BusyStudent(int[] startTime, int[] endTime, int queryTime)
        {
            int result = 0;
            for(int i = 0; i < startTime.Length; i++)
            {
                int start = startTime[i];
                int end = endTime[i];

                if (start <= queryTime && end >= queryTime)
                    result++;
            }

            Console.WriteLine(result);
            return result;
        }
    }
}
