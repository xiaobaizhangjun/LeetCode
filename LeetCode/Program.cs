using System;


namespace LeetCode
{
    //    给定一个整数数组和一个目标值，找出数组中和为目标值的两个数。

    //你可以假设每个输入只对应一种答案，且同样的元素不能被重复利用。

    //示例:

    //给定 nums = [2, 7, 11, 15], target = 9

    //因为 nums[0] + nums[1] = 2 + 7 = 9
    //所以返回[0, 1]
    public class Program
    {
        public static void Main(string[] args)
        {
            //int[] nums = new int[] { 1, 25, 30, 20 };
            //Program program = new Program();
            //int[] result = program.TwoSum(nums, 21);
            //foreach (var num in result)
            //{
            //    Console.Write("{0} ", num);
            //}
            //ReverseInt reverseInt = new ReverseInt();
            //reverseInt.Reverse(-321);
            //Atoi atoi = new Atoi();["flower","flow","flight"]
            //Console.WriteLine(atoi.MyAtoi("-42"));
            LongestCommon longestCommon = new LongestCommon();
            string[] strs =new string[] { "flower", "flow" ,"floweri"};
            longestCommon.LongestCommonPrefix(strs);
            Console.ReadKey();
        }
        public int[] TwoSum(int[] nums, int target)
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
            return new int[] { };
        }
    }
}
