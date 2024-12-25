using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukkan angka : ");
            string input = Console.ReadLine();
            string[] bagian = input.Split(',');

            int jumlahBaris = bagian.Length > 1 ? int.Parse(bagian[1]) : int.Parse(bagian[0]);
            bool terbalik = bagian.Length > 1 && bagian[0] == "99";

            if (terbalik)
            {
                for (int i = jumlahBaris; i >= 1; i--)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("* ");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                for (int i = 1; i <= jumlahBaris; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("* ");
                    }
                    Console.WriteLine();
                }
            }
            Console.ReadLine();
        }
    }
}