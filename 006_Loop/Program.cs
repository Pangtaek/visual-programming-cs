int sum = 0;
int oddsum = 0;         // 홀
int evensum = 0;        // 짝
double rsum = 0;               // 역수
for (int i = 1; i <= 100; i++)
{
    sum += i;
    rsum += 1.0 / i;
    if ((i % 2) != 0)
        oddsum += i;
    else
        evensum += i;
}
Console.WriteLine("1~100까지의 합:"+sum);
Console.WriteLine("1~100까지의 짝수의 합:" + evensum);
Console.WriteLine("1~100까지의 홀수의 합:" + oddsum);
Console.WriteLine("1~100까지의 역수의 합:" + rsum);