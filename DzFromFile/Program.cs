


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

////Console.WriteLine("Задание 9");

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

//Console.WriteLine("Мир Труд Май");
//Console.WriteLine("Мир");
//Console.WriteLine("\tТруд");
//Console.WriteLine("\t\tМай");

//11. Программа просит пользователя ввести 2 числовые переменные. А после она
//меняет их местами и выводит результат на экран. Но, так как пользователь может
//ошибиться, необходимо предусмотреть тот факт, что пользователь может ввести,
//например, букву или строку, а так же учесть, что число может быть дробным, и для
//выделения её дробной части одни используют точку, другие – запятую.

//Console.WriteLine("Задание 11");

//double num1;
//double num2;


//while (true)
//{
//    Console.WriteLine("Введите первое число:");

//    string input = Console.ReadLine().Replace(".", ",");

//    if (Double.TryParse(input, out num1))
//    {
//        break;
//    }
//}


//while (true)
//{
//    Console.WriteLine("Введите второе число:");

//    string input = Console.ReadLine().Replace(".", ",");

//    if (Double.TryParse(input, out num2))
//    {
//        break;
//    }
//}


//double t = num1;
//num1 = num2;
//num2 = t;


//Console.WriteLine($"Первое число: {num1}");
//Console.WriteLine($"Второе число: {num2}");


//12. Программа для подсчета периметра и площади фигур (треугольник,
//четырехугольник, круг). Пользователь выбирает фигуру, указывает, что программа
//будет считать – площадь или периметр. Задаётся все необходимые значения, а на
//основе полученных результатов, программа должна подсчитать, какими могли бы
//быть периметры или площади остальных фигур.

//Console.WriteLine("Задание 12");

//double? area = null;
//double? perimeter = null;

//Console.WriteLine("Введите наименование фигуры (triangle, quadrilateral, circle):");
//string choiceFigure = Console.ReadLine();

//Console.WriteLine("Что считать (area, perimeter):");
//string choiceAction = Console.ReadLine();

//if (choiceFigure == "triangle")
//{
//    if (choiceAction == "area")
//    {
//        Console.WriteLine("Введите длину основания треугольника:");
//        double baseLength = double.Parse(Console.ReadLine());
//        Console.WriteLine("Введите высоту треугольника:");
//        double height = double.Parse(Console.ReadLine());
//        area = 0.5 * baseLength * height;
//    }
//    else if (choiceAction == "perimeter")
//    {
//        Console.WriteLine("Введите длины сторон треугольника:");
//        double sideA = double.Parse(Console.ReadLine());
//        double sideB = double.Parse(Console.ReadLine());
//        double sideC = double.Parse(Console.ReadLine());
//        perimeter = sideA + sideB + sideC;
//    }
//}
//else if (choiceFigure == "quadrilateral")
//{
//    Console.WriteLine("Введите длину и ширину четырёхугольника:");
//    double length = double.Parse(Console.ReadLine());
//    double width = double.Parse(Console.ReadLine());

//    if (choiceAction == "area")
//    {
//        area = length * width;
//    }
//    else if (choiceAction == "perimeter")
//    {
//        perimeter = 2 * (length + width);
//    }
//}
//else if (choiceFigure == "circle")
//{
//    Console.WriteLine("Введите радиус круга:");
//    double radius = double.Parse(Console.ReadLine());

//    if (choiceAction == "area")
//    {
//        area = Math.PI * radius * radius;
//    }
//    else if (choiceAction == "perimeter")
//    {
//        perimeter = 2 * Math.PI * radius;
//    }
//}
//else
//{
//    Console.WriteLine("Неизвестная фигура.");
//}

//if (choiceAction == "area" && area != null)
//{
//    Console.WriteLine($"Площадь: {area}");
//}
//else if (choiceAction == "perimeter" && perimeter != null)
//{
//    Console.WriteLine($"Периметр: {perimeter}");
//}
//else
//{
//    Console.WriteLine("Неверный выбор действия или данные для расчета отсутствуют.");
//}


//13.Составить программу вывода на экран числа, вводимого с клавиатуры. Вводимому
//числу должно предшествовать сообщение «Вы ввели число».

//Console.WriteLine("Задание 13");

//double num;

//Console.WriteLine("Введите число:");

//string input = Console.ReadLine();

//if (Double.TryParse(input, out num))
//{
//    Console.WriteLine($"Ваше введенное число: {num}");
//}
//else
//{
//    Console.WriteLine("Вы ввели не корректное число");
//}


//14.Составить программу вывода на экран следующей информации:
//2 кг
//13 17

//Console.WriteLine("Задание 14");

//Console.WriteLine("2 кг");
//Console.WriteLine("13 17");


//15. Составить программу вывода на экран «столбиком» четырех случайных чисел.

//Console.WriteLine("Задание 15");

//Random random = new Random();  

//Console.WriteLine("Четыре случайных числа:");

//for (int i = 0; i < 4; i++)   
//{
//    int randomNumber = random.Next(-1000, 1000);  
//    Console.WriteLine(randomNumber);         
//}


//16.Найти корни квадратного уравнения(коэффициента задаются пользователем с
//клавиатуры)

//Console.WriteLine("Задание 16");

//Console.WriteLine("Введите коэффициенты квадратного уравнения");

