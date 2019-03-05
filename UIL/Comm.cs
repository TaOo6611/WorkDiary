using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.International.Converters.PinYinConverter;   //引入命名空间  

namespace WorkDiary.UIL
{
    public class Comm
    {
        /// <summary>  
        /// 获得一个字符串的拼音  
        /// </summary>  
        /// <param name="str"></param>  
        /// <returns></returns>  
        public static string GetPinYin(string str)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char item in str)
            {
                //判断是不是汉字，如果不是原字符返回  
                if (ChineseChar.IsValidChar(item))
                {
                    sb.Append(GetPinYin(item));
                }
                else
                {
                    sb.Append(item);
                }
            }
            return sb.ToString();
        }

        /// <summary>  
        /// 获得单个字符的拼音  
        /// </summary>  
        /// <param name="c"></param>  
        /// <returns></returns>  
        public static string GetPinYin(char c)
        {
            ChineseChar cc = new ChineseChar(c);
            string str = cc.Pinyins[0]; //多音字只取第一个  


            return str.Substring(0, str.Length - 1); //去掉最后的声调  
        }

        public static char GetFirstPY(char c)
        {
            if (ChineseChar.IsValidChar(c))
            {
                ChineseChar cc = new ChineseChar(c);
                string str = cc.Pinyins[0]; //多音字只取第一个  

                return str.ToUpper()[0];
            }
            else
            {
                return c;
            }
        }

        public static string GetFirstPY(string str)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char item in str)
            {
                sb.Append(GetFirstPY(item));
            }
            return sb.ToString();
        }
    }
}
