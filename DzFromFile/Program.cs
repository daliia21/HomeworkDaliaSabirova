


//1. Вывести на экран число e (основание натурального логарифма) с точностью до
// десятых.

//Console.WriteLine("Задание 1");

//double e = 1;
//for (int i = 1; i < 15; i++)
//{
//    e += 1.0 / Factorial(i);
//}
//Console.WriteLine(Math.Round(e, 1));

//int Factorial(int n)
//{
//    int factorial = 1;
//    for (int i = 1; i <= n; i++)
//        factorial *= i;

//    return factorial;
//}


//2. Вывести на экран числа 50 и 10 одно под другим.

//Console.WriteLine("Задание 2");

//Console.WriteLine(50);
//Console.WriteLine(10);


//3. Составить программу вывода на экран «столбиком» четырех любых чисел.

//Console.WriteLine("Задание 3");

//for (int i = 56; i < 60; i++)
//{
//    Console.WriteLine(i);
//}


//4. Пользователь вводит число. Выведите на экран число, которое больше введенного
// на 10.

//Console.WriteLine("Задание 4");

//int Number = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine(Number + 10);


//5. Дана сторона квадрата. Найти его периметр

//Console.WriteLine("Задание 5");

//int SquareSide = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine(SquareSide * 4);


//6. Дан радиус окружности. Найти длину окружности и площадь круга.

//Console.WriteLine("Задание 6");

//int Radius = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine(Radius * 2 * Math.PI);
//Console.WriteLine(Math.Pow(Radius, 2) * Math.PI); 


//7. Найти значение y=cos(x)

//Console.WriteLine("Задание 7");

//int x = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(Math.Cos(x));


//8. Даны основания и высота равнобедренной трапеции. Найти ее периметр.

//Console.WriteLine("Задание 8");

//double LowerBaseTrapezoid = Convert.ToDouble(Console.ReadLine());
//double UpperBaseTrapezoid = Convert.ToDouble(Console.ReadLine());
//double HeightTrapezoid = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine((LowerBaseTrapezoid + UpperBaseTrapezoid) / 2 * HeightTrapezoid);


//9. Известна стоимость 1 кг конфет, печенья и яблок. Найти стоимость всей покупки,
//если купили x кг конфет, у кг печенья и z кг яблок

//Console.WriteLine("Задание 9");

//double CandyPrise = Convert.ToDouble(Console.ReadLine());
//double СrackerPrice = Convert.ToDouble(Console.ReadLine());
//double ApplePrise = Convert.ToDouble(Console.ReadLine());

//double x = Convert.ToDouble(Console.ReadLine());
//double y = Convert.ToDouble(Console.ReadLine());
//double z = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine(CandyPrise * x + СrackerPrice * y + ApplePrise * z);


//10. Напишите программу, выводит на экран три строки "Мир", "Труд" и "Май"
//(кавычки не нужны). Причём сделайте, чтобы выводилось сначала так:
//Мир Труд Май
//Затем так:
//Мир
//    Труд
//         Май

//Console.WriteLine("Задание 10");


Console.WriteLine("Мир");
Console.WriteLine("     Труд");
Console.WriteLine("          Май");