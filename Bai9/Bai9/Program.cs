

        Console.WriteLine("Lê Anh Quốc Msv: 2415053122234 Bài 9");
        string[] arr = new string[]
        {
            "Hello",
            null,
            "",
            "CSharp",
            "   ",
            "World"
        };

        int count = CountValidStrings(arr);

        Console.WriteLine("✅ Số chuỗi khác null và khác rỗng là: " + count);

    // Hàm đếm chuỗi hợp lệ
    static int CountValidStrings(string[] arr)
    {
        if (arr == null)
            return 0;

        int count = 0;

        foreach (string s in arr)
        {
            if (!string.IsNullOrEmpty(s) && !string.IsNullOrWhiteSpace(s))
            {
                count++;
            }
        }

        return count;
    }
