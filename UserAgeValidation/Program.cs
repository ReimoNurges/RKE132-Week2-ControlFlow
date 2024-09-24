
// sugu
// perekonna nimi   
// 
//Welcome, Mr/Ms. [perekonnanimi]

Console.WriteLine("Mis on teie sugu?  m/f");
char gender = Char.Parse(Console.ReadLine());
Console.WriteLine("Mis on teie perekonnanimi?");
string pere = Console.ReadLine();
if (gender == 'm')
{
    string pronoun = ("Mr.");
    Console.WriteLine($"Welcome, {pronoun} {pere}");
}
else if (gender == 'f')
{
    string pronoun = ("Ms.");
    Console.WriteLine($"Welcome, {pronoun} {pere}");
}
else Console.WriteLine($"Welcome, {pere}");
