using System;

namespace OOP.Character
{
    public class Bun
    {
 
        public static void PrintBun()
        {
            // 번이 캐릭터 도트 배열
            string[] bun =
            {
                "................................",
                "................................",
                "..........KKKKKKKKKKKK..........",
                "..........RRRRRRRRRRRR..........",
                "........KKKKKKKKKKKKKKKK........",
                "........RRRRRRYYYYRRRRRR........",
                ".......RRRRRRYYYYYYRRRRRR.......",
                ".......RRRRRRRGGGGRRRRRRR.......",
                ".......RRRRRRYYYYYYRRRRRR.......",
                "......RRRRRRRRRRRRRRRRRRRK......",
                "......RRRRRRRRRRRRRRRRRRRK......",
                ".....DDDHHHDDDDDDDDRRHHHRRK.....",
                ".....KKHHHKKKKKKKKKKKKHHHKK.....",
                ".......HHHSSSSSSSSSSSSHHH.......",
                ".......HHKSSSSSSSSSSSSKHH.......",
                ".......HHTSSWKSSSSWKSSTHH.......",
                ".......HHTSSKKSSSSKKSSTHH.......",
                ".......HHKPSSSSSSSSSSPKHH.......",
                ".......HHHSSSSSKKSSSSSHHH.......",
                "..........KKKKTTTTKKKK..........",
                "..........KRRRRWWRRRRK..........",
                "..........KRRYYYYYYRRK..........",
                "........KRRRYYYYYYYYRRRK........",
                ".......KSSRRYYYYYYYYRRSSK.......",
                ".......KSSRRYYOOOOYYRRSSK.......",
                ".......KSSRRYYOOOOYYRRSSK.......",
                ".......KK.KRRYYYYYYRRK.KK.......",
                "...........BBBBBBBBBB...........",
                "...........BBBBBBBBBB...........",
                "...........BBBBBBBBBB...........",
                "..........KWWWWK.KWWWWK.........",
                "..........KKKKKK.KKKKKK........."
            };

            // 배열에서 한 줄씩 꺼내기
            foreach (string line in bun)
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

                        // 노란색
                        case 'Y':
                            Console.BackgroundColor = ConsoleColor.Yellow;
                            break;

                        // 주황색
                        case 'O':
                            Console.BackgroundColor = ConsoleColor.DarkYellow;
                            break;

                        // 피부색
                        case 'S':
                            Console.BackgroundColor = ConsoleColor.Yellow;
                            break;

                        // 피부 그림자
                        case 'T':
                            Console.BackgroundColor = ConsoleColor.Black;
                            break;

                        // 머리카락
                        case 'H':
                            Console.BackgroundColor = ConsoleColor.DarkYellow;
                            break;

                        // 바지
                        case 'B':
                            Console.BackgroundColor = ConsoleColor.DarkBlue;
                            break;

                        // 흰색
                        case 'W':
                            Console.BackgroundColor = ConsoleColor.White;
                            break;

                        // 초록색
                        case 'G':
                            Console.BackgroundColor = ConsoleColor.Green;
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