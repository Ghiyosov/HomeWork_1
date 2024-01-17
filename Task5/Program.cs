int a;
a= Convert.ToInt32(Console.ReadLine());
int[] m = new int[a];
for (int i = 0; i < a; i++) 
{
    m[i] = Convert.ToInt32(Console.ReadLine()); 
}
m = m.OrderBy(x => x).ToArray(); 
for (int i = 0; i < a; i++) 
{
    int l = 0;
    for (int j = 0; j < a ; j++) 
    {
        if ((m[i] == m[j]) && i!=j) 
        {
            l++;
        }
    }
    if (l>0) Console.Write(m[i]+" ");
}