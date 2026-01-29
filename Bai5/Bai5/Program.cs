        
        Console.WriteLine("Lê Anh Quốc, Msv 2415053122234, Bài 5");
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

        if (arr == null || arr.Length == 0)
        {
            Console.WriteLine("Mảng rỗng hoặc chưa được khởi tạo, không xử lý!");
            return;
        }

        // Tìm giá trị lớn nhất (KHÔNG dùng Max)
        int max = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
        }

        Console.WriteLine("Giá trị lớn nhất trong mảng là: " + max);
