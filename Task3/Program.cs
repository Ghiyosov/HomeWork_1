double a,b=2147483647,z=0;
while (true)
{
    a = Convert.ToInt32(Console.ReadLine());


    if (a<0) continue;
    

    if(b==a) break;

    b=a;
    z+=a;
}
System.Console.WriteLine(z);