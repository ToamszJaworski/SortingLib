using Sorting;
using System.Diagnostics;

namespace QuickSort
{
    public struct QuickSortAlgorithm
    {
        /// <summary>
        /// Sort with Quick Sort Algorithm on int values.
        /// </summary>
        public static void QuickSort(int[] array, int left, int right)
        {
            if (right <= left) return; //stop sorting when right mareker is lower than left marker

            //sets local variables. -1 and +1 becouse we call incerement before first read
            var leftPointer = left - 1;
            var rightPointer = right + 1;

            var pivot = array[(left + right) / 2]; //calculatin pivot value

            while (true)
            { 
                //first while find first value greater than pivot
                do
                {
                    leftPointer++;

                    if (leftPointer >= array.Length)
                        break;
                }
                while (pivot > array[leftPointer]) ;

                //second while find first value lower than pivot
                do
                {
                    rightPointer--;

                    if (rightPointer < 0)
                        break;
                }
                while (pivot < array[rightPointer]) ;

                //check if we still looping
                if (leftPointer <= rightPointer)
                {
                    //spawps two values in array
                    var buffer = array[leftPointer];
                    array[leftPointer] = array[rightPointer];
                    array[rightPointer] = buffer;
                }
                else
                    break; //if not, break the loop
            }

            //call QuickSort again but only on first half of an array if we didnt end sorting on this way
            if(rightPointer > left)
                QuickSort(array, left, rightPointer);

            //call QuickSort again but only on second half of an array if we didnt end sorting on this way
            if (leftPointer < right)
                QuickSort(array, leftPointer, right);
        }

        /// <summary>
        /// Sort with Quick Sort Algorithm on long values.
        /// </summary>
        public static void QuickSort(long[] array, int left, int right)
        {
            if (right <= left) return; //stop sorting when right mareker is lower than left marker

            //sets local variables. -1 and +1 becouse we call incerement before first read
            var leftPointer = left - 1;
            var rightPointer = right + 1;

            var pivot = array[(left + right) / 2]; //calculatin pivot value

            while (true)
            {
                //first while find first value greater than pivot
                do
                {
                    leftPointer++;

                    if (leftPointer >= array.Length)
                        break;
                }
                while (pivot > array[leftPointer]);

                //second while find first value lower than pivot
                do
                {
                    rightPointer--;

                    if (rightPointer < 0)
                        break;
                }
                while (pivot < array[rightPointer]);

                //check if we still looping
                if (leftPointer <= rightPointer)
                {
                    //spawps two values in array
                    var buffer = array[leftPointer];
                    array[leftPointer] = array[rightPointer];
                    array[rightPointer] = buffer;
                }
                else
                    break; //if not, break the loop
            }

            //call QuickSort again but only on first half of an array if we didnt end sorting on this way
            if (rightPointer > left)
                QuickSort(array, left, rightPointer);

            //call QuickSort again but only on second half of an array if we didnt end sorting on this way
            if (leftPointer < right)
                QuickSort(array, leftPointer, right);
        }

        /// <summary>
        /// Sort with Quick Sort Algorithm on float values.
        /// </summary>
        public static void QuickSort(float[] array, int left, int right)
        {
            if (right <= left) return; //stop sorting when right mareker is lower than left marker

            //sets local variables. -1 and +1 becouse we call incerement before first read
            var leftPointer = left - 1;
            var rightPointer = right + 1;

            var pivot = array[(left + right) / 2]; //calculatin pivot value

            while (true)
            {
                //first while find first value greater than pivot
                do
                {
                    leftPointer++;

                    if (leftPointer >= array.Length)
                        break;
                }
                while (pivot > array[leftPointer]);

                //second while find first value lower than pivot
                do
                {
                    rightPointer--;

                    if (rightPointer < 0)
                        break;
                }
                while (pivot < array[rightPointer]);

                //check if we still looping
                if (leftPointer <= rightPointer)
                {
                    //spawps two values in array
                    var buffer = array[leftPointer];
                    array[leftPointer] = array[rightPointer];
                    array[rightPointer] = buffer;
                }
                else
                    break; //if not, break the loop
            }

            //call QuickSort again but only on first half of an array if we didnt end sorting on this way
            if (rightPointer > left)
                QuickSort(array, left, rightPointer);

            //call QuickSort again but only on second half of an array if we didnt end sorting on this way
            if (leftPointer < right)
                QuickSort(array, leftPointer, right);
        }

        /// <summary>
        /// Sort with Quick Sort Algorithm on double values.
        /// </summary>
        public static void QuickSort(double[] array, int left, int right)
        {
            if (right <= left) return; //stop sorting when right mareker is lower than left marker

            //sets local variables. -1 and +1 becouse we call incerement before first read
            var leftPointer = left - 1;
            var rightPointer = right + 1;

            var pivot = array[(left + right) / 2]; //calculatin pivot value

            while (true)
            {
                //first while find first value greater than pivot
                do
                {
                    leftPointer++;

                    if (leftPointer >= array.Length)
                        break;
                }
                while (pivot > array[leftPointer]);

                //second while find first value lower than pivot
                do
                {
                    rightPointer--;

                    if (rightPointer < 0)
                        break;
                }
                while (pivot < array[rightPointer]);

                //check if we still looping
                if (leftPointer <= rightPointer)
                {
                    //spawps two values in array
                    var buffer = array[leftPointer];
                    array[leftPointer] = array[rightPointer];
                    array[rightPointer] = buffer;
                }
                else
                    break; //if not, break the loop
            }

            //call QuickSort again but only on first half of an array if we didnt end sorting on this way
            if (rightPointer > left)
                QuickSort(array, left, rightPointer);

            //call QuickSort again but only on second half of an array if we didnt end sorting on this way
            if (leftPointer < right)
                QuickSort(array, leftPointer, right);
        }

        /// <summary>
        /// Sort with quick sort algorithm on float values.
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
            QuickSort(copiedArray, 0, copiedArray.Length - 1); //sort array
            stopwatch.Stop(); //stop stopwatch

            switch (type)
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
