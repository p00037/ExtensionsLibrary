using System;

namespace SKZKIOT.Common
{
    public static class NullableDateTimeExtensions
    {
        /// <summary>
        /// 日付フォーマット（nullの時は空を返す）
        /// </summary>
        /// <param name="source">拡張メソッド本体の値</param>
        /// <param name="formatString">フォーマット文字列</param>
        /// <returns>フォーマットされた値</returns>
        public static string Format(this DateTime? source, string formatString)
        {
            if (source == null)
            {
                return "";
            }

            return Convert.ToDateTime(source).ToString(formatString);
        }
    }
}
