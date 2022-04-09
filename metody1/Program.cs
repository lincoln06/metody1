using System;

namespace metody1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int y = 1;
            int z = 2;
            int i = 0;
            FirstCheck(x, y, z, i);

        }
        static void FirstCheck(int x, int y, int z, int i)
        {
            if (i >= 5)
            {
                Console.ReadKey();
                return;
            }

            else
            {
                int j = 0;
                SecondCheck(x, y, z, i, j);
            }
        }
        static void SecondCheck(int x, int y, int z, int i, int j)
        {
            if (j >= 5)
            {
                i++;
                FirstCheck(x, y, z, i);
            }
            else
                ThirdCheck(x, y, z, i,j);
        }
        static void ThirdCheck(int x, int y, int z, int i,int j)
        {
            if (j % 2 == 0) FourthCheck(x, y, z, i, j);
            else FifthCheck(x, y, z, i, j);
        }
        static void FourthCheck(int x,int y, int z,int i, int j)
        {
            if(j==1 || j==3)
            {
                Console.WriteLine($"X: {x}");
            }
           else
            {
                Console.WriteLine($"Z: {z}");
            }
            IncreaseJ(x,y,z,i,j);
        }
        static void FifthCheck(int x, int y, int z, int i, int j)
        {
            if((j+1)%3!=0)
            {
                Console.WriteLine($"Y: {y}");
            }
            else
            {
                Console.WriteLine($"X: {x}");
            }
            IncreaseJ(x,y,z,i,j);
        }
        static void IncreaseJ(int x, int y, int z, int i, int j)
        {
            j++;
            SecondCheck(x, y, z, i, j);
        }
    }
}
