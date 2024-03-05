void WriteLineArray(int[] arr) {
   foreach (var element in arr)
   {
      Console.WriteLine(element);
   }
};

// Insertion Sort;
int [] InsertionSort (int [] arr) {
   var copy = new int[arr.Length];
   System.Array.Copy(arr, copy, arr.Length);

   for (var i = 1; i < copy.Length; ++i) {
      var current = copy[i];
      var firstIndex = i;

      for (var j = i-1; j >=0; --j) {
         var previous = copy[j];

         if (previous > current) {
             firstIndex = j;
            copy[j+1] = previous; 
         }
         else {
            break;
         }
      };
      copy[firstIndex] = current;
   }
   return copy;
};
Console.WriteLine("Сортування вставками");
WriteLineArray(InsertionSort(new [] {9,10,6,8,1,5,3,4,7}));

// Bubble Sort;
int [] BubbleSort (int [] arr) {
   var copy = new int[arr.Length];
   System.Array.Copy(arr, copy, arr.Length);
   for (var i = 1; i <= copy.Length-1; ++i) {
      for (var j = 0; j < copy.Length-1; ++j) {
         var last = copy[j];
         if (copy[j] > copy[j+1]) {
          copy[j] = copy[j+1];
          copy[j+1] = last;
         }
      }
   }
   return copy;
};
Console.WriteLine("Бульбашкове сортування");
WriteLineArray(BubbleSort(new [] {9,10,6,8,1,5,3,4,7}));

// Selection Sort;
int [] SelectionSort (int [] arr) {
   var copy = new int[arr.Length];
   System.Array.Copy(arr, copy, arr.Length);
   int temp;
   int smallest;
   for (var i = 0; i < copy.Length-1; i++) {
      smallest = i;
      for (var j = i + 1; j < copy.Length; j++) {
           if (copy[j] < copy[smallest]) {
         smallest = j;
      }
      }
      temp = copy[smallest];
      copy[smallest] = copy[i];
      copy[i] = temp;
   }
    return copy;
};
Console.WriteLine("Сортування вибором");
WriteLineArray(SelectionSort(new [] {9,10,6,8,1,5,3,4,7}));