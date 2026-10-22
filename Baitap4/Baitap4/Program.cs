using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Nhap ho, ten lot va ten. Xuat ra ho ten day du.");
            Console.WriteLine();

            Console.Write("Nhap ho:");
            string ho = Console.ReadLine();

            Console.Write("Nhap ten lot:");
            string tenlot = Console.ReadLine();

            Console.Write("Nhap ten:");
            string ten = Console.ReadLine();

            Console.WriteLine("Ho va ten day du: {0} {1} {2}", ho, tenlot, ten);

            Console.ReadKey(true);
        }
    }
}
