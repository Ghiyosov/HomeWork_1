int x = 2147483647, n;
n = Convert.ToInt32(Console.ReadLine());
int[] m = new int[n];
for (int i=0; i>0; i++)
{
    m[i] = Convert.ToInt32(Console.ReadLine());
    if (n == 0) break;
    if (n < x) x = n;
}
System.Console.Write(x);
