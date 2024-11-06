//1. Вывести на экран число e (основание натурального логарифма) с точностью до
// десятых.

Console.WriteLine("Задание 1");

double e = 1;
for (int i = 1; i < 15; i++)
{
    e += 1.0 / Factorial(i);
}
Console.WriteLine(Math.Round(e, 1));

int Factorial(int n)
{
    int factorial = 1;
    for (int i = 1; i <= n; i++)
        factorial *= i;

    return factorial;
}

//2. Вывести на экран числа 50 и 10 одно под другим.

Console.WriteLine("Задание 2");

Console.WriteLine(50);
Console.WriteLine(10);

//3. Составить программу вывода на экран «столбиком» четырех любых чисел.

Console.WriteLine("Задание 3");

for (int i = 56; i < 60; i++)
{
    Console.WriteLine(i);
}

//4. Пользователь вводит число. Выведите на экран число, которое больше введенного
// на 10.

Console.WriteLine("Задание 4");

int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(number + 10);