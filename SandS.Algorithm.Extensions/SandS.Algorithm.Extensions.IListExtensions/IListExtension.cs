﻿using System;
using System.Collections.Generic;

namespace SandS.Algorithm.Extensions.IListExtension
{
    public static class IListExtensions
    {
        public static void SetWithRandomElements<T>(this IList<T> array, T min, T max, int capacity, Func<T, T, T> funcToGetNewRandomElement)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array), "Array is null");
            }

            if (funcToGetNewRandomElement == null)
            {
                throw new ArgumentNullException(nameof(funcToGetNewRandomElement), "Function to get new ramndom element is null.");
            }

            for (int i = 0; i < capacity; ++i)
            {
                array.Add(funcToGetNewRandomElement(min, max));
            }
        }

        public static void Show<T>(this IList<T> array)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array), "Array is null");
            }

            foreach (var item in array)
            {
                Console.WriteLine(item + "  ");
            }
        }
    }
}