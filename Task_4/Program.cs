// программа, которая принимает на вход три числа и выдаёт максимальное из этих чисел;

int a, b, c, max;
string userEnter_a, userEnter_b, userEnter_c;

Console.Write("Введите первое число ");
userEnter_a = Console.ReadLine();
Console.Write("Введите второе число ");
userEnter_b = Console.ReadLine();
Console.Write("Введите третье число ");
userEnter_c = Console.ReadLine();


a = int.Parse(userEnter_a);
b = int.Parse(userEnter_b);
c = int.Parse(userEnter_c);
max = a;

if(a > max) max = a;
if(b > max) max = b;
if(c > max) max = c;

Console.WriteLine($"Максимальное из введенных чисел = {max}");