using System;
class Program {
  static void Main() {
   Console.WriteLine("Array");
   Console.WriteLine("-------------");
    //array digunakan untuk menyimpan banyak data
    //contoh tanpa array
    // string namaMurid1 = "Ayu";
    // string namaMurid2 = "Bunga";
    // string namaMurid3 = "Cyntia";
    // string namaMurid4 = "Deni";
    // string namaMurid5 = "Elisa";
    //gimana kalo murid ada 100 atau 1000? 
    //maka agar lebih efisien kita gunakan array
    // int[] aAngka;
    // string[] aNama;
    // object[] aObjek;
    String[] nama_array_murid = new String[5]; // inisialisasi array dengan jumlah data 
   Console.WriteLine("---------- memasukkan data ke array");
     nama_array_murid[0] = "Ayu"; //[0] ini adalah index, index dimulai dari 0,
     //jika jumlah datanya 5 maka indexnya 0-4, 
     nama_array_murid[1] = "Bunga";
     nama_array_murid[2] = "Cyntia";
     nama_array_murid[3] = "Deni";
     nama_array_murid[4] = "Elisa";
     //sama dong kayak yang di atas, kalo datanya ada 100 masak harus buat nama_array_murid[100]
     //kita bisa membuat looping untuk mengisi datanya
     //contoh membuat 10 data
     int[] nilai_array_murid = new int[10];
     //buat object scanner unutk input
     for(int i = 0; i < 10; ++i)
     {
        Console.Write("masukan nilai murid ke [" + (i+1) + "] : "); // keterangan input
        string input = Console.ReadLine(); //proses input lalu di masukan dalam variable input
        nilai_array_murid[i] = Convert.ToInt32(input);// i adalah angka yang akan di looping mulai dari 0-9
        
     }
     //maka kita akan menginputkan data sebanyak 10x
     //kalo mau input ada 100 tinggal looping aja seratus kali

     //atau bisa langsung di masukkan
     int[] absen_array_murid = new int[5]{
     1,2,3,4,5
     }; //1 memiliki index 0

    Console.WriteLine("---------- menampilkan array\n");
     // cara menampilkan array
    Console.WriteLine("nama :" + nama_array_murid[0]); 
     //bagaimana kalo datanya ada banyak? ya looping aja
     
     for (int i = 0; i < 5; ++i)
     {
        Console.WriteLine("nama murid ke [" + (i+1) + "] : " + nama_array_murid[i]); //menampilkan array nama_array_murid 
     }
      for (int i = 0; i < 5; ++i)
     {
        Console.WriteLine("absen murid ke [" + (i+1) + "] : " + absen_array_murid[i]); //menampilkan array absen_array_murid 
     }
     // terus bagaimana kalo banyak datanya tidak diketahui? masak harus meriksa satu per satu?
     //bisa gunakan nama_array.length
      for (int i = 0; i < nilai_array_murid.Length; ++i)
     {
        Console.WriteLine("nilai murid ke [" + (i+1) + "] : " + nilai_array_murid[i]); //menampilkan array nilai_array_murid 
     }

 
    }
}
