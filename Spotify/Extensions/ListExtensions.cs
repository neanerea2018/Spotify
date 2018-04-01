using System.Collections.Generic;

namespace Spotify.Extensions
{
    public static class ListExtensions
    {
        public static void Add<T>(this List<T> list, params T[] elements)
        {
            list.AddRange(elements);
        }
    }
}