// Задача 41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.WriteLine ("Введите числа:");
string numbers = Console.ReadLine();
// перебираем каждый элемент строки. кладем его в массив.
string [] newNumbers = new string [numbers.Length];
int c = 0;
for (int i = 0; i < newNumbers.Length; i++)
{
  if (numbers[i] == ',')
  {
    c++;
  }
  else
  {
    newNumbers[c] = newNumbers[c]+$"{numbers[i]}";
  }
}
c++;
int [] resultNumbers = new int[c];
PrintArray (resultNumbers, newNumbers);
int sum = 0;
for (int i = 0; i < c; i++)
{
  if (resultNumbers[i]>0)
  {
    sum++;
  }
}
Console.WriteLine ("Количество чисел больше 0: "+sum);

void PrintArray (int [] array, string [] string1)
{
  for (int i = 0; i < array.Length; i++)
  {
  array[i] = Convert.ToInt32(string1[i]);
  Console.Write (array[i]+"  ");
  }
Console.WriteLine();
}
