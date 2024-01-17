int x = -2147483648, n;
n = Convert.ToInt32(Console.ReadLine());
var m = new int[n];
while (true)
{
    n = Convert.ToInt32(Console.ReadLine());
    if (n == 0) break;
    if (n > x) x = n;
}
System.Console.WriteLine(x);