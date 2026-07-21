using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Shop_Supplies
{
    internal class Table
    {
       
        public static void PrintTable()
        {
            // 번이 캐릭터 도트 배열
            string[] Table =
            {
                "................................",
                "................................",
                "................................",
                "................................",
                ".....SSSSSSSSSSSSSSSSSSSSS......",
                "....SSHHHHHHHHHHHHHHHHHHHSS.....",
                "....SHHHHHHHHHHHHHHHHHHHHHS.....",
                "....SHHHHHHHHHHHHHHHHHHHHHS.....",
                "....SHHHHHHHHHHHHHHHHHHHHHS.....",
                "....SHHHHHHHHHHHHHHHHHHHHHS.....",
                "....SHHHHHHHHHHHHHHHHHHHHHS.....",
                "....SHHHHHHHHHHHHHHHHHHHHHS.....",
                "....SHHHHHHHHHHHHHHHHHHHHHS.....",
                "....SSHHHHHHHHHHHHHHHHHHHSS.....",
                "....HSSSSSSSSSSSSSSSSSSSSSH.....",
                "....HHHHHHHHHHHHHHHHHHHHHHH.....",
                ".....HHHHHHHHHHHHHHHHHHHHH......",
                ".............TGWGT..............",
                "...........TTTGGGTTT............",
                ".........TTGGGGWGGGGTT..........",
                "........TGGGGWGGGWGGGGT.........",
                "........TGWWWGWWWGWWWGT.........",
                ".........TTGGGGGGGGGTT..........",
                "...........TTTTTTTTT............",
                "................................",
                "................................",
                "................................",
                "................................",
                "................................",
                "................................",
                "................................",
                "................................",
            };

            // 배열에서 한 줄씩 꺼내기
            foreach (string line in Table)
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

                        // 진한회색
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

