using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //////задание 2
            ////int[] array = { -7, -1, 2, -4, 8, -3 };
            ////int count = 0;
            ////foreach (int elem in array)
            ////{
            //// if (elem % 2 == 0) count++;
            ////}
            ////Console.WriteLine($"count={count}");

            ////задание 1
            //Console.Write("размер=");
            //int n = int.Parse(Console.ReadLine());
            //int[] array = new int[n];
            //for (int i = 0; i < array.Length; i++)
            //{
            // Console.Write($"array[{i}]=");
            // array[i] = int.Parse(Console.ReadLine());
            //}
            //int p = array[0];
            //for (int i = 0; i < array.Length; i++)
            //{
            // array[i] = array[i] + array[0];
            // //array[i] += array[0];
            //}
            //for (int i = 0; i < array.Length; i++)
            //{
            // Console.WriteLine($"array[{i}]={array[i]}");
            //}
            //Console.ReadKey();

            ////задание3
            //Задача 3
            //Console.Write("n=");
            //int n=Convert.ToInt32(Console.ReadLine());
            //int[] mass = new int[n];
            //for(int i=0;i<n;i++)
            //{
            //    Console.Write($"mass[{i}]=");
            //    mass[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //int max = mass[0];
            //int index1 = 0;
            //int min = mass[0];
            //int index2 = 0;
            //for(int i=0;i<n;i++)
            //{
            //    if (mass[i]>max)
            //    {
            //        max= mass[i];
            //        index1 = i;
            //    }
            //    if(mass[i]<min)
            //    {
            //        min= mass[i];
            //        index2 = i;
            //    }
            //}
            //Console.WriteLine($"max={max}");
            //Console.WriteLine($"index1={index1}");
            //Console.WriteLine($"min={min}");
            //Console.WriteLine($"index2={index2}");
            //int new_min = max;
            //int new_max = min;
            //for(int i=0;i<n;i++)
            //{
            //    Console.WriteLine($"mass[{i}]={mass[i]}");
            //}
            //Console.WriteLine($"new_max={new_max}");
            //Console.WriteLine($"new_min={new_min}");
            //Console.WriteLine($"Кол-во элементов между макс и мин  ={Math.Abs(index2-index1)-1}");
            Console.ReadKey();


        }
    }
}
