using System;
using System.Collections.Generic;

namespace IntroductionToLinq.Exercise1
{
    public static class ExtensionsSolution
    {
        public static IEnumerable<TResult> MySelect<TSource, TResult>(
            this IEnumerable<TSource> source,
            Func<TSource, TResult> selector)
        {
            foreach (var item in source)
            {
                yield return selector(item);
            }
        }

        public static IEnumerable<TResult> MySelectMany<TSource, TResult>(
            this IEnumerable<TSource> source,
            Func<TSource, IEnumerable<TResult>> selector)
        {
            foreach (var item in source)
            {
                foreach (var t in selector(item))
                {
                    yield return t;
                }
            }
        }

        public static int MySum(this IEnumerable<int> source)
        {
            int sum = 0;
            foreach (var item in source)
            {
                sum += item;
            }
            return sum;
        }

        public static int MyCount<TSource>(this IEnumerable<TSource> source)
        {
            int count = 0;
            foreach (var item in source)
            {
                count += 1;
            }
            return count;
        }
    }
}