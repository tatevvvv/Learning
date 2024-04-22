
using OOADHW10;

int min = 1901;
int max = 2000;

Random rnd = new Random();
Console.WriteLine(Math.Floor((double)rnd.Next() * (max - min + 1) + min));
