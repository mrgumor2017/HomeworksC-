using System.Text;

namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Random random = new Random();

            int[] arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
            {
                int res = random.Next(10);
                arr[i] = res;
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();


            int countparne = 0;
            int countneparne = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                bool isDuplicate = false;
                for (int j = 0; j < i; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        isDuplicate = true;
                        break;
                    }
                }

                if (!isDuplicate)
                {
                    if (arr[i] % 2 == 0)
                    {
                        countparne++;
                    }
                    else
                    {
                        countneparne++;
                    }

                }
            }
            Console.WriteLine("Кількість парних унікальних елементів : " + countparne);
            Console.WriteLine("Кількість непарних унікальних елементів : " + countneparne);
            Console.WriteLine();

            int[] arr2 = new int[10];
            for (int i = 0; i < arr2.Length; i++)
            {
                int res = random.Next(10);
                arr2[i] = res;
                Console.Write(arr2[i] + " ");
            }
            Console.Write("\nВведіть параметр : ");
            int param = int.Parse(Console.ReadLine());
            int countmen = 0;
            for (int i = 0; i < arr2.Length; i++)
            {
                if (arr2[i] < param)
                {
                    countmen++;
                }
            }
            Console.WriteLine("Кількість елементів менше параметра : " + countmen);
            Console.WriteLine();

            double[] A = new double[5];
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write($"Введіть {i + 1} елемент масиву : ");
                double elem = double.Parse(Console.ReadLine());
                A[i] = elem;
            }
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write(A[i] + " ");
            }
            Console.WriteLine("\n");

            double[,] B = new double[3, 4];
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    double res = random.Next(90) + 10 + random.NextDouble();
                    res = Math.Round(res, 2);
                    B[i, j] = res;
                    Console.Write(B[i, j] + " ");
                }
                Console.WriteLine();

            }
            Console.WriteLine();

            double maxel = A[0];
            double minel = A[0];
            double suma = 0;
            double dobutok = 1;

            foreach (double item in A)
            {
                dobutok *= item;
                suma += item;
                if (item > maxel)
                {
                    maxel = item;
                }
                if (item < minel)
                {
                    minel = item;
                }
            }

            foreach (double item in B)
            {
                dobutok *= item;
                suma += item;
                if (item > maxel)
                {
                    maxel = item;
                }
                if (item < minel)
                {
                    minel = item;
                }
            }

            double sumaparn = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] % 2 == 0)
                {
                    sumaparn += A[i];
                }
            }
            double sumaneparn = 0;
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j += 2)
                {
                    sumaneparn += B[i, j];
                }

            }


            Console.WriteLine("Максимальний елемент : " + maxel);
            Console.WriteLine("Мінімальний елемент : " + minel);
            Console.WriteLine("Загальна сума елементів : " + suma);
            Console.WriteLine("Загальний добуток елементів : " + dobutok);
            Console.WriteLine("Сума парних елементів масиву А : " + sumaparn);
            Console.WriteLine("Сума непарних стовпців масиву В : " + sumaneparn);

            int[,] arr3 = new int[5, 5];
            for (int i = 0; i < arr3.GetLength(0); i++)
            {
                for (int j = 0; j < arr3.GetLength(1); j++)
                {
                    int res = random.Next(-100, 100);
                    arr3[i, j] = res;
                    Console.Write(arr3[i, j] + " ");
                }
                Console.WriteLine();

            }
            Console.WriteLine();

            int[] arr4 = new int[25];

            int it = 0;
            int maxelem = arr3[0, 0];
            int minelem = arr3[0, 0];
            foreach (int elem in arr3)
            {
                if (maxelem < elem)
                {
                    maxelem = elem;
                }
                if (minelem > elem)
                {
                    minelem = elem;
                }
                arr4[it] = elem;
                Console.Write(arr4[it] + " ");
                it++;
            }
            Console.WriteLine();
            int minindex = Array.IndexOf(arr4, minelem);
            int maxindex = Array.IndexOf(arr4, maxelem);
            int suma2 = 0;
            if (minindex < maxindex)
            {
                for (int i = minindex; i <= maxindex; i++)
                {
                    suma2 += arr4[i];
                }
            }
            else
            {
                for (int i = minindex; i >= maxindex; i--)
                {
                    suma2 += arr4[i];
                }
            }
            Console.WriteLine("Мінімальний елемент :" + minelem);
            Console.WriteLine("Максимальний елемент :" + maxelem);
            Console.WriteLine("Сума елементів : " + suma2);

            int kilk = 0;
            foreach (int item in arr4)
            {
                if (item + 5 == minelem || item - 5 == minelem)
                {
                    kilk++;
                }
            }
            Console.WriteLine("Кількість елементів які відрізняються на 5 від мінмаьлного :" + kilk);
        }
    }
}
