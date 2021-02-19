using System.IO;
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("---------------------");
   
   // deklarasi Variable
   int umur; //type data integer untuk angka tanpa koma, jika koma akan di bulatkan (variable = number)
   string nama;//string untuk kata / huruf
   float PI;// float untuk angka dengan koma (pecahan) jika bulat maka akan di conversi (contoh 1 == 1.00)
   double PI2;// doube mirip dengan float namun angka di belakang koma lebih banyak
   //note(koma dalam bahasa pemrograman menggunakan titik (.))
   bool udahmakan; // bool / bolean adalah type data yang menghasilkan true (benar) / false (salah)
   char indexprestasi; // char adalah type data untuk 1 huruf 
   
   //pemberian nilai pada variable / inisialisasi
   umur = 21;
   nama  = "Yogi";
   PI = 3.14f;
   PI2 = 3.33;
   udahmakan = true;
   indexprestasi = 'A'; // char menggunakan petik 1 sedangkan string menggunakan petik 2
   
   //output 
   //output di c# menggunakan Console.WriteLine
    Console.WriteLine("Nama : " + nama); //tanda << menggunakan untuk menyambung variable
    Console.WriteLine("umur : " + umur);
    Console.WriteLine("Sudah Makan? : " + udahmakan);
    Console.WriteLine("Index Prestasi : " + indexprestasi);
    Console.Write("PI = " + PI + " dan PI 2 = " + PI2); //jangan lupa titik koma di akhir setiap baris
   // Console.Write digunakan untuk menghasilkan output / Console.WriteLine digunakan untuk menambah line (enter)
    }
}
