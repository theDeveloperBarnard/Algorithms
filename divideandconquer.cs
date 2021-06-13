using System;

namespace Algorithms {
    public class sorting {

        public int[] insertionSort(int[] arr) {
            for(int i = 1; i < arr.Length; i++) {
                int key = arr[i];
                int j = i - 1;
                while(j >= 0 && arr[j] > key) {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;

            }
            return arr;
        }

        public void mergeSort(int[] arr, int first, int last) {
          if(first < last) {
              int middle = (first + last)/ 2;
              mergeSort(arr, first, middle);
              mergeSort(arr, middle + 1, last);
              merge(arr, first, middle, last);
          } 
          return;
        }
        private void merge(int[] arr, int first, int middle, int last) {
          int a = middle - first + 1;
          int b = last - middle;
          int[] left = new int[a + 1];
          int[] right = new int[b + 1];
          for(int i = 0; i < a; i++) {
              left[i] = arr[first + i];
          }
          for(int i = 0; i < b; i++) {
              right[i] = arr[middle + i + 1];
          }
          left[a] = Int32.MaxValue;
          right[b] = Int32.MaxValue;

          int leftCount = 0;
          int rightCount = 0;
          for(int i = first; i <= last; i++) {
              if(left[leftCount] <= right[rightCount]) {
                  arr[i] = left[leftCount];
                  leftCount++;
              }
              else {
                  arr[i] = right[rightCount];
                  rightCount++;
              }
          }


          return;
        }
    }
}