// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 2, 4, 9 -> [1, 2, 5, 7, 19, 2, 4, 9 ]
// 6, 1, 33, 2, 93, 15, 424, 0-> [6, 1, 33, 2, 93, 15, 424, 0]

    void showArray()
    {
    int[] array = new int[99998];
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    array[i] = rand.Next(0, 9999999);

    String str = "[";

    foreach(int i in array){
        str = str + i.ToString() + ", ";
    }

    str = str.Remove(str.Length - 1);
    str = str + "]";

    Console.WriteLine(str);
}


showArray();