//double a = double.Parse(Console.ReadLine());
//double b = double.Parse(Console.ReadLine());
//double c = double.Parse(Console.ReadLine());

//double discriminant = b * b - 4 * a * c;

//if (discriminant > 0)
//{
//    double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
//    double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
//    Console.WriteLine($"Корни уравнения: x1 = {x1} и x2 = {x2}");

//}

//else if (discriminant == 0)
//{
//    double x = -b / (2 * a);
//    Console.WriteLine($"Корень уравнения: x1 = {x}");
//}

//else
//{
//    Console.WriteLine("Уравнение не имеет действительных корней");
//}


//17.Даны два целых числа. Найти: а) их среднее арифметическое; б) их среднее
//геометрическое.

//Console.WriteLine("Задание 17");

//Console.WriteLine("Введите два целых числа");

//double a = double.Parse(Console.ReadLine());
//double b = double.Parse(Console.ReadLine());

//Console.WriteLine($"Среднее арифметическое чисел - {(a + b) / 2}");
//Console.WriteLine($"Среднее геометрическое чисел - {Math.Sqrt((a * b))}");


//18.Известны координаты на плоскости двух точек. Составить программу вычисления
//расстояния между ними.

//Console.WriteLine("Задание 18");

//Console.WriteLine("Введите координаты x и y первой точки:");

//double x1 = double.Parse(Console.ReadLine());
//double y1 = double.Parse(Console.ReadLine());

//Console.WriteLine("Введите координаты x и y второй точки:");

//double x2 = double.Parse(Console.ReadLine());
//double y2 = double.Parse(Console.ReadLine());

//Console.WriteLine($"Расстояние между точками - {Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1))}");


//19.Составить программу обмена значениями трех переменных величин а, b, c по
//следующим двум схемам:
//а) b присвоить значение c, а присвоить значение b, с присвоить значение а;
//б) b присвоить значение а, с присвоить значение b, а присвоить значение с.

//Console.WriteLine("Задание 19");

//Console.WriteLine("Введите значения a, b и c");

//int a = Convert.ToInt32(Console.ReadLine());
//int b = Convert.ToInt32(Console.ReadLine());
//int c = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine($"Исходные значения: a = {a}, b = {b}, c = {c}");

//int TemporaryA = a;

//a = b;
//b = c;
//c = TemporaryA;

//Console.WriteLine($"Значения после применения схемы: a = {a}, b = {b}, c = {c}");


//Console.WriteLine("Введите значения a, b и c");

//int a = Convert.ToInt32(Console.ReadLine());
//int b = Convert.ToInt32(Console.ReadLine());
//int c = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine($"Исходные значения: a = {a}, b = {b}, c = {c}");

//int TemporaryB = b;

//b = a;
//a = c;
//c = TemporaryB;

//Console.WriteLine($"Значения после применения схемы: a = {a}, b = {b}, c = {c}");


//20.С начала суток прошло n секунд. Определить:
//а) сколько полных часов прошло с начала суток;
//б) сколько полных минут прошло с начала очередного часа;
//в) сколько полных секунд прошло с начала очередной минуты.

//Console.WriteLine("Задание 20");

//int n = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine($"С начала суток прошло {n / 3600} полных часов");
//Console.WriteLine($"С начала очередного часа прошло {(n % 3600) / 60} полных минут");
//Console.WriteLine($"С начала очередной минуты прошло {(n % 60)} полных секунд");


//21.Дан прямоугольник с размерами 543 х 130 мм. Сколько квадратов со стороной 130
//мм можно отрезать от него?

//Console.WriteLine("Задание 21");

//int a = 543;
//int b = 130;
//int SideSquare = 130;

//Console.WriteLine(a / SideSquare);


//22.Дано трехзначное число. В нем зачеркнули последнюю справа цифру и приписали
//ее в начале. Найти полученное число.

//Console.WriteLine("Задание 22");

//int a = Convert.ToInt32(Console.ReadLine());

//int LastSybm = a % 10;

//Console.WriteLine($"{LastSybm}{a / 10}");


//23.Дано натуральное число n (n > 999). Найти:
//а) число сотен в нем;
//б) число тысяч в нем.

//Console.WriteLine("Задание 23");

//int n = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine($"Количество сотен: {n / 100}");
//Console.WriteLine($"Количество тысяч:{n / 1000}");


/*24.Дано четырехзначное число. Найти:
а) число, полученное при прочтении его цифр справа налево;
б) число, образуемое при перестановке первой и второй, третьей и четвертой цифр
заданного числа. Например, из числа 5434 получить 4543, из числа 7048 — 784;
в) число, образуемое при перестановке второй и третьей цифр заданного числа.
Например, из числа 5084 получить 5804;
г) число, образуемое при перестановке двух первых и двух последних цифр
заданного числа. Например, из числа 4566 получить 6645, из числа 7304 — 473.*/

//Console.WriteLine("Задание 24");

//int a = Convert.ToInt32(Console.ReadLine());

//int a1 = a / 1000;
//int a2 = (a / 100) % 10;
//int a3 = (a / 10) % 10;
//int a4 = a % 10;

//Console.WriteLine($"а){a4}{a3}{a2}{a1}");
//Console.WriteLine($"б){a2}{a1}{a4}{a3}");
//Console.WriteLine($"б){a1}{a3}{a2}{a4}");
//Console.WriteLine($"б){a3}{a4}{a1}{a2}");

