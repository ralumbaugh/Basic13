using System;
using System.Collections.Generic;

namespace Basic13
{
    class Program
    {
        public static void Print(int StartPoint, int EndPoint)
        {
            for(int i=StartPoint; i<=EndPoint; i++)
            {
                Console.WriteLine(i);
            }
        }
        
        public static void PrintOdds(int StartPoint, int EndPoint)
        {
            for(int i=StartPoint; i<=EndPoint; i++)
            {
                if(i%2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static void PrintSum(int StartPoint, int EndPoint)
        {
            int total = 0;
            for(int i=StartPoint; i<=EndPoint; i++)
            {
                total= total+i;
                Console.WriteLine($"New number: {i} Sum: {total}");
            }
        }

        public static void IterateArray(int[] MyArray)
        {
            for(int i=0; i<MyArray.Length; i++)
            {
                Console.WriteLine(MyArray[i]);
            } 
        }

        public static int FindMax(int[] MyArray)
        {
            int CurrentMax = MyArray[0];
            for(int i=1; i<MyArray.Length; i++)
            {
                if(MyArray[i] > CurrentMax)
                {
                    CurrentMax = MyArray[i];
                }
            }
            return CurrentMax;
        }

        public static void GetAverage(int[] MyArray)
        {
            float AverageTotal = 0;
            for(int i=0; i<MyArray.Length; i++)
            {
                AverageTotal = AverageTotal + MyArray[i];
            }
            Console.WriteLine(AverageTotal/MyArray.Length);
        }

        public static int[] OddArray(int StartPoint, int EndPoint)
        {
            List<int> OutputList = new List<int>();
            for(int i=StartPoint; i<=EndPoint; i++)
            {
                if(i%2 != 0)
                {
                    OutputList.Add(i);
                }
            }
            int[] Output = new int[OutputList.Count];
            for(int i=0; i<OutputList.Count; i++)
            {
                Output[i] = OutputList[i];
            }
            return Output;
        }

        public static int GreaterThanY(int[] numbers, int y)
        {
            int count = 0;
            for(int i = 0; i<numbers.Length; i++)
            {
                if(numbers[i]>y){
                    count ++;
                }
            }
            return count;
        }

        public static int[] SquareArrayValues(int[] numbers)
        {
            for(int i=0; i<numbers.Length; i++)
            {
                numbers[i] = numbers[i]*numbers[i];
            }
            return numbers;
        }
        public static int[] EliminateNegatives(int[] numbers)
        {
            for(int i=0; i<numbers.Length; i++)
            {
                if(numbers[i]<0)
                {
                    numbers[i] = 0;
                }
            }
            return numbers;
        }
        public static void MinMaxAverage(int[] numbers)
        {
            int MyMin = numbers[0];
            int MyMax = numbers[0];
            float MyTotal = 0;
            for(int i=0; i<numbers.Length; i++)
            {
                if(MyMin>numbers[i])
                {
                    MyMin=numbers[i];
                }
                if(MyMax<numbers[i])
                {
                    MyMax=numbers[i];
                }
                MyTotal += numbers[i];
            }
            Console.WriteLine($"Minimum: {MyMin} Maximum: {MyMax} Average: {MyTotal/numbers.Length}");
        }
        public static void ShiftValues(int[] numbers)
        {
            for(int i=0; i<numbers.Length-1; i++)
            {
                numbers[i] = numbers[i+1];
            }
            numbers[numbers.Length-1] = 0;
        }
        public static object[] NumToString(int[] numbers)
        {
            object[] mybrandnewobject = new object[numbers.Length];
            for(int i=0; i<numbers.Length; i++)
            {
                if(numbers[i]<0)
                {
                    mybrandnewobject[i] = "Dojo";
                }
                else
                {
                    mybrandnewobject[i] = numbers[i];
                }
            }
            return mybrandnewobject;
        }

        static void Main(string[] args)
        {
            int[] array1 = {8,6,7,5,3,0,9};
            int[] array2 = {-5, 3, 5, 18, 2, -3, 0};
            Print(1, 255);
            PrintOdds(1, 255);
            PrintSum(1,255);
            IterateArray(array1);
            Console.WriteLine(FindMax(array1));
            GetAverage(array1);
            int[] OddNumbers = OddArray(1, 17);
            Console.WriteLine(GreaterThanY(array1, 4));
            Console.WriteLine(SquareArrayValues(array1));
            Console.WriteLine(EliminateNegatives(array2));
            MinMaxAverage(array1);
            ShiftValues(array1);
            Console.WriteLine(NumToString(array2));
        }
    }
}
