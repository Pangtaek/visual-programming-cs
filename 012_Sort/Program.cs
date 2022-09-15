Random r = new Random();
int[] array = new int[10];

for (int i = 0; i < 10; i++)
{
    array[i] = r.Next(100);
    Console.Write(array[i] + "\t");
}
Console.WriteLine();

for(int i = 9; i > 0; i--)
{
    for(int j=0; j < i; j++)
    {
        if (array[j] > array[i])
        {
            int t = array[j];
            array[j] = array[i];
            array[i] = t;
        }
    }
}

for (int i = 0; i < 10; i++)
    Console.Write(array[i] + "\t");
Console.WriteLine();