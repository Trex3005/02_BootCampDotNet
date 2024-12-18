﻿internal class Program
{
    private static void Main(string[] args)
    {

        // Setting để hiển thị những ký tự đặc biệt trên console
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        // ẩn con tro chuột
        Console.CursorVisible = false;

        // vẽ cây thông
        string[] tree = {
            "        *        ",
            "       ***       ",
            "      *****      ",
            "     *******     ",
            "    *********    ",
            "   ***********   ",
            "  *************  ",
            " *************** ",
            "       |||       ",
            "       |||       "
        };

        while (true)
        {
            Console.Clear();
            // lấy chiều dài, chiều rộng của console
            // để vẽ cây thông và tuyết rơi
            int width = Console.WindowWidth;
            int heigh = Console.WindowHeight;
            // define biến random để tạo hiệu ứng ngẫu nhiên
            Random rand = new Random();

            // tạo hiệu ứng tuyết rơi
            char[] snowflakes = { '.', '*', '+', 'o' };

            // vẽ cây thông
            for (int i = 0; i < tree.Length; i++) // for này để vẽ từng dòng cây thông
            {
                Console.SetCursorPosition((width - tree[i].Length) / 2, (heigh - tree.Length) / 2 + i);
                foreach (var ch in tree[i]) // foreach này để vẽ từng ký tự
                {
                    if (ch == '*')
                    {
                        // vẽ màu ngẫu nhiên cho cây thông
                        Console.ForegroundColor = (ConsoleColor)rand.Next(8, 16);
                    }
                    else
                    {
                        // vẽ màu xanh lá cho thân cây
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    Console.Write(ch);
                }
            }
            // tạo số lượng tuyết rơi

            int snowCount = 100;
            // vẽ tuyết rơi
            for (int i = 0; i < snowCount; i++)
            {
                // setup vị trí vẽ tuyết rơi
                // sẽ dùng random để vẽ tuyết trên console
                int snowX = rand.Next(0, width);
                int snowY = rand.Next(0, heigh / 2);

                // set vị trí vẽ tuyết rơi
                Console.SetCursorPosition(snowX, snowY);
                // set màu cho tuyết rơi
                Console.ForegroundColor = ConsoleColor.White;
                // vẽ tyueets rơi
                Console.Write(snowflakes[rand.Next(snowflakes.Length)]);
            }

            Thread.Sleep(150);
        }
    }
}
