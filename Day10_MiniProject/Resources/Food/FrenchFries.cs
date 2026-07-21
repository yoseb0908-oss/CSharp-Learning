using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Food
{
    internal class FrenchFries
    {
       

        public static void PrintFrenchFries()
        {
            // 감자튀김 도트 배열
            string[] FrenchFries =
            {
                "................",
                "......SKSH......",
                "...HKSHSHSSKS...",
                "...HSSHSSSSSSS..",
                "..SSHSHSSHHSH...",
                "...SSHSHSSHSHS..",
                "...SSHHSSHSHH...",
                "...DDHSHSSHDD...",
                "...WDDDDDDDDW...",
                "...DWWHHHDWWD...",
                "...DDDHDDHDDD...",
                "....DDHHHHDD....",
                "....DDHDDHDD....",
                ".....DHHHDD.....",
                ".....DDDDDD.....",
                "................",


            };

            // 배열에서 한 줄씩 꺼내기
            foreach (string line in FrenchFries)
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

                        // 빨간색
                        case 'R':
                            Console.BackgroundColor = ConsoleColor.Red;
                            break;

                        // 진한빨간색
                        case 'D':
                            Console.BackgroundColor = ConsoleColor.DarkRed;
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
    