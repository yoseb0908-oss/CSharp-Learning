using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Logo
{
    internal class Logo
    {
       

        public static void PrintLettuce()
        {
            // 번이 캐릭터 도트 배열
            string[] Lettuce =
            {
                "................................",
                "................................",
                "................................",
                ".............RRRRRR.............",
                "...........RRHSHSHHRR...........",
                ".........RRRHHHHHHSHRRR.........",
                ".........RRHHSHSHSHHHRRR........",
                ".......RRRGTHHHHHHHHTGRRR.......",
                ".......RRHGGGGGGGGGGGGHRRR......",
                "......RRHWRRRGGGGGGRRRWHRRR.....",
                ".....RRHHWHHHRRRRRRHHHWHHRR.....",
                ".....RRHWWWHHHHHHHHHHWWWHRR.....",
                ".....RRHWWWWWWWWWWWWWWWWHRR.....",
                ".....RHWWWHHHHHHHHHHHWWWWHR.....",
                ".....RHWWWHRRRRRRRRRHWWWWHR.....",
                ".....RHRRWHHRRHHHHRRHWRRWHR.....",
                ".....RHWWWWHRRHWWHRRHWWWWHR.....",
                ".....RHRWWWHRRRRRRRHHWWRWHR.....",
                ".....RHWWWWHRRHWWHRRHWWWHHR.....",
                "..HHHRRHWWHHRRHHHHRRHWWWHRRHHH..",
                "..HRRHHHHWRRRRRRRRRRHWWHHHHRRH..",
                "....RRRHHHHHHHHHHHHHHHHHRRRR....",
                "...RHHRRRRRRRRRRRRRRRRRRHRHRR...",
                "..HRHRHRRHHRRHHRRHHRRHRRHHHRRH..",
                "..HRHHRRRHRHRHRHRHRRHRHRHRHRRH..",
                "...RHRHRRHRHRHHRRHHRHRHRHRHRR...",
                "..HRHHRRRHRHRHRHRHRRHHHRHRHRH...",
                "....RRRHRHHRRHRHRHHRHRHRRRR.....",
                "....HHHRRRRRRRRRRRRRRRRRKHH.....",
                "..........HHHHHHHHHHH...........",
                "............RRRRRRR.............",
                "................................",
     
            };

            // 배열에서 한 줄씩 꺼내기
            foreach (string line in Lettuce)
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

                        // 녹색
                        case 'G':
                            Console.BackgroundColor = ConsoleColor.Green;
                            break;

                        // 진한 녹색
                        case 'T':
                            Console.BackgroundColor = ConsoleColor.DarkGreen;
                            break;

                        // 흰색
                        case 'W':
                            Console.BackgroundColor = ConsoleColor.White;
                            break;

                        // 빨간색
                        case 'R':
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
    
