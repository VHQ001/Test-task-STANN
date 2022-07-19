namespace Task_one
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        private static void ChangeValue(ref int x, ref int y, ref int z)
        {
            x += z;
            z = x - z;
            x -= z;
            y += x;
            x = y - x;
            y -= x;
        }
    }
}
