using System.IO;
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Pengulangan lanjutan x latihan");
   Console.WriteLine("-----------------");
    
    
    Console.WriteLine("----------- perulangan 2 dimensi");
   //pengulangan 2 dimensi yaitu baris dan kolom
   //000
   //000
   //
   //contoh pengulangan 2 dimensi
   for(int i = 1; i <= 5; i++){ // ini untuk baris 
       for(int j = 1; j <= 4; j++){ // ini untuk kolom | 5 baris 4 kolom
         Console.Write("baris ke " + i + " kolom ke " + j + "| ");  
       }
      Console.WriteLine( );
   }
  Console.WriteLine( );
   
   
  Console.WriteLine(" ------------ perulangan 3 dimensi");
   //perulangan 3 dimensi yaitu baris kolom 1 isi
   /*
| 1| 1| 1| | 1| 1| 2| | 1| 1| 3| -> baris
| 1| 2| 1| | 1| 2| 2| | 1| 2| 3| 
| 1| 3| 1| | 1| 3| 2| | 1| 3| 3| 
    isi         isi         isi
| 2| 1| 1| | 2| 1| 2| | 2| 1| 3| 
| 2| 2| 1| | 2| 2| 2| | 2| 2| 3| 
| 2| 3| 1| | 2| 3| 2| | 2| 3| 3| 
    isi         isi         isi
| 3| 1| 1| | 3| 1| 2| | 3| 1| 3| 
| 3| 2| 1| | 3| 2| 2| | 3| 2| 3| 
| 3| 3| 1| | 3| 3| 2| | 3| 3| 3| 
    isi         isi         isi
    
kolom
   */
   for(int i = 1; i<=3; i++){ // baris
       for(int j = 1; j<=3; j++){ //kolom
           for(int k = 1; k<=3; k++){ //isi (kolom baris)
           Console.Write("| " + i + "| " + j + "| " + k + "|\t");
            
            }
            Console.WriteLine();
        }
       Console.WriteLine( );
}

  Console.WriteLine(" ------------ perulangan 3 dimensi ++ ");
   
    // lebih dari 3 dimensi sama kayak 3 dimensi tapi isinya 
    /*
| 1| 1| 1| 1|   | 1| 1| 1| 2|   | 1| 1| 1| 3|   
| 1| 1| 2| 1|   | 1| 1| 2| 2|   | 1| 1| 2| 3|   
| 1| 1| 3| 1|   | 1| 1| 3| 2|   | 1| 1| 3| 3|   
    isi1            isi1            isi1
| 1| 2| 1| 1|   | 1| 2| 1| 2|   | 1| 2| 1| 3|   
| 1| 2| 2| 1|   | 1| 2| 2| 2|   | 1| 2| 2| 3|   
| 1| 2| 3| 1|   | 1| 2| 3| 2|   | 1| 2| 3| 3|   
  isi1            isi1            isi1
| 1| 3| 1| 1|   | 1| 3| 1| 2|   | 1| 3| 1| 3|   
| 1| 3| 2| 1|   | 1| 3| 2| 2|   | 1| 3| 2| 3|   
| 1| 3| 3| 1|   | 1| 3| 3| 2|   | 1| 3| 3| 3|   
  isi1            isi1            isi1
                    isi 2
                    
| 2| 1| 1| 1|   | 2| 1| 1| 2|   | 2| 1| 1| 3|   
| 2| 1| 2| 1|   | 2| 1| 2| 2|   | 2| 1| 2| 3|   
| 2| 1| 3| 1|   | 2| 1| 3| 2|   | 2| 1| 3| 3|   
  isi1            isi1            isi1
| 2| 2| 1| 1|   | 2| 2| 1| 2|   | 2| 2| 1| 3|   
| 2| 2| 2| 1|   | 2| 2| 2| 2|   | 2| 2| 2| 3|   
| 2| 2| 3| 1|   | 2| 2| 3| 2|   | 2| 2| 3| 3|   
  isi1            isi1            isi1
| 2| 3| 1| 1|   | 2| 3| 1| 2|   | 2| 3| 1| 3|   
| 2| 3| 2| 1|   | 2| 3| 2| 2|   | 2| 3| 2| 3|   
| 2| 3| 3| 1|   | 2| 3| 3| 2|   | 2| 3| 3| 3|   
  isi1            isi1            isi1
                    isi2

| 3| 1| 1| 1|   | 3| 1| 1| 2|   | 3| 1| 1| 3|   
| 3| 1| 2| 1|   | 3| 1| 2| 2|   | 3| 1| 2| 3|   
| 3| 1| 3| 1|   | 3| 1| 3| 2|   | 3| 1| 3| 3|   
  isi1            isi1            isi1
| 3| 2| 1| 1|   | 3| 2| 1| 2|   | 3| 2| 1| 3|   
| 3| 2| 2| 1|   | 3| 2| 2| 2|   | 3| 2| 2| 3|   
| 3| 2| 3| 1|   | 3| 2| 3| 2|   | 3| 2| 3| 3|   
  isi1            isi1            isi1
| 3| 3| 1| 1|   | 3| 3| 1| 2|   | 3| 3| 1| 3|   
| 3| 3| 2| 1|   | 3| 3| 2| 2|   | 3| 3| 2| 3|   
| 3| 3| 3| 1|   | 3| 3| 3| 2|   | 3| 3| 3| 3|   
  isi1            isi1            isi1
                    isi3
    */

   for(int i = 1; i<=3; i++){ // baris
       for(int j = 1; j<=3; j++){ //kolom
           for(int k = 1; k<=3; k++){ // 1 isi (kolom, baris)
                for(int l = 1; l <=3; l ++){ // 2 isi(kolom, baris)
                        Console.Write("| " + i + "| " + j + "| " + k + "| " + l + "|\t"); 
                }
               Console.WriteLine( );
            
            }
            Console.WriteLine();
        }
       Console.WriteLine( );
}

