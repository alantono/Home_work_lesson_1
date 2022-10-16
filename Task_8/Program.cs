// программа, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N;

int a;
string userEnter_a;

Console.Write("Введите число ");
userEnter_a = Console.ReadLine();

a = int.Parse(userEnter_a);

int count = 1;
while(count < a)
{ 
    if(count%2==0) Console.Write($"{count}, ");
        
    count = count + 1;
}
