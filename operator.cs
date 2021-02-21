using System.IO;
using System;

class Program
{
    static void Main()
    {
    Console.WriteLine( "Operator\n");
Console.WriteLine( "-----------\n");
    
    //-----------operator---------------
    //simbol untuk melakukan operasi
    
    //----------------Operator Aritmatika
    /*
Penjumlahan +
Pengurangan -
Perkalian   *
Pembagian   /
Sisa Bagi   %
    
    */
    Console.WriteLine("----------------------aritmatika\n");
    int angka1,angka2;
    int hasil;
    
    angka1 = 10;
    angka2 = 20;
    
    //tambah
    hasil = angka1+angka2;
    Console.WriteLine( "Hasil dari "+angka1+" + "+angka2+" = "+hasil);
    //kurang
    hasil = angka1-angka2;
    Console.WriteLine( "Hasil dari "+angka1+" - "+angka2+" = "+hasil);
    //kali
    hasil = angka1 * angka2;
    Console.WriteLine( "Hasil dari "+angka1+" x "+angka2+" = "+hasil);
    //bagi
    hasil = angka2 / angka1;
    Console.WriteLine( "Hasil dari "+angka1+" : "+angka2+" = "+hasil);
    //modulus atau sisa bagi
    hasil = angka1 % angka2;
    Console.WriteLine( "Hasil dari "+angka1+" mod "+angka2+" = "+hasil);
    
    
     Console.WriteLine( "----------------------penugasan\n");
    
    //----------------Operator penugasan (Assignment Operator) 
    // fungsinya untuk mengisi nilai
    
    /*
Pengisian Nilai             =
Pengisian dan Penambahan    +=
Pengisian dan Pengurangan   -=
Pengisian dan Perkalian     *=
Pengisian dan Pembagian     /=
Pengisian dan Sisa bagi     %=
    */
    
    int a,b,cc;
    
    //=
    a = 1;
    b = 2;
    
    //+=
    a+=b; // artinya a = a + b; 3
     Console.WriteLine( "a+=b : "+a);
    a-=b; // artinya a = a - b; -1
     Console.WriteLine( "a-=b : "+a);
    a*=b; // artinya a = a x b; 2
     Console.WriteLine( "a*=b : "+a);
    a/=b; // artinya a = a / b; 0,5 / 1 karena int
     Console.WriteLine( "a/=b : "+a);
    a%=b; // artinya a = a % b;  1
     Console.WriteLine( "a%=b : "+a);
     
     //-----------operator bitwise dengan style penugasan
     //operasi berdasarkan biner
     /*
    AND             &
    OR              |
    XOR             ^
    NOT/komplemen   ~
    Left Shift      <<
    Right Shift     >>
    */
    Console.WriteLine("a : "+a+", b : "+b);
    a<<=b; // artinya a = a << b; menggunakan rumus biner | 0101010
     Console.WriteLine( "a<<=b : "+a);
    a>>=b; // artinya a = a >> b; menggunakan rumus biner | 0101010
     Console.WriteLine( "a>>=b : "+a);
    a&=b; // artinya a = a & b; menggunakan rumus biner | 0101010
     Console.WriteLine( "a&=b : "+a);
    a|=b; // artinya a = a | b; menggunakan rumus biner | 0101010
     Console.WriteLine( "a|=b : "+a);
    a^=b; // artinya a = a ^ b; menggunakan rumus biner | 0101010
     Console.WriteLine( "a^=b : "+a);
     cc = ~a;
     Console.WriteLine( "~a : "+cc);
     cc = ~b;
     Console.WriteLine( "~b : "+cc);
    
    
    
    Console.WriteLine( "----------------------perbandingan\n");
    
    //----------------perbandingan
    //untuk membandingkan 2 buah nilai
    // menghasilkan true 1, dan false 0
    
    /*
Lebih Besar             >
Lebih Kecil             <
Sama Dengan             ==
Tidak Sama dengan       !=
Lebih Besar Sama dengan >=
Lebih Kecil Sama dengan <=
  */
  Console.WriteLine("a : "+a+", b : "+b);
  bool c;
  c = a > b;
  Console.WriteLine( "a>b : "+c);
  c = a < b;
  Console.WriteLine( "a<b : "+c);
  c = a == b;
  Console.WriteLine( "a==b : "+ c);
  c = a != b;
  Console.WriteLine( "a!=b : "+ c);
  c = a >= b;
  Console.WriteLine( "a>=b : "+ c);
  c = a <= b;
  Console.WriteLine( "a<=b : "+ c);
  
 
 //---------------operator logika
 
 Console.WriteLine( "-------------------logika\n");
 
 /*
Logika AND        true  && true = true, sisanya false
Logika OR         false  || false = false, sisanya true
Negasi/kebalikan    !true = false, !false = true
*/
// a=1, b=2

Console.WriteLine("a : "+a+", b : "+b);
Console.WriteLine("a && b : "+ (a==3&&b==2)); //false
Console.WriteLine("a || b : "+ (a==3||b==2)); //true
Console.WriteLine( "!a : "+ !(a==3||b==2)); //false
Console.WriteLine( "!b : "+ !(a==3&&b==2));//true


//---------------operator lain-lain

Console.WriteLine( "---------------------- operator lain-lain\n");

/*
Alamat memori   &   untuk mengambil alamat memori
Pointer         *   untuk membuat pointer
Ternary         ? : untuk membuat kondisi
Increment       ++  untuk menambah 1
Decrement       --  untuk mengurangi 1

*/
//web tidak support unsafe
// int ptr1= 0;
// unsafe {
//     int* ptr2 = &ptr1;
//     *ptr2 = 220;
// }
// Console.WriteLine("ambil tempat memori variable d : "+ ptr1);
Console.WriteLine("apakah 1 = 2 ? : "+ ((1 == 2) ? "iya" : "tidak"));
int var = 7;
//karna di yang di proses pertama adalah operasi/variable lalu baru string jadi saya akali dengan menanmbahkan -1 dan +1
Console.WriteLine(var+" ditambahkan satu kali : " + (++var)); 
Console.WriteLine(var+" dikurangkan satu kali : " + (--var));
Console.WriteLine(var+" ditambahkan satu kali : " + (var++)); //ditampilkan dlu baru di tambah jadinya akan tetap 
Console.WriteLine("setelah di ditambah satu kali : "+var); //hasil sebenarnya
Console.WriteLine(var+" dikurangkan satu kali : " + (var--)); //ditampilkan dlu baru di tambah jadinya akan tetap 
Console.WriteLine("setelah di kurangi satu kali : "+var); //hasil sebenarnya

    


    }
}
