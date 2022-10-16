// программа на вход принимает два числа и выдаёт, какое число большее, а какое меньшее;

int a, b;
string userEnter_a, userEnter_b;

Console.Write("Введите первое число ");
userEnter_a = Console.ReadLine();
Console.Write("Введите второе число ");
userEnter_b = Console.ReadLine();

a = int.Parse(userEnter_a);
b = int.Parse(userEnter_b);

if(a > b) Console.WriteLine($"Первое число = {a} и больше второго = {b}");
if(a < b) Console.WriteLine($"Второе число = {b} и больше первого = {a}");
if(a == b) Console.WriteLine($"Первое число:{a} и второе число:{b} - равны");
