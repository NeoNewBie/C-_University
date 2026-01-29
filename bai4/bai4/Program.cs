       

        Console.WriteLine("Lê Anh Quốc, Msv: 2415053122234, Bài 4");
        int n;

        Console.Write("Nhập số phần tử n: ");
        n = int.Parse(Console.ReadLine());

        int[] arr = null;   // khai báo mảng nhưng CHƯA khởi tạo

        if (n > 0)
        {
            arr = new int[n];   // khởi tạo mảng

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhập phần tử [{i}]: ");
                arr[i] = int.Parse(Console.ReadLine());
            }
        }

        // Check null
        if (arr == null)
        {
            Console.WriteLine("Lỗi: Mảng chưa được khởi tạo!");
            return;
        }

        // Tính tổng
        int sum = 0;
        foreach (int x in arr)
        {
            sum += x;
        }

        Console.WriteLine("Tổng các phần tử trong mảng là: " + sum);
