// See https://aka.ms/new-console-template for more information
int zaman =DateTime.Now.Hour;

if(zaman>=6 && zaman <= 12)
{
    Console.WriteLine("iyi günler!");
}
else if (zaman>12 && zaman<=18)
{
    Console.WriteLine("iyi günler!");
}
else
{
    Console.WriteLine("iyi geceler!");
}
Console.WriteLine(zaman >= 6 && zaman <= 12 ? "iyi günler" : zaman > 12 && zaman <= 18 ? "iyi günler" : "iyi geceler");