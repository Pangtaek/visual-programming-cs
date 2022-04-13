Random r = new Random();
int[] array = new int[10];

for(int i = 0; i < 10; i++)
{
    array[i] = r.Next(100);
}

int sum = 0;
int max = array[0];
int min = array[0];
foreach(var x in array)
{
    Console.Write(x+"\t");
    sum += x;
    if (x > max)
        max = x;
    if (x < min)
        min = x;
}

Console.WriteLine();
Console.WriteLine("합 : "+sum);
Console.WriteLine("최소 : "+min);
Console.WriteLine("최대 : "+max);