using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Shop_Supplies
{
    internal class Door
    {
       

        public static void PrintChair()
        {
            // 번이 캐릭터 도트 배열
            string[] Chair =
            {
                "................................",
                "................................",
                "................................",
                "................................",
                "................................",
                ".....HHHHHHHHHHHHHHHHHHHHHH.....",
                ".....HHHHHHHHHHHHHHHHHHHHHH.....",
                ".....HHKKKKKKKKKKKKKKKKKKHH.....",
                ".....HHKDDDDDDDDDDDDDDDDKHH.....",
                ".....HHKDKKKKKKKKKKKKKKDKHH.....",
                ".....HHKDKBBBFWWFBBBBFKDKHH.....",
                ".....HHKDKBBFWWBBBBBFWKDKHH.....",
                ".....HHKDKBFWWBBBBBFWWKDKHH.....",
                ".....HHKDKFWWBBBBBFWWWKDKHH.....",
                ".....HHKDKWWFBBBBBFWWWKDKHH.....",
                ".....HHKDKWFBBBBFWWWWFKDKHH.....",
                ".....HHKDKFBBBBFWWWWFFKDKHH.....",
                ".....HHKDKBBBBFWWWWFFBKDKHH.....",
                ".....HHKDKBBBFWWWWFFBFKDKHH.....",
                ".....HHKDKBBFWWWWFFBFBKDKHH.....",
                ".....HHKDKBFWWWWFFBFBBKDKHH.....",
                ".....HHKDKBFWWWFFBFBBBKDKHH.....",
                ".....HHKDKFWWWFFBFBBBBKDKHH.....",
                ".....HHKDKWWWFFBFFBBBBKDKHH.....",
                ".....HHKDKKKKKKKKKKKKKKKKHH.....",
                ".....HHKDDDDDDDDDDDDDKHHKHH.....",
                ".....HHKDDDDDDDDDDDKKKHHKHH.....",
                ".....HHKDKKKKKKKKKKKHHHHKHH.....",
                ".....HHKDKDDDDKDDKDKKKHHKHH.....",
                ".....HHKDKDDDDKDDKDDDKKKKHH.....",
                ".....HHKDKDDDDKDDKDDDDKDKHH.....",
                ".....HHKDKDDDDKDDKDDDDKDKHH.....",
                ".....HHKDKDDDDKDDKDDDDKDKHH.....",
                ".....HHKDKDDDDKDDKDDDDKDKHH.....",
                ".....HHKDKDDDDKDDKDDDDKDKHH.....",
                ".....HHKDKDDDDKDDKDDDDKDKHH.....",
                ".....HHKDKDDDDKDDKDDDDKDKHH.....",
                ".....HHKDKDDDDKDDKDDDDKDKHH.....",
                ".....HHKDKDDDDKDDKDDDDKDKHH.....",
                ".....HHKDDDDDDDDDDDDDDDDKHH.....",
                ".....HHKKKKKKKKKKKKKKKKKKHH.....",
                ".....GTTTGGGGGGGGGGGGGGTTTG.....",
                ".....GTTTTTTTTTTTTTTTTTTTTG.....",
                ".....GGGGGGGGGGGGGGGGGGGGGG.....",
                "................................",
                "................................",
                "................................",
                "................................",


            };

            // 배열에서 한 줄씩 꺼내기
            foreach (string line in Chair)
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

                        // 회색
                        case 'G':
                            Console.BackgroundColor = ConsoleColor.Gray;
                            break;

                        // 회색
                        case 'T':
                            Console.BackgroundColor = ConsoleColor.DarkGray;
                            break;

                        // 빨간색
                        case 'R':
                            Console.BackgroundColor = ConsoleColor.Red;
                            break;

                        // 진한빨간색
                        case 'D':
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                            break;

                        // 진한파란색
                        case 'B':
                            Console.BackgroundColor = ConsoleColor.DarkBlue;
                            break;

                        // 진한파란색
                        case 'F':
                            Console.BackgroundColor = ConsoleColor.Blue;
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
    