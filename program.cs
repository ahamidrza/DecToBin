using System;

namespace DesToBin
{
    class Program
    {
        static void Main(string[] args)
        {
            int Des = int.Parse(Console.ReadLine());
            int LastDesNum = 1;
            for (int Num = 1; Num < Des; Num = Num * 2)
            {
                LastDesNum = Num;
            }
            string Bin = "";
            while (LastDesNum != 0)
            {
                if(LastDesNum > Des)
                {
                    Bin += 0;
                }
                else
                {
                    Bin += 1;
                    Des = Des - LastDesNum;
                }
                LastDesNum = LastDesNum / 2;
            }
            if(Bin.Length % 2 != 0)
            {
                Bin = "0" + Bin;
            }
            Console.WriteLine(Bin);
        }
    }
}
