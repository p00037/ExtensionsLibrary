namespace ExtensionsLibrary
{
    public static class NullableIntegerExtensions
    {
        /// <summary>
        /// int型に変換（nullのときは0を返す）
        /// </summary>
        /// <param name="source">拡張メソッド本体の値</param>
        /// <returns>int型に変換した値</returns>
        public static int ToInt(this int? source)
        {
            if (source == null)
            {
                return 0;
            }

            return (int)source;
        }
    }
}
