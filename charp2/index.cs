using System; 

 

class Program 

{ 

    static void Main(string[] args) 

    { 

        int[] arr = new int[30]; 

        Random rand = new Random(); 

        for (int i = 0; i < arr.Length; i++) 

        { 

            arr[i] = rand.Next(100); 

        } 

 

        // Сортування масиву бульбашковим методом 

        for (int i = 0; i < arr.Length - 1; i++) 

        { 

            for (int j = 0; j < arr.Length - 1; j++) 

            { 

                if (arr[j] > arr[j + 1]) 

                { 

                    int temp = arr[j]; 

                    arr[j] = arr[j + 1]; 

                    arr[j + 1] = temp; 

                } 

            } 

        } 

        Console.WriteLine("Бульбашковий метод:"); 

        foreach (int x in arr) 

        { 

            Console.Write(x + " "); 

        } 

        Console.ReadKey(); 

    } 

} 