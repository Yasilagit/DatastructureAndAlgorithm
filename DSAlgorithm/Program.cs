﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Array array = new Array(2);
            //array.Print();
            array.Insert(10);
            array.Insert(20);
            array.Insert(30);
            array.Insert(40);
            array.Insert(50);
            array.RemoveAt(4);
            array.Print();
            Console.WriteLine($"Index Of {array.IndexOf(30)}");
            Console.ReadKey();

        }
        class Array
        {
            int[] array;
            int count = 0;
            public Array(int size)
            {
                array = new int[size];

            }
            public void Insert(int element)
            {
                if (count == array.Length)
                {
                    int[] tempArray = new int[count * 2];
                    for (int i = 0; i < count; i++)
                    {
                        tempArray[i] = array[i];
                    }
                    tempArray[count] = element;
                    array = tempArray;
                    count++;
                }
                else
                {
                    array[count++] = element;
                }

            }
            public void Print()
            {
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine(array[i]);
                }
                Console.ReadKey();

            }
            public void RemoveAt(int index)
            {
                if (index < 0 || index > count - 1)
                    throw new Exception("invalid index");

                for (int i = index; i < count; i++)
                {
                    array[i] = array[i + 1];
                }
                count--;

            }
            public int IndexOf(int element)
            {
                for (int i = 0; i < count; i++)
                {
                    if (array[i] == element)
                    {
                        return i;
                    }
                }
                return 0;
            }

        }
    }
}
