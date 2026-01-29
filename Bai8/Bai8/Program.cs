

        Console.WriteLine("Lê Anh Quốc, MSV 2415053122234, Bài 8");
        Console.Write("Nhập một câu: ");
        string sentence = Console.ReadLine();

        // Check chuỗi null
        if (sentence == null)
        {
            Console.WriteLine("❌ Chuỗi null, không xử lý!");
            return;
        }

        string longestWord = FindLongestWord(sentence);

        if (longestWord != null)
        {
            Console.WriteLine("✅ Từ dài nhất trong câu là: " + longestWord);
            Console.WriteLine("Độ dài: " + longestWord.Length);
        }

    // Hàm tìm từ dài nhất
    static string FindLongestWord(string str)
    {
        if (str == null)
            return null;

        string[] words = str.Split(
            new char[] { ' ' },
            StringSplitOptions.RemoveEmptyEntries
        );

        if (words.Length == 0)
            return null;

        string maxWord = words[0];

        for (int i = 1; i < words.Length; i++)
        {
            if (words[i].Length > maxWord.Length)
            {
                maxWord = words[i];
            }
        }

        return maxWord;
    }
