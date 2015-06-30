using System;

namespace _16.Print_Long_Sequence
{
    class PrintLongSeq
    {
        static void Main()
        {
            for (int i = 2; i < 1002; i++)
            {
                if (i % 2 == 0 )
                {
                    Console.Write("{0},", i);
                }
                else
                {
                    Console.Write("{0},", -i);
                }
            }
        }
    }
}
