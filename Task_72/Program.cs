// Заданы 2 массива: info и data. В массиве info хранятся 
// двоичныепредставления нескольких чисел (без разделителя). 
// В массиве data хранится информация о количестве бит, 
// которые занимают числа из массива info.
// Напишите программу, которая составит массив десятичных 
// представлений чисел массива data с учётом информации 
// из массива info.
// входные данные:
//- data = {0, 1, 1, 1, 1, 0, 0, 0, 1 }
//- info = {2, 3, 3, 1 }
// выходные данные:
// - 1, 7, 0, 1
// решение Александра и Елены
// внести метод перевода из 2 в 10 систему 
// int[] data = { 0, 1, 1, 1, 1, 0, 0, 0, 1 };
// int[] info = { 2, 3, 3, 1 };
// int[] resultArr = new int[info.Length];
// int n = 0;
// for (int i =0; i < info.Length; i++)
// {
//     for (int j = 0; j < info[i]; j++)
//     {
//         string data = 0;
//         resultArr[i] = data[j];
//     }
//     Console.Write(resultArr);
// }

int[] info = { 0, 1, 1, 1, 1, 0, 0, 0, 1 };
int[] data = { 2, 3, 3, 1 };
int index = 0;
foreach (int d in data)
{
    string two = "";
    for (int i = 0; i < d; i++)
    {
        two +=info[index];
        index++;
    }
    int ten = Convert.ToInt32(two, 2);
    Console.Write($" {ten}");
}