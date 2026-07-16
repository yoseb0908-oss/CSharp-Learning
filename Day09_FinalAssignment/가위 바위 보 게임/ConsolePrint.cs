using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public static class ConsolePrint
    {
        public static void Title()
        {
            Console.WriteLine("▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩");
            Console.WriteLine("▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩");
            Console.WriteLine("▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩");
            Console.WriteLine("▩▩▩▩▩                                                  ▩▩▩▩▩");
            Console.WriteLine("▩▩▩    HI-SCORE                           ♥ ♥ ♥ ♥ ♥      ▩▩▩");
            Console.WriteLine("▩▩▩    123000                                            ▩▩▩");
            Console.WriteLine("▩▩▩                                                      ▩▩▩");
            Console.WriteLine("▩▩▩                      S T A R T                       ▩▩▩");
            Console.WriteLine("▩▩▩                                                      ▩▩▩");
            Console.WriteLine("▩▩▩                                                      ▩▩▩");
            Console.WriteLine("▩▩▩                                                      ▩▩▩");
            Console.WriteLine("▩▩▩                    ARE YOU READY?                    ▩▩▩");
            Console.WriteLine("▩▩▩                                                      ▩▩▩");
            Console.WriteLine("▩▩▩                                                      ▩▩▩");
            Console.WriteLine("▩▩▩                     YES◀   NO                        ▩▩▩");
            Console.WriteLine("▩▩▩                                                      ▩▩▩");
            Console.WriteLine("▩▩▩▩                                             ?      ▩▩▩▩");
            Console.WriteLine("▩▩▩▩▩                                                  ▩▩▩▩▩");
            Console.WriteLine("▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩");
            Console.WriteLine("▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩");
            Console.WriteLine("▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩");
            Console.WriteLine("게임 시작(1) / 도움말(2) / 게임 종료(3)");
        }


        public static void ShowHelp()
        {
            char back = ' ';
            Console.Clear();

            while (back != 'B' && back != 'b')
            {
                Console.WriteLine("===================================================================");
                Console.WriteLine("               [도움말]              ");
                Console.WriteLine("===================================================================");
                Console.WriteLine(" - 1번을 누르면 게임이 시작됩니다.     ");
                Console.WriteLine(" - 3번을 누르면 게임이 종료됩니다.     ");
                Console.WriteLine( "===================================================================");
                Console.WriteLine(" - 게임은 총 5판입니다.  ");
                Console.WriteLine(" - 초기 소지금은 10,000원입니다.      ");
                Console.WriteLine(" - 최소 배팅금은 1,000원입니다.       ");
                Console.WriteLine(" - 이기면 배팅금의 x3배입니다.        ");
                Console.WriteLine(" - 지면 배팅한 금액을 잃습니다.        ");
                Console.WriteLine(" - 소지금보다 많은금액을 베팅할 수 없습니다. ");
                Console.WriteLine(" - 비길 경우 베팅금은 누적됩니다.  ");
                Console.WriteLine(" - 누적된 베팅금은 승자가 가져가게 됩니다.  ");
                Console.WriteLine(" - 게임 종료시까지 누적 판돈이 남아 있으면 플레이어에게 반환됩니다.  ");
                Console.WriteLine("===================================================================");
                Console.WriteLine("===================================================================");
                Console.WriteLine("===================================================================");
                Console.WriteLine("뒤로가려면 'B' 또는 'b'를 눌러주세요! ");

                back = char.Parse(Console.ReadLine()!);

                if (back != 'B' && back != 'b')
                {
                    Console.WriteLine("잘못 입력했습니다.");
                    Thread.Sleep(1000);
                    Console.Clear();
                }
            }
        }





    }
}
