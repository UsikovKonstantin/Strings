using System;
using System.Collections.Generic;

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

        #region Алгоритм КМП
        /// <summary>
        /// Алгоритм КМП для поиска вхождения подстроки
        /// </summary>
        /// <param name="source"> исходная строка </param>
        /// <param name="pattern"> искомая строка </param>
        /// <param name="start"> индекс начала поиска </param>
        /// <returns> индекс вхождения pattern в source </returns>
        public static int IndexOf_KMP(string source, string pattern, int start)
        {
            int n = source.Length;
            int m = pattern.Length;
            int[] pref = PrefixFunction(pattern);
            int i = start, k = 0;
            while (i < n && k < m)
            {
                if (source[i] == pattern[k])
                {
                    ++i;
                    ++k;
                }
                else if (k == 0)
                {
                    ++i;
                }
                else
                {
                    k = pref[k - 1];
                }
            }
            if (k == m)
            {
                return i - k;
            }
            return -1;
        }

        /// <summary>
        /// Вспомогательная функция метода КМП - подсчёт длины префиксов, совпадающих с суффиксами
        /// </summary>
        /// <param name="pattern"> искомая строка </param>
        /// <returns> массив длин префиксов </returns>
        public static int[] PrefixFunction(string pattern)
        {
            int n = pattern.Length;
            int[] res = new int[n];
            res[0] = 0;
            int k = 0;
            for (int i = 1; i < n; ++i)
            {
                // При несовпадении символов откат к предыдущему успешному префиксу
                // Возможно до нуля, если символ i не является концом никакого префикса
                while (k > 0 && pattern[k] != pattern[i])
                {
                    // Гарантируется k > res[k - 1], поэтому зацикливания не будет
                    k = res[k - 1];
                }

                // При совпадении символов расширяем успешный префикс
                if (pattern[k] == pattern[i])
                {
                    ++k;
                }

                // Сохраняем i-й успешный префикс (его длину)
                res[i] = k;
            }
            return res;
        }
        #endregion

        #region Улучшенный алгоритм КМП
        /// <summary>
        /// Улучшенный алгоритм КМП
        /// </summary>
        /// <param name="source"> исходная строка </param>
        /// <param name="pattern"> искомая строка </param>
        /// <param name="start"> индекс начала поиска </param>
        /// <returns> список всех вхождений pattern в source </returns>
        public static List<int> IndexOfKMP_Best(string source, string pattern, int start)
        {
            List<int> res = new List<int>();
            string expand = pattern + Convert.ToChar(0) + source.Substring(start);
            int[] pref = PrefixFunction(expand);
            int n = pref.Length;
            int m = pattern.Length;
            for (int i = 0; i < n; ++i)
            {
                if (pref[i] == m)
                {
                    res.Add(i - 2 * m + start);
                }
            }
            return res;
        }
        #endregion
    }
}