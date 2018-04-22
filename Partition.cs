using System;
using System.Collections.Generic;
using System.Text;

namespace Quicksort
{
    /**
     * Collection of partitiong methods and supporting methods
     */
    class Partition
    {
        /**
         * Swap method - swaps values of passed arguments
         * @param [INOUT]   Arg1 first argument
         * @param [INOUT]   Arg2 second argument
         */
        public static void Swap <Type> (ref Type Arg1, ref Type Arg2)
        {
            Type Arg3 = Arg1;
            Arg1 = Arg2;
            Arg2 = Arg3;
        }

        /**
         * Lomuto method - implementation of Lomuto partition algorithm
         * @param [INOUT] <Type>    Source array to be sorted
         * @param [IN] <delegate>   comparator camparing method
         * @param [IN] <int>        Begin first index of piece of Source array that is going to be sorted 
         * @param [IN] <int>        End last index of piece of Source array that is going to be sorted
         */
        public static int Lomuto <Type> (ref Type[] Source, Comparator <Type> comparator, int Begin, int End)
        {
            Type Pivot = Source[End];
            int i = Begin - 1;

            for(int j = Begin; j < End; j++)
            {
                if(comparator(Source[j], Pivot))
                {
                    i++;
                    Swap(ref Source[i], ref Source[j]);
                }
            }

            Swap(ref Source[i + 1], ref Source[End]);
            return (i+1);
        }

        /**
         * Hoare method - implementation of Hoare partition algorithm
         * @param [INOUT] <Type>    Source array to be sorted
         * @param [IN] <delegate>   comparator
         * @param [IN] <int>        Begin first index of piece of Source array that is going to be sorted 
         * @param [IN] <int>        End last index of piece of Source array that is going to be sorted
         */
        public static int Hoare <Type> (ref Type[] Source, Comparator<Type> comparator, int Begin, int End)
        {
            Type Pivot = Source[Begin];
            int i = Begin - 1;
            int j = End + 1;

            while (true)
            {
                do
                {
                    i++;
                }
                while (comparator(Source[i], Pivot));

                do
                {
                    j--;
                }
                while (comparator(Pivot, Source[j]));

                if (j <= i)
                {
                    return j;
                }

                Swap(ref Source[i], ref Source[j]);
            }
        }
    }
}
