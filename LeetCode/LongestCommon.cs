using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class LongestCommon
    {
        //编写一个函数来查找字符串数组中的最长公共前缀。

        //如果不存在公共前缀，返回空字符串 ""。

        //示例 1:

        //输入: ["flower","flow","flight"]
        //        输出: "fl"
        //示例 2:

        //输入: ["dog","racecar","car"]
        //        输出: ""
        //解释: 输入不存在公共前缀。
        //说明:

        //所有输入只包含小写字母 a-z 。


        public string LongestCommonPrefix(string[] strs)
        {
            //先排序，然后用第一个字符串和最后一个字符串比较
            if (strs != null && strs.Length > 0)
            {
                int num = 0;
                Array.Sort(strs);
                char[] first = strs[0].ToCharArray();
                char[] last = strs[strs.Length - 1].ToCharArray();
                for (int i = 0; i < first.Length; i++)
                {
                    if (first[i] == last[i])
                    {
                        num++;
                    }
                    else
                    {
                        break;
                    }

                }
                if (num == 0)
                {
                    return "";
                }
                return strs[0].ToString().Substring(0, num);
            }
            return "";
        }

    }
}
