using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[50];
            int i, n,a=1,b;
            Console.Write("Nhap kich co mang: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < n; i++)
            {
                Console.Write("Phan tu - {0}: ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            while(a==1)
            {
                Console.WriteLine("Vui long nhan phim 1 neu muon Sap Xep Mang");
                Console.WriteLine("Vui long nhan phim 2 neu muon tinh tong cac chu so chan");
                Console.WriteLine("Vui long nhan phim 3 neu muon tim Max");
                b =Convert.ToInt32 (Console.ReadLine());
                switch (b)
                {
                    case 1:
                        SapXep(arr1, n);
                        Console.Write("\nCac phan tu mang theo thu tu tang dan:\n");
                        for (i = 0; i < n; i++)
                        {
                            Console.Write("{0}  ", arr1[i]);
                        }
                        Console.Write("\n");
                        break;
                    case 2:
                        Console.WriteLine("Sum = {0}", Sum(arr1, n));
                        break;
                    case 3:
                        Console.WriteLine("Max = {0}", Max(arr1, n));
                        break;
                }
                Console.WriteLine("Tiep Tuc Nhan Phim 1");
                Console.WriteLine("Thoat Nhan Phim Khac ");
                a = Convert.ToInt32(Console.ReadLine());

            }
            Console.ReadKey();
        }

        static void SapXep(int[] arr1, int n)
        {
            int i, j, tmp;
            for (i = 0; i < n; i++)
            {
                for (j = i + 1; j < n; j++)
                {
                    if (arr1[j] < arr1[i])
                    {
                        tmp = arr1[i];
                        arr1[i] = arr1[j];
                        arr1[j] = tmp;
                    }
                }
            }
        }


        static int Sum(int[] arr1,int n)
        {
            int i, tong = 0;
            for (i = 0; i < n; i++)
                if (arr1[i] % 2 == 0) tong = tong + arr1[i];
            return tong;
        }


        static int Max(int[] arr1, int n)
        {
            int i;
            int max = arr1[0];
            for (i = 0; i < n; i++)
    
                if (arr1[i] > max) max = arr1[i];
            
            return max;
        }
    }
}
