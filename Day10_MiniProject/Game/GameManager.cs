using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerDream.Game
{
    

    internal class GameManager
    {
        public void Start() // 게임 실행
        {
            Console.SetWindowSize(150, 30);
            int select = 0;

            

            while (true)
            {
                Console.Clear();

                GameTool.ShowBune();
                GameTool.ShowTitleA();
                GameTool.ShowTitleB();

                GameTool.ShowMainMenu(select);
                

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
                                    GameTool.Story();
                                    GameTool.Play();
                                    break;
                                  

                                case 1:
                                    // 게임 설명
                                    Console.Clear();

                                    GameTool.Description();

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
    }
