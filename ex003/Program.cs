System.Console.WriteLine("Введите число, а магия определить четное оно или нет ");
string name = Console.ReadLine();
int number = Convert.ToInt32(name);
if (number % 2 == 0)
{
    System.Console.WriteLine("Ваше число четное");
} 
else 
{
    System.Console.WriteLine("Ваше число нечетное");
}    