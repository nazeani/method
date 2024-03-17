using System;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 4, 5, 8 };
            int[] arr2 = { 1, 7, 3, 5 };
            Console.WriteLine(CommonElement(arr1, arr2));
            Console.WriteLine(Multiplication(arr1, arr2));
            //the radius of the circle
            int r = 5;
            Console.WriteLine(Area(r));
            //the width and length of the rectangle
            int width = 4;
            int length = 5;
            Console.WriteLine(Area(width, length));
            //rectangular parallelepiped
            int a = 6;
            int b = 7;
            int c = 8;
            Console.WriteLine(Area(a, b, c));
            //A circle drawn inside a triangle
            int x = 9;
            int y = 10;
            int z = 11;
            int p = (x + y + z) / 2;
            int radius = 6;
            Console.WriteLine(Area(x, y, z, p, radius));
            string[] arr3 = { "Anar", "Eli", "Yusif", "Arif" };
            Console.WriteLine("Character to search for:");
            string character = Console.ReadLine();
            Console.WriteLine(FirstCharacter(arr3, character));
        }
        //task1 
        static string CommonElement(int[] a, int[] b)
        {
            string c = "";
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < b.Length; j++)
                {
                    if (a[i] == b[j])
                    {
                        c += a[i] + " ";
                    }

                }

            }
            return c;

        }
        //task2
        static string Multiplication(int[] a, int[] b)
        {
            string d = "";
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < b.Length; j++)
                {
                    if (i == j)
                    {
                        d += a[i] * b[j] + " ";
                    }

                }

            }
            return d;
        }
        //task3
        static string FirstCharacter(string[] a, string character)
        {
            string result = "";
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i].StartsWith(character))
                {
                    result += a[i] + " ";
                    Console.WriteLine(result);
                }
            }
            return result;
        }
        //task4
        static int Area(int r)
        {
            int p = 3;
            int s = p * (r * r);
            return s;
        }
        static int Area(int width, int length)
        {
            int S = width * length;
            return S;
        }
        static int Area(int a, int b, int c)
        {
            int S = 2 * (a * b + a * c + b * c);
            return S;
        }
        static int Area(int x, int y, int z, int p, int r)
        {
            int S = p * r;
            return S;
        }

    }
}
