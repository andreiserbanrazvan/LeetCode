using Microsoft.VisualBasic.CompilerServices;
using System;

namespace LeetCode
{/// <summary>
 //// #1
 /// Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
//   You may assume that each input would have exactly one solution, and you may not use the same element twice.
//   You can return the answer in any order.
/// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int[] TwoSum(int[] nums, int target)
            {

                int[] nums2 = new int[2];
                int[] nums3 = new int[2];
                int j = 0;
                bool found = false;
                for (int i = 0; i < nums.Length; i++)
                {
                    nums2[j++] = nums[i];
                    nums3[j] = i;
                    for (int k = nums.Length - 1; k > 0; k--)
                    {
                        if (nums[i] + nums[k] == target)
                        {
                            nums2[j] = nums[k];
                            nums3[j] = k;
                            found = true;
                            break;
                        }
                    }
                    if (found == true)
                    {
                        break;
                    }
                    else
                    {
                        nums2[j] = 0;
                        nums3[j] = 0;
                        j--;
                    }
                }

                return nums3;
            }

            int[] TwoSum2(int[] nums, int target)
            {
                int[] indicesOfSum = new int[2];
                for (int i = 0; i < nums.Length; i++)
                {
                    for (int j = i + 1; j < nums.Length; j++)
                    {
                        if (nums[i] + nums[j] == target)
                        {
                            indicesOfSum[0] = i;
                            indicesOfSum[1] = j;
                            break;
                        }
                    }
                }
                return indicesOfSum;
            }

            int[] nums = { 3, 2, 4 };
            int target = 6;
           int[] exercise = TwoSum2(nums, target);
            for (int i = 0; i<exercise.Length;i++)
            {
                Console.WriteLine(exercise[i]);
            }
        }
    }
}
