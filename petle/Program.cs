using System;
//1
/*
for (int i = 1; i <= 100; i++) {

  Console.WriteLine(i);
    if (IsPrime(i))
    {
        Console.WriteLine(i);
    }
}
*/
//2
int numer =  0;
do {
    numer++;
    if (numer % 2 != 0) { continue; }
    Console.WriteLine(numer);

}
while (numer<1000);
/*
//3
//11235813

double a = 1;
double b = 2;
int x   = 0;
while (x < 100)
{
    double d = a + b;
    double e = d / b;
    double fi = e ; 
    x++;Console.WriteLine(fi);
    double a=b;
    double b = d;

}

//1+2=3
//  3+5=8
//8+5=13
*/
//4

for (int i = 0; i <= 10; i++)  { for (int u = 0; u <= 10; u+=2) { Console.WriteLine(" "); } Console.WriteLine(i);  }