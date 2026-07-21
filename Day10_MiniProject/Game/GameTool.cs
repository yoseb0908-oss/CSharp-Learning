using BurgerDream.Resources.Character;
using OOP.Character;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace BurgerDream.Game
{
  
     class GameTool // 게임 전체 관리자
    {
        private int _x;
        private int _y;

        public GameTool(int x, int y)
        {
            _x = x;
            _y = y;
        }
        


        public static void ShowTitleA() // 게임 타이틀화면
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.SetCursorPosition(10, 1);

            int x = 10;
            int y = 1;

            
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.SetCursorPosition(x, y);
                Console.WriteLine("███████████  █████  █████ ███████████     █████████  ██████████ ███████████");
                Console.SetCursorPosition(x, y+1);
                Console.WriteLine("░███░░░░░███░░███  ░░███ ░░███░░░░░███   ███░░░░░███░░███░░░░░█░░███░░░░░███");
                Console.SetCursorPosition(x, y+2);
                Console.WriteLine("░███    ░███ ░███   ░███  ░███    ░███  ███     ░░░  ░███  █ ░  ░███    ░███");
                Console.SetCursorPosition(x, y+3);
                Console.WriteLine("░██████████  ░███   ░███  ░██████████  ░███          ░██████    ░██████████");
                Console.SetCursorPosition(x, y+4);
                Console.WriteLine("░███░░░░░███ ░███   ░███  ░███░░░░░███ ░███    █████ ░███░░█    ░███░░░░░███");
                Console.SetCursorPosition(x, y+5);
                Console.WriteLine("░███    ░███ ░███   ░███  ░███    ░███ ░░███  ░░███  ░███ ░   █ ░███    ░███");
                Console.SetCursorPosition(x, y+6);
                Console.WriteLine("███████████  ░░████████   █████   █████ ░░█████████  ██████████ █████   █████");
                Console.SetCursorPosition(x, y+7);
                Console.WriteLine("░░░░░░░░░░░    ░░░░░░░░   ░░░░░   ░░░░░   ░░░░░░░░░  ░░░░░░░░░░ ░░░░░   ░░░░░");
                Console.SetCursorPosition(x, y+8);
                Console.ResetColor();
            
        }

        public static void ShowTitleB() // 게임 타이틀화면
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.SetCursorPosition(45, 9);

            int x = 45;
            int y = 9;

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(x, y);
            Console.WriteLine("██████████   ███████████   ██████████   █████████   ██████   ██████");
            Console.SetCursorPosition(x, y+1);
            Console.WriteLine("░███░░░░███ ░░███░░░░░███ ░░███░░░░░█  ███░░░░░███ ░░██████ ██████");
            Console.SetCursorPosition(x, y+2);
            Console.WriteLine("░███   ░░███ ░███    ░███  ░███  █ ░  ░███    ░███  ░███░█████░███");
            Console.SetCursorPosition(x, y+3);
            Console.WriteLine("░███    ░███ ░██████████   ░██████    ░███████████  ░███░░███ ░███");
            Console.SetCursorPosition(x, y+4);
            Console.WriteLine("░███    ░███ ░███░░░░░███  ░███░░█    ░███░░░░░███  ░███ ░░░  ░███");
            Console.SetCursorPosition(x, y+5);
            Console.WriteLine("░███    ███  ░███    ░███  ░███ ░   █ ░███    ░███  ░███      ░███");
            Console.SetCursorPosition(x, y+6);
            Console.WriteLine("██████████   █████   █████ ██████████ █████   █████ █████     █████");
            Console.SetCursorPosition(x, y+7);
            Console.WriteLine("░░░░░░░░░░   ░░░░░   ░░░░░ ░░░░░░░░░░ ░░░░░   ░░░░░ ░░░░░     ░░░░░");
            Console.ResetColor();
        }

        public static void ShowMainMenu(int select) // 게임 메인메뉴
        {
            Console.SetCursorPosition(60, 23);

            int centerx = 60;
            int y = 23;

            if (select == 0)
            {
                string text1 = "▶ 게임 시작";
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.SetCursorPosition(centerx - (text1.Length / 2), y);
                Console.WriteLine(text1);
                Console.ResetColor();
            }
            else
            {
                string text2 = "  게임 시작";
                Console.SetCursorPosition(centerx - (text2.Length / 2), y);
                Console.WriteLine(text2);
            }

            if (select == 1)
            {
                string text3 = "▶ 게임 설명";
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.SetCursorPosition(centerx - (text3.Length / 2), y+1);
                Console.WriteLine(text3);
                Console.ResetColor();
            }

            else
            {
                string text4 = "  게임 설명";
                Console.SetCursorPosition(centerx - (text4.Length / 2), y+1);
                Console.WriteLine(text4);
            }

            if (select == 2)
            {
                string text5 = "▶ 게임 종료";
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.SetCursorPosition(centerx - (text5.Length / 2), y+2);
                Console.WriteLine(text5);

            }
            else
            {
                string text6 = "  게임 종료";
                Console.SetCursorPosition(centerx - (text6.Length / 2), y+2);
                Console.WriteLine(text6);
            }
        }

        public static void ShowBune()
        {
            Console.SetCursorPosition(20, 10);
            int x = 20;
            int y = 10;

            Console.SetCursorPosition(x, y);
            SmallBun.PrintBun();
        }

        public static void Description()
        {
            Console.WriteLine("==========================================================");
            Console.WriteLine("                     게임 설명");
            Console.WriteLine("==========================================================");
            Console.WriteLine();

            Console.WriteLine("Burger Dream에 오신 것을 환영합니다!");
            Console.WriteLine();

            Console.WriteLine("당신은 작은 햄버거 가게의 사장입니다.");
            Console.WriteLine("손님이 주문한 햄버거를 정확하게 만들어");
            Console.WriteLine("돈을 벌고 가게를 성장시켜 보세요!");
            Console.WriteLine();

            Console.WriteLine("[ 게임 진행 ]");
            Console.WriteLine();

            Console.WriteLine("1. 손님이 주문을 합니다.");
            Console.WriteLine("2. 주문한 재료를 순서대로 선택합니다.");
            Console.WriteLine("3. 햄버거를 완성하여 손님에게 제공합니다.");
            Console.WriteLine("4. 완성도에 따라 돈과 평판을 획득합니다.");
            Console.WriteLine("5. 하루가 끝나면 가게를 업그레이드할 수 있습니다.");
            Console.WriteLine();

            Console.WriteLine("[ 평가 기준 ]");
            Console.WriteLine();

            Console.WriteLine("◎ 재료가 모두 맞으면 높은 점수!");
            Console.WriteLine("◎ 순서가 틀리면 감점!");
            Console.WriteLine("◎ 재료가 부족하거나 잘못 넣으면 큰 감점!");
            Console.WriteLine("◎ 점수가 높을수록 더 많은 수익을 얻습니다.");
            Console.WriteLine();

            Console.WriteLine("[ 승리 조건 ]");
            Console.WriteLine();

            Console.WriteLine("가게를 성장시키고 최고의 햄버거 맛집을");
            Console.WriteLine("만드는 것이 목표입니다!");
            Console.WriteLine();

            Console.WriteLine("==========================================================");
            Console.WriteLine("        ESC : 메인 메뉴로 돌아가기");
            Console.WriteLine("==========================================================");
            Console.ReadKey(true);
        }

        public static void Story() // 스토리 화면
        {
            
            Console.SetCursorPosition(60, 15);
            int centerx = 60;
            int y = 15;

            string text1 = "BURGER DREAM";
            Console.SetCursorPosition(centerx -(text1.Length / 2), y - 1);
            Console.WriteLine(text1);
            Console.WriteLine();
            string text2 = "Press Any Key...";
            Console.SetCursorPosition(centerx - (text2.Length / 2), y);
            Console.WriteLine(text2);
            Console.ReadKey(true);
            Console.Clear();

            string text3 = "5년 전...";
            Console.SetCursorPosition(centerx - (text3.Length / 2), y);
            Console.WriteLine(text3);
            Console.WriteLine();
            Thread.Sleep(2000);
            Console.Clear();

            string text4 = "오랫동안 햄버거를 만드는 것을 좋아했던 '번이'.";
            Console.SetCursorPosition(centerx - (text4.Length / 2), y );
            Console.WriteLine(text4);
            Console.WriteLine();
            Thread.Sleep(2000);
            Console.Clear();

            string text5 = "언젠가는 모두가 행복해지는 햄버거 가게를";
            Console.SetCursorPosition(centerx - (text5.Length / 2), y - 1);
            Console.WriteLine(text5);
            string text6 = "운영하는 것이 그의 오랜 꿈이었습니다.";
            Console.SetCursorPosition(centerx - (text6.Length / 2), y);
            Console.WriteLine(text6);
            Console.WriteLine();
            Thread.Sleep(2000);
            Console.Clear();

            string text7 = "하지만 가진 돈은 얼마 없었고,";
            Console.SetCursorPosition(centerx - (text7.Length / 2), y - 1);
            Console.WriteLine(text7);
            string text8 = "5년동안 쓰리잡을 하며 겨우 모은 돈으로";
            Console.SetCursorPosition(centerx - (text8.Length / 2), y);
            Console.WriteLine(text8);
            string text9 = "작은 가게 하나를 겨우 열 수 있었습니다.";
            Console.SetCursorPosition(centerx - (text9.Length / 2), y + 1);
            Console.WriteLine(text9);
            Console.WriteLine();
            Thread.Sleep(2000);
            Console.Clear();

            string text10 = "첫 손님을 맞이하는 오늘.";
            Console.SetCursorPosition(centerx - (text10.Length / 2), y - 1);
            Console.WriteLine(text10);
            string text11 = "이 작은 가게가 최고의 햄버거 가게가 될 수 있을까요?";
            Console.SetCursorPosition(centerx - (text11.Length / 2), y);
            Console.WriteLine(text11);
            Console.WriteLine();
            Thread.Sleep(2000);
            Console.Clear();

            string text12 = "손님의 주문을 정확하게 만들고";
            Console.SetCursorPosition(centerx - (text12.Length / 2), y - 1);
            Console.WriteLine(text12);
            string text13 = "돈을 모아 가게를 성장시켜 보세요!";
            Console.SetCursorPosition(centerx - (text13.Length / 2), y);
            Console.WriteLine(text13);
            Console.WriteLine();
            Thread.Sleep(2000);
            Console.Clear();

            string text14 = "최고의 햄버거는 최고의 정성에서 시작됩니다.";
            Console.SetCursorPosition(centerx - (text14.Length / 2), y - 1);
            Console.WriteLine(text14);
            Console.WriteLine();
            Thread.Sleep(2000);
            Console.Clear();

            string text15 = "Press Any Key...";
            Console.SetCursorPosition(centerx - (text15.Length / 2), y);
            Console.WriteLine(text15);
            Console.ReadKey(true);
        }

        public static void Play() // 게임 플레이
        {
            Console.Clear();
            Console.SetCursorPosition(60, 15);
            int centerx = 60;
            int y = 15;

            string text1 = "Day 1";
            Console.SetCursorPosition(centerx - (text1.Length / 2), y - 1);
            Console.WriteLine();
            string text2 = "첫 영업을 시작합니다.";
            Console.SetCursorPosition(centerx - (text2.Length / 2), y);
            Console.WriteLine(text2);
            Console.WriteLine();
            Thread.Sleep(1500);
            Console.Clear();
        }

        public void Nextday() // 시간 흐름
        {

        }

        public void GameOver() // 게임 엔딩
        {

        }
    }





}
