using System;

class Program
{
    static void Main()
    {
    Console.WriteLine("switch case");
    Console.Write("-----------------\n");
    //switch case adalah percabangan kode program dimana kita membandingkan isi sebuah variabel dengan beberapa nilai
    //contoh
    //int number = 2; //langsung input atau
    int number;
    Console.Write("masukkan angka : ");
    number = Convert.ToInt32(Console.ReadLine());
    switch(number){ //variable yg akan di switch / di periksa
        case 0: // jika number == 0
            Console.Write("number == 0"); //jalankan ini
            break; //break di gunakan untuk menstop / case yang selanjutnya di hentikan  jika casenya benar
        case 1: // jika number == 1
            Console.Write("number == 1"); //jalankan ini
            break; //break
        case 3: //jika number == 3
            Console.Write("number == 3"); //jalankan ini
            break; //break
        default: // jika variable tidak sama dengan case 
            Console.Write("number != 0,1,3"); //jalankan ini
            break;//break
    }

    }
}
