﻿using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace DeviceTracker.Common
{
    public static class CollectionExtension
    {
        public static void Sort<TSource, TKey>(this Collection<TSource> source, Func<TSource, TKey> keySelector)
        {
            var sortedList = source.OrderBy(keySelector).ToList();
            source.Clear();
            foreach (var sortedItem in sortedList)
                source.Add(sortedItem);
        }

        public static void SortDescending<TSource, TKey>(this Collection<TSource> source,
                                                         Func<TSource, TKey> keySelector)
        {
            var sortedList = source.OrderByDescending(keySelector).ToList();
            source.Clear();
            foreach (var sortedItem in sortedList)
                source.Add(sortedItem);
        }
    }
}