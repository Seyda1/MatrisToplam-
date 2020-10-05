using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication42
{
    class Program
    {
        static void Main(string[] args)
        {
            int satır1, sutun1,satır2,sutun2;
            Console.WriteLine("1.Matris için satır sayıs:");
            satır1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("1.Matris için sutun sayısı:");
                sutun1=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("2.Matris için satır sayıs:");
            satır2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.Matris için sutun sayısı:");
                sutun2=Convert.ToInt32(Console.ReadLine());
                int[,] dizi1 = new int[satır1, sutun1];
            int[,]dizi2=new int [satır2,sutun2];
            int[,]toplam=new int[satır1,sutun1];
            for (int x = 0; x < satır1; x++)
            {
                for (int y = 0; y < sutun1; y++)
                {
                    Console.WriteLine("1.matrisin {0}x{1} değerlerini giriniz:", x + 1, y + 1);
                    dizi1[x,y] = Convert.ToInt32(Console.ReadLine());
                   
                }
            }
            for (int t = 0; t < satır1; t++)
            {
                for (int z = 0; z < sutun1; z++)
                {
                    Console.WriteLine("2.matrisin {0}x{1} değerlerini giriniz:", t + 1, z+ 1);
                    dizi2[t, z] = Convert.ToInt32(Console.ReadLine());

                }
            }
            Console.WriteLine("İki Matrisin Toplamı:");
            for (int i = 0; i < satır1; i++)
            {
                for (int j = 0; j < sutun1; j++)
                    toplam[i, j] = dizi1[i, j] + dizi2[i, j];
            }
            for (int a = 0; a < satır1; a++)
            {
                Console.WriteLine();
                for (int b = 0; b < sutun1; b++)
                {
                    Console.Write(toplam[a, b] + " ");

                    
                }
            }
            Console.Read();
            
        }
    }
}
