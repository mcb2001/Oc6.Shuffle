﻿using System;
using System.Collections.Generic;

namespace Oc6.Shuffle
{
    public static class IListExtensions
    {
        private static readonly Random _randomizer = new Random();

        /// <summary>
        /// <para>Does a inplace Fisher–Yates shuffle of any <see cref="IList{T}"/> and returns the list.</para>
        /// </summary>
        /// <typeparam name="T">Any type</typeparam>
        /// <param name="list">The list to shuffle</param>
        /// <returns>The sorted list</returns>
        public static IList<T> Shuffle<T>(this IList<T> list)
        {
            for (int i = list.Count - 1; i > 0; --i)
            {
                int j = _randomizer.Next(0, i + 1);
                T a = list[i];
                list[i] = list[j];
                list[j] = a;
            }

            return list;
        }
    }
}
