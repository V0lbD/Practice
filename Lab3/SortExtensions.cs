namespace Lab3;

public static class SortExtensions
{
    public enum SortingOrder // порядок сортировки
    {
        Ascending = 0, // по возрастанию
        Descending = 1 // по убыванию
    }
    
    public enum SortingAlgorithm  // алгоритмы сортировки
    {
        InsertionSort, // вставками
        SelectionSort, // выбором
        HeapSort,      // пирамидальная
        QuickSort,     // быстрая
        MergeSort      // слиянием
    }
    
    #region перегруженные методы расширения метода List.Sort()
    
    // четвёртого параметра нет
    public static T[] Sort<T>(
        this T[] collectionToSort, SortingOrder sortingOrder, SortingAlgorithm sortingAlgorithm)
    {
        var comparer = Comparer<T>.Default; // берёт comparer из System.Collections.Generic\
        return collectionToSort.Sort(sortingOrder, sortingAlgorithm, comparer);
    }

    // четвёртый параметр - значение типа Comparer<T>
    public static T[] Sort<T>(
        this T[] collectionToSort, SortingOrder sortingOrder, SortingAlgorithm sortingAlgorithm, Comparer<T> comparer)
    {
        return collectionToSort.Sort(sortingOrder, sortingAlgorithm, comparer as IComparer<T>);
    }
    
    // четвёртый параметр - значение типа IComparer<T>
    public static T[] Sort<T>(
        this T[] collectionToSort, SortingOrder sortingOrder, SortingAlgorithm sortingAlgorithm, IComparer<T> comparer)
    {
        switch (sortingAlgorithm)
        {
            case SortingAlgorithm.InsertionSort:
                return InsertionSort(collectionToSort, sortingOrder, comparer);
            case SortingAlgorithm.SelectionSort:
                return SelectionSort(collectionToSort, sortingOrder, comparer);
            case SortingAlgorithm.MergeSort:
                return MergeSort(collectionToSort, sortingOrder, comparer);
            case SortingAlgorithm.HeapSort:
                return HeapSort(collectionToSort, sortingOrder, comparer);
            case SortingAlgorithm.QuickSort:
                return QuickSort(collectionToSort, sortingOrder, comparer); // можно не писать данный case, однако пусть будет, т.к. понадобится при добавлении новых методов
            default:
                return QuickSort(collectionToSort, sortingOrder, comparer);
        }
    }

    // четвёртый параметр - делегат Comparison<T> на объект которого подписан метод, задающий внешнее отношение порядка на пространстве элементов типа T
    
    public static T[] Sort<T>(
        this T[] collectionToSort, SortingOrder sortingOrder, SortingAlgorithm sortingAlgorithm, Comparison<T> comparison)
    {
        var comparer = Comparer<T>.Create(comparison);
        return collectionToSort.Sort(sortingOrder, sortingAlgorithm, comparer);
    }
    #endregion

    #region вспомогательные методы для сортировок

    private static void Swap<T>(T[] a, int i, int j)
    {
        (a[i], a[j]) = (a[j], a[i]); // swap two variables without using a temporary variable
    }
    
    private static bool CompareInner<T>(T x, T y, SortingOrder sortingOrder, IComparer<T> comparer)
    {
        return ((sortingOrder == SortingOrder.Ascending) && (comparer.Compare(x, y) < 0));
    }
    
    #endregion

    #region InsertionSort

    private static T[] InsertionSort<T>(T[] keys, SortingOrder sortingMode, IComparer<T> comparer)
    {
        
    }

    #endregion

    #region SelectionSort

    private static T[] SelectionSort<T>(T[] keys, SortingOrder sortingMode, IComparer<T> comparer)
    {
        
    }

    #endregion

    #region HeapSort

    private static T[] HeapSort<T>(T[] keys, SortingOrder sortingMode, IComparer<T> comparer)
    {
        
    }

    #endregion
    
    #region QuickSort

    private static T[] QuickSort<T>
        (T[] keys, SortingOrder sortingMode, IComparer<T> comparer)
    {
        
    }

    #endregion

    #region MergeSort

    private static T[] MergeSort<T>(T[] keys, SortingOrder sortingMode, IComparer<T> comparer)
    {
        
    }

    #endregion
    
    
    #region алгоритмы сортировки
    
    
    
    #endregion
}