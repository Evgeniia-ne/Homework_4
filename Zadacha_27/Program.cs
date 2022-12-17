// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.Clear();
int DataEntry(string str)
{
    Console.WriteLine(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

  int Sum(int number)
  {    
    int counter = Convert.ToString(number).Length;
    int ost = 0;
    int result = 0;

    for (int i = 0; i < counter; i++){
      ost = number - number % 10;
      result = result + (number - ost);
      number = number / 10;
    }
   return result;
  }
int number = DataEntry("Введите число: ");
int sum = Sum(number);
Console.WriteLine("Сумма цифр в числе: " + sum);