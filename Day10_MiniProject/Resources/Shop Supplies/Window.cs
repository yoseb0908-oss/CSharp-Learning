using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Shop_Supplies
{
    internal class Window
    {
      
        public static void PrintWindow()
        {
            // 번이 캐릭터 도트 배열
            string[] Window =
            {
                "................................",
                "................................",
                "................................",
                "................................",
                ".....HHHHHHHHHHHHHHHHHHHHHH.....",
                ".....HRRRRRRRRRRRRRRRRRRRRH.....",
                ".....HKKKKKKKKKKKKKKKKKKKKH.....",
                ".....HRKNNNNBWBRRNNNNNWWKRH.....",
                ".....HRKNNNBWWNRRNNNNBWBKRH.....",
                ".....HRKNNBWWBNRRNNNBWBNKRH.....",
                ".....HRKNBWBNBNRRNNBWBNNKRH.....",
                ".....HRKBWBNNNNRRNBWBNNNKRH.....",
                ".....HRKWBNNNNNRRBWBNNNNKRH.....",
                ".....HRKRRRRRRRRRRRRRRRRKRH.....",
                ".....HRKRRRRRRRRRRRRRRRRKRH.....",
                ".....HRKNNNNNBWRRNNNNNBWKRH.....",
                ".....HRKNNNNBWBRRNNNNBWBKRH.....",
                ".....HRKNNBWWBNRRNNNBWBNKRH.....",
                ".....HRKNNBWBNNRRNNBWBNNKRH.....",
                ".....HRKBBWNNNNRRBBWBNNNKRH.....",
                ".....HRKWWBBNNNRRWWBBNNNKRH.....",
                ".....HRKWBNNNNNRRWWNNNNNKRH.....",
                ".....HKKKKKKKKKKKKKKKKKKKKH.....",
                ".....HRRRRRRRRRRRRRRRRRRRRH.....",
                ".....HTTTTGGTTSETGGETGETTTH.....",
                ".....HTESEEGSGGSGEEGESEGETH.....",
                ".....HEGGSEEEGGEEGSEEGGESEH.....",
                ".....HTTTTTTTTTTTTTTTTTTTTH.....",
                "......TTTTTTTTTTTTTTTTTTTT......",
                "................................",
                "................................",
                "................................",
               


            };

            // 배열에서 한 줄씩 꺼내기
            foreach (string line in Window)
            {
                // 한 줄 안의 문자를 하나씩 꺼내기
                foreach (char pixel in line)
                {
                    switch (pixel)
                    {
                        // 투명 배경
                        case '.':
                            Console.BackgroundColor = ConsoleColor.Black;
                            break;

                        // 검은색 외곽선
                        case 'K':
                            Console.BackgroundColor = ConsoleColor.Black;
                            break;

                        // 노란색
                        case 'S':
                            Console.BackgroundColor = ConsoleColor.Yellow;
                            break;

                        // 진한노랑
                        case 'H':
                            Console.BackgroundColor = ConsoleColor.DarkYellow;
                            break;

                        // 흰색
                        case 'W':
                            Console.BackgroundColor = ConsoleColor.White;
                            break;

                        // 녹색
                        case 'G':
                            Console.BackgroundColor = ConsoleColor.Green;
                            break;

                        // 진한녹색
                        case 'E':
                            Console.BackgroundColor = ConsoleColor.DarkGreen;
                            break;

                        // 진한빨간색
                        case 'R':
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                            break;

                        // 파란색
                        case 'B':
                            Console.BackgroundColor = ConsoleColor.Blue;
                            break;

                        // 진한파란색
                        case 'N':
                            Console.BackgroundColor = ConsoleColor.DarkBlue;
                            break;

                        // 회색
                        case 'T':
                            Console.BackgroundColor = ConsoleColor.DarkGray;
                            break;

                        default:
                            Console.BackgroundColor = ConsoleColor.Black;
                            break;
                    }

                    // 가로 비율을 맞추기 위해 공백 두 칸 출력
                    Console.Write("  ");
                }

                Console.ResetColor();
                Console.WriteLine();






            }
        }

    }
}
   