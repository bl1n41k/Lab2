using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
	class Array
	{
        int Left; 
        int Right; 
        int[] arr; 

        public Array()
        {
            arr = new int[0]; 
        }
        public Array(int n) 
        {
            arr = new int[n];
            Left = 0; Right = n - 1;
            for (int i = 0; i < n; i++)
            {
                arr[i] = i;
            }
        }
        public Array(int left, int right) // массив с границами
        {
            arr = new int[right - left + 1];
            Left = left;
            Right = right;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i;
            }
        }

        public int this[int index] // Выход за границы массива
        {
            get
            {
                if (index < Left || index > Right)
                    throw new IndexOutOfRangeException("Out of range");
                return arr[index - Left];
            }
            set
            {
                if (index < Left || index > Right)
                    throw new IndexOutOfRangeException("Out of range");
                arr[index - Left] = value;
            }
        }

        //арифметические операций + -  * и / на число 
        public static Array operator +(Array arr1, Array arr2)
        {
            if (arr1.Left != arr2.Left || arr1.Right != arr2.Right) // Если элементы из разных диапазонов
                throw new NotSupportedException();
            Array arr = new Array(arr1.Left, arr1.Right);
            for (int i = arr.Left; i <= arr.Right; i++)
                arr[i] = arr1[i] + arr2[i];
            return arr;
        }
        public static Array operator -(Array arr1, Array arr2)
        {
            if (arr1.Left != arr2.Left || arr1.Right != arr2.Right) // Если элементы из разных диапазонов
                throw new NotSupportedException();
            Array vector = new Array(arr1.Left, arr1.Right);
            for (int i = vector.Left; i <= vector.Right; i++)
                vector[i] = arr1[i] - arr2[i];
            return vector;
        }
        public static Array operator *(Array arr, int num)
        {
            Array vector = new Array(arr.Left, arr.Right);
            for (int i = vector.Left; i <= vector.Right; i++)
                vector[i] = arr[i] * num;
            return vector;
        }
        public static Array operator /(Array arr, int num)
        {
            if (num == 0) throw new DivideByZeroException(); // Если элементы массива делим на 0
            Array arr1 = new Array(arr.Left, arr.Right);
            for (int i = arr1.Left; i <= arr1.Right; i++)
                arr1[i] = arr[i] / num;
            return arr1;
        }

        public int[] search(int value) // Поиск всех индексов с указанным значением
        {
            int element = 0;
            int[] arrElement;
            for (int i = 0; i < arr.Length; i++) 
                if (arr[i] == value)
                    element++;
            arrElement = new int[element]; // размер = кол-ву элементов в массиве с указанным значением
            int j = 0;
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] == value) 
                    arrElement[j++] = i;
            if (element != 0) return arrElement;
            else throw new Exception("Not found!");
        }
        public void printElement(int element) // Вывод значения элемента по заданному индексу
        {
            Array array = new Array(Left, Right);
            array.arr = arr;
            if (element < Left || element > Right)
              throw new IndexOutOfRangeException("Out of range"); 
            Console.WriteLine(array[element]);
        }
        public void print()
        {
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }
    }
}

