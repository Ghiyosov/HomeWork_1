int x = 2147483647, n;
n = Convert.ToInt32(Console.ReadLine());
int[] m = new int[n];
for (int i=0; i<n; i++)
{
    m[i] = Convert.ToInt32(Console.ReadLine());
    if (m[i] < x) x = m[i];
}
System.Console.Write(x);
