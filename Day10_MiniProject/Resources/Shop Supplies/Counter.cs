using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Shop_Supplies
{
    internal class Counter
    {
      

        public static void PrintkitchenCounterTops()
        {
            // 번이 캐릭터 도트 배열
            string[] kitchenCounterTops =
            {
                
                "................................................",
                "................................................",
                "...........GTTTTG...............................",
                "...........GEAKKT...............................",
                "...........TTTTGT...............................",
                ".............GT.................................",
                "..........GGTGTTTTT..........RRRRRRRRR..........",
                "..........GKKKKKKKG..........RSSSSSSSR..........",
                "..........TKTTTTTKGKGTTGGKKKKRSHHHSKSR..........",
                "..........TKTTTTTKGKTEAKGKKKKRSEEESSSR..........",
                "..........TKTKKKTKGKTWGWTKKKKRSRRRSKSR..........",
                "..........TKKKTKKKTKTGWGTKKKKRSHHHSSSR..........",
                "......SSSSGTTKTKTTGSTWGWTSSSSRSSSSSKSRSSSS......",
                ".....SSSSTKKKKKKKKKTTRESTSSSSRSSSSSSSRSSSSS.....",
                "....SSSSSGGTKKKKKTTTGGTTGSSSSRRRRRRRRRSSSSSS....",
                "....SSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS....",
                "....SSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS....",
                "....RRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRR....",
                "....RRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRR....",
                ".....HHKHHKHHKHHKHHKHHKKKKHHKHHKHHKHHKHHKHH.....",
                ".....HHKHHKHHKHHKHHKHKSRRSKHKHHKHHKHHKHHKHH.....",
                ".....HHKHHKHHKHHKHHKKSRSSRSKKHHKHHKHHKHHKHH.....",
                ".....HHKHHKHHKHHKHHKSRSSSSRSKHHKHHKHHKHHKHH.....",
                ".....HHKHHKHHKHHKHHKSRRRRRRSKHHKHHKHHKHHKHH.....",
                ".....HHKHHKHHKHHKHHKSRSSSSRSKHHKHHKHHKHHKHH.....",
                ".....HHKHHKHHKHHKHHKSRSSSSRSKHHKHHKHHKHHKHH.....",
                ".....HHKHHKHHKHHKHHKKSRRRRSKKHHKHHKHHKHHKHH.....",
                ".....HHKHHKHHKHHKHHKHKSSSSKHKHHKHHKHHKHHKHH.....",
                "....HKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKH....",
                "....HHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHH....",
                "................................................",
                "................................................",



            };
            // 배열에서 한 줄씩 꺼내기
            foreach (string line in kitchenCounterTops)
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

                        // 노랑
                        case 'S':
                            Console.BackgroundColor = ConsoleColor.Yellow;
                            break;

                        // 진한노랑
                        case 'H':
                            Console.BackgroundColor = ConsoleColor.DarkYellow;
                            break;

                        // 회색
                        case 'G':
                            Console.BackgroundColor = ConsoleColor.Gray;
                            break;

                        // 진한 화색
                        case 'T':
                            Console.BackgroundColor = ConsoleColor.DarkGray;
                            break;

                        // 흰색
                        case 'W':
                            Console.BackgroundColor = ConsoleColor.White;
                            break;

                        // 진한빨간색
                        case 'R':
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                            break;

                        // 빨간색
                        case 'Q':
                            Console.BackgroundColor = ConsoleColor.Red;
                            break;

                        // 녹색
                        case 'E':
                            Console.BackgroundColor = ConsoleColor.Green;
                            break;
                        
                        // 진한녹색
                        case 'A':
                            Console.BackgroundColor = ConsoleColor.DarkGreen;
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
        