class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите элементы массива через пробел:");
        string[] inputArray = Console.ReadLine().Split(); // Вводим элементы массива с клавиатуры

        int count = 0; // Переменная для подсчета количества элементов длиной меньше или равной 3 символам

        for (int i = 0; i < inputArray.Length; i++) // Перебираем все элементы массива
        {
            if (inputArray[i].Length <= 3) // Проверяем длину каждого элемента
            {
                count++; // Увеличиваем счетчик, если элемент подходит по условию
            }
        }

        string[] newArray = new string[count]; // Создаем новый массив нужной длины

        int newIndex = 0; // Переменная для индексации нового массива

        for (int i = 0; i < inputArray.Length; i++) // Перебираем все элементы исходного массива
        {
            if (inputArray[i].Length <= 3) // Проверяем длину каждого элемента
            {
                newArray[newIndex] = inputArray[i]; // Добавляем элемент в новый массив
                newIndex++; // Увеличиваем индекс нового массива
            }
        }

        Console.WriteLine("Новый массив, содержащий элементы длиной не более 3 символов:");
        for (int i = 0; i < newArray.Length; i++) // Выводим элементы нового массива
        {
            Console.WriteLine(newArray[i]);
        }
    }
}