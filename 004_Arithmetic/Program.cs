double x, y;

Console.WriteLine("첫번째 수를 입력하시오.");
x = double.Parse(Console.ReadLine());

Console.WriteLine("두번째 수를 입력하시오.");
y  = double.Parse(Console.ReadLine());

Console.WriteLine(x + "+" + y + "={0}", x + y);
Console.WriteLine(x + "-" + y + "={0}", x - y);
Console.WriteLine(x + "*" + y + "={0}", x * y);
Console.WriteLine(x + "/" + y + "={0}", x / y);
Console.WriteLine(x + "%" + y + "={0}", x % y);