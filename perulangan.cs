using System.IO;
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Pengulangan");
 Console.WriteLine("-----------");
    
    
  Console.WriteLine("----------- for");
   //pengulangan dalam bahasa pemrogramman umumnya ada 3 pengulangan
   //pengulangan menggunakan -------------------- for
   //contoh pengulangan 5x
   for(int i = 0; i < 5; ++i){
    Console.WriteLine(i); //01234 karena int i dimulai dari o
       //kenapa 0 karena umumnya for digunakan untuk menampilkan isi array
       //karena index array di mulai dari 0
       // angka 5 adalah jumlah banyaknya pengulangan
   }
Console.WriteLine("");
   
   //agar dimulai 1 langsung saja isikan int i = 1 dan juga < di kasih = atau 5 di ganti jadi 6agar mengulang 5x 
    for(int k = 0; k <= 5 /*i  < 6*/; ++k){
    Console.WriteLine(k); //01234 karena int i dimulai dari o
       //kenapa 0 karena umumnya for digunakan untuk menampilkan isi array
       //karena index array di mulai dari 0
       // angka 5 adalah jumlah banyaknya pengulangan
   }
Console.WriteLine("");
   //contoh pengulangan 5 tapi decrement
   for(int l = 5; l > 0 ; l--){
    Console.WriteLine(l); // 54321 karena int i dimulai dari 5 
   }
   
   
  Console.WriteLine("----------- do while");
     //pengulangan menggunakan -------------------- while do
     int j = 0; //karna int i sudah di pake di child scope (for) maka tidak bisa di gunkan lagi di c java c ++ tidak berlaku
     do{
         j++; //i + 1
      Console.WriteLine(j); // cetak i 
         
     }while(j < 5); // sampai i lebih kecil dari 5
     // hasil 12345
     Console.WriteLine("");
     j = 5; //ubah i = 5
     //---------------while
     while(j > 0){ //cek apakah i lebih besar dari 0 jika true
      Console.WriteLine(j); //cetak i
         j--; //i kurang 1
     }
    }
}
