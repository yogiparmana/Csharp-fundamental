using System;
class Program {
  static void Main() {
Console.WriteLine("Input Console");
Console.WriteLine("-----------------");
    //input menggunakan 
    //Console.ReadLine() string
    int number; //inisialisasi variable int number
    Console.Write("Masukkan Number : "); //keterangan input
    number =  Convert.ToInt32(Console.ReadLine()); // proses input. karena readline hanya menghasilkan string maka kita
    //mengakalinya dengan method Convert.ToInt32() agar readline di baca int
    Console.WriteLine("output number : " + number); // proses output
    
    
    string kata; // inisialisasi variable string kata (di c# menggunakan s kecil)
    Console.Write("Masukkan Kata : "); //keterangan input
    kata = Console.ReadLine(); // proses input
    Console.WriteLine("output string : " + kata); // output
   
  }
}
