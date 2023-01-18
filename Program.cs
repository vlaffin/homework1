//1 задача

Console.WriteLine("введите первое число");
int number1 = int.Parse(Console.ReadLine());


Console.WriteLine("введите второе число");
int number2 = int.Parse(Console.ReadLine());

if (number1<number2)
{
Console.WriteLine ("наибольшее число = " +  number2);
Console.WriteLine ("наименьшее число = " +  number1);
}
else
{
Console.WriteLine ("наибольшее число = " + number1);
Console.WriteLine ("наименьшее число = " + number2);
}

