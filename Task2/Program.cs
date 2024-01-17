double a, n, z=0;
 a = Convert.ToInt32(Console.ReadLine());
 n = Convert.ToInt32(Console.ReadLine());
 for (int i=0; i<=n; i++) {
    z+=Math.Pow(a,i);
 }
 System.Console.WriteLine(z);
