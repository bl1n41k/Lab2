using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public static class NumberSystem8
	{
        static int Num;
        public static int From8To10(int num) 
        {
            bool check = false;
            if (num < 0) check = true; // Проверка на положительность 
            num = Math.Abs(num);
            int temp = 0;
            for (int i = 0; 0 < num; i++)
            {
                temp += num % 10 * (int)Math.Pow(8, i);
                num /= 10;
            }
            if (check == false)
                return temp;
            else return -1 * temp;
        }
        public static void From10To8(int basis, int num)
        {
            if (basis == 8)
            {
                if (CheckRecord(num))
                    Num = num;
                else throw new NotSupportedException();
            }
            else if (basis == 10)
                Num = int.Parse(Convert.ToString(num, 8)); // перевод в 8 сс
            else throw new NotSupportedException();
        }
        public static bool CheckRecord(int num) // Проверка на корректность 
        {
            num = Math.Abs(num);
            for (int i = 0; i < num.ToString().Length; i++)
            {
                if (num % 10 == 9 || num % 10 == 8) return false;
                num /= 10;
            }
            return true;
        }
        public static int GetNum() => Num; 
        public static int Sum(int num1, int num2) // Сумма чисел в 8 сс
        {
            if (CheckRecord(num1) && CheckRecord(num2)) 
            {
                bool check = false; 
                if (num1 + num2 < 0)
                    check = true;
                if (check == false)
                    return int.Parse(Convert.ToString(From8To10(num1) + From8To10(num2), 8));
                else
                    return -1 * int.Parse(Convert.ToString(-1 * (From8To10(num1) + From8To10(num2)), 8));
            }
            else throw new NotSupportedException();
        }
        public static int Sub(int num1, int num2) // Разность чисел в 8 сс 
        {
            if (CheckRecord(num1) && CheckRecord(num2))  
                return -Sum(-num1, num2); 
            else throw new NotSupportedException();
        }
        public static int AND(int num1, int num2) // Логическое И двух чисел в 2 сс
        { 
            if (num1 < 0 || num2 < 0) throw new NotSupportedException(); // Если числа отрицательные
            else if (CheckRecord(num1) && CheckRecord(num2)) 
            {
                string num1_2cc = Convert.ToString(From8To10(num1), 2);
                string num2_2cc = Convert.ToString(From8To10(num2), 2);
                string temp = "";
                int bin1 = 0;
                int bin2 = Math.Abs(num1_2cc.Length - num2_2cc.Length); 
                while (bin2 < Math.Max(num1_2cc.Length, num2_2cc.Length))  // Логическое И для каждой пары битов 
                {
                    if (num1_2cc.Length < num2_2cc.Length)
                        temp += num1_2cc[bin1++] - '0' & num2_2cc[bin2++] - '0';  
                    else
                        temp += num1_2cc[bin2++] - '0' & num2_2cc[bin1++] - '0';
                }
                return int.Parse(temp);
            }
            else throw new NotSupportedException();
        }
        public static int OR(int num1, int num2) // Логическое ИЛИ двух чисел в 2 сс
        {
            if (num1 < 0 || num2 < 0) throw new NotSupportedException(); // Если числа отрицательные
            else if (CheckRecord(num1) && CheckRecord(num2)) 
            {
                string num1_2cc = Convert.ToString(From8To10(num1), 2);
                string num2_2cc = Convert.ToString(From8To10(num2), 2);
                string temp = "";
                int bin1 = 0;
                int bin2 = Math.Abs(num1_2cc.Length - num2_2cc.Length);
                for (int i = 0; i < bin2; i++)  // Переписываем младшие разряды 
                    if (num1_2cc.Length < num2_2cc.Length)
                        temp += num2_2cc[i] - '0';
                    else
                        temp += num1_2cc[i] - '0';

                while (bin2 < Math.Max(num1_2cc.Length, num2_2cc.Length)) // Логическое ИЛИ для каждой пары битов 
                {
                    if (num1_2cc.Length > num2_2cc.Length)
                        temp += num1_2cc[bin2++] - '0' | num2_2cc[bin1++] - '0';
                    else
                        temp += num1_2cc[bin1++] - '0' | num2_2cc[bin2++] - '0';
                }
                return int.Parse(temp);
            }
            else throw new NotSupportedException();
        }
    }
}
