using Common;
using System;
using System.Threading;

namespace _0716_서요셉
{
    enum RockPaperScissors_
    {
        NONE,
        ROCK,       // 주먹
        PAPER,      // 보
        SCISSORS    // 가위
    }

    class Player // 가위, 바위, 보 준비
    {
        public static RockPaperScissors_ Select()
        {
            Console.Write("가위, 바위, 보 중 하나를 입력하세요 > ");
            string input = Console.ReadLine()!;

            if (input == "가위")
            {
                return RockPaperScissors_.SCISSORS;
            }
            else if (input == "바위")
            {
                return RockPaperScissors_.ROCK;
            }
            else if (input == "보")
            {
                return RockPaperScissors_.PAPER;
            }
            else
            {
                return RockPaperScissors_.NONE;
            }
        }

    }

    class Ingame
    {
       private int _count = 0; // 게임시작화면창 딜레이
       private int _money = 10000; // 내 소지금
       private int _pot = 0; // 비겼을 때 누적되는 돈
       private int _winCount = 0; // 이긴 수 카운트
       private int _loseCount = 0; // 진 수 카운트
       private int _drawCount = 0; // 비긴 수 카운트

        public Ingame(int count, int money, int pot, int winCount, int loseCount, int drawCount)
        {
            _count = count;
            _money = money;
            _pot = pot;
            _winCount = winCount;
            _loseCount = loseCount;
            _drawCount = drawCount;
        }

        public void PlayGame()
        {
            Console.Clear();

            int money = 10000;
            int pot = 0;
            int winCount = 0;
            int loseCount = 0;
            int drawCount = 0;

            for (int i = 1; i <= 5; i++)
            {
                int bet = GameMoney(ref money);

                money -= bet;
                pot += bet;

                Console.WriteLine($"이번 베팅금 : {bet}원");
                Console.WriteLine($"남은 소지금 : {money}원");
                Console.WriteLine($"누적 판돈 : {pot}원");

                Thread.Sleep(2000);

                int result = Computer.PlayOneRound();

                if (result == 1)
                {
                    winCount++;

                    Console.WriteLine("축하드립니다. 승리하셨습니다!");

                    money += pot * 3;
                    pot = 0;
                }
                else if (result == 0)
                {
                    drawCount++;

                    Console.WriteLine("비겼습니다. 판돈이 다음 판으로 누적됩니다.");

                    
                }
                else if (result == -1)
                {
                    loseCount++;

                    Console.WriteLine("졌습니다. 판돈을 모두 잃었습니다.");

                    pot = 0;
                }
                else if (result == -2)
                {
                    Console.WriteLine( "잘못 입력했으므로 이번 판을 다시 진행합니다.");

                    money += bet;
                    pot -= bet;
                    i--;
                }

                Console.WriteLine();
                Console.WriteLine($"현재 소지금 : {money}원");
                Console.WriteLine($"현재 누적 판돈 : {pot}원");

                Thread.Sleep(2000);

                if (money <= 0)
                {
                    Console.WriteLine("소지금을 모두 잃었습니다.");
                    Console.WriteLine("게임을 종료합니다.");
                    break;
                }
            }

            Console.Clear();
            Console.WriteLine("================최종결과=================");
            Console.WriteLine($"총 승리 횟수 : {winCount}회");
            Console.WriteLine($"총 패배 횟수 : {loseCount}회");
            Console.WriteLine($"총 무승부 횟수 : {drawCount}회");
            Console.WriteLine($"최종 소지금 : {money}원");
            Console.WriteLine("=====================================");
        }

        public int GameMoney(ref int money)
        {
            int bet = 0; // 판돈

            while (true)
            {
                Console.WriteLine("얼마를 배팅하시겠습니가?");
              
                bet = int.Parse(Console.ReadLine()!);

                Thread.Sleep(2000);
                Console.Clear();

                if (bet < 1000)
                {
                    Console.Write(bet);
                    Console.ReadLine();
                    Console.WriteLine("최소 베팅금은 1000원입니다.");
                    continue;
                }

                if (bet > money)
                {
                    Console.WriteLine("소지금보다 많이 베팅할 수 없습니다.");
                    continue;
                }

                if (bet == money)
                {
                    Console.WriteLine("올인 하셨습니다.");
                    
                }
                return bet;
            }
        }


    }

    class Computer
    {
        private static Random rand = new Random();

        public static RockPaperScissors_ Select()
        {
            int comNumber = rand.Next(0, 3);

            if (comNumber == 0)
            {
                return RockPaperScissors_.SCISSORS;
            }
            else if (comNumber == 1)
            {
                return RockPaperScissors_.ROCK;
            }
            else
            {
                return RockPaperScissors_.PAPER;
            }
        }

        public static int PlayOneRound()
        {
            Console.Clear();

            Console.WriteLine("==========================================");
            Console.WriteLine("가위 바위 보 게임에 오신 걸 환영합니다!!");
            Console.WriteLine("가위 ~ 바위 ~ 보!");
            Console.WriteLine();

            RockPaperScissors_ player = Player.Select();
            RockPaperScissors_ computer = Computer.Select();

            Console.WriteLine();
            Console.WriteLine($"사용자 : {GamePrint.ChoiceToString(player)}");
            Console.WriteLine($"컴퓨터 : {GamePrint.ChoiceToString(computer)}");
            Console.WriteLine();

            int result = Judge.CheckResult(player, computer);

            return result;
        }

    }

    class Judge
    {
        public static int CheckResult(
            RockPaperScissors_ player,
            RockPaperScissors_ computer)
        {
            if (player == RockPaperScissors_.NONE)
            {
                return -2; // 잘못된 입력
            }

            if (player == computer)
            {
                return 0; // 무승부
            }

            if (
                (player == RockPaperScissors_.SCISSORS &&
                 computer == RockPaperScissors_.PAPER) ||

                (player == RockPaperScissors_.ROCK &&
                 computer == RockPaperScissors_.SCISSORS) ||

                (player == RockPaperScissors_.PAPER &&
                 computer == RockPaperScissors_.ROCK)
            )
            {
                return 1; // 승리
            }

            return -1; // 패배
        }
    }

    class GamePrint // 한글 출력
    {
        public static string ChoiceToString(RockPaperScissors_ choice)
        {
            if (choice == RockPaperScissors_.ROCK)
            {
                return "바위";
            }
            else if (choice == RockPaperScissors_.PAPER)
            {
                return "보";
            }
            else if (choice == RockPaperScissors_.SCISSORS)
            {
                return "가위";
            }
            else
            {
                return "잘못된 입력";
            }
        }
    }


    internal class RockPaperScissors
    {
     
        static void Main(string[] args)
        {
            int choice = 0; // 메뉴 선택

            while (choice != 3)
            {
                Console.Clear();
                ConsolePrint.Title();
                
                choice = int.Parse(Console.ReadLine()!);

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("게임을 시작합니다...");
                        Thread.Sleep(2000);
                        Console.Clear();
                        Ingame game = new Ingame
                        (
                            0,      // count
                            10000,  // money
                            0,      // pot
                            0,      // winCount
                            0,      // loseCount
                            0       // drawCount
                        );     
                        game.PlayGame();
                        break;

                    case 2:
                        ConsolePrint.ShowHelp();

                        Console.WriteLine();
                        break;

                    case 3:
                        Console.WriteLine("게임을 종료합니다.");
                        Thread.Sleep(2000);
                        break;

                    default:
                        Console.WriteLine("잘못 입력했습니다.");
                        Thread.Sleep(2000);
                        break ;

                }
            }
        }
    }
}