Console.WriteLine("--------------fariasi loop");
//loop bisa dibuat variasi seperti membuat segitiga atau bintang atau yang lainnya tergantung sebagaimana bagusnya kita memahami for loop itu sendiri
//contoh fariasi

Console.WriteLine("fariasi 1");
   for(int i = 0; i<=3; i++){ 
       for(int j = 0; j<=i; j++){ 
           Console.Write("o ");
       }
      Console.WriteLine( );
   }
  Console.WriteLine( );

  Console.WriteLine("fariasi 2.1"); //decrment
   for(int i = 0; i<=3; i++){ 
       for(int j = 3; j>=i; j--){ 
           Console.Write("o ");
       }
      Console.WriteLine( );
   }
  Console.WriteLine( );

  Console.WriteLine("fariasi 2.2");// increment
   for(int i = 0; i<=3; i++){ 
       for(int j = i; j<=3; j++){ 
           Console.Write("o ");
       }
      Console.WriteLine( );
   }
  Console.WriteLine( );
   
   
  Console.WriteLine("fariasi 3.1"); //dengan spasi
     for(int i = 0; i<=3; i++){ 
       for(int j = 0; j<i; j++){ 
           Console.Write(" ");
       }
        for(int k = 4; k>i; k--){ 
           Console.Write("o ");
       }
      Console.WriteLine( );
   }
  Console.WriteLine( );
   
  Console.WriteLine("fariasi 3.2"); //dengan calculate
     for(int i = 0; i<=3; i++){ 
       for(int j = 0; j<i; j++){ 
           Console.Write("  ");
       }
        for(int k = 3; k>=(2*i-3); k--){ 
           Console.Write("o ");
       }
      Console.WriteLine( );
   }
  Console.WriteLine( );
   
   Console.WriteLine("fariasi 4.1"); // dengan space
     for(int i = 0; i<=3; i++){ 
       for(int k = i; k<3; k++){ 
           Console.Write(" ");
       }
       for(int j = 0; j<=i; j++){ 
           Console.Write("o ");
       }
      
      Console.WriteLine( );
   }
  Console.WriteLine( );
   
    Console.WriteLine("fariasi 4.2"); // dengan calculate
      for(int i = 0; i < 5; i++){
        for(int j = 4; j > i; j--){
        Console.Write("  ");
        }
        for(int k = 0; k<(2*i-1); k++){
        Console.Write("o "); 
        }
  Console.WriteLine( );
   }
     Console.WriteLine( );
   

   
      Console.WriteLine("fariasi 5.1"); //decremet
     for(int i = 0; i<=3; i++){ 
       for(int j = 0; j<i; j++){ 
           Console.Write("  ");
       }
        for(int k = 3; k>=i; k--){ 
           Console.Write("o ");
       }
      Console.WriteLine( );
   }
  Console.WriteLine( );
     Console.WriteLine("fariasi 5.2"); //incrment
     for(int i = 0; i<=3; i++){ 
       for(int j = 0; j<i; j++){ 
           Console.Write("  ");
       }
        for(int k = i; k<=3; k++){ 
           Console.Write("o ");
       }
      Console.WriteLine( );
   }
  Console.WriteLine( );
   
           Console.WriteLine("fariasi 6.1"); // decrement
     for(int i = 0; i<=3; i++){ 
      for(int k = 3; k>i; k--){ 
           Console.Write("  ");
       }
       for(int j = 0; j<=i; j++){ 
           Console.Write("o ");
       }
       
      Console.WriteLine( );
   }
  Console.WriteLine( );
   
        Console.WriteLine("fariasi 6.2"); // incrment
     for(int i = 0; i<=3; i++){ 
      for(int k = i; k<3; k++){ 
           Console.Write("  ");
       }
       for(int j = 0; j<=i; j++){ 
           Console.Write("o ");
       }
       
      Console.WriteLine( );
   }
  Console.WriteLine( );
   
      Console.WriteLine("fariasi 7.1"); // dengan calculate
      for(int i = 1; i < 4; i++){
        for(int j = 4; j > i; j--){
        Console.Write("  ");
        }
        for(int k = 0; k<(2*i-1); k++){
        Console.Write("o "); 
        }
  Console.WriteLine( );
   }   
   for(int i = 0; i<=3; i++){ 
       for(int j = 0; j<i; j++){ 
           Console.Write("  ");
       }
        for(int k = 3; k>=(2*i-3); k--){ 
           Console.Write("o ");
       }
      Console.WriteLine( );
   }
     Console.WriteLine( );
      
      Console.WriteLine("fariasi 7.2"); //dengan spasi
     for(int i = 0; i<=3; i++){ 
       for(int k = i; k<3; k++){ 
           Console.Write(" ");
       }
       for(int j = 0; j<=i; j++){ 
           Console.Write("o ");
       }
      
      Console.WriteLine( );
   }
        for(int i = 1; i<=3; i++){ 
       for(int j = 0; j<i; j++){ 
           Console.Write(" ");
       }
        for(int k = 4; k>i; k--){ 
           Console.Write("o ");
       }
      Console.WriteLine( );
   }
  Console.WriteLine( );
   
   
   
  Console.WriteLine("fariasi 8");
      for(int i = 0; i<=3; i++){ 
       for(int j = i; j<=3; j++){ 
           Console.Write("o ");
       }
           for(int k = 1; k<=1; k++){ 
           Console.Write("  ");
       }
       for(int j = 0; j<=(2*i); j++){ 
           Console.Write("o ");
       }

          for(int j = 1; j<=1; j++){ 
           Console.Write("  ");
       }
        for(int k = i; k<=3; k++){ 
           Console.Write("o ");
       }
      
      Console.WriteLine( );
   }
   for(int i = 1; i<=3; i++){ 
       for(int j = 0; j<=i; j++){ 
           Console.Write("o ");
       }
         for(int j = 1; j<=1; j++){ 
           Console.Write("  ");
       }
        for(int k = (2*i-3); k<=3; k++){ 
           Console.Write("o ");
            
       }
        for(int k = 1; k<=1; k++){ 
           Console.Write("  ");
       }
       for(int j = 0; j<=i; j++){ 
           Console.Write("o ");
       }
      Console.WriteLine( );
   }
   
  Console.WriteLine( );
   
  Console.WriteLine("--------------perulangan dengan kondisi");
   //perulangan juga bisa memiliki kondisi 
   //seperti saat kita membuat perulangan angka ganjil
  Console.WriteLine("Membuat bilangan ganjil");
   for(int i = 0; i < 10; i++){
       //kondisi
       if(i%2 != 0){
          Console.Write( i +" ");
       }
   }
   
     Console.WriteLine( );
   
     Console.WriteLine("Membuat bilangan genap");
   for(int i = 0; i < 10; i++){
       //kondisi
       if(i%2 == 0){
          Console.Write( i +" ");
       }
   }
   
     Console.WriteLine( );
   
    Console.WriteLine("fariasi 4.3"); // dengan if
      for(int i = 0; i < 5; i++){
        for(int j = 4; j > i; j--){
        Console.Write("  ");
        }
        for(int k = 0; k<i; k++){
            if(k!=0){
            for(int l = 0; l < 2; l ++){
                Console.Write("o "); 
            }
            }else{
                Console.Write("o "); 
            }
        }
  Console.WriteLine( );
   }
   
  Console.WriteLine( );
    }
}
