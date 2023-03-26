// Receba o nome do usuário. Escreva seu nome ninja:

String Nome;
String NomeNinja;

Console.WriteLine("----Nome Ninja----");
Console.WriteLine();

Console.Write("Digite seu Nome:");
Nome = Console.ReadLine()!;

NomeNinja = Nome.Trim().ToLower()      
.Replace("a", "KA")
.Replace("b", "ZU")
.Replace("c", "MI")
.Replace("d", "TE")
.Replace("e", "KU")
.Replace("f", "LU")
.Replace("g", "JI")
.Replace("h", "RI")
.Replace("i", "KI")
.Replace("j", "ZUS")
.Replace("k", "ME")
.Replace("l", "TA")
.Replace("m", "RIN")
.Replace("n", "TO")
.Replace("o", "MO")
.Replace("p", "NO")
.Replace("q", "KE")
.Replace("r", "SHI")
.Replace("s", "ARI")
.Replace("t", "CHI")
.Replace("u", "DO")
.Replace("v", "RU")
.Replace("w", "MEI")
.Replace("x", "NA")
.Replace("Y", "FU")
.Replace("Z", "ZI");

Console.WriteLine();
Console.WriteLine($"seu Nome Ninja é {NomeNinja}");


