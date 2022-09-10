using System;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[] {3,2,3};
         
            int[] sum =TwoSum(arr,6);

            Console.WriteLine("[{0}]", string.Join(", ", sum));
        }
        public static int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[j] == target - nums[i])
                    {
                        return new int[] { i, j };
                    }
                }
            }

            return null;

        }






    }
    
}   


    





