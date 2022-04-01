namespace ClassLibraryStrings
{
    public static class Strings
    {
        #region Примитивный алгоритм
        /// <summary>
        /// Классический (примитивный) поиск вхождения подстроки, начиная с заданного индекса
        /// </summary>
        /// <param name="source"> исходная строка </param>
        /// <param name="pattern"> искомая строка </param>
        /// <param name="start"> индекс начала поиска </param>
        /// <returns> индекс вхождения pattern в source, начиная с индекса start </returns>
        public static int IndexOfAny_Primitive(string source, string pattern, int start)
        {
            int finish = source.Length - pattern.Length + 1;
            int i = start;
            while (i < finish)
            {
                while (i < finish && source[i] != pattern[0])
                {
                    ++i;
                }
                if (i < finish && IsPattern(source, pattern, i))
                {
                    return i;
                }
                ++i;
            }
            return -1;
        }

        /// <summary>
        /// Проверяет, содержит ли строка source подстроку pattern по индексу i
        /// </summary>
        /// <param name="source"> исходная строка </param>
        /// <param name="pattern"> искомая строка </param>
        /// <param name="i"> индекс в строке source </param>
        /// <returns> true, если начиная с индекса i source содержит pattern, иначе false </returns>
        public static bool IsPattern(string source, string pattern, int i)
        {
            int n = pattern.Length;
            int j = 1;
            while (j < n && source[i + j] == pattern[j])
            {
                ++j;
            }
            return j == n;
        }
        #endregion
    }
}