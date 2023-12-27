using System;

namespace ConsoleApp9 {
    internal class Program {
        static void Main(string[] args) {
            // Calling all the methods in Main method
            Console.WriteLine(Sum(5, 6, 7));
            Console.WriteLine(Sum(5.5, 6.6, 7.7));
            Console.WriteLine(Sum(new int[] { 1, 2, 3, 4, 5 }));
            Console.WriteLine(Sum(new double[] { 1.1, 2.2, 3.3, 4.4, 5.5 }));
            Console.WriteLine(IndexOf("Hello World", 'o'));
            Console.WriteLine(LastIndexOf("Hello World", 'o'));
            Console.WriteLine(Max(new int[] { 1, 2, 3, 4, 5 }));
            Console.WriteLine(IsPositiveAndEven(6));
            Console.WriteLine(CountPositiveAndEven(new int[] { 1, 2, 3, 4, 5 }));
            Console.WriteLine(string.Join(", ", GetPositiveAndEven(new int[] { 1, 2, 3, 4, 5 })));
            Console.WriteLine(string.Join(", ", Reverse(new int[] { 1, 2, 3, 4, 5 })));
            Console.WriteLine(TrimStart("    Hello World"));
            Console.WriteLine(TrimEnd("Hello World    "));
        }

        #region Task1

        // Verilmiş 3 ədədin cəmini tapan method(həm int, həm double ədədlər üçün)

        static int Sum(int a, int b, int c) {
            return a + b + c;
        }

        static double Sum(double a, double b, double c) {
            return a + b + c;
        }

        #endregion

        #region Task2

        // Verilmiş ədədlər siyahısındaki bütün ədədlərin cəmini tapan method (həm int, həm double ədədlər üçün)

        static int Sum(int[] arr) {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++) {
                sum += arr[i];
            }
            return sum;
        }

        static double Sum(double[] arr) {
            double sum = 0;
            for (int i = 0; i < arr.Length; i++) {
                sum += arr[i];
            }
            return sum;
        }

        #endregion

        #region Task3

        // Verilmiş yazıda veirlmiş charın yerləşdiyi ilk indexi tapan method(yoxdursa -1 qaytarır)

        static int IndexOf(string str, char ch) {
            for (int i = 0; i < str.Length; i++) {
                if (str[i] == ch) {
                    return i;
                }
            }
            return -1;
        }

        #endregion

        #region Task4

        // Verilmiş yazıda veirlmiş charın yerləşdiyi son indexi tapan method (yoxdursa -1 qaytarır)

        static int LastIndexOf(string str, char ch) {
            for (int i = str.Length - 1; i >= 0; i--) {
                if (str[i] == ch) {
                    return i;
                }
            }
            return -1;
        }

        #endregion

        #region Task5

        // Verilmiş ədədlər siyahısındaki ən böyük ədədi tapan method

        static int Max(int[] arr) {
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++) {
                if (arr[i] > max) {
                    max = arr[i];
                }
            }
            return max;
        }

        #endregion

        #region Task6

        // Verilmiş ədədin müsbət və cüt olub olmadığını tapan method

        static bool IsPositiveAndEven(int num) {
            return num > 0 && num % 2 == 0;
        }

        #endregion

        #region Task7

        // Verilmiş ədədlər siyahısındaki müsbət və cüt ədədlərin sayını tapan method

        static int CountPositiveAndEven(int[] arr) {
            int count = 0;
            for (int i = 0; i < arr.Length; i++) {
                if (IsPositiveAndEven(arr[i])) {  // Evvelki metoddan istifadə edirik
                    count++;
                }
            }
            return count;
        }

        #endregion

        #region Task8

        // Verilmiş ədədlər siyahısındaki müsbət və cüt ədədlərdən ibarət yeni bir array düzəldən method.

        static int[] GetPositiveAndEven(int[] arr) {
            int[] newArr = new int[CountPositiveAndEven(arr)];  // Evvelki metoddan istifadə edirik
            int index = 0;
            for (int i = 0; i < arr.Length; i++) {
                if (IsPositiveAndEven(arr[i])) {  // Evvelki metoddan istifadə edirik
                    newArr[index++] = arr[i];
                }
            }
            return newArr;
        }

        #endregion

        #region Task9

        // Verilmiş ədədlər siyahısından tərsinə düzülmüs yeni bir array qaytaran method.

        static int[] Reverse(int[] arr) {
            int[] newArr = new int[arr.Length];
            int index = 0;
            for (int i = arr.Length - 1; i >= 0; i--) {
                newArr[index++] = arr[i];
            }
            return newArr;
        }

        #endregion

        #region Task10

        // Verilmiş yazının əvvəlindəki boşluqlar silinmiş bir string düzəldən method

        static string TrimStart(string str) {
            string newStr = "";
            int index = 0;
            while (str[index] == ' ') {
                index++;
            }
            for (int i = index; i < str.Length; i++) {
                newStr += str[i];
            }
            return newStr;
        }

        #endregion

        #region Task11

        // Verilmiş yazıdan sonundaki boşluqlar silinmiş yeni string düzəldən method

        static string TrimEnd(string str) {
            string newStr = "";
            int index = str.Length - 1;
            while (str[index] == ' ') {
                index--;
            }
            for (int i = 0; i <= index; i++) {
                newStr += str[i];
            }
            return newStr;
        }

        #endregion

    }
}
