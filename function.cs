//penulisan fungsi
/*<visibility> <return type> <name>(<parameters>)
{
    <function code>
}
*/
//visibility = public private static
using System;
class Program {
  static void Main() {
   Console.WriteLine("function" );
   Console.WriteLine("-------------" );
    //function / fungsi adalah suatu bagian dari program yang dipergunakan untuk mengerjakan suatu tugas tertentu yang menghasilkan 
    //suatu nilai untuk dikembalikan ke program pemanggil dan letaknya dipisahkan dari bagian program yang menggunakannya.
    //public static void main(String[] args) ini adalah fungsi utama dari java
   Console.WriteLine("----------------- penulisan fungsi" );

    //cetak kata dengan membuat object 
    //karena kita tidak membuat fungsi static jadi kita harus memanggil object class ini dlu baru 
    cetak_kata("ini adalah kata yang akan di cetak");
   

   Console.WriteLine("ini adalah int yg di kembalian : " + kembalian_angka() );
   Console.WriteLine("ini adalah bool yg di kembalian : " + kembalian_bool() );
   Console.WriteLine("ini adalah float yg di kembalian : " + kembalian_float() );
    // ini 2 nilai yang mau di tambahkan
    int angka_1 = 10;
    int angka_2 = 20;
   Console.WriteLine("----------------- fungsi dengan parameter" );
    // lalu masukkan ke 2 nilai ini ke fungsi
    //tambah(angka_1, angka_2); // cara memasukkan nilai ke parameter
    //ini tidak akan di cetak ke console karena belum di cout
   Console.WriteLine(angka_1 + " + " + angka_2 + " = " + tambah(angka_1,angka_2) );
    // ini adalah fungsi yg sangat sederhana, mungkin akan lebih baik langsung membuatnya tanpa fungsi
    //namun bagaimana kalau kita akan menambahkan banyak penjumalahan?
    //kita tidak mungkin membuatnya satu per-satu,
    // maka dengan adanya fungsi kita dengan mudah mengganti parameternya saja;
    //contoh
    angka_1 = 5; // nilainya akan di timpa
    angka_2 = 5;// nilainya akan di timpa
   Console.WriteLine(angka_1 + " + " + angka_2 + " = " + tambah(angka_1,angka_2) );
    //atau agar lebih mudah kita bisa menggunakan void untuk membuat coutnya
    angka_1 = 7;
    angka_2 = 9;
    cetak_perjumlahan(angka_1,angka_2); // mencetak dengan fungsi
   
    }

static void tampil_kata(){ // ini adalah fungsi static berfungsi agar bisa langsung memanggilnya tanpa membuat object
   Console.WriteLine("hello" ); // ini adalah program yang dijalankan apabila kita memanggil fungsi tersebut
}
    
static void tampil(){ //fungsi ini tanpa static, jadi saat pemanggilan kita memanggilnya dengan memnggil object baru fungsi
   Console.WriteLine("hai" );
}
//ada 2 jenis fungsi yaitu fungsi dengan mengembalikan sebuah nilai / atau tanpa dikembalikan
//tanpa kembalian yaitu menggunakan awalan void
//kalau mengembalikan nilai walannya berupa nilai type data yang mau di dikembalikan
//contoh kalau kita mengeluarkan nilai angka maka menggunakan int
//jika menggunakan kembalian maka akan harus menggunakan return
static int kembalian_angka(){
    return 12;
}

static bool kembalian_bool(){
    return true;
}

static float kembalian_float(){
    return 19.5f;
}


// fungsi dengan parameter
// jika dalam fungsi memiliki masukkan yang tidak di ketahui / memiliki banyak 
// Parameter ini akan menyimpan nilai yang diinputkan ke fungsi 
//contoh fungsi untuk mencetak string namun string tidak di ketahui / mau di diinputkan
static void cetak_kata(String kata){
   Console.WriteLine("kata yang di masukkan ke parameter : " + kata );
}


//contoh fungsi untuk mengembalikan 2 nilai yang di tambahkan namun 2 nilai ini tidak di ketahui angkanya

static int tambah(int nilai_1, int nilai_2){ //nilai_1 dan nilai_2 yang bertipe int itu Parameter
    int hasil = nilai_1 + nilai_2; // proses menghitung nilai
    return hasil; // mengembalikan nilai hasil
}
// membuat void cout untuk menampilkan keterangan cout perjumlahannya

static void cetak_perjumlahan(int angka_1, int angka_2){
   Console.WriteLine(angka_1 + " + " + angka_2 + " = " + tambah(angka_1,angka_2) ); // mengambil fungsi di dalam fungsi
}


}
