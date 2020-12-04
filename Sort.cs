using Bubble;
using Insertion;
using QuickSort;

namespace Sorting
{
    public struct Sort
    {
        #region Bubble

        /// <summary>
        /// Sorting an intiger array with using bubble algorithm.
        /// </summary>
        /// <param name="array">Int array to sort.</param>
        public static void Bubble(int[] array) => BubbleAlgorithm.Sort(array);

        /// <summary>
        /// Sorting an long array with using bubble algorithm.
        /// </summary>
        /// <param name="array">Long array to sort.</param>
        public static void Bubble(long[] array) => BubbleAlgorithm.Sort(array);

        /// <summary>
        /// Sorting an float array with using bubble algorithm.
        /// </summary>
        /// <param name="array">Float array to sort.</param>
        public static void Bubble(float[] array) => BubbleAlgorithm.Sort(array);

        /// <summary>
        /// Sorting an double array with using bubble algorithm.
        /// </summary>
        /// <param name="array">Double array to sort.</param>
        public static void Bubble(double[] array) => BubbleAlgorithm.Sort(array);

        /// <summary>
        /// Returns duration of algorithm calculations in ticks.
        /// </summary>
        /// <param name="array">Flaot array to sort.</param>
        /// <param name="type">Type of returned duration.</param>
        public static long BubbleTime(float[] array, TimeType type) => BubbleAlgorithm.Time(array, type); //returns time

        /// <summary>
        /// Returns prepared message of duration in ticks.
        /// </summary>
        /// <param name="array">Float array to sort.</param>
        /// <param name="type">Type of returned duration.</param>
        public static string BubbleTimePrint(float[] array, TimeType type)
        {
            if (type == TimeType.Both)
                return string.Format("Bubble Sorting Duration: {0} Miliseconds / {1} Ticks.", BubbleAlgorithm.Time(array, TimeType.Miliseconds), BubbleAlgorithm.Time(array, TimeType.Ticks)); //returns preprepared messageof time
            return string.Format("Bubble Sorting Duration: {0} {1}", BubbleAlgorithm.Time(array, type), type == TimeType.Ticks ? "Ticks." : "Miliseconds."); //returns preprepared message of time
        }

        #endregion

        #region QuickSort

        /// <summary>
        /// Sorting an intiger array with using quick sort algorithm.
        /// </summary>
        /// <param name="array">Int array to sort.</param>
        public static void QuickSort(int[] array) => QuickSortAlgorithm.QuickSort(array, 0, array.Length - 1);

        /// <summary>
        /// Sorting an long array with using quick sort algorithm.
        /// </summary>
        /// <param name="array">Long array to sort.</param>
        public static void QuickSort(long[] array) => QuickSortAlgorithm.QuickSort(array, 0, array.Length - 1);

        /// <summary>
        /// Sorting an float array with using quick sort algorithm.
        /// </summary>
        /// <param name="array">Float array to sort.</param>
        public static void QuickSort(float[] array) => QuickSortAlgorithm.QuickSort(array, 0, array.Length - 1);

        /// <summary>
        /// Sorting an double array with using quick sort algorithm.
        /// </summary>
        /// <param name="array">Double array to sort.</param>
        public static void QuickSort(double[] array) => QuickSortAlgorithm.QuickSort(array, 0, array.Length - 1);

        /// <summary>
        /// Returns duration of algorithm calculations in ticks.
        /// </summary>
        /// <param name="array">Float array to sort.</param>
        /// <param name="type">Type of returned duration.</param>
        public static long QuickSortTime(float[] array, TimeType type) => QuickSortAlgorithm.Time(array, type); //returns time

        /// <summary>
        /// Returns prepared message of duration in ticks.
        /// </summary>
        /// <param name="array">Float array to sort.</param>
        /// <param name="type">Type of returned duration.</param>
        public static string QuickSortTimePrint(float[] array, TimeType type)
        {
            if (type == TimeType.Both)
                return string.Format("Quick Sorting Duration: {0} Miliseconds / {1} Ticks.", QuickSortAlgorithm.Time(array, TimeType.Miliseconds), QuickSortAlgorithm.Time(array, TimeType.Ticks)); //returns preprepared messageof time
            return string.Format("Quick Sorting Duration: {0} {1}", QuickSortAlgorithm.Time(array, type), type == TimeType.Ticks ? "Ticks." : "Miliseconds."); //returns preprepared message of time
        }

        #endregion

        #region Insertion

        /// <summary>
        /// Insertion sort on int values.
        /// </summary>
        /// <param name="array">Int array to sort.</param>
        public static void Insertion(int[] array) => InsertionAlgorithm.Insertion(array);

        /// <summary>
        /// Insertion sort on long values.
        /// </summary>
        /// <param name="array">Long array to sort.</param>
        public static void Insertion(long[] array) => InsertionAlgorithm.Insertion(array);

        /// <summary>
        /// Insertion sort on float values.
        /// </summary>
        /// <param name="array">Float array to sort.</param>
        public static void Insertion(float[] array) => InsertionAlgorithm.Insertion(array);

        /// <summary>
        /// Insertion sort on double values.
        /// </summary>
        /// <param name="array">Double array to sort.</param>
        public static void Insertion(double[] array) => InsertionAlgorithm.Insertion(array);

        /// <summary>
        /// Returns duration of algorithm calculations in ticks.
        /// </summary>
        /// <param name="array">Float array to sort.</param>
        /// <param name="type">Type of returned duration.</param>
        public static long InsertionTime(float[] array, TimeType type) => InsertionAlgorithm.Time(array, type); //returns time

        /// <summary>
        /// Returns prepared message of duration in ticks.
        /// </summary>
        /// <param name="array">Float array to sort.</param>
        /// <param name="type">Type of returned duration.</param>
        public static string InsertionTimePrint(float[] array, TimeType type)
        {
            if(type == TimeType.Both)
                return string.Format("Insertion Sorting Duration: {0} Miliseconds / {1} Ticks.", InsertionAlgorithm.Time(array, TimeType.Miliseconds), InsertionAlgorithm.Time(array, TimeType.Ticks)); //returns preprepared messageof time
            return string.Format("Insertion Sorting Duration: {0} {1}", InsertionAlgorithm.Time(array, type), type == TimeType.Ticks ? "Ticks." : "Miliseconds."); //returns preprepared message of time
        }

        #endregion
    }

    public enum TimeType
    {
        Ticks,
        Miliseconds,
        Both
    }
}
