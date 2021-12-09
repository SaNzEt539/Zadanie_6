using System;

namespace consoleTask_6_3
{
    class Matrix
    {
        int m;
        int k;
        int[,] matrix;
        public Matrix(int m, int k)
        {
            this.m = m;
            this.k = k;
            matrix = new int[m, k];
            int n = m * k;
            Random rand = new Random();
            bool flag = true;
            for (int i = 0; i < k; i++)
            {
                if (flag)
                {
                    for (int j = 0; j<m; j++)
                    {
                        matrix[j, i] = rand.Next(1, n);
                    }
                    flag = false;
                }
                else
                {
                    for (int j = m-1; j>=0; j--)
                    {
                        matrix[j, i] = rand.Next(1, n);
                    }
                    flag = true;
                }
            }
        }
        public string Show()
        {
            string str = String.Empty;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    str += matrix[i, j] + " ";
                }
                str += "\n";
            }
            return str;
        }        
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите число строк m: ");
                int m = int.Parse(Console.ReadLine());
                Console.Write("Введите число столбцов k: ");
                int n = int.Parse(Console.ReadLine());
                Matrix matrix = new Matrix(m, n);
                Console.WriteLine("Результат:\n{0}", matrix.Show());
            }
            catch(System.FormatException)
            {
                Console.WriteLine("Введено что-то не то");
            }
        }
    }
}
