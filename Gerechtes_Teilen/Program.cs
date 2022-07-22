//Gerechtes Teilen

Console.Write("Stueckzahl ? ");
int stueckzahl = Convert.ToInt32(Console.ReadLine());

Console.Write("Anzahl Empfänger ? ");
int empfaenger = Convert.ToInt32(Console.ReadLine());

int proEmpfaenger = stueckzahl / empfaenger;
int rest = stueckzahl % empfaenger;

Console.WriteLine(proEmpfaenger);
Console.WriteLine(rest);
Console.ReadKey();


