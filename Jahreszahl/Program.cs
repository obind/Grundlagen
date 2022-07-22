Console.Write("Jahreszahl ? ");
int jahr = Convert.ToInt32(Console.ReadLine());

int x = jahr / 100;
int y = jahr % 100;
Console.WriteLine(x);
Console.WriteLine("2-stellige Jahreszahl " + y);
Console.ReadKey();