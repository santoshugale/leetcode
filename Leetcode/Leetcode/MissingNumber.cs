﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Leetcode
{
    public class MissingNumber
    {
        public static int GetMissingNumber(int[] nums)
        {
            return ((nums.Length * (nums.Length + 1)) / 2) - nums.Sum(x => x);
        }

        public static int GetMissingNumberOptimized(int[] nums)
        {
            var array = new int[nums.Length + 1];
            foreach (var num in nums)
            {
                array[num]++;
            }
            return Array.IndexOf(array, 0);
        }
    }
}
