namespace IfStatements
{
    public static class Task5
    {
        public static int DoSomething(int i)
        {
            var result = i;

            if (i < 0 && i >= -5)
            {
                result += 5;
            }

            if (i > 0 && i <= 5)
            {
                result -= 5;
            }

            return result;
        }
    }
}
