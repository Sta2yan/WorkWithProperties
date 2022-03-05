using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithProperties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player(10, 3);
            Render render = new Render();
            render.DrawPlayer(player);
        }
    }

    class Player
    {
        public int PositionX { get; }
        public int PositionY { get; }

        public Player(int x, int y)
        {
            PositionX = x;
            PositionY = y;
        }
    }

    class Render
    {
        public void DrawPlayer(Player player, char playerSymbol = '@')
        {
            Console.SetCursorPosition(player.PositionX, player.PositionY);
            Console.WriteLine(playerSymbol);
        }
    }
}