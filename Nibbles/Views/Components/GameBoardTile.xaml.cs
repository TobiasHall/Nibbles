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
    /// Interaction logic for GameBoardTile.xaml
    /// </summary>
    public partial class GameBoardTile : UserControl
    {
        public int Id { get; private set; }
        public bool HasWormPartOnTile { get; set; }
        public bool IsWall { get; set; }

        public GameBoardTile()
        {
            InitializeComponent();

            Rectangle rectangle = new Rectangle()
            {
                Width = GamePreference.DefaultGameBordTile.Width,
                Height = GamePreference.DefaultGameBordTile.Height,
                Fill = GamePreference.DefaultGameBoardColor,
                Stroke = Brushes.Black,
                StrokeThickness = 10
            };

            Master.Children.Add(rectangle);
        }
        public GameBoardTile(int index)
        {
            InitializeComponent();

            Rectangle rectangle = new Rectangle()
            {
                Width = GamePreference.DefaultGameBordTile.Width,
                Height = GamePreference.DefaultGameBordTile.Height,
                Fill = GamePreference.DefaultGameBoardColor,
                Uid = index.ToString()
            };
            Id = index;

            Master.Children.Add(rectangle);
        }
    }
}
