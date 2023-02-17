// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int [] GetIntArrayFromString(string str)
{
    string [] nums = str.Split(" ");
    int [] res = new int [nums.Length];
    for (int i = 0; i < nums.Length; i++)
    {
        res [i] = int.Parse(nums[i]);
    }
    return res;
}

int CountPositiveNumbers (int [] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count ++;
    }
    return count;
}

Console.Write("Введите элементы через пробел: ");
string nums = Console.ReadLine();
int [] result = GetIntArrayFromString(nums);
int count = CountPositiveNumbers(result);
Console.WriteLine ($"Количество положительных чилел - {count}");