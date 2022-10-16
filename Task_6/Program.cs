// программа, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

int a;
string userEnter_a;

Console.Write("Введите число ");
userEnter_a = Console.ReadLine();

a = int.Parse(userEnter_a);

if(a%2==0) 
{
    Console.WriteLine($"Число = {a} - четное");
}
else
{
    Console.WriteLine($"Число = {a} - нечетное");
}