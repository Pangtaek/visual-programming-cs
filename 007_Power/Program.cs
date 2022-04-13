int x, y;
int result = 1;
Console.Write("정수:");
x = int.Parse(Console.ReadLine());

Console.Write("지수:");
y = int.Parse(Console.ReadLine());

for (int i = 1; i <= y; i++)
    result = result * x;

Console.WriteLine(x+"^"+y+"="+result);