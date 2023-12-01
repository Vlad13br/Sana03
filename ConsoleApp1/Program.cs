//Всі змінні для програми
int numberOfElements;
double NegativeElementsSum = 0;
double minElement = 0;
double maxElement = 0;
double MaxElementIndex = 0;
double maxAbsElement = 0;
double PositiveElementsSumOfIndex = 0;
double numberOfIntegers = 0;

bool isValidInput = false;

var arrayGenerator = new Random();

//Зчитування і валідація розміру масиву
do
{
    Console.Write("Введіть розмір масиву: ");
    isValidInput = int.TryParse(Console.ReadLine(), out numberOfElements);

    if (!isValidInput || numberOfElements <= 0)
    {
        Console.WriteLine("Неправильно введені дані. Розмір масиву повинен бути додатнім числом.");
    }

} while (!isValidInput || numberOfElements <= 0);

double[] randomNumbers = new double[numberOfElements];

//Генерація масиву
Console.Write("Елементи масиву: ");
for (int i = 0; i < numberOfElements; i++)
{
    double randomNumber = arrayGenerator.NextDouble() * 200 - 100;
    randomNumbers[i] = randomNumber;
    Console.Write($"{randomNumbers[i],9:F2} ");
}
//Обрахунок всіх значень
for (int i = 0; i < randomNumbers.Length; i++)
{
    double randomNumber = randomNumbers[i];

    if (randomNumber < 0) NegativeElementsSum += randomNumber;
    if (randomNumber < minElement) minElement = randomNumber;
    if (randomNumber > maxElement)
    {
        maxElement = randomNumber;
        MaxElementIndex = i; //Використовуємо i як індекс
    }
    if (Math.Abs(randomNumber) > maxAbsElement) maxAbsElement = Math.Abs(randomNumber);
    if (randomNumber > 0) PositiveElementsSumOfIndex += i; 
    if (randomNumber % 1 == 0) numberOfIntegers++;
}

//Форматований вивід в консоль знайдених значень
Console.WriteLine("\nСума від'ємних елементів масиву: {0:F2}", NegativeElementsSum);
Console.WriteLine("Мінімальний елемент масиву: {0:F2}", minElement);
Console.WriteLine("Індекс максимального елемента масиву: {0}", MaxElementIndex);
Console.WriteLine("Максимальний за модулем елемент масиву: {0:F2}", maxAbsElement);
Console.WriteLine("Сума індексів додатних елементів масиву: {0}", PositiveElementsSumOfIndex);
Console.WriteLine("Кількість цілих чисел у масиві: {0}", numberOfIntegers);
