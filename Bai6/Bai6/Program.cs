    
        Console.WriteLine("Lê Anh Quốc Msv: 2415053122234, Bài 6");
        Console.Write("Nhập số phần tử n: ");
        int n = int.Parse(Console.ReadLine());

        int[] arr = null;

        if (n > 0)
        {
            arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhập phần tử [{i}]: ");
                arr[i] = int.Parse(Console.ReadLine());
            }
        }

        int countEven = CountEven(arr);
        Console.WriteLine("✅ Số phần tử chẵn trong mảng là: " + countEven);

    // Hàm đếm số phần tử chẵn
    static int CountEven(int[] arr)
    {
        if (arr == null)
            return 0;

        int count = 0;
        foreach (int x in arr)
        {
            if (x % 2 == 0)
                count++;
        }
        return count;
    }
