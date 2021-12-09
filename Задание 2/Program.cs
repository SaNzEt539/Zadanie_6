using System;

namespace consoleTask_6_2
{
    class Program
    {
        static double[] Arr(int N)
        {
            Random rand = new Random();
            double[] arr = new double[N];
            for (int i=0; i<N;i++)
            {
                arr[i] = rand.NextDouble();
            }
            return arr;
        }
        static string Res(double[] arr)
        {
            string str = String.Empty;
            double max;
            max = arr[0];
            foreach (double a in arr)
            {
                if (Math.Abs(max) > Math.Abs(a))
                {
                    max = a;
                }
            }
            return max.ToString();
        }
        static string Out(double[] arr)
        {
            string str = String.Empty;
            foreach(double a in arr)
            {
                str += a + " ";
            }
            return str;
        }
        static void Main(string[] args)
        {
            try
            {                
                Console.Write("Введите число элементов массива: ");
                int N = int.Parse(Console.ReadLine());
                double[] arr = Arr(N);
                Console.WriteLine("Массив: {0}", Out(arr));
                Console.WriteLine("Максимальное число: {0}", Res(arr));
            }
            catch(System.FormatException)
            {
                Console.WriteLine("Введено что-то не то");
            }
        }
    }
}
