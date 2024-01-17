int n , z=0, x=1;
n = Convert.ToInt32(Console.ReadLine());
int[] m = new int[n];
for (int i=0; i<n; i++)
{
    m[i] = Convert.ToInt32(Console.ReadLine());
    if ((m[i]>0 && z>0) || (m[i]<0 && z<0)) x++;
    z=m[i];


}
if (x>1) System.Console.WriteLine("YES");
else System.Console.WriteLine("NO");
