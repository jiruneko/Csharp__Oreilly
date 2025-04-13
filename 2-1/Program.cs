int a = 19;
int b = 23;
int c;
c = a + b;
Console.WriteLine(c);

// double a = 1, b = 2.5, c = -3;
// double x = (-b + Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
// Console.WriteLine(x);

int number;
Console.WriteLine(number = 123);
Console.WriteLine(number);

int x, y;
x = y = 0;
Console.WriteLine(x);
Console.WriteLine(y);

int i = 42;
int i2 = (int)42.0;
int i3 = (int)(i / 1.0);

Console.WriteLine(i);
Console.WriteLine(i2);
Console.WriteLine(i3);

double di = i;
Console.WriteLine(i / 5);
Console.WriteLine(di / 5);
Console.WriteLine(i / 5.0);

int willFail = (int)42.0;
int willAlsoFail = (int)(i / 1.0);

Console.WriteLine(willFail);
Console.WriteLine(willAlsoFail);
