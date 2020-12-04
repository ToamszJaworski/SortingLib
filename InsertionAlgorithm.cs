using Sorting;
using System.Diagnostics;

namespace Insertion
{
    public struct InsertionAlgorithm
    {
        /// <summary>
        /// Insertion sort on int values.
        /// </summary>
        /// <param name="array">Int array to sort.</param>
        public static void Insertion(int[] array)
        {
            for (int i = 0; i < array.Length; i++) //loop threw whole array
            {
                var moveIndex = i; //set move index as an i for default

                do //do while to iterate backwards and find lower value than array[i]
                {
                    moveIndex--;

                    if (moveIndex < 0)
                    {
                        moveIndex = -1;
                        break;
                    }
                }
                while (array[i] < array[moveIndex]);

                moveIndex++; //add one to move index becouse we wanna move to the position of last value higher than array[i]

                var buffer = array[i]; //saving array[i]
                for (int j = i; j > moveIndex; j--) //loop whole all backward steps and move values one step forward in array
                {
                    array[j] = array[j - 1];
                }
                array[moveIndex] = buffer; //set value on move index to array[i] saved in buffer
            }
        }

        /// <summary>
        /// Insertion sort on long values.
        /// </summary>
        /// <param name="array">Long array to sort.</param>
        public static void Insertion(long[] array)
        {
            for (int i = 0; i < array.Length; i++) //loop threw whole array
            {
                var moveIndex = i; //set move index as an i for default

                do //do while to iterate backwards and find lower value than array[i]
                {
                    moveIndex--;

                    if (moveIndex < 0)
                    {
                        moveIndex = -1;
                        break;
                    }
                }
                while (array[i] < array[moveIndex]);

                moveIndex++; //add one to move index becouse we wanna move to the position of last value higher than array[i]

                var buffer = array[i]; //saving array[i]
                for (int j = i; j > moveIndex; j--) //loop whole all backward steps and move values one step forward in array
                {
                    array[j] = array[j - 1];
                }
                array[moveIndex] = buffer; //set value on move index to array[i] saved in buffer
            }
        }

        /// <summary>
        /// Insertion sort on float values.
        /// </summary>
        /// <param name="array">Float array to sort.</param>
        public static void Insertion(float[] array)
        {
            for (int i = 0; i < array.Length; i++) //loop threw whole array
            {
                var moveIndex = i; //set move index as an i for default

                do //do while to iterate backwards and find lower value than array[i]
                {
                    moveIndex--;

                    if (moveIndex < 0)
                    {
                        moveIndex = -1;
                        break;
                    }
                }
                while (array[i] < array[moveIndex]);

                moveIndex++; //add one to move index becouse we wanna move to the position of last value higher than array[i]

                var buffer = array[i]; //saving array[i]
                for (int j = i; j > moveIndex; j--) //loop whole all backward steps and move values one step forward in array
                {
                    array[j] = array[j - 1];
                }
                array[moveIndex] = buffer; //set value on move index to array[i] saved in buffer
            }
        }

        /// <summary>
        /// Insertion sort on double values.
        /// </summary>
        /// <param name="array">Double array to sort.</param>
        public static void Insertion(double[] array)
        {
            for (int i = 0; i < array.Length; i++) //loop threw whole array
            {
                var moveIndex = i; //set move index as an i for default

                do //do while to iterate backwards and find lower value than array[i]
                {
                    moveIndex--;

                    if (moveIndex < 0)
                    {
                        moveIndex = -1;
                        break;
                    }
                }
                while (array[i] < array[moveIndex]);

                moveIndex++; //add one to move index becouse we wanna move to the position of last value higher than array[i]

                var buffer = array[i]; //saving array[i]
                for (int j = i; j > moveIndex; j--) //loop whole all backward steps and move values one step forward in array
                {
                    array[j] = array[j - 1];
                }
                array[moveIndex] = buffer; //set value on move index to array[i] saved in buffer
            }
        }

        /// <summary>
        /// Sort with insertion algorithm on float values.
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
            Insertion(copiedArray); //sort array
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
