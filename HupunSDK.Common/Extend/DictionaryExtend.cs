﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace HupunSDK.Common.Extend
{
    public static class DictionaryExtend
    {
        /// <summary>
        /// 将指定的字典转换成按属性名称排序过的查询参数
        /// </summary>
        /// <param name="dict"></param>
        /// <param name="urlencode"></param>
        /// <param name="exclude">排除的参数</param>
        /// <returns></returns>
        public static string ToSortQueryParameters(this IDictionary<string, object> dict, bool urlencode = false, params string[] exclude)
        {
            var sortDict = dict.OrderBy(m => m.Key).Select(m =>
            {
                if (m.Value == null || exclude.Contains(m.Key))
                    return null;
                if (m.Value is string && (string)m.Value == string.Empty)
                    return null;
                var val = m.Value.ToString();
                var encodeVal = "";
                if (urlencode)
                    encodeVal += HttpUtility.UrlEncode(val.ToString());
                else
                    encodeVal = val;
                return $"{m.Key}={encodeVal}";
            }).Where(m => m != null);
            var result = string.Join("&", sortDict.ToArray());
            return result;
        }

        /// <summary>
        /// 转换为签名字符串
        /// </summary>
        /// <param name="dict"></param>
        /// <param name="urlencode"></param>
        /// <param name="exclude"></param>
        /// <returns></returns>
        public static string ToSignString(this IDictionary<string, object> dict, bool urlencode = false, params string[] exclude)
        {
            var sortDict = dict.OrderBy(m => m.Key).Select(m =>
            {
                if (m.Value == null || exclude.Contains(m.Key))
                    return null;
                if (m.Value is string && (string)m.Value == string.Empty)
                    return null;
                var val = m.Value.ToString();
                var encodeVal = "";
                if (urlencode)
                    encodeVal += HttpUtility.UrlEncode(val.ToString());
                else
                    encodeVal = val;
                return $"{m.Key}{encodeVal}";
            }).Where(m => m != null);
            var result = string.Join("", sortDict.ToArray());
            return result;
        }


        /// <summary>
        /// 将指定的字典转换成按属性名称排序过的查询参数
        /// </summary>
        /// <param name="dict"></param>
        /// <param name="urlencode"></param>
        /// <param name="exclude">排除的参数</param>
        /// <returns></returns>
        public static string ToSortQueryParameters(this IDictionary<string, string> dict, bool urlencode = false, params string[] exclude)
        {
            var sortDict = dict.OrderBy(m => m.Key).Select(m =>
            {
                if (m.Value == null || exclude.Contains(m.Key))
                    return null;
                if (m.Value is string && (string)m.Value == string.Empty)
                {
                    return null;
                }
                var val = m.Value.ToString();
                var encodeVal = "";
                if (urlencode)
                {
                    encodeVal += HttpUtility.UrlEncode(val.ToString());
                }
                else
                {
                    encodeVal = val;
                }
                return $"{m.Key}={encodeVal}";
            }).Where(m => m != null);
            var result = string.Join("&", sortDict.ToArray());
            return result;
        }

        /// <summary>
        /// 清除字典中值为空的项。
        /// </summary>
        /// <param name="dict">待清除的字典</param>
        /// <returns>清除后的字典</returns>
        public static IDictionary<string, object> CleanupDictionary(this IDictionary<string, object> dict)
        {
            IDictionary<string, object> newDict = new Dictionary<string, object>(dict.Count);
            IEnumerator<KeyValuePair<string, object>> dem = dict.GetEnumerator();

            while (dem.MoveNext())
            {
                string name = dem.Current.Key;

                object value = dem.Current.Value;

                if (value != null && value is int && (int)value != default(int))
                {
                    newDict.Add(name, value);
                }
                else if (value != null && value is decimal && (decimal)value != default(decimal))
                {
                    newDict.Add(name, value);
                }
                else if (value != null && value is string && (string)value != default(string))
                {
                    newDict.Add(name, value);
                }
                else if (value != null && value is long && (long)value != default(long))
                {
                    newDict.Add(name, value);
                }

                //if (value != null && (value.GetType() == typeof(int) ||
                //    value.GetType() == typeof(decimal) ||
                //    value.GetType() == typeof(string) ||
                //    value.GetType() == typeof(long)))
                //{
                //    newDict.Add(name, value);
                //}
                else if (value != null)
                {
                    newDict.Add(name, JsonConvert.SerializeObject(value));
                }
            }
            return newDict;
        }
    }
}
