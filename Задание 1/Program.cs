using System;

namespace consoleTask_6_1
{
    class Arrays
    {
        int[] m_Array;
        int[,] m_dArray;
        public Arrays(int N, int n, int m)
        {
            m_Array = Array(N);
            m_dArray = Array(n, m);
        }
        int[] Array(int n)
        {
            Random rand = new Random();
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = rand.Next(-100, 100);
            }
            return arr;
        }
        int[,] Array(int n, int m)
        {
            Random rand = new Random();
            int[,] arr = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    arr[i, j] = rand.Next(-100, 100);
                }
            }
            return arr;
        }
        public void Show()
        {
            Console.WriteLine("Элементы одномерного массива: ");
            foreach (int a in m_Array)
            {
                Console.Write("{0} ", a);
            }
            Console.WriteLine();
            Console.WriteLine("Элементы двумерного массива: ");
            int i = 0;
            foreach (int a in m_dArray)
            {
                Console.Write("{0} ", a);
                if (i < m_dArray.GetUpperBound(1))
                {
                    i++;
                }
                else
                {
                    Console.WriteLine();
                    i = 0;
                }
            }
        }
        public void Result(int a, int b)
        {
            Console.WriteLine("Индексы одномерного массива: ");
            for (int i = 0; i < m_Array.Length; i++)
            {
                if (m_Array[i] < a || m_Array[i] > b)
                {
                    Console.Write("{0} ", i);
                }
            }
            Console.WriteLine();
            Console.WriteLine("Индексы двумерного массива: ");
            for (int i = 0; i < m_dArray.GetUpperBound(0) + 1; i++) 
            {
                for (int j = 0; j < m_dArray.GetUpperBound(1) + 1; j++)
                {
                    if ((m_dArray[i, j] < a) || (m_dArray[i, j] > b))
                    {                        
                        Console.Write("[{0}, {1}] ", i, j);
                    }
                }
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                try
                {
                    Console.WriteLine("\tВвод интревала для обоих массивов");
                    Console.Write("Введите A: ");
                    int A = int.Parse(Console.ReadLine());
                    Console.Write("Введите B: ");
                    int B = int.Parse(Console.ReadLine());
                    Console.Write("\tВведите размер одномерного массива: ");
                    int masN = int.Parse(Console.ReadLine());
                    Console.WriteLine("\tВвод размера для двумерного массива");
                    Console.Write("Введите число строк: ");
                    int N = int.Parse(Console.ReadLine());
                    Console.Write("Введите число столбцов: ");
                    int M = int.Parse(Console.ReadLine());
                    Arrays z = new Arrays(masN, N, M);
                    z.Show();
                    z.Result(A, B);
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Введено что-то не то");
                }
            }
        }
    }
}
