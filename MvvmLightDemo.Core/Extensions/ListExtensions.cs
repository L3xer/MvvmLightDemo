using System;
using System.Collections.Generic;

namespace MvvmLightDemo.Core.Extensions
{
    public static class ListExtensions
    {
        public static List<T> Shuffle<T>(this List<T> list, int shuffles)
        {
            int index;
            var rand = new Random();
            var sortOrderList = new List<T>();

            for (int i = 0; i < shuffles; i++) {
                while (list.Count > 0) {
                    index = rand.Next(list.Count);

                    sortOrderList.Add(list[index]);

                    list.RemoveAt(index);
                }

                list = sortOrderList;
                sortOrderList = new List<T>();
            }

            return list;
        }
    }
}
