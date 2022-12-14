using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bubble_Sort
{
    class Program
    {
        // deklarasi array int dengan ukuran 20
        private int[] a = new int [20];

        // deklarasi variabel int untuk menyimpan banyaknya data pada array
        private int n;

        // fungsi / method untuk menerima masukan
        public void read()
        {
            // menerima angka untuk menentukan banyaknya data yang disimpan pada array
            while (true)
            {
                Console.Write("Masukkan banyaknya elemen pada Array: ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 20)
                    break;
                else
                    Console.WriteLine("\n Array dapat mempunyai maksimal 20 elemen. \n");
            }
            Console.WriteLine("");
            Console.WriteLine("--------------------");
            Console.WriteLine("Masukkan elemen Array");
            Console.WriteLine("--------------------");

            // pengguna masukkan elemen pada Array
            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                a[i] = Int32.Parse(s1);
            }
        }
        public void display()
        {
            // menampilkan array yang tersusun
            Console.WriteLine("");
            Console.WriteLine("--------------------------");
            Console.WriteLine("Elemen array yang tersusun");
            Console.WriteLine("--------------------------");
            for (int j = 1; j < n; j++)
            {
                Console.WriteLine(a[j]);
            }
            Console.WriteLine("");
        }
        public void BubbleSortArray()
        {
            for (int i = 1; i < n; i++) // for n - 1 passes
            {
                // pada pass i, bandingkan n - 1 elemen pertama dengan elemen selanjutnya
                for (int j = 0; j < n - i; j++)
                {
                    if (a[j] > a[j + 1]) // jika elemen tidak dalam urutan yang benar
                    {
                        // tukar elemen
                        int temp;
                        temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            // creating the object of the BubbleSort class
            Program mylist = new Program();
            // pemanggilan fungsi untuk menerima elemen array
            mylist.read();
            // pemanggilan fungsi untuk mengurutkan array
            mylist.BubbleSortArray();
            // pemanggilan fungsi untuk menampilkan array yang tersusun
            mylist.display();
            // exit
            Console.WriteLine("\n\nTekan tombol apa saja untuk keluar.");
            Console.Read();
        }
    }
}
