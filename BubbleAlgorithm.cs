using Sorting;
using System.Diagnostics;

namespace Bubble
{
    public struct BubbleAlgorithm
    {
        /// <summary>
        /// Sort with bubble algorithm on int values.
        /// </summary>
        public static void Sort(int[] array)
        {
            var sorted = false; //bool value to detect sorted array

            while(!sorted) //running algorithm while sorted = false
            {
                sorted = true; //sets sorted to true becouse if it's not, we will set it to false in for loop

                for (int i = 0; i < array.Length - 1; i++) //looping threw whole array
                {
                    if(array[i] > array[i+1]) //check if value in array is greater than next value
                    {
                        //swap those two values
                        var buffer = array[i]; //write array value into buffer
                        array[i] = array[i + 1]; //write next array value into this value
                        array[i + 1] = buffer; //rewrite next array value with buffer
                        sorted = false; //set sorted flag to false
                    }
                }
            }
        }

        /// <summary>
        /// Sort with bubble algorithm on long values.
        /// </summary>
        public static void Sort(long[] array)
        {
            var sorted = false; //bool value to detect sorted array

            while (!sorted) //running algorithm while sorted = false
            {
                sorted = true; //sets sorted to true becouse if it's not, we will set it to false in for loop

                for (int i = 0; i < array.Length - 1; i++) //looping threw whole array
                {
                    if (array[i] > array[i + 1]) //check if value in array is greater than next value
                    {
                        //swap those two values
                        var buffer = array[i]; //write array value into buffer
                        array[i] = array[i + 1]; //write next array value into this value
                        array[i + 1] = buffer; //rewrite next array value with buffer
                        sorted = false; //set sorted flag to false
                    }
                }
            }
        }

        /// <summary>
        /// Sort with bubble algorithm on float values.
        /// </summary>
        public static void Sort(float[] array)
        {
            var sorted = false; //bool value to detect sorted array

            while (!sorted) //running algorithm while sorted = false
            {
                sorted = true; //sets sorted to true becouse if it's not, we will set it to false in for loop

                for (int i = 0; i < array.Length - 1; i++) //looping threw whole array
                {
                    if (array[i] > array[i + 1]) //check if value in array is greater than next value
                    {
                        //swap those two values
                        var buffer = array[i]; //write array value into buffer
                        array[i] = array[i + 1]; //write next array value into this value
                        array[i + 1] = buffer; //rewrite next array value with buffer
                        sorted = false; //set sorted flag to false
                    }
                }
            }
        }

        /// <summary>
        /// Sort with bubble algorithm on double values.
        /// </summary>
        public static void Sort(double[] array)
        {
            var sorted = false; //bool value to detect sorted array

            while (!sorted) //running algorithm while sorted = false
            {
                sorted = true; //sets sorted to true becouse if it's not, we will set it to false in for loop

                for (int i = 0; i < array.Length - 1; i++) //looping threw whole array
                {
                    if (array[i] > array[i + 1]) //check if value in array is greater than next value
                    {
                        //swap those two values
                        var buffer = array[i]; //write array value into buffer
                        array[i] = array[i + 1]; //write next array value into this value
                        array[i + 1] = buffer; //rewrite next array value with buffer
                        sorted = false; //set sorted flag to false
                    }
                }
            }
        }

        /// <summary>
        /// Sort with bubble algorithm on float values.
        /// </summary>
        public static long Time(float[] array, TimeType type)
        { 
            //copy whole array
            var copiedArray = new float[array.Length];

            for (int i = 0; i < copiedArray.Length; i++)
            {
                copiedArray[i] = array[i];
            }

            var stopwatch = new Stopwatch(); //creates stopwatch
            stopwatch.Start(); //start stopwatch
            Sort(copiedArray); //sort array
            stopwatch.Stop(); //stop stopwatch

            switch(type)
            {
                case TimeType.Miliseconds:
                    return stopwatch.ElapsedMilliseconds; //return number of miliseconds counted while sorting array
                case TimeType.Ticks:
                    return stopwatch.ElapsedTicks; //return number of ticks counted while sorting array
                default:
                    return 0;
            }      
        }
    }
}
