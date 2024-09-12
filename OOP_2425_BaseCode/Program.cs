/*Contains - Checks if the given value is in the array. This has a return type of bool.
Remove - Removes the first value encountered in the array. The array must shrink accordingly. This has a return type of int[].
RemoveAt - Removes the specific index of the array. The array must shrink accordingly. This has a return type of int[].
Find - Locates the index of the first encountered value of the array. This has a return type of int. It should return -1 if it fails to locate the value.Contains - Checks if the given value is in the array. This has a return type of bool.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2425_BaseCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] list = new int[0];
            Random rnd = new Random();

            DisplayArray(list);

            for (int x = 0; x < 100; x++)
            {
                list = AddToArray(list, rnd.Next(20));
                DisplayArray(list);
            }

            Console.ReadKey();
        }

        /// <summary>
        /// This should be the only method used to display the array
        /// </summary>
        /// <param name="array"></param>
        static void DisplayArray(int[] array)
        {
            Console.WriteLine("The current length of the array is " + array.Length);
            Console.WriteLine("It contains the following values:");

            foreach (int i in array)
                Console.Write(i + "\t");

            
        }

        /// <summary>
        /// This method a value into the array
        /// </summary>
        /// <param name="array"></param>
        /// <param name="value"></param>
        /// <returns>returns the array with the added value</returns>
        static int[] AddToArray(int[] array, int value)
        {
            int[] newArray = new int[array.Length + 1];

            for (int x = 0; x < array.Length; x++)
                newArray[x] = array[x];

            newArray[array.Length] = value;

            return newArray;
        }

        static void Contains(int[] array, int value) //Contains
        {
            for (int x = 0; x < array.Length; x++)
            {
                counter++;

                if (array[x] == userInput)
                    return true;
            }
            return -1;
        }

       
        {
            
            Console.WriteLine();
            Console.WriteLine(" ");
            Console.WriteLine();

            if (subscript == -1)
                Console.WriteLine("{0} is NOT in array, # of comparisons is {1}",
                    userInput, counter);
            else
                Console.WriteLine("{0} {1}", int[NewArrayExpression];
        }
    }
    

        static void Remove()(int[] array, int value)//Remove
        {
    int[] array = NewArrayExpression [array.length];
    for (int i = 0; i < NewArrayExpression.length; i++)
    {
        if (array[i] == int)
            break;
    }

    return NewArrayExpression;
}
        static void RemoveAt()(int[] array, int value)//RemoveAt
        {
           
        }
        static void Find()(int[] array, int value)//Find
        {
           

        }

    }
}
