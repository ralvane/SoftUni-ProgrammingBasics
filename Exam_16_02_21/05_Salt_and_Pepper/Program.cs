namespace _05_SaltAndPepper
{
    using System;
    using System.Linq;

    class Program
    {
        // change 1's to 0's
        static ulong Salt(ulong num, int step)
        {
            ulong result = num;

            for (int i = 0; i < 64; i += step)
            {
                if (((result >> i) & 1) == 1)
                {
                    result &= ~((ulong)1 << i);
                }
            }

            return result;
        }

        // change 0's to 1's
        static UInt64 Pepper(ulong num, int step)
        {
            ulong result = num;

            for (int i = 0; i < 64; i += step)
            {
                if (((result >> i) & 1) == 0)
                {
                    result |= (ulong)1 << i;
                }
            }

            return result;
        }

        public static void Main()
        {
            ulong dishesCount = ulong.Parse(Console.ReadLine());

            do
            {
                var usrInput = Console.ReadLine()
                    .Split((char[])null, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (usrInput[0] == "salt")
                {
                    dishesCount = Salt(dishesCount, int.Parse(usrInput[1]));
                }
                else if (usrInput[0] == "pepper")
                {
                    dishesCount = Pepper(dishesCount, int.Parse(usrInput[1]));
                }
                else if (usrInput[0] == "end")
                {
                    break;
                }
            } while (true);

            Console.WriteLine(dishesCount);
        }
    }
}