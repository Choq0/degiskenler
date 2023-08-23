using System ;

// Integer tanımlama :

int deger1 =6;
int deger2= 7;
int deger3 = deger1 + deger2 ;

Console.WriteLine(deger3);

// Boolean

bool bool1 = 10 > deger1 ;

Console.WriteLine(bool1);

// Bize cevap True olarak dönecektir ==> çünkü deger1 = 6 olduğundan 10>6 True sonucunu verir.

string str20 = "20" ;
int int23 = 23 ;
string yenideger = str20 + int23.ToString() ;
Console.WriteLine(yenideger); 
// Burdan da çıktımız 2023 olarak gelecektir.


// Strin değeri int değere çevirmek için ise :


int intnew = int23 + Convert.ToInt32(str20) ;
Console.WriteLine(intnew);

// Yeni değerimiz 43 olarak bize dönecektir.

int int22 = int23 + int.Parse(str20) ;
Console.WriteLine(int22);

// Burdan da sonucumuz yine 43 gelecektir.

// DATETIME // 

string datetime = DateTime.Now.ToString("dd/MM/yyyy") ;
Console.WriteLine(datetime);

string datetime2 = DateTime.Now.ToString("dd.MM.yy") ;
Console.WriteLine(datetime2) ;

// Saat :

string hour = DateTime.Now.ToString("HH:mm") ;
Console.WriteLine(hour) ;
