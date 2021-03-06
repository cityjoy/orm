﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Qhyhgf.WeiXin.Qy.Api.Helpers
{
    /// <summary>
    /// Json字符串操作辅助类
    /// </summary>
    public class JsonHelper
    {
        /// <summary>
        /// 字符串转化成为对象
        /// </summary>
        /// <typeparam name="T">对象</typeparam>
        /// <param name="objStr">json数据</param>
        /// <returns>转化后对象</returns>
        public static T DeserializeObject<T>(string objStr) where T : class
        {
            T result = JsonConvert.DeserializeObject<T>(objStr);
            return result;
        }
        /// <summary>
        /// 把对象转化为json
        /// </summary>
        /// <param name="obj">对象</param>
        /// <returns>转换后的字符串</returns>
        public static string SerializeObject<T>(T obj)
        {
            IsoDateTimeConverter timeConverter = new IsoDateTimeConverter();
            //这里使用自定义日期格式，如果不使用的话，默认是ISO8601格式     
            timeConverter.DateTimeFormat = "yyyy'-'MM'-'dd' 'HH':'mm':'ss";
            return JsonConvert.SerializeObject(obj, Formatting.Indented, timeConverter);
        }
    }
}
