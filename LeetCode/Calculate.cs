using System;
using System.Text.RegularExpressions;

namespace LeetCode
{
    //实现一个基本的计算器来计算一个简单的字符串表达式的值。

    //字符串表达式仅包含非负整数，+， - ，*，/ 四种运算符和空格  。 整数除法仅保留整数部分。

    //示例 1:

    //输入: "3+2*2"
    //输出: 7
    //示例 2:

    //输入: " 3/2 "
    //输出: 1
    //示例 3:

    //输入: " 3+5 / 2 "
    //输出: 5
    //说明：

    //你可以假设所给定的表达式都是有效的。
    //请不要使用内置的库函数 eval
    public class Calculate
    {
        public int Calculates(string express)
        {
            int result = 0;
            express = express.Replace(" ", "");
            string[] s1 = express.Split(new char[2] { '+', '-' });
            foreach (string ex in s1)
            {
                string[] s2 = ex.Split(new char[2] { '*', '/' });
                char[] ops1 = Regex.Replace(ex, @"[0-9]", "").ToCharArray();
                string num = Operation(s2, ops1).ToString();
                express = express.Replace(ex, num);
            }
            string[] s3 = express.Split(new char[2] { '+', '-' });
            char[] ops2 = Regex.Replace(express, @"[0-9]", "").ToCharArray();
            result = Operation(s3, ops2);
            return result;
        }
        private static int Operation(string[] nums, char[] ops)
        {
            int num = Int32.Parse(nums[0]);
            for (int i = 1; i < nums.Length; i++)
            {
                switch (ops[i - 1])
                {
                    case '*':
                        num = num * Int32.Parse(nums[i]);
                        break;
                    case '/':
                        num = num / Int32.Parse(nums[i]);
                        break;
                    case '+':
                        num = num + Int32.Parse(nums[i]);
                        break;
                    case '-':
                        num = num - Int32.Parse(nums[i]);
                        break;
                    default:
                        break;
                }
            }
            return num;
        }
    }

}
