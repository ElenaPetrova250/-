Console.Write("Введи трёхзначное число: ");
int threeNumber = int.Parse(Console.ReadLine());
string stringNumber = Convert.ToString(threeNumber);
Console.WriteLine("вторая цифра этого числа -> "+stringNumber[1]);
