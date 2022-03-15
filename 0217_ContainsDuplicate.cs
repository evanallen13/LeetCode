using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class ContaineDuplicate{

         public static bool ContainsDuplicate(int[] nums) {
        
             if(nums.Length <= 1) return false;
             Dictionary<int, int> dict = new Dictionary<int, int>();

            int l = 0;
            int r = nums.Length - 1;

            while(l < r){

                int numLeft = nums[l];
                int numRight = nums[r];
                bool check1 = dict.ContainsKey(numLeft);
                bool check2 = dict.ContainsKey(numRight);

                if(!check1)
                    dict.Add(numLeft, 1);
                else if(!check2)
                    dict.Add(numRight, 1);
                else    
                    return true;

                l++;
                r--;
            }

            return false;
        }
    }

}