using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Character
{
    internal class Cone
    {
    
        public static void PrintCone()
        {
            // 번이 캐릭터 도트 배열
            string[] patty =
            {
                "................................",
                "................................",
                "................................",
                "...............RR...............",
                ".............BBBBCC.............",
                "............BBBBBCCC............",
                "..........RBBBBBBBCCCC..........",
                ".........RBBBBBBBBBCCCC.........",
                ".........RRBRRRRRBBCCCC.........",
                ".........RRRRHHHHHHHCCC.........",
                "........RRHHHHSHHSHHHHH.........",
                ".........HHHSSSSHSSSHHH.........",
                "........HSSHSWKSSWKSGSS.........",
                "........HSSHSKKSSKKSHSS.........",
                ".........SSSSKKSSKKSSSS.........",
                "..........HSPSSKKSSPSH..........",
                "...........HSSSSSSSSH...........",
                ".............BBSSBB.............",
                "............BWWHHWWB............",
                "...........BBWHHHHWBB...........",
                "...........SSWGGGGWSS...........",
                "..........SSSWWHHWWSSS..........",
                "..........SSKWWWWWWKSS..........",
                "..........SSKBBBBBBKSS..........",
                ".............BBBBBB.............",
                ".............BBTTBB.............",
                ".............SSKKSS.............",
                ".............BWKKWB.............",
                "............RRRKKRRR............",
                "............WWWKKWWW............",
                "................................",
                "................................",
            };

            // 배열에서 한 줄씩 꺼내기
            foreach (string line in patty)
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

                        // 파란색
                        case 'T':
                            Console.BackgroundColor = ConsoleColor.Blue;
                            break;

                        // 진한 파란색
                        case 'B':
                            Console.BackgroundColor = ConsoleColor.DarkBlue;
                            break;

                        // 피부색
                        case 'S':
                            Console.BackgroundColor = ConsoleColor.Yellow;
                            break;

                        // 머리카락
                        case 'H':
                            Console.BackgroundColor = ConsoleColor.DarkYellow;
                            break;

                        // 녹색
                        case 'G':
                            Console.BackgroundColor = ConsoleColor.Green;
                            break;

                        // 빨간색
                        case 'R':
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                            break;

                        // 흰색
                        case 'W':
                            Console.BackgroundColor = ConsoleColor.White;
                            break;

                        // 볼터치
                        case 'P':
                            Console.BackgroundColor = ConsoleColor.Magenta;
                            break;

                        // 모자
                        case 'C':
                            Console.BackgroundColor = ConsoleColor.DarkMagenta;
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
