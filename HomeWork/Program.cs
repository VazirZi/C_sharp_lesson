//====================Первая_программа====================

/*
Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 == number2)     //--проверяем, если числа равны, то выводим соответствующее сообщение
{
    Console.WriteLine("Введенные числа равны");
}
else if (number1 > number2)
{
    Console.WriteLine("Первое число " + "(" + number1 + ")" +" больше второго " + "(" + number2 + ")");
} 
else 
{
    Console.WriteLine("Второе число " + "(" + number2 + ")" +" больше первого " + "(" + number1 + ")");
}
*/

//====================Вторая_программа====================

/*
Console.Write("Введите количество чисел: ");
int count = Convert.ToInt32(Console.ReadLine());

int[] numbers = new int[count]; //--объявляем динамический массив для записи нужного количества чисел

int index = 0;

while (index < count)           //--организуем цикл для записи чисел в массив
{
    Console.Write("Введите число: ");
    numbers[index] = Convert.ToInt32(Console.ReadLine());
    index++;
}

index = 0;                  //--обнуляем индекс для дальнейшего использования в цикле
int max = numbers[0];       //--принимаем за максимальное значение первый элемент массива

while (index < count-1)
{
    if (numbers[index+1] > max)
    {
        max = numbers[index+1];
    }
    index++;
}

Console.Write("Максимальное число = " + max);
*/

//====================Третья_программа====================

/*
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine("Число четное");
}
else 
{
Console.WriteLine("Число НЕчетное");
}
*/

//====================Четвертая_программа====================

/*
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int index = 1;

Console.WriteLine(index);       //--выводим единицу (так как по условию задачи от 1 до N)

index++;                        //--доводим index до четного числа (здесь index = 2)

while (index <= number)
{
    Console.WriteLine(index);
    index+=2;                   //--увеличиваем index на 2 для выведения четных чисел
}
*/