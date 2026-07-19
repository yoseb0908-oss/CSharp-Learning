using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace _0716_서요셉_하이로우세븐
{
    class Card // 카드 1장
    {
        public string Shape; // 카드 문양
        public int Number;   // 숫자

        public string GetNumberText()
        {
            switch (Number)
            {
                case 1:
                    return "A"; // 1번

                case 11:
                    return "J"; // 11번

                case 12:
                    return "Q"; // 12번

                case 13:
                    return "K"; // 13번

                default:
                    return Number.ToString();
            }
        }
    }

    class CardPlace // 카드 52장 공간
    {
        private Card[] Deck = new Card[52];
        string[] shapes = { "♦", "♠", "♥", "♣" };

        private int currentIndex = 0;


        public CardPlace() // 생성 된 카드를 섞기.
        {
            CreateCard();

            Shuffle();
        }

        public void CreateCard() // 카드 생성
        {
            int index = 0;
            for (int i = 1; i <= shapes.Length; i++)
            {
                for (int j = 1; j <= 13; j++)
                {
                    Deck[index] = new Card();

                    Deck[index].Shape = shapes[i - 1];
                    Deck[index].Number = j;

                    index++;
                }
            }
        }


        public Card? GetCard() // 카드 출력
        {
            if (currentIndex >= Deck.Length)
            {
                Console.WriteLine("더 이상 남아있는 카드가 없습니다.");
                return null;
            }

            Card temp = Deck[currentIndex];

            currentIndex++;

            return temp;
        }

        public void Shuffle() // 카드 섞기
        {
            Random random = new Random();

            for (int i = 0; i < Deck.Length; i++)
            {
                int randomindex = random.Next(i, Deck.Length);

                Card temp = Deck[i];
                Deck[i] = Deck[randomindex];
                Deck[randomindex] = temp;
            }

        }

        public bool CanDrawSixCards() // 카드 6장 남아있는지 확인.
        {
            return currentIndex + 6 <= Deck.Length;
        }


        public Card? PeekNextTurnSixthCard() // 다음 턴 6번째카드 확인.
        {
            int nextSixthIndex = currentIndex + 5;

            if (nextSixthIndex >= Deck.Length)
            {
                return null;
            }

            return Deck[nextSixthIndex];
        }

        public void ShowNextTurnSixthCard() // 6번째카드 출력
        {
            Card? card = PeekNextTurnSixthCard();

            if (card == null)
            {
                Console.WriteLine("다음 턴을 진행할 카드가 부족합니다.");
                return;
            }

            Console.Write("[입력 치트] 다음 턴 6번째 카드 : ");
            Color.PrintCard(card.Shape, card.GetNumberText());
            Console.WriteLine();
        }

        public void ShowRemainingCards() // 남은 전체카드 확인
        {
            for (int i = currentIndex; i < Deck.Length; i++)
            {             
                Color.PrintCard( Deck[i].Shape, Deck[i].GetNumberText());
                Console.Write(" / ");
                
            }
            
        }

    }

    class Color // 카드 색
    {
        public static void PrintCard(string shape, string number)
        {
            switch (shape)
            {
                case "♦":
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    break;

                case "♠":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;

                case "♥":
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;

                case "♣":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
            }

            Console.Write($"{shape} {number}");
            Console.ResetColor();
        }
    }

    enum Choice
    {
        HIGH = 1,
        LOW,
        SEVEN
    }

    class Game // 게임 진행
    {
        private CardPlace cardPlace;
        private Card[] playCards = new Card[6];

        private Choice userChoice; // 사용자 입력 변수

        private int money = 10000; // 현재 소지금
        private int betMoney;      // 이번 판 베팅금
        private bool isFold = false; // fold 값.

        public Game()
        {
            cardPlace = new CardPlace();
        }

        public void DrawCards() // 덱 뽑기
        {
            for (int i = 0; i < playCards.Length; i++)
            {
                Card? card = cardPlace.GetCard();

                if (card != null)
                {
                    playCards[i] = card;
                }

                if (card == null)
                {
                    break;
                }
            }

        }

        public void ShowCards() // 덱 출력
        {

            for (int i = 0; i < 5; i++)
            {
                Color.PrintCard(playCards[i].Shape,playCards[i].GetNumberText());

                Console.Write(" / ");

            }
            Console.WriteLine("6. ??");

            Console.WriteLine();
            Console.Write("[상시 치트] 현재 정답 카드 : ");
            Color.PrintCard(playCards[5].Shape,playCards[5].GetNumberText());
            Console.WriteLine();
        }

        public void UserInput() // 사용자입력
        {
            isFold = false;

            while (true)
            {
                Console.WriteLine("1. HIGH");
                Console.WriteLine("2. LOW");
                Console.WriteLine("3. SEVEN");
                Console.WriteLine("4. [입력 치트]다음 턴 6번째 카드 보기");
                Console.WriteLine("5. [입력 치트]남은 카드 전체 보기");
                Console.WriteLine("fold. 이번 턴 포기");
                Console.Write("선택 : ");

                string input = Console.ReadLine()!;
                Console.WriteLine();

                switch (input)
                {
                    case "1":
                        userChoice = Choice.HIGH;
                        return;

                    case "2":
                        userChoice = Choice.LOW;
                        return;

                    case "3":
                        userChoice = Choice.SEVEN;
                        return;

                    case "4":
                        cardPlace.ShowNextTurnSixthCard(); 
                        continue;

                    case "5":
                        cardPlace.ShowRemainingCards();
                        Console.WriteLine();
                        continue;

                    case "fold":
                        isFold = true;
                        return;

                    default:
                        Console.WriteLine("올바른 값을 입력해주세요.");
                        Console.WriteLine();
                        continue;
                }
            }
        }

        public void OpenLastCard() // 마지막 카드 공개
        {
            Console.WriteLine("마지막 카드 공개 !");

            Color.PrintCard(playCards[5].Shape, playCards[5].GetNumberText());
            Console.WriteLine();

        }

        public void Result() // 결과
        {
            int lastNumber = playCards[5].Number;

            switch (userChoice)
            {
                case Choice.HIGH:
                    if (lastNumber > 7)
                    {
                        money += betMoney;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("╔════════════════════════════════════════════╗");
                        Console.ResetColor();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("             ██╗    ██╗██╗███╗   ██╗");
                        Console.WriteLine("             ██║    ██║██║████╗  ██║");
                        Console.WriteLine("             ██║ █╗ ██║██║██╔██╗ ██║");
                        Console.WriteLine("             ██║███╗██║██║██║╚██╗██║");
                        Console.WriteLine("             ╚███╔███╔╝██║██║ ╚████║");
                        Console.WriteLine("              ╚══╝╚══╝ ╚═╝╚═╝  ╚═══╝");
                        Console.WriteLine();
                        Console.WriteLine("             ★ 예측에 성공했습니다! ★");
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine($"               + {betMoney}GOLD");
                        Console.ResetColor();
                        Console.WriteLine();
                        Console.WriteLine($"            현재 소지금 : {money}");
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("╚════════════════════════════════════════════╝");
                        Console.ResetColor();
                        Thread.Sleep(3000);
                    }

                    else
                    {
                        money -= betMoney;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("╔════════════════════════════════════════════╗");
                        Console.WriteLine();
                        Console.WriteLine("      ██████╗  █████╗ ███╗   ███╗███████╗");
                        Console.WriteLine("     ██╔════╝ ██╔══██╗████╗ ████║██╔════╝");
                        Console.WriteLine("     ██║  ███╗███████║██╔████╔██║█████╗");
                        Console.WriteLine("     ██║   ██║██╔══██║██║╚██╔╝██║██╔══╝");
                        Console.WriteLine("     ╚██████╔╝██║  ██║██║ ╚═╝ ██║███████╗");
                        Console.WriteLine("      ╚═════╝ ╚═╝  ╚═╝╚═╝     ╚═╝╚══════╝");
                        Console.ResetColor();
                        Console.WriteLine();
                        Console.WriteLine("            베팅금을 모두 잃었습니다.");
                        Console.WriteLine("                  Game Over");
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine($"               - {betMoney}GOLD");
                        Console.ResetColor();
                        Console.WriteLine();
                        Console.WriteLine($"            현재 소지금 : {money}");
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("╚════════════════════════════════════════════╝");
                        Console.ResetColor();
                        Thread.Sleep(3000);
                    }
                    break;

                case Choice.LOW:
                    if (lastNumber < 7)
                    {
                        money += betMoney;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("╔════════════════════════════════════════════╗");
                        Console.ResetColor();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("             ██╗    ██╗██╗███╗   ██╗");
                        Console.WriteLine("             ██║    ██║██║████╗  ██║");
                        Console.WriteLine("             ██║ █╗ ██║██║██╔██╗ ██║");
                        Console.WriteLine("             ██║███╗██║██║██║╚██╗██║");
                        Console.WriteLine("             ╚███╔███╔╝██║██║ ╚████║");
                        Console.WriteLine("              ╚══╝╚══╝ ╚═╝╚═╝  ╚═══╝");
                        Console.WriteLine();
                        Console.WriteLine("             ★ 예측에 성공했습니다! ★");
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine($"               + {betMoney}GOLD");
                        Console.ResetColor();
                        Console.WriteLine();
                        Console.WriteLine($"            현재 소지금 : {money}");
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("╚════════════════════════════════════════════╝");
                        Console.ResetColor();
                        Thread.Sleep(3000);
                    }

                    else
                    {
                        money -= betMoney;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("╔════════════════════════════════════════════╗");
                        Console.WriteLine();
                        Console.WriteLine("      ██████╗  █████╗ ███╗   ███╗███████╗");
                        Console.WriteLine("     ██╔════╝ ██╔══██╗████╗ ████║██╔════╝");
                        Console.WriteLine("     ██║  ███╗███████║██╔████╔██║█████╗");
                        Console.WriteLine("     ██║   ██║██╔══██║██║╚██╔╝██║██╔══╝");
                        Console.WriteLine("     ╚██████╔╝██║  ██║██║ ╚═╝ ██║███████╗");
                        Console.WriteLine("      ╚═════╝ ╚═╝  ╚═╝╚═╝     ╚═╝╚══════╝");
                        Console.ResetColor();
                        Console.WriteLine();
                        Console.WriteLine("            베팅금을 모두 잃었습니다.");
                        Console.WriteLine("                  Game Over");
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine($"               - {betMoney}GOLD");
                        Console.ResetColor();
                        Console.WriteLine();
                        Console.WriteLine($"            현재 소지금 : {money}");
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("╚════════════════════════════════════════════╝");
                        Console.ResetColor();
                        Thread.Sleep(3000);
                    }                       
                    break;

                case Choice.SEVEN:
                    if (lastNumber == 7)
                    {
                        money += betMoney * 13;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("╔════════════════════════════════════════════╗");
                        Console.WriteLine();
                        Console.WriteLine(" ███████╗███████╗██╗   ██╗███████╗███╗   ██╗");
                        Console.WriteLine(" ██╔════╝██╔════╝██║   ██║██╔════╝████╗  ██║");
                        Console.WriteLine(" ███████╗█████╗  ██║   ██║█████╗  ██╔██╗ ██║");
                        Console.WriteLine(" ╚════██║██╔══╝  ╚██╗ ██╔╝██╔══╝  ██║╚██╗██║");
                        Console.WriteLine(" ███████║███████╗ ╚████╔╝ ███████╗██║ ╚████║");
                        Console.WriteLine(" ╚══════╝╚══════╝  ╚═══╝  ╚══════╝╚═╝  ╚═══╝");
                        Console.WriteLine();
                        Console.WriteLine("          ★★★★ JACKPOT ★★★★");
                        Console.WriteLine();
                        Console.WriteLine($"               + {betMoney}GOLD");
                        Console.WriteLine();
                        Console.WriteLine($"            현재 소지금 : {money}");
                        Console.WriteLine();
                        Console.WriteLine("╚════════════════════════════════════════════╝");
                        Console.ResetColor();
                        Console.WriteLine();
                        Thread.Sleep(3000);
                    }                   

                    else
                    {
                        money -= betMoney;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("╔════════════════════════════════════════════╗");
                        Console.WriteLine();
                        Console.WriteLine("      ██████╗  █████╗ ███╗   ███╗███████╗");
                        Console.WriteLine("     ██╔════╝ ██╔══██╗████╗ ████║██╔════╝");
                        Console.WriteLine("     ██║  ███╗███████║██╔████╔██║█████╗");
                        Console.WriteLine("     ██║   ██║██╔══██║██║╚██╔╝██║██╔══╝");
                        Console.WriteLine("     ╚██████╔╝██║  ██║██║ ╚═╝ ██║███████╗");
                        Console.WriteLine("      ╚═════╝ ╚═╝  ╚═╝╚═╝     ╚═╝╚══════╝");
                        Console.ResetColor();
                        Console.WriteLine();
                        Console.WriteLine("            베팅금을 모두 잃었습니다.");
                        Console.WriteLine("                  Game Over");
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine($"               - {betMoney}GOLD");
                        Console.ResetColor();
                        Console.WriteLine();
                        Console.WriteLine($"            현재 소지금 : {money}");
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("╚════════════════════════════════════════════╝");
                        Console.ResetColor();
                        Thread.Sleep(3000);
                    }                       
                    break ;

                default:
                    Console.WriteLine("잘못 입력하셨습니다. 다시 입력해주세요.");
                    break;

            }
            Console.Clear();
        }

        public void Bet() // 베팅금 입력
        {
            Console.WriteLine("=====================================");
            Console.WriteLine("           HIGH LOW SEVEN");
            Console.WriteLine("=====================================");
            Console.WriteLine();
            Console.WriteLine ($"💰현재 소지금 : {money}");
           

            while (true)
            {
                Console.Write("🎲베팅금 입력 :");
                int input = int.Parse(Console.ReadLine()!);
                Console.WriteLine();

                if (input <= 1000)
                {
                    Console.WriteLine("1000원 이하의 금액은 베팅할 수 없습니다.");
                    continue;
                }

                if (input > money)
                {
                    Console.WriteLine("현재 소지금보다 높은 금액은 베팅할 수 없습니다.");
                    continue;
                }

                betMoney = input;
                break;
            }
            Console.Clear();
        }

        public void Play() // 최종 출력
        {
            while (true)
            {
                if (!cardPlace.CanDrawSixCards())
                {
                    GameClear();
                    break;
                }

                Bet();
                DrawCards();
                ShowCards();
                Console.WriteLine("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");
                UserInput();

                if (isFold) // fold 처리
                {
                    money -= betMoney;

                    Console.WriteLine("이번 턴을 포기했습니다.");
                    Console.WriteLine($"베팅금 {betMoney}원을 잃었습니다.");
                    Console.WriteLine($"현재 소지금 : {money}");

                    isFold = false; 

                    if (money <= 0)
                    {
                        GameOver();
                        break;
                    }

                    continue;  
                }

                OpenLastCard();
                Result();

                if (money <= 0)
                {
                    GameOver();
                    break;
                }

                Console.WriteLine();

            }
        }
        public void GameClear() // 카드 소진 엔딩
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine("        ██████╗  █████╗ ███╗   ███╗███████╗");
            Console.WriteLine("       ██╔════╝ ██╔══██╗████╗ ████║██╔════╝");
            Console.WriteLine("       ██║  ███╗███████║██╔████╔██║█████╗");
            Console.WriteLine("       ██║   ██║██╔══██║██║╚██╔╝██║██╔══╝");
            Console.WriteLine("       ╚██████╔╝██║  ██║██║ ╚═╝ ██║███████╗");
            Console.WriteLine("        ╚═════╝ ╚═╝  ╚═╝╚═╝     ╚═╝╚══════╝");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
            Console.WriteLine("              ★ GAME CLEAR ★");
            Console.ResetColor();

            Console.WriteLine();
            Console.WriteLine("        모든 카드를 사용했습니다!");
            Console.WriteLine("        끝까지 살아남은 당신의 승리입니다.");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"        최종 소지금 : {money}원");
            Console.ResetColor();

            Console.WriteLine();
            Console.WriteLine("        아무 키나 누르면 타이틀로 돌아갑니다.");
            Console.ReadKey(true);
        }

        public void GameOver() // 소지금 소진 엔딩
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine();
            Console.WriteLine("        ██████╗  █████╗ ███╗   ███╗███████╗");
            Console.WriteLine("       ██╔════╝ ██╔══██╗████╗ ████║██╔════╝");
            Console.WriteLine("       ██║  ███╗███████║██╔████╔██║█████╗");
            Console.WriteLine("       ██║   ██║██╔══██║██║╚██╔╝██║██╔══╝");
            Console.WriteLine("       ╚██████╔╝██║  ██║██║ ╚═╝ ██║███████╗");
            Console.WriteLine("        ╚═════╝ ╚═╝  ╚═╝╚═╝     ╚═╝╚══════╝");
            Console.WriteLine();
            Console.WriteLine("        ██████╗ ██╗   ██╗███████╗██████╗");
            Console.WriteLine("       ██╔═══██╗██║   ██║██╔════╝██╔══██╗");
            Console.WriteLine("       ██║   ██║██║   ██║█████╗  ██████╔╝");
            Console.WriteLine("       ██║   ██║╚██╗ ██╔╝██╔══╝  ██╔══██╗");
            Console.WriteLine("       ╚██████╔╝ ╚████╔╝ ███████╗██║  ██║");
            Console.WriteLine("        ╚═════╝   ╚═══╝  ╚══════╝╚═╝  ╚═╝");
            Console.ResetColor();

            Console.WriteLine();
            Console.WriteLine("        소지금을 모두 잃었습니다.");
            Console.WriteLine("        아쉽지만 이번 도전은 여기까지입니다.");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"        최종 소지금 : {money}원");
            Console.ResetColor();

            Console.WriteLine();
            Console.WriteLine("        아무 키나 누르면 타이틀로 돌아갑니다.");
            Console.ReadKey(true);
        }
    }

    class Title
    {
        public void DrawTitles() // 게임 시작 화면
        {
            Console.Clear();

            Console.WriteLine("========================================================");
            Console.WriteLine("            ██╗  ██╗██╗ ██████╗ ██╗  ██╗");
            Console.WriteLine("            ███████║██║██║  ███╗███████║");
            Console.WriteLine("            ██╔══██║██║██║   ██║██╔══██║");
            Console.WriteLine("            ██║  ██║██║╚██████╔╝██║  ██║");
            Console.WriteLine("            ╚═╝  ╚═╝╚═╝ ╚═════╝ ╚═╝  ╚═╝");
            Console.WriteLine();
            Console.WriteLine("                  HIGH LOW SEVEN");
            Console.WriteLine("========================================================");
            Console.WriteLine();
           
        }

        public void DrawMenu(int select) // 화면 선택
        {
            if (select == 0)
                Console.WriteLine("▶ 게임 시작");
            else
                Console.WriteLine("  게임 시작");

            if (select == 1)
                Console.WriteLine("▶ 게임 설명");
            else
                Console.WriteLine("  게임 설명");

            if (select == 2)
                Console.WriteLine("▶ 게임 종료");
            else
                Console.WriteLine("  게임 종료");
        }

        public void Description() // 게임 설명
        {
            Console.Clear();

            Console.WriteLine("========== 게임 설명 ==========");
            Console.WriteLine();
            Console.WriteLine("HIGH  : 8 ~ K");
            Console.WriteLine("LOW   : A ~ 6");
            Console.WriteLine("SEVEN : 7");
            Console.WriteLine();
            Console.WriteLine("SEVEN 적중 시 13배 지급!");
            Console.WriteLine();
            Console.WriteLine("아무 키나 누르면 돌아갑니다.");

            Console.ReadKey(true);
        }

     

        public void Start() // 최종 게임출력
        {
            int select = 0;

            while (true)
            {
                Console.Clear();

                DrawTitles();
                DrawMenu(select);

                ConsoleKeyInfo key = Console.ReadKey(true);

                switch (key.Key)
                {
                    case ConsoleKey.UpArrow:
                        select--;
                        if (select < 0)
                        {
                            select = 2;
                        }
                        break;

                    case ConsoleKey.DownArrow:
                        select++;
                        if (select > 2)
                        {
                            select = 0;
                        }
                        break;

                    case ConsoleKey.Enter:
                        {
                            switch (select)
                            {
                                case 0:
                                    // 게임 시작
                                    Console.Clear();

                                    Game game = new Game();
                                    game.Play();
                                    break;

                                case 1:
                                    // 게임 설명
                                    Console.Clear();

                                    Description();

                                    break;                                   

                                case 2:
                                    // 게임 종료
                                    return;
                            }
                            break;
                        }
                }
            }
        }

    }




    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            Title title = new Title();
            
            title.Start();


           



            
            
        }
    }








   
}





