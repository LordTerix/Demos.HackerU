﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.HackerU.CommonTypes
{
    public class BasicTypesDemos
    {
        public static void Run()
        {
            //--Basic C# Types
            TestTypes();
            
            Console.WriteLine("-----");
            //--Test Array Type
            TestArray();

            Console.WriteLine("-----");

            TestReadToArray();

            Console.WriteLine("-----");

            //--Test Dynamic Array Type
            TestDynamicArray();

        }

        private static void TestDynamicArray()
        {
            var arrNumbers = new List<int>();
            arrNumbers.Add(10);
            arrNumbers.Add(100);
            arrNumbers.Add(454);
            arrNumbers.RemoveAt(1);//remove 100

            int val = 100;
            for (int i = 0; i < 10; i++)
            {
                val += 5;
                arrNumbers.Add(val);
            }

            Console.WriteLine("List:");
            for (int i = 0; i < arrNumbers.Count; i++)
            {
                Console.WriteLine(arrNumbers[i]);
            }
          
            Console.WriteLine("Removing Last Item....");
            arrNumbers.RemoveAt(arrNumbers.Count -1);

            Console.WriteLine("List:");
            for (int i = 0; i < arrNumbers.Count; i++)
            {
                Console.WriteLine(arrNumbers[i]);
            }

        }

        private static void TestReadToArray()
        {
            int[] arr = new int[5];

            //Read From User 
            //Insert to Array each number
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("input num");
                string numText =  Console.ReadLine();
                //Convert string to int
                int num = int.Parse(numText);
                arr[i] = num;
            }

            //Calculate AVG+Print Array
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                Console.Write($"[{i}]={arr[i]} | ");
            }
            Console.WriteLine();
            int avg = sum / arr.Length;
            Console.WriteLine("AVG="+avg);


        }

        private static void TestArray()
        {
            //Static Array
            int[] numbers = new int[10];
            numbers[0] = -3;
            numbers[1] = 10;

            for (int i = 2; i < numbers.Length; i++)
            {
                numbers[i] = numbers[i - 1] + 5;
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"{i}-->{numbers[i]}");
            }


        }

        private static void TestTypes()
        {
            int x = 10;
            int y = 100;
            int z = x + y;
            Console.WriteLine($"x={x},y={y},z={z}");

            double d1 = 5.75;
            double d2 = 5.75345456;
            d1++;//d1 = d1+1;
            d1 += 6f;//d1 = d1+6
            d1 += d2;//d1 = d1+6
            Console.WriteLine($"d1={d1}");

            float f = 10.34f;
            Console.WriteLine($"f={f}");

            bool isEquals = (d1 == d2);
            Console.WriteLine($"isEquals d1=d2 ---> {isEquals}");

            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);

            string dt2 = DateTime.Now.ToShortDateString();
            Console.WriteLine(dt2);

            string dt3 = DateTime.Now.ToLongDateString();
            Console.WriteLine(dt3);

            DateTime dt4 = DateTime.Now.AddHours(48);
            Console.WriteLine(dt4);

            //Var Value
            var y2 = 10;//y2 is int
            var b2 = true;
            Console.WriteLine("y2 is int" + y2);



        }
    }
}
