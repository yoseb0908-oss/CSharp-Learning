using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Character
{
    internal class Lettuce
    {
        

        public static void PrintLettuce()
        {
            // 번이 캐릭터 도트 배열
            string[] Lettuce =
            {               
                "................................",
                "..............HHHH..............",
                "............HHHHHHHH............",
                "..........HHPPPPPPPPHH..........",
                ".........HHPPHHHHHHPPHH.........",
                ".........HPPHHHHHHHHPPHH........",
                "........HPPHHHHHHHHHHPPH........",
                "........HPHHKKSHSKKSHHPH........",
                "........HHHSSSSSSSSSHHHH........",
                ".......HHSHSWKSSSWKSHSHHH.......",
                ".......HSSHSKKSSSKKSHSSHH.......",
                ".......HSSHSKKSSSKKSHSSHH.......",
                ".......HHPHSPSSKKSSPHHPHH.......",
                ".......HHQHHSSSSSSSSHHQHH.......",
                ".........HHHPQWSSWHPHHHH........",
                "..........HHPQWWWWHPHHH.........",
                "..........HPPPQPPPHPPH..........",
                "..........PPQPGTGTHQPP..........",
                "..........PPQGTGTGHQPP..........",
                ".........PPPQPSSSSHQPPP.........",
                ".........PPQPPPPPPHHHHP.........",
                "..........SSWRWRWRHHWHS.........",
                "..........SSWRWRWWRHHH..........",
                "...........WRWWRWWWRW...........",
                ".............SSKKSS.............",
                ".............PPKKPP.............",
                ".............WWKKWW.............",
                "............QWPKKPWQ............",
                "............PPPKKPPP............",
                "............WWWKKWWW............",
                "................................",
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

                        // 피부색
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

                        // 회색
                        case 'R':
                            Console.BackgroundColor = ConsoleColor.Gray;
                            break;

                        // 진한회색
                        case 'D':
                            Console.BackgroundColor = ConsoleColor.DarkGray;
                            break;

                        // 볼터치
                        case 'P':
                            Console.BackgroundColor = ConsoleColor.Magenta;
                            break;

                        // 진한보라
                        case 'Q':
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