using System;

namespace Laba_2_W
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите чётное число");
            int x = Convert.ToInt32(Console.ReadLine());
            if(x % 2 == 0){
                for (int i = 2; i < x; i++)
                {
                    if (isSimple(i)){
                        for (int j = 2; j < x; j++)
                        {
                            if (isSimple(j))
                            {
                                if (i + j == x)
                                {
                                    Console.WriteLine($"({i} : {j})");
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Введите чётное число");
            }

            bool isSimple(int n)
            {
                bool taf = true;
                for (int z = 2; z < (n / 2); z++)
                {
                    if (n % z == 0)
                    {
                        taf = false;
                        break;
                    }
                    else
                    {
                        taf = true;
                    }
                }
                return taf;
            }
        }
    }
}
