namespace IfStatements
{
    public static class Task7
    {
        public static int DoSomething(bool b, int i)
        {
            var result = i;

            if (b && (i > -7 && i < 7))
            {
                result = 7 - i;
            }

            if (!b && (i <= -5 || i >= 5))
            {
                result += 5;
            }

            return result;
        }
    }
}
