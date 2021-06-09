using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Media;

namespace Nibbles
{
    public static class GamePreference
    {
        public static (int Height, int Width) DefaultGameBoard { get; private set; } = (400, 400);
        public static (int Height, int Width) DefaultGameBordTile { get; private set; } = (20, 20);
        public static int NumberOfGameBoardTiles { get; private set; } = (DefaultGameBoard.Height * DefaultGameBoard.Width) / (DefaultGameBordTile.Height * DefaultGameBordTile.Width);
        public static Brush DefaultGameBoardColor { get; private set; } = Brushes.LightGray;

    }
}
