// Задание с клавиатуры число элементов массива

int n;
Console.WriteLine("Введите число элементов массива");
n = Convert.ToInt16(Console.ReadLine());
// Объявим одномерный массив Data с n-элементами
double[] data = new double[n];
int i = 0;
while (i < n)
{
    Console.WriteLine("Введите элемент массива");
    data[i] = double.Parse(Console.ReadLine());
    i++;
}
// Вывод содержимого массива
for (i=0; i<n; i++)
Console.WriteLine("Элемент ["+i+"]:" + data[i]);
Console.ReadKey();