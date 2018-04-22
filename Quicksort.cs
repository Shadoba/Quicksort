using System;
using System.Collections.Generic;
using System.Text;



namespace Quicksort
{
    /* 
     * comparator delegete
     */
    delegate bool Comparator<Type>(Type Arg1, Type Arg2);
    /* 
     * partition delegete of partitioning method
     */
    delegate int partition <Type> (ref Type [] Source, Comparator <Type> comparator, int Begin, int End);

    /*
     * Class containing quick sort method
     */
    class Quicksort
    {
        /**
        * quicksort method - Sorts elemenets if pointed by Begin and End piece of Source array
        * @param [INOUT] <Type>    Source array to be sorted
        * @param [IN] <delegate>   comparator comparing method
        * @param [IN] <delegate>   partitiion partitioning method
        * @param [IN] <int>        Begin first index of piece of Source array that is going to be sorted 
        * @param [IN] <int>        End last index of piece of Source array that is going to be sorted
        */
        public static void quicksort <Type> (ref Type[] Source, Comparator <Type> comparator, partition <Type> part, int Begin, int End)
        {
            if(Begin < End)
            {
                int PartitioningPoint = part(ref Source, comparator, Begin, End);
                quicksort <Type> (ref Source, comparator, part, Begin, PartitioningPoint - 1);
                //TODO Hoare partition should use this bounds: PartitioningPoint, End, but seems it works anyway
                quicksort <Type> (ref Source, comparator, part, PartitioningPoint + 1, End);
            }
        }
    }
}
