using BurgerDream.Game;

namespace BurgerDream
{
    internal class Program
    {
        static void Main(string[] args)
        {

            GameManager gameManager = new GameManager();
            Console.CursorVisible = false;

            gameManager.Start();
            
        }
    }
}

   

    

  
