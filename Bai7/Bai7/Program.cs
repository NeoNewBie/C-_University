
        Console.WriteLine("Lê Anh Quốc Msv: 2415053122234, Bài 7" );
        Console.Write("Nhập họ tên: ");
        string fullName = Console.ReadLine();

        // Check chuỗi null
        if (fullName == null)
        {
            Console.WriteLine("❌ Chuỗi null, không thể tách!");
            return;
        }

        // Tách chuỗi thành mảng
        string[] words = SplitName(fullName);

        // Check mảng kết quả null
        if (words == null)
        {
            Console.WriteLine("❌ Mảng kết quả null, không in!");
            return;
        }

        Console.WriteLine("✅ Các từ trong họ tên:");
        foreach (string word in words)
        {
            Console.WriteLine(word);
        }

    // Hàm tách họ tên
    static string[] SplitName(string name)
    {
        if (name == null)
            return null;

        // Tách theo khoảng trắng, loại bỏ khoảng trắng thừa
        string[] result = name.Split(
            new char[] { ' ' },
            StringSplitOptions.RemoveEmptyEntries
        );

        return result;
    }
