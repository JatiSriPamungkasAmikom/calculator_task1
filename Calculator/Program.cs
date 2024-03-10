using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, option;

            Console.WriteLine("Pilih menu pada Kalkulator:");
            Console.WriteLine();

            Console.WriteLine("1. Penambahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");
            Console.WriteLine();

            Console.Write("Input pilihan menu 1-4:> "); option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    add();
                    break;
                case 2:
                    sub();
                    break;
                case 3:
                    multiple();
                    break;
                case 4:
                    div();
                    break;
                default:
                    Console.WriteLine("Pilihan menu tidak tersedia!");
                    break;
            }

            Console.WriteLine();
            Console.WriteLine("\nTekan sembarang key untuk Keluar");

            Console.ReadKey();
        }

        // Simplify with function
        static void add()
        {
            int a, b;

            Console.Write("Masukkan nilai a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Masukkan nilai b: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("-----------------------------------");

            Console.WriteLine("Hasil Penambahan dari {0} + {1} = {2}", a, b, addition(a, b));
        }

        static void sub()
        {
            int a, b;

            Console.Write("Masukkan nilai a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Masukkan nilai b: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("-----------------------------------");

            Console.WriteLine("Hasil Pengurangan dari {0} - {1} = {2}", a, b, subtraction(a, b));
        }

        static void multiple()
        {
            int a, b;

            Console.Write("Masukkan nilai a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Masukkan nilai b: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("-----------------------------------");

            Console.WriteLine("Hasil Perkalian dari {0} x {1} = {2}", a, b, multiplication(a, b));
        }

        static void div()
        {
            int a, b;

            Console.Write("Masukkan nilai a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Masukkan nilai b: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("-----------------------------------");

            Console.WriteLine("Hasil Pembagian dari {0} / {1} = {2}", a, b, division(a, b));
        }

        // Operation
        static int addition(int a, int b) {
            return (a + b);
        }

        static int subtraction(int a, in int b) { 
            return (a - b);
        }

        static int multiplication(int a, int b) {
            return (a * b);
        }

        static int division(int a, int b) { 
            return (a / b);
        }


    }
}
