// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число: ");
int Number = Convert.ToInt32(Console.ReadLine());
string NumberThree = Convert.ToString(Number);

if (NumberThree.Length > 2){
    Console.WriteLine("третья цифра: " + NumberThree[2]);
}
else {
    Console.WriteLine("третей цифры нет");
}