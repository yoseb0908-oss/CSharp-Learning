using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Character
{
    internal class Patty
    {
        
        public static void PrintPatty()
        {
            // 번이 캐릭터 도트 배열
            string[] patty =
            {
                "................................",
                "................................",
                "................................",
                ".............WWWWWW.............",
                "...........WWGWWWWGWW...........",
                "..........WWWWWWWWWWWW..........",
                ".........WWWWTWWWWTWWWW.........",
                "........WWWTWWTWWTWWWTWW........",
                "........WWGWTTTTTTTTGWWW........",
                ".........WWTWWWWWWWWTWWW........",
                "..........WRRRRRRRRRRW..........",
                "..........DRRRHHHHRRRD..........",
                "..........DHHHHHSSHHHD..........",
                ".........HHHSWKSSWKSHHH.........",
                "........HHSHSKKSSKKSHSHH........",
                "........HHSHPKKSSKKPHSHH........",
                ".........HHHPSSKKSSPHHH.........",
                "............WWRRRRWW............",
                "...........WWWWRRWWWW...........",
                "..........WWGWRWWRWGWW..........",
                "..........WWGWGWWWWGWW..........",
                "..........SSKWGWWWWKSS..........",
                ".........SSSKRRRRRRKSSS.........",
                ".........SSKKRRRRRRKKSS.........",
                "............RRRRRRRR............",
                "............RRRRRRRR............",
                "............RRRRRRRR............",
                ".............GGKKGG.............",
                ".............WWKKWW.............",
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

                        // 빨간색
                        case 'R':
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                            break;

                        // 어두운 빨간색
                        case 'D':
                            Console.BackgroundColor = ConsoleColor.Red;
                            break;

                        // 피부색
                        case 'S':
                            Console.BackgroundColor = ConsoleColor.Yellow;
                            break;

                        // 머리카락
                        case 'H':
                            Console.BackgroundColor = ConsoleColor.DarkYellow;
                            break;

                        // 진한 회색
                        case 'G':
                            Console.BackgroundColor = ConsoleColor.DarkGray;
                            break;

                        //  회색
                        case 'T':
                            Console.BackgroundColor = ConsoleColor.Gray;
                            break;

                        // 흰색
                        case 'W':
                            Console.BackgroundColor = ConsoleColor.White;
                            break;

                        // 볼터치
                        case 'P':
                            Console.BackgroundColor = ConsoleColor.Magenta;
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
   