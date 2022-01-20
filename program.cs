using System;

namespace DesToBin
{
    class Program
    {
        static void main()
        {
            Console.WriteLine("in this script you can convert decimal numbers to binary");
            Console.WriteLine("——————————————————————————————————————————");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("note : max valid number is 999,999,999");
            Console.ResetColor();
            Console.WriteLine("——————————————————————————————————————————");
            Console.Write("please type your decimal number : ");
            int Des = int.Parse(Console.ReadLine());
            int LastDesNum = 1;
            Console.WriteLine("——————————————————————————————————————————");
            for (int Num = 1; Num < Des; Num = Num * 2)
            {
                LastDesNum = Num;
            }
            string Bin = "";
            while (LastDesNum != 0)
            {
                if (LastDesNum > Des)
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
            string d = "";
            string ds = "";
            if (Bin.Length < 16 && Bin.Length > 8)
            {
                for (int b = 0; b < 16 - Bin.Length; b++)
                {
                    d += "0";
                    ds = "16 bit result";
                }
            }
            else if (Bin.Length < 8 && Bin.Length > 0)
            {
                for (int b = 0; b < 8 - Bin.Length; b++)
                {
                    d += "0";
                    ds = "8 bit result";
                }
            }
            else if (Bin.Length < 32 && Bin.Length > 16)
            {
                for (int b = 0; b < 32 - Bin.Length; b++)
                {
                    d += "0";
                    ds = "32 bit result";
                }
            }
            Console.WriteLine("binary number is : " + d + Bin);
            Console.WriteLine("——————————————————————————————————————————");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(ds);
            Console.ResetColor();
            Console.WriteLine("——————————————————————————————————————————");
            main();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to destobin");
            Console.WriteLine("——————————————————————————————————————————");
            main();
            Console.WriteLine("——————————————————————————————————————————");
            Console.WriteLine("allrights reserved for hamidreza ahmadi");
        }
    }
}
