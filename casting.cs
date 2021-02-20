using System.IO;
using System;

class Program
{
    static void Main()
    {
    Console.WriteLine("casting");
    Console.WriteLine("-----------");
   
   
   //--------------------------Casting-----------------------
   //casting adalah mengubah type data agar bisa di operasikan
   
   int a = 10;
   float b = 10.5f; // jangan lupa f untuk float
   //int hasil = a + b; //eroor karena hasil adalah int sedangkan jawabannya berupa float
   //maka
   
   int hasil = a + (int)b; // float b akan di convert ke int 
   
   //penulisan casting yaitu di depan variable di tambah kurung () diisi dengan pengubah type data
   
   
   Console.WriteLine("hasil dari "+a+"+"+b+"="+hasil);
   //hasilnya adalah 10+10.5=20 karena float sudah jadi int maka akan .5 akan hilang
    // hasilnya akan 20 dan ini salah karena hasil yang sebenarnya adalah 20.5 jadi kita salah dalam pemilihan variable hasil menjadi float
    float hasilbenar = (float)a + b;
    Console.WriteLine("hasil benar dari "+a+"+"+b+"="+hasilbenar);

    }
}
