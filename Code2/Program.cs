class Program
{
    static void Main(string[] args)
    {
        //Инициализация исходного массива строк
        string[] origArray = {"retro", "hello", "wq", "por", "hiller"};
        //Создание итогового массива строк
        string[] newArray = new string[origArray.Length];
        int newIndex = 0;

        //Итерирование по исходному массиву
        for (int i = 0; i < origArray.Length; i++)

        {
            // Проверка длины строки
            if (origArray[i].Length <= 3)

            {
                //Добавление строки в новый массив
                newArray[newIndex] = origArray[i];
                newIndex++;
            }
        }
        //Вывод результата
        Console.WriteLine("Новый массив строк:");
        for (int i = 0; i < newIndex; i++)
    {
        Console.WriteLine(newArray[i]);
    }
    }
}