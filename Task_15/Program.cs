// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру, обозначающую день недели: ");
int Number = Convert.ToInt32(Console.ReadLine());

if ( Number == 6 | Number == 7) {
    Console.WriteLine("Выходной день");
}
else if ( Number < 1 | Number >7) {
    Console.WriteLine("Это не день недели");
}
else {
    Console.WriteLine("Не выходной день");
}