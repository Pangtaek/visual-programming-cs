// List와 배열에 10개의 랜덤숫자를 저장하고 정렬

int[] a = new int[10];
List<int> b = new List<int>();
double[] c = new double[10];
Random r = new Random();

for(int i = 0; i < 10; i++)
{
    a[i] = r.Next(100);
    b.Add(a[i]);
    c[i] = r.NextDouble();          // 0~1 사이의 숫자
}

PrintArray(a);
PrintList(b);
PrintArray(c);

// 정렬
Array.Sort(a);
b.Sort();
Array.Sort(c);

Console.WriteLine("정렬완료");
Console.WriteLine();
PrintArray(a);
PrintList(b);
PrintArray(c);

void PrintArray<T>(T[] a)
{
    Console.WriteLine("--배열--");
    for(int i =0; i <a.Length; i++)
        Console.WriteLine(a[i]);
    Console.WriteLine();

     //foreach(var i in a)
     //    Console.WriteLine(i);
}

void PrintList(List<int> a)
{
    Console.WriteLine("--리스트--");
    foreach(int i in a)
        Console.WriteLine(i);
    Console.WriteLine();
}