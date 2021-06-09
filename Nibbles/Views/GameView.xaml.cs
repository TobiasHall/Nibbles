using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Nibbles
{
    /// <summary>
    /// Interaction logic for GameView.xaml
    /// </summary>
    public partial class GameView : UserControl
    {
        public GameView()
        {
            InitializeComponent();
            DataContext = new GameViewModel();
            CreateGameBoard();
        }
        private void CreateGameBoard()
        {
            GameBoard.Width = GamePreference.DefaultGameBoard.Width;
            GameBoard.Height = GamePreference.DefaultGameBoard.Height;
            GameBoard.Opacity = 0.90;

            for (int i = 0; i < GamePreference.NumberOfGameBoardTiles; i++)
            {
                GameBoardTile tile = new GameBoardTile(i);
                GameBoard.Children.Add(tile);
            }
        }
    }
}
