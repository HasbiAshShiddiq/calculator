using System;


namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pilih Menu Kalkulator");
            Console.WriteLine("\n1.Penjumlahan");
            Console.WriteLine("2.Pengurangan");
            Console.WriteLine("3.Pembagian");
            Console.WriteLine("4.Perkalian");

            Console.Write("\nInput Nomor Menu [1...4] : ");
            int c = int.Parse(Console.ReadLine());

            switch(c)
            {
                case 1: Console.Write("Masukan Nilai a : ");
                        int a = Convert.ToInt16(Console.ReadLine());
                        Console.Write("Masukan Nilai b : ");
                        int b = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Hasil Penjumlahan {0} + {1} = {2}", a, b, Penjumlahan(a, b));
                    break;
                case 2:
                    Console.Write("Masukan Nilai a : ");
                    int d = Convert.ToInt16(Console.ReadLine());
                    Console.Write("Masukan Nilai b : ");
                    int e = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Hasil Penjumlahan {0} + {1} = {2}", d, e, Pengurangan(d, e));
                    break;
                case 3:
                    Console.Write("Masukan Nilai a : ");
                    int f = Convert.ToInt16(Console.ReadLine());
                    Console.Write("Masukan Nilai b : ");
                    int g = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Hasil Penjumlahan {0} + {1} = {2}", f, g, Pembagian(f, g));
                    break;
                case 4:
                    Console.Write("Masukan Nilai a : ");
                    int h = Convert.ToInt16(Console.ReadLine());
                    Console.Write("Masukan Nilai b : ");
                    int i = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Hasil Penjumlahan {0} + {1} = {2}", h, i, Penjumlahan(h, i));
                    break;
                default: Console.WriteLine("\nMaaf Perintah Yang Dimasukan Tidak Tersedia");
                    break;
            }

            Console.WriteLine("\nTekan Sembarang Key Untuk Keluar");

            Console.ReadKey();
        }
        static int Penjumlahan(int a, int b)
        {
            return a + b;
        }
        static int Pengurangan(int d, int e)
        {
            return d + e;
        }
        static int Pembagian(int f, int g)
        {
            return f + g;
        }
        static int Perkalian(int h, int i)
        {
            return h + i;
        }
    }
}