﻿using System.Linq;

namespace Hawk.Base.Utils
{
    /// <summary>
    /// 多国语言处理
    /// </summary>
   public class GlobalHelper
    {
       public static string Get(string name)
       {
           return name;
       }
    
        public static string FormatArgs(params object[] values)
        {
            var format = values[0];
            // Get localized version of the default language string:
            var localFormat = Get(format.ToString());
            // Feed the resulting format string into String.Format:
            return string.Format(localFormat, values.Skip(1).ToArray());
        }
    }
}
