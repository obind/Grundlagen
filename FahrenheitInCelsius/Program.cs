Console.Write("Fahrenheit: ");
int fahrenheit = Convert.ToInt32(Console.ReadLine());

int zwischenschritt = fahrenheit - 32;

float ergebniss = zwischenschritt * 5/9;

Console.WriteLine($"{fahrenheit} °F sind {ergebniss} C°");
Console.ReadKey();

