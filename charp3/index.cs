using System; 

 

class Program 

{ 

    static void Main(string[] args) 

    { 

        // Створюємо масив з 30 випадкових цілих чисел в діапазоні від 0 до 99 

        int[] arr = new int[30]; 

        Random rand = new Random(); 

        for (int i = 0; i < arr.Length; i++) 

        { 

            arr[i] = rand.Next(100); 

        } 

        // Сортування масиву за допомогою алгоритму сортування вибором 

        for (int i = 0; i < arr.Length - 1; i++) 

        { 

            int minIndex = i; 

            for (int j = i + 1; j < arr.Length; j++) 

            { 

                if (arr[j] < arr[minIndex]) 

                { 

                    minIndex = j; 

                } 

            } 

            int temp = arr[minIndex]; 

            arr[minIndex] = arr[i]; 

            arr[i] = temp; 

        } 

        Console.WriteLine("Масив, за допомогою алгоритму сортування вибором:"); 

        foreach (int x in arr) 

        { 

            Console.Write(x + " "); 

        } 

        Console.ReadKey(); 

    } 

} 