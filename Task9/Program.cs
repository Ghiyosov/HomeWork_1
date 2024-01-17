int a;
a = Convert.ToInt32(Console.ReadLine());
for (int i = a; i > 0; i /= 10) 
{
    Console.Write(i%10);
}
