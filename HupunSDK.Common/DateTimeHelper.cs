using System;
using System.Collections.Generic;
using System.Text;

namespace HupunSDK.Common
{
    public class DateTimeHelper
    {

        /// <summary>
        /// 时间转时间戳（毫秒）
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        public static long ConvertDateTimeToMillisecond(DateTime dateTime)
        {
            var startTime = new DateTime(1970, 1, 1);
            return (dateTime.Ticks - startTime.Ticks) / 10000; 
        }
    }
}
