int a, b=0, n=0;
while (true) 
{
    Console.WriteLine("Give a number:");
    Console.Write("> ");
    a = Convert.ToInt32(Console.ReadLine());
        if (a == 0) break;

    b += a;
    n++;
}
Console.WriteLine($"Total sum of numbers: {b}");
Console.WriteLine($"Total amount of numbers: {n}");