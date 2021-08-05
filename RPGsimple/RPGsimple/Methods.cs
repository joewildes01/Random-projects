using System;
using System.Linq;
namespace RPGsimple
{
    public static class Methods
    {
        public static bool In<T>(this T obj, params T[] args)
        {
            return args.Contains(obj);
        }
    }
}
