int x, y, z;

Console.WriteLine("첫번째수");
x=int.Parse(Console.ReadLine());

Console.WriteLine("두번째수");
y = int.Parse(Console.ReadLine());

Console.WriteLine("세번째수");
z = int.Parse(Console.ReadLine());

Console.WriteLine("가장큰수 : "+Larger(Larger(x, y),z));

int  Larger(int x, int y)
{
    return (x > y) ? x : y;
}