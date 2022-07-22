Console.Write("Laengenangabe in mm ? ");
int laenge = Convert.ToInt32(Console.ReadLine());

int mm = laenge % 10;
int x = laenge / 10;

int temp = x;
int cm = temp % 100;
int temp2 = temp / 100; 

int m = temp2 % 1000;
int km = temp2 % 100;

Console.WriteLine(laenge);
Console.WriteLine("mm " + mm);
Console.WriteLine(temp);
Console.WriteLine("cm " + cm);
Console.WriteLine(temp2);
Console.WriteLine("m " + m);
Console.WriteLine("km " + km);

Console.WriteLine($"{laenge} mm entsprechen {km}km {m}m {cm}cm {mm}mm");