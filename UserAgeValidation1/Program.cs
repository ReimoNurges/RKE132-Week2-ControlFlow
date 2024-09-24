// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;

Console.WriteLine("Kui vana te olete?");
string vanus = Console.ReadLine();
int vanusArv = 0;
bool KasonArv = Int32.TryParse(vanus, out vanusArv);

//int vanus = Int32.Parse(Console.ReadLine());
if (KasonArv == true)
{
    if (vanusArv >= 13)
    {
        Console.WriteLine("Welcome to instagram");
    }
    else
    {
        Console.WriteLine("You are too young for instagram");
    }
}
else Console.WriteLine("Sisestage õige vanus");
