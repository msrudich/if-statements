﻿namespace IfStatements
{
    public static class Task14
    {
        public static int DoSomething(bool b1, bool b2, int i)
        {
            if (b1)
            {
                if (b2)
                {
                    if (i <= -5)
                    {
                        return 10 - (i * 2);
                    }

                    if (i > -5 && i <= 5)
                    {
                        return i * -2;
                    }

                    if (i > 5)
                    {
                        return 10 - (i * 2);
                    }
                }

                if (!b2)
                {
                    if (i <= -5)
                    {
                        return i * i * i;
                    }

                    if (i > -5 && i <= 5)
                    {
                        return i * i;
                    }

                    if (i > 5)
                    {
                        return i * i * i;
                    }
                }
            }

            if (!b1)
            {
                if (b2)
                {
                    if (i < -9)
                    {
                        return -i;
                    }

                    if (i >= -9 && i < -7)
                    {
                        return i;
                    }

                    if (i >= -7 && i < -3)
                    {
                        return i * 10;
                    }

                    if (i >= -3 && i <= 7)
                    {
                        return i;
                    }

                    if (i > 7)
                    {
                        return -i;
                    }
                }

                if (!b2)
                {
                    if (i < -9)
                    {
                        return -i;
                    }

                    if (i >= -9 && i < -3)
                    {
                        return i;
                    }

                    if (i >= -3 && i < 0)
                    {
                        return -100 * i;
                    }

                    if (i == 0)
                    {
                        return 0;
                    }

                    if (i > 0 && i < 5)
                    {
                        return -100 * i;
                    }

                    if (i >= 5 && i <= 7)
                    {
                        return i;
                    }

                    if (i > 7)
                    {
                        return -i;
                    }
                }
            }

            return 1000000000;
        }
    }
}
