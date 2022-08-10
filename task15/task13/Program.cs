Console.Write("Введи число: ");
int Number = int.Parse(Console.ReadLine());
if (Number > 99)
    Console.WriteLine((Number / 100) % 10);
else
    Console.WriteLine("-> третьей цифры нет");
