using System;

namespace ConsoleApp10 {
    internal class Program {
        static void Main(string[] args) {
            Calculate(5, 6, '+');
            Console.WriteLine(Count("Hello World", 'l'));
            Console.WriteLine(CountWords("Hello World"));
            Console.WriteLine(SumOfDigits(123));
            Console.WriteLine(Power(2, 3));

            int[] array = ConvertToPositive(new int[] { 1, 2, 3, -4, -5, 6, -7, 8, 9 });
            for (int i = 0; i < array.Length; i++) {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine(Reverse("Hello World"));

        }

        #region Task1

        // Verilmiş iki ədəd üzərində verilmiş operator simvoluna əsasən riyazi əməliyyat aparıb nəticəsini console-da göstərən metod.

        static void Calculate(int a, int b, char op) {
            switch (op) {
                case '+':
                    Console.WriteLine(a + b);
                    break;
                case '-':
                    Console.WriteLine(a - b);
                    break;
                case '*':
                    Console.WriteLine(a * b);
                    break;
                case '/':
                    Console.WriteLine(a / b);
                    break;
                default:
                    Console.WriteLine("Invalid operator");
                    break;
            }
        }

        #endregion

        #region Task2

        // Verilmiş yazıdaki verilmiş simvolun sayını qaytaran metod

        static int Count(string str, char ch) {
            int count = 0;
            for (int i = 0; i < str.Length; i++) {
                if (str[i] == ch) {
                    count++;
                }
            }
            return count;
        }

        #endregion

        #region Task3

        // Verilmiş yazıdaki sözlərin sayını qaytaran metod

        static int CountWords(string str) {
            int count = 0;
            for (int i = 0; i < str.Length; i++) {
                if (str[i] == ' ') {
                    count++;
                }
            }
            return count + 1;
        }

        #endregion

        #region Task4

        // Verilmiş  ədədin rəqəmləri cəmini qaytaran metod

        static int SumOfDigits(int num) {
            int sum = 0;
            while (num > 0) {
                sum += num % 10;
                num /= 10;
            }
            return sum;
        }

        #endregion

        #region Task5

        // Verilmiş ədədi verilmiş qüvvətə yüksəldib nəticəsini qaytaran metod

        static int Power(int num, int pow) {
            int result = 1;
            for (int i = 0; i < pow; i++) {
                result *= num;
            }
            return result;
        }

        #endregion

        #region Task6

        // Verilmiş ədədlər siyahısının bütün elementlərini müsbət şəkildə qaytaran metod.

        static int[] ConvertToPositive(int[] arr) {
            int[] result = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++) {
                if (arr[i] < 0) result[i] = -1 * arr[i];
                else result[i] = arr[i];
            }
            return result;
        }

        #endregion

        #region Task7

        // Verilmiş yazını tərs formada qaytaran metod

        static string Reverse(string str) {
            string result = "";
            for (int i = str.Length - 1; i >= 0; i--) {
                result += str[i];
            }
            return result;
        }

        #endregion
    }
}
