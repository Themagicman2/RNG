using System;
Random randomerare = new();
int slump_tal = randomerare.Next(1, 101);
int försök = 0;
int svar;


do
{
Console.WriteLine("GISSA DET HEMLIGA TALET OCH VINN EN KAKA");

Console.Write("Gissa på ett tal mellan 1-100:    ");
 svar = Convert.ToInt32(Console.ReadLine());
försök++;


    if (svar < slump_tal)
    {
        Console.WriteLine(försök + " försöket, svaret är för lågt, gissa igen!");

    }
    else if (svar > slump_tal)
    {
        Console.WriteLine(försök + " försöket, svaret är för högt, gissa igen!");

    }
    if (Math.Abs(svar - slump_tal) < 4)
    {
        Console.WriteLine(försök + " försöket, det är VÄLDIGT nära...");
    }

} while (svar != slump_tal);


Console.WriteLine("GRATTIS, du vann en kaka!");

Console.ReadKey();
