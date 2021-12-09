using System;
using System.Collections;
namespace consoleTask_6_4
{
    class Massive
    {
        int[][] arr;
        Random rand = new Random();
        public Massive(int n)
        {
            arr = new int[n][];
            for (int i=0; i<n; i++)
            {
                arr[i] = new int[rand.Next(1, 10)];
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j< arr[i].Length; j++)
                {
                    arr[i][j] = rand.Next(-100, 100);
                }
            }
        }
        public string Show()
        {
            string str = String.Empty;
            foreach (int[] a in arr)
            {
                foreach (int j in a)
                {
                    str += j + " ";
                }
                str += "\n";
            }
            return str;
        }
        public ArrayList ShowInterval(int a, int b)
        {
            ArrayList aList = new ArrayList();
            foreach (int[] i in arr)
            {
                foreach (int j in i)
                {
                    if (j < a || j > b) 
                    {
                        aList.Add(j);
                    }
                }                
            }
            return aList;
        }
    }
    class Program
    {
        static string ToStr(ArrayList aL)
        {
            string str = String.Empty;
            for (int i =0; i<aL.Count; i++)
            {
                str += aL[i] + " ";
            }
            return str;
        }
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите размер массива: ");
                int N = int.Parse(Console.ReadLine());
                Console.Write("Введите интервал A: ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Введите интервал B: ");
                int b = int.Parse(Console.ReadLine());
                Massive mas = new Massive(N);
                Console.WriteLine("Массив:\n{0}", mas.Show());
                ArrayList arrayList = mas.ShowInterval(a, b);
                
                Console.WriteLine("Результат: {0}", ToStr(arrayList));
            }
            catch(System.FormatException)
            {
                Console.WriteLine("Введено что-то не то");
            }
        }
    }
}
