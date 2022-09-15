double weight, height;

Console.WriteLine("체중을 입력하시오.");
weight = double.Parse(Console.ReadLine());

Console.WriteLine("신장을 입력하시오.");
height = double.Parse(Console.ReadLine());

double bmi = weight / (height / 100 * height / 100);
Console.WriteLine("BMI = "+bmi);
if(bmi<20)
    Console.WriteLine("저체중");
else if (bmi < 25)
    Console.WriteLine("정상체중");
else if (bmi < 30)
    Console.WriteLine("경도비만");
else if (bmi < 40)
    Console.WriteLine("비만");
else
    Console.WriteLine("고도비만");
