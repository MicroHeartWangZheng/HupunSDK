using System;

namespace HupunSDK.Common.Extend
{
    public static class DateTimeExtend
    {
        /// <summary>
        /// 时间转时间戳（毫秒）
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        public static long ToTimeStamp(this DateTime dateTime)
        {
            var startTime = new DateTime(1970, 1, 1);
            return (dateTime.Ticks - startTime.Ticks) / 10000;
        }
    }
}
