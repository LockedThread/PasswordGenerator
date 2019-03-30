namespace PasswordGenerator
{
    public static class ArrayUtils
    {
        public static T[] CombineArrays<T>(ref T[] t1, ref T[] t2)
        {
            var t = new T[t1.Length + t2.Length];

            var current = 0;

            foreach (var tt in t1)
            {
                t[current] = tt;
                current += 1;
            }

            foreach (var tt in t2)
            {
                t[current] = tt;
                current += 1;
            }

            return t;
        }
    }
}