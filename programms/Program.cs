//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа

/*Console.Write("Введите трехзначное число: ");
int Value = Convert.ToInt32(Console.ReadLine());
int Length = Value.ToString().Length;
if (Length == 3)
{
    int result = (Value / 10) % 10;
    Console.WriteLine("Данным числом является " + result);
}
else
{
    Console.WriteLine("Введенное число не является трехзначным");
}
*/

//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*int Prompt(string msg)
{

System.Console.WriteLine($"{msg}");
return Convert.ToInt32(Console.ReadLine());
}
int number = Prompt("Введите число");

int fnumber(int number)
{
while (number > 999)
{
number /= 10;
}
return number % 10;
}

bool check(int number)
{
if (number < 100)
return false;
else return true;
}

if (check(number) != true)
System.Console.WriteLine("Третьей цифры нет");
else
System.Console.WriteLine($"Третья цифра числа {number} является {fnumber(number)}");*/

//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*int Prompt(string msg)
{

System.Console.WriteLine($"{msg}");
return Convert.ToInt32(Console.ReadLine());
}
int number = Prompt("Введите число");
string day = "Это не день недели";
string check(int number)
{
if (number >= 6 && number < 8) day = "Это выходной";
if (number >= 1 && number < 6) day = "Это будний день";
return day;
}
System.Console.WriteLine(check(number));
*/
//