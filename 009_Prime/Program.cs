//int nPrime = 0;

//for(int x =2; x<=1000; x++)
//{
//    for(int i = 2; i < x; i++)
//    {
//        if (x % i == 0)
//            break;
//        if (x == i)
//        {
//            nPrime++;
//            Console.Write("{0}\t",x);
//        }
//    }
//    Console.WriteLine();
//    Console.WriteLine("개수 : {0}",nPrime);
//}

int nPrime = 0;
for (int x = 2; x <= 1000; x++)
{
    int i;
    for (i = 2; i < x; i++)
    {
        if (x % i == 0) // 소수가 아님
            break;
    }
    if (i == x)
    {
        Console.Write("{0}\t", x);
        nPrime++;
    }
}
Console.WriteLine();
Console.WriteLine("소수의 갯수 = {0}", nPrime);
