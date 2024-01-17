int a, b=0, c=1;
a = Convert.ToInt32(Console.ReadLine());
for (int i = a; i > 0; i /= 10) 
{
    b += i % 10;
    Console.Write((i%10)+"+");
}
Console.WriteLine("="+b);
for (int i = a; i > 0; i /= 10)
{
    c *= i % 10;
    Console.Write((i % 10) + "*");
}
Console.WriteLine("=" + c);