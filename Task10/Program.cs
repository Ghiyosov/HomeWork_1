int a;
a= Convert.ToInt32(Console.ReadLine());
int[] m = new int[a];
for (int i = 0; i < a; i++) m[i] = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < a; i++) 
{
    int x = 0;
    for (int j = 1; j <= m[i] ; j++) 
    {
        if ((m[i]%j) == 0) 
        {
            x++;
        }
    }
    if (x>2) Console.Write(m[i]+" ");
}