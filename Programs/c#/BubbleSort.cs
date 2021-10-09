using System;

namespace BubbleSort {
   class BubbleSort {
      static void Main(string[] args) {
         
         /* Initialize varibles */
         int[] arrayToSort = { 78, 55, 45, 98, 13 };
         int temp;
         
         /* Sort Array Here */
         for (int j = 0; j <= arrayToSortarrayToSort.Length - 2; j++) {
            for (int i = 0; i <= arrayToSort.Length - 2; i++) {
               if (arrayToSort[i] > arrayToSort[i + 1]) {
                  temp= arrayToSort[i + 1];
                  arrayToSort[i + 1] = arrayToSort[i];
                  arrayToSort[i] = temp;
               }
            }
         }
         
         /* Display  Sorted array */
         Console.WriteLine("Sorted:");
         foreach (int p in arrayToSort)
            Console.Write(p + " ");
         Console.Read();
      }
   }
}
