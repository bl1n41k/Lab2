using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Arr
	{
        int Left; 
        int Right; 
        int[] arr; 

        public Arr()
        {
            arr = new int[0]; 
        }
        public Arr(int n) 
        {
            arr = new int[n];
            Left = 0; Right = n - 1;
            for (int i = 0; i < n; i++)
            {
                arr[i] = i;
            }
        }
        public Arr(int left, int right) // массив с границами
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
        public static Arr operator +(Arr arr1, Arr arr2)
        {
            if (arr1.Left != arr2.Left || arr1.Right != arr2.Right) // Если элементы из разных диапазонов
                throw new NotSupportedException();
            Arr arr = new Arr(arr1.Left, arr1.Right);
            for (int i = arr.Left; i <= arr.Right; i++)
                arr[i] = arr1[i] + arr2[i];
            return arr;
        }
        public static Arr operator -(Arr arr1, Arr arr2)
        {
            if (arr1.Left != arr2.Left || arr1.Right != arr2.Right) // Если элементы из разных диапазонов
                throw new NotSupportedException();
            Arr vector = new Arr(arr1.Left, arr1.Right);
            for (int i = vector.Left; i <= vector.Right; i++)
                vector[i] = arr1[i] - arr2[i];
            return vector;
        }
        public static Arr operator *(Arr arr, int num)
        {
            Arr vector = new Arr(arr.Left, arr.Right);
            for (int i = vector.Left; i <= vector.Right; i++)
                vector[i] = arr[i] * num;
            return vector;
        }
        public static Arr operator /(Arr arr, int num)
        {
            if (num == 0) throw new DivideByZeroException(); // Если элементы массива делим на 0
            Arr arr1 = new Arr(arr.Left, arr.Right);
            for (int i = arr1.Left; i <= arr1.Right; i++)
                arr1[i] = arr[i] / num;
            return arr1;
        }

        public int[] Search(int value) // Поиск всех индексов с указанным значением
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
        public string PrintElement(int element) // Вывод значения элемента по заданному индексу
        {
            Arr array = new Arr(Left, Right);
            array.arr = arr;
            if (element < Left || element > Right)
              throw new IndexOutOfRangeException("Out of range"); 
            return this.arr[element].ToString();
        }
        public override string ToString()
        {
            string str = "";
            for (int i = 0; i < arr.Length; i++)
                str += arr[i].ToString() + " ";
            return str;
        }
    }
}